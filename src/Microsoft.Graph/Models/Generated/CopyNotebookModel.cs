// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type CopyNotebookModel.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class CopyNotebookModel
    {

        /// <summary>
        /// Gets or sets isDefault.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isDefault", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsDefault { get; set; }
    
        /// <summary>
        /// Gets or sets userRole.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userRole", Required = Newtonsoft.Json.Required.Default)]
        public OnenoteUserRole? UserRole { get; set; }
    
        /// <summary>
        /// Gets or sets isShared.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isShared", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsShared { get; set; }
    
        /// <summary>
        /// Gets or sets sectionsUrl.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sectionsUrl", Required = Newtonsoft.Json.Required.Default)]
        public string SectionsUrl { get; set; }
    
        /// <summary>
        /// Gets or sets sectionGroupsUrl.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sectionGroupsUrl", Required = Newtonsoft.Json.Required.Default)]
        public string SectionGroupsUrl { get; set; }
    
        /// <summary>
        /// Gets or sets links.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "links", Required = Newtonsoft.Json.Required.Default)]
        public NotebookLinks Links { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name", Required = Newtonsoft.Json.Required.Default)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets createdBy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdBy", Required = Newtonsoft.Json.Required.Default)]
        public string CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets createdByIdentity.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdByIdentity", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet CreatedByIdentity { get; set; }
    
        /// <summary>
        /// Gets or sets lastModifiedBy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedBy", Required = Newtonsoft.Json.Required.Default)]
        public string LastModifiedBy { get; set; }
    
        /// <summary>
        /// Gets or sets lastModifiedByIdentity.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedByIdentity", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet LastModifiedByIdentity { get; set; }
    
        /// <summary>
        /// Gets or sets lastModifiedTime.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedTime { get; set; }
    
        /// <summary>
        /// Gets or sets id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id", Required = Newtonsoft.Json.Required.Default)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or sets self.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "self", Required = Newtonsoft.Json.Required.Default)]
        public string Self { get; set; }
    
        /// <summary>
        /// Gets or sets createdTime.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedTime { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
