// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type OnenoteSectionCopyToNotebookRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class OnenoteSectionCopyToNotebookRequestBody
    {
    
        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id", Required = Newtonsoft.Json.Required.Default)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or sets GroupId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "groupId", Required = Newtonsoft.Json.Required.Default)]
        public string GroupId { get; set; }
    
        /// <summary>
        /// Gets or sets RenameAs.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "renameAs", Required = Newtonsoft.Json.Required.Default)]
        public string RenameAs { get; set; }
    
        /// <summary>
        /// Gets or sets SiteCollectionId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "siteCollectionId", Required = Newtonsoft.Json.Required.Default)]
        public string SiteCollectionId { get; set; }
    
        /// <summary>
        /// Gets or sets SiteId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "siteId", Required = Newtonsoft.Json.Required.Default)]
        public string SiteId { get; set; }
    
    }
}
