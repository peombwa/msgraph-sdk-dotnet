// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type WindowsInformationProtectionExemptAppLockerFilesCollectionRequestBuilder.
    /// </summary>
    public partial class WindowsInformationProtectionExemptAppLockerFilesCollectionRequestBuilder : BaseRequestBuilder, IWindowsInformationProtectionExemptAppLockerFilesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new WindowsInformationProtectionExemptAppLockerFilesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WindowsInformationProtectionExemptAppLockerFilesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IWindowsInformationProtectionExemptAppLockerFilesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IWindowsInformationProtectionExemptAppLockerFilesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new WindowsInformationProtectionExemptAppLockerFilesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IWindowsInformationProtectionAppLockerFileRequestBuilder"/> for the specified WindowsInformationProtectionWindowsInformationProtectionAppLockerFile.
        /// </summary>
        /// <param name="id">The ID for the WindowsInformationProtectionWindowsInformationProtectionAppLockerFile.</param>
        /// <returns>The <see cref="IWindowsInformationProtectionAppLockerFileRequestBuilder"/>.</returns>
        public IWindowsInformationProtectionAppLockerFileRequestBuilder this[string id]
        {
            get
            {
                return new WindowsInformationProtectionAppLockerFileRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
