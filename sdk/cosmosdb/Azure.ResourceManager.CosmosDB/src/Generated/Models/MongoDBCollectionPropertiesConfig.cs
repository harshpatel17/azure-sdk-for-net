// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The MongoDBCollectionPropertiesConfig. </summary>
    public partial class MongoDBCollectionPropertiesConfig : CosmosDBBaseConfig
    {
        /// <summary> Initializes a new instance of MongoDBCollectionPropertiesConfig. </summary>
        public MongoDBCollectionPropertiesConfig()
        {
        }

        /// <summary> Initializes a new instance of MongoDBCollectionPropertiesConfig. </summary>
        /// <param name="throughput"> Value of the Cosmos DB resource throughput or autoscaleSettings. Use the ThroughputSetting resource when retrieving offer details. </param>
        /// <param name="autoscaleSettings"> Specifies the Autoscale settings. </param>
        internal MongoDBCollectionPropertiesConfig(int? throughput, AutoscaleSettings autoscaleSettings) : base(throughput, autoscaleSettings)
        {
        }
    }
}
