// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.PaloAltoNetworks.Ngfw;
using Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Samples
{
    public partial class Sample_PostRulesResourceCollection
    {
        // PostRules_List_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_PostRulesListMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/preview/2022-08-29-preview/examples/PostRules_List_MaximumSet_Gen.json
            // this example is just showing the usage of "PostRules_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "lrs1";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestackResource = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this PostRulesResource
            PostRulesResourceCollection collection = globalRulestackResource.GetPostRulesResources();

            // invoke the operation and iterate over the result
            await foreach (PostRulesResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PostRulesResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // PostRules_List_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_PostRulesListMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/preview/2022-08-29-preview/examples/PostRules_List_MinimumSet_Gen.json
            // this example is just showing the usage of "PostRules_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "lrs1";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestackResource = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this PostRulesResource
            PostRulesResourceCollection collection = globalRulestackResource.GetPostRulesResources();

            // invoke the operation and iterate over the result
            await foreach (PostRulesResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PostRulesResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // PostRules_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PostRulesGetMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/preview/2022-08-29-preview/examples/PostRules_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "PostRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "lrs1";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestackResource = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this PostRulesResource
            PostRulesResourceCollection collection = globalRulestackResource.GetPostRulesResources();

            // invoke the operation
            string priority = "1";
            PostRulesResource result = await collection.GetAsync(priority);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PostRulesResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PostRules_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_PostRulesGetMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/preview/2022-08-29-preview/examples/PostRules_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "PostRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "lrs1";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestackResource = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this PostRulesResource
            PostRulesResourceCollection collection = globalRulestackResource.GetPostRulesResources();

            // invoke the operation
            string priority = "1";
            bool result = await collection.ExistsAsync(priority);

            Console.WriteLine($"Succeeded: {result}");
        }

        // PostRules_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PostRulesGetMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/preview/2022-08-29-preview/examples/PostRules_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "PostRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "lrs1";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestackResource = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this PostRulesResource
            PostRulesResourceCollection collection = globalRulestackResource.GetPostRulesResources();

            // invoke the operation
            string priority = "1";
            PostRulesResource result = await collection.GetAsync(priority);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PostRulesResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PostRules_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_PostRulesGetMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/preview/2022-08-29-preview/examples/PostRules_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "PostRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "lrs1";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestackResource = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this PostRulesResource
            PostRulesResourceCollection collection = globalRulestackResource.GetPostRulesResources();

            // invoke the operation
            string priority = "1";
            bool result = await collection.ExistsAsync(priority);

            Console.WriteLine($"Succeeded: {result}");
        }

        // PostRules_CreateOrUpdate_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PostRulesCreateOrUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/preview/2022-08-29-preview/examples/PostRules_CreateOrUpdate_MaximumSet_Gen.json
            // this example is just showing the usage of "PostRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "lrs1";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestackResource = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this PostRulesResource
            PostRulesResourceCollection collection = globalRulestackResource.GetPostRulesResources();

            // invoke the operation
            string priority = "1";
            PostRulesResourceData data = new PostRulesResourceData("postRule1")
            {
                ETag = new ETag("c18e6eef-ba3e-49ee-8a85-2b36c863a9d0"),
                Description = "description of post rule",
                RuleState = StateEnum.Disabled,
                Source = new SourceAddr()
                {
                    Cidrs =
{
"1.0.0.1/10"
},
                    Countries =
{
"India"
},
                    Feeds =
{
"feed"
},
                    PrefixLists =
{
"PL1"
},
                },
                NegateSource = BooleanEnum.True,
                Destination = new DestinationAddr()
                {
                    Cidrs =
{
"1.0.0.1/10"
},
                    Countries =
{
"India"
},
                    Feeds =
{
"feed"
},
                    PrefixLists =
{
"PL1"
},
                    FqdnLists =
{
"FQDN1"
},
                },
                NegateDestination = BooleanEnum.True,
                Applications =
{
"app1"
},
                Category = new Category(new string[]
            {
"https://microsoft.com"
            }, new string[]
            {
"feed"
            }),
                Protocol = "HTTP",
                ProtocolPortList =
{
"80"
},
                InboundInspectionCertificate = "cert1",
                AuditComment = "example comment",
                ActionType = ActionEnum.Allow,
                EnableLogging = StateEnum.Disabled,
                DecryptionRuleType = DecryptionRuleTypeEnum.SSLOutboundInspection,
                Tags =
{
new TagInfo("keyName","value")
},
            };
            ArmOperation<PostRulesResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, priority, data);
            PostRulesResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PostRulesResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PostRules_CreateOrUpdate_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PostRulesCreateOrUpdateMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/preview/2022-08-29-preview/examples/PostRules_CreateOrUpdate_MinimumSet_Gen.json
            // this example is just showing the usage of "PostRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "lrs1";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestackResource = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this PostRulesResource
            PostRulesResourceCollection collection = globalRulestackResource.GetPostRulesResources();

            // invoke the operation
            string priority = "1";
            PostRulesResourceData data = new PostRulesResourceData("postRule1");
            ArmOperation<PostRulesResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, priority, data);
            PostRulesResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PostRulesResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
