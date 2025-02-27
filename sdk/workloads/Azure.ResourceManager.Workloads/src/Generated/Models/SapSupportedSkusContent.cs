// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The SAP request to get list of supported SKUs. </summary>
    public partial class SapSupportedSkusContent
    {
        /// <summary> Initializes a new instance of SapSupportedSkusContent. </summary>
        /// <param name="appLocation"> The geo-location where the resource is to be created. </param>
        /// <param name="environment"> Defines the environment type - Production/Non Production. </param>
        /// <param name="sapProduct"> Defines the SAP Product type. </param>
        /// <param name="deploymentType"> The deployment type. Eg: SingleServer/ThreeTier. </param>
        /// <param name="databaseType"> The database type. Eg: HANA, DB2, etc. </param>
        public SapSupportedSkusContent(AzureLocation appLocation, SapEnvironmentType environment, SapProductType sapProduct, SapDeploymentType deploymentType, SapDatabaseType databaseType)
        {
            AppLocation = appLocation;
            Environment = environment;
            SapProduct = sapProduct;
            DeploymentType = deploymentType;
            DatabaseType = databaseType;
        }

        /// <summary> The geo-location where the resource is to be created. </summary>
        public AzureLocation AppLocation { get; }
        /// <summary> Defines the environment type - Production/Non Production. </summary>
        public SapEnvironmentType Environment { get; }
        /// <summary> Defines the SAP Product type. </summary>
        public SapProductType SapProduct { get; }
        /// <summary> The deployment type. Eg: SingleServer/ThreeTier. </summary>
        public SapDeploymentType DeploymentType { get; }
        /// <summary> The database type. Eg: HANA, DB2, etc. </summary>
        public SapDatabaseType DatabaseType { get; }
        /// <summary> The high availability type. </summary>
        public SapHighAvailabilityType? HighAvailabilityType { get; set; }
    }
}
