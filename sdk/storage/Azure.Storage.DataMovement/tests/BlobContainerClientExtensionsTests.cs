﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Net.Http.Headers;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Azure.Identity;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Azure.Storage.DataMovement.Models;
using NUnit.Framework;

namespace Azure.Storage.DataMovement.Blobs.Tests
{
    [NonParallelizable]
    public class BlobContainerClientExtensionsTests
    {
        [OneTimeSetUp]
        public void Setup()
        {
            ExtensionMockTransferManager = new MockTransferManager();

            _backupTransferManagerValue = (Lazy<TransferManager>)typeof(BlobContainerClientExtensions).GetField("s_defaultTransferManager", BindingFlags.NonPublic | BindingFlags.Static).GetValue(null);

            typeof(BlobContainerClientExtensions).GetField("s_defaultTransferManager", BindingFlags.NonPublic | BindingFlags.Static).SetValue(null, new Lazy<TransferManager>(() => ExtensionMockTransferManager));
        }

        [OneTimeTearDown]
        public void Teardown()
        {
            typeof(BlobContainerClientExtensions).GetField("s_defaultTransferManager", BindingFlags.NonPublic | BindingFlags.Static).SetValue(null, _backupTransferManagerValue);
        }

        [Test]
        public async Task VerifyStartUploadDirectoryAsync([Values] bool addBlobDirectoryPath, [Values] bool addTransferOptions)
        {
            var accountUrl = "https://mockstorageaccount.blob.core.windows.net/";

            var containerName = "mockcontainer";

            var blobDirectoryPrefix = addBlobDirectoryPath ? "blobDirectoryPrefix" : null;

            var blobUri = new Uri(accountUrl + (addBlobDirectoryPath ? containerName + "/" + blobDirectoryPrefix : containerName));

            var directoryPath = Path.GetTempPath();

            var options = addTransferOptions ? new TransferOptions() : (TransferOptions)null;

            var expDestinationResourceType = addBlobDirectoryPath ? typeof(BlobDirectoryStorageResourceContainer) : typeof(BlobStorageResourceContainer);

            var assertionComplete = false;

            ExtensionMockTransferManager.OnStartTransferContainerAsync = (sourceResource, destinationResource, transferOptions) =>
            {
                Assert.AreEqual(directoryPath, sourceResource.Path);
                Assert.AreEqual(blobUri, destinationResource.Uri);
                Assert.AreEqual(options, transferOptions);
                Assert.IsInstanceOf(expDestinationResourceType, destinationResource);

                assertionComplete = true;
            };

            var client = new BlobServiceClient(new Uri(accountUrl), new DefaultAzureCredential()).GetBlobContainerClient(containerName);

            if (addTransferOptions)
            {
                await client.StartUploadDirectoryAsync(directoryPath, new BlobContainerClientTransferOptions { BlobDirectoryPrefix = blobDirectoryPrefix, TransferOptions = options });
            }
            else
            {
                await client.StartUploadDirectoryAsync(directoryPath, blobDirectoryPrefix);
            }

            Assert.IsTrue(assertionComplete);
        }

        [Test]
        public async Task VerifyStartDownloadToDirectoryAsync([Values] bool addBlobDirectoryPath, [Values] bool addTransferOptions)
        {
            var accountUrl = "https://mockstorageaccount.blob.core.windows.net/";

            var containerName = "mockcontainer";

            var blobDirectoryPrefix = addBlobDirectoryPath ? "blobDirectoryPrefix" : null;

            var blobUri = new Uri(accountUrl + (addBlobDirectoryPath ? containerName + "/" + blobDirectoryPrefix : containerName));

            var directoryPath = Path.GetTempPath();

            var options = addTransferOptions ? new TransferOptions() : (TransferOptions)null;

            var expSourceResourceType = addBlobDirectoryPath ? typeof(BlobDirectoryStorageResourceContainer) : typeof(BlobStorageResourceContainer);

            var assertionComplete = false;

            ExtensionMockTransferManager.OnStartTransferContainerAsync = (sourceResource, destinationResource, transferOptions) =>
            {
                Assert.AreEqual(directoryPath, destinationResource.Path);
                Assert.AreEqual(blobUri, sourceResource.Uri);
                Assert.AreEqual(options, transferOptions);
                Assert.IsInstanceOf(expSourceResourceType, sourceResource);

                assertionComplete = true;
            };

            var client = new BlobServiceClient(new Uri(accountUrl), new DefaultAzureCredential()).GetBlobContainerClient(containerName);

            if (addTransferOptions)
            {
                await client.StartDownloadToDirectoryAsync(directoryPath, new BlobContainerClientTransferOptions { BlobDirectoryPrefix = blobDirectoryPrefix, TransferOptions = options });
            }
            else
            {
                await client.StartDownloadToDirectoryAsync(directoryPath, blobDirectoryPrefix);
            }

            Assert.IsTrue(assertionComplete);
        }

        private MockTransferManager ExtensionMockTransferManager { get; set; }

        private Lazy<TransferManager> _backupTransferManagerValue;

        private class MockTransferManager : TransferManager
        {
            public MockTransferManager() { }

            public Action<StorageResourceContainer, StorageResourceContainer, TransferOptions> OnStartTransferContainerAsync { get; set; }

            public override Task<DataTransfer> StartTransferAsync(StorageResourceContainer sourceResource, StorageResourceContainer destinationResource, TransferOptions transferOptions = null)
            {
                if (OnStartTransferContainerAsync != null)
                {
                    OnStartTransferContainerAsync(sourceResource, destinationResource, transferOptions);
                }

                return Task.FromResult<DataTransfer>(null);
            }
        }
    }
}
