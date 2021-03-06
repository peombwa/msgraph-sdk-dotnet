// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Device Compliance User Status.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceComplianceUserStatus : Entity
    {
    
        /// <summary>
        /// Gets or sets user display name.
        /// User name of the DevicePolicyStatus.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string UserDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets devices count.
        /// Devices count for that user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "devicesCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DevicesCount { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Compliance status of the policy report. Possible values are: unknown, notApplicable, compliant, remediated, nonCompliant, error, conflict, notAssigned.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public ComplianceStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets last reported date time.
        /// Last modified date time of the policy report.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastReportedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastReportedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// UserPrincipalName.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
    }
}

