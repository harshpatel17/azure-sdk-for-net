// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NewRelicObservability.Models;

namespace Azure.ResourceManager.NewRelicObservability
{
    /// <summary>
    /// A class representing the TagRule data model.
    /// A tag rule belonging to NewRelic account
    /// </summary>
    public partial class TagRuleData : ResourceData
    {
        /// <summary> Initializes a new instance of TagRuleData. </summary>
        public TagRuleData()
        {
        }

        /// <summary> Initializes a new instance of TagRuleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning State of the resource. </param>
        /// <param name="logRules"> Set of rules for sending logs for the Monitor resource. </param>
        /// <param name="metricRules"> Set of rules for sending metrics for the Monitor resource. </param>
        internal TagRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, NewrelicProvisioningState? provisioningState, LogRules logRules, MetricRules metricRules) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            LogRules = logRules;
            MetricRules = metricRules;
        }

        /// <summary> Provisioning State of the resource. </summary>
        public NewrelicProvisioningState? ProvisioningState { get; }
        /// <summary> Set of rules for sending logs for the Monitor resource. </summary>
        public LogRules LogRules { get; set; }
        /// <summary> Set of rules for sending metrics for the Monitor resource. </summary>
        public MetricRules MetricRules { get; set; }
    }
}
