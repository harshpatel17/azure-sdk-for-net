// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Verticals.AgriFood.Farming.Samples
{
    internal class Samples_SensorDataModels
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetSensorDataModelsClient("2022-11-01-preview");

            var data = new
            {
                measures = new
                {
                    key = new
                    {
                        dataType = "Bool",
                    },
                },
            };

            Response response = client.CreateOrUpdate("<sensorPartnerId>", "<sensorDataModelId>", RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("dataType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetSensorDataModelsClient("2022-11-01-preview");

            var data = new
            {
                type = "<type>",
                manufacturer = "<manufacturer>",
                productCode = "<productCode>",
                measures = new
                {
                    key = new
                    {
                        description = "<description>",
                        dataType = "Bool",
                        type = "<type>",
                        unit = "<unit>",
                        properties = new
                        {
                            key = new { },
                        },
                    },
                },
                status = "<status>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new { },
                },
            };

            Response response = client.CreateOrUpdate("<sensorPartnerId>", "<sensorDataModelId>", RequestContent.Create(data), new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("manufacturer").ToString());
            Console.WriteLine(result.GetProperty("productCode").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("dataType").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("unit").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("properties").GetProperty("<test>").ToString());
            Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<test>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetSensorDataModelsClient("2022-11-01-preview");

            var data = new
            {
                measures = new
                {
                    key = new
                    {
                        dataType = "Bool",
                    },
                },
            };

            Response response = await client.CreateOrUpdateAsync("<sensorPartnerId>", "<sensorDataModelId>", RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("dataType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetSensorDataModelsClient("2022-11-01-preview");

            var data = new
            {
                type = "<type>",
                manufacturer = "<manufacturer>",
                productCode = "<productCode>",
                measures = new
                {
                    key = new
                    {
                        description = "<description>",
                        dataType = "Bool",
                        type = "<type>",
                        unit = "<unit>",
                        properties = new
                        {
                            key = new { },
                        },
                    },
                },
                status = "<status>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new { },
                },
            };

            Response response = await client.CreateOrUpdateAsync("<sensorPartnerId>", "<sensorDataModelId>", RequestContent.Create(data), new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("manufacturer").ToString());
            Console.WriteLine(result.GetProperty("productCode").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("dataType").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("unit").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("properties").GetProperty("<test>").ToString());
            Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<test>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSensorDataModel()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetSensorDataModelsClient("2022-11-01-preview");

            Response response = client.GetSensorDataModel("<sensorPartnerId>", "<sensorDataModelId>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("dataType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSensorDataModel_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetSensorDataModelsClient("2022-11-01-preview");

            Response response = client.GetSensorDataModel("<sensorPartnerId>", "<sensorDataModelId>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("manufacturer").ToString());
            Console.WriteLine(result.GetProperty("productCode").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("dataType").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("unit").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("properties").GetProperty("<test>").ToString());
            Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<test>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSensorDataModel_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetSensorDataModelsClient("2022-11-01-preview");

            Response response = await client.GetSensorDataModelAsync("<sensorPartnerId>", "<sensorDataModelId>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("dataType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSensorDataModel_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetSensorDataModelsClient("2022-11-01-preview");

            Response response = await client.GetSensorDataModelAsync("<sensorPartnerId>", "<sensorDataModelId>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("manufacturer").ToString());
            Console.WriteLine(result.GetProperty("productCode").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("dataType").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("unit").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("properties").GetProperty("<test>").ToString());
            Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<test>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetSensorDataModelsClient("2022-11-01-preview");

            Response response = client.Delete("<sensorPartnerId>", "<sensorDataModelId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetSensorDataModelsClient("2022-11-01-preview");

            Response response = client.Delete("<sensorPartnerId>", "<sensorDataModelId>", new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetSensorDataModelsClient("2022-11-01-preview");

            Response response = await client.DeleteAsync("<sensorPartnerId>", "<sensorDataModelId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetSensorDataModelsClient("2022-11-01-preview");

            Response response = await client.DeleteAsync("<sensorPartnerId>", "<sensorDataModelId>", new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSensorDataModels()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetSensorDataModelsClient("2022-11-01-preview");

            foreach (var item in client.GetSensorDataModels("<sensorPartnerId>"))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("dataType").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSensorDataModels_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetSensorDataModelsClient("2022-11-01-preview");

            foreach (var item in client.GetSensorDataModels("<sensorPartnerId>", new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, 1234, "<skipToken>", new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("type").ToString());
                Console.WriteLine(result.GetProperty("manufacturer").ToString());
                Console.WriteLine(result.GetProperty("productCode").ToString());
                Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("dataType").ToString());
                Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("type").ToString());
                Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("unit").ToString());
                Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("properties").GetProperty("<test>").ToString());
                Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result.GetProperty("eTag").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("createdBy").ToString());
                Console.WriteLine(result.GetProperty("modifiedBy").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("<test>").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSensorDataModels_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetSensorDataModelsClient("2022-11-01-preview");

            await foreach (var item in client.GetSensorDataModelsAsync("<sensorPartnerId>"))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("dataType").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSensorDataModels_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetSensorDataModelsClient("2022-11-01-preview");

            await foreach (var item in client.GetSensorDataModelsAsync("<sensorPartnerId>", new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, 1234, "<skipToken>", new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("type").ToString());
                Console.WriteLine(result.GetProperty("manufacturer").ToString());
                Console.WriteLine(result.GetProperty("productCode").ToString());
                Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("dataType").ToString());
                Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("type").ToString());
                Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("unit").ToString());
                Console.WriteLine(result.GetProperty("measures").GetProperty("<test>").GetProperty("properties").GetProperty("<test>").ToString());
                Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result.GetProperty("eTag").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("createdBy").ToString());
                Console.WriteLine(result.GetProperty("modifiedBy").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("<test>").ToString());
            }
        }
    }
}
