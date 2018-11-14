// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Mobile App Troubleshooting Event.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MobileAppTroubleshootingEvent : DeviceManagementTroubleshootingEvent
    {
    
        /// <summary>
        /// Gets or sets managed device identifier.
        /// Device identifier created or collected by Intune.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDeviceIdentifier", Required = Newtonsoft.Json.Required.Default)]
        public string ManagedDeviceIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// Identifier for the user that tried to enroll the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userId", Required = Newtonsoft.Json.Required.Default)]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets application id.
        /// Intune application identifier.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applicationId", Required = Newtonsoft.Json.Required.Default)]
        public string ApplicationId { get; set; }
    
        /// <summary>
        /// Gets or sets history.
        /// Intune Mobile Application Troubleshooting History Item
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "history", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<MobileAppTroubleshootingHistoryItem> History { get; set; }
    
    }
}
