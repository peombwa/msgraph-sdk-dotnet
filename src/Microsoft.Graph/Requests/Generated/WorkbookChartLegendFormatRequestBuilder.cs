// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookChartLegendFormatRequestBuilder.
    /// </summary>
    public partial class WorkbookChartLegendFormatRequestBuilder : EntityRequestBuilder, IWorkbookChartLegendFormatRequestBuilder
    {

        /// <summary>
        /// Constructs a new WorkbookChartLegendFormatRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WorkbookChartLegendFormatRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IWorkbookChartLegendFormatRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IWorkbookChartLegendFormatRequest Request(IEnumerable<Option> options)
        {
            return new WorkbookChartLegendFormatRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Fill.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartFillRequestBuilder"/>.</returns>
        public IWorkbookChartFillRequestBuilder Fill
        {
            get
            {
                return new WorkbookChartFillRequestBuilder(this.AppendSegmentToRequestUrl("fill"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Font.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartFontRequestBuilder"/>.</returns>
        public IWorkbookChartFontRequestBuilder Font
        {
            get
            {
                return new WorkbookChartFontRequestBuilder(this.AppendSegmentToRequestUrl("font"), this.Client);
            }
        }
    
    }
}
