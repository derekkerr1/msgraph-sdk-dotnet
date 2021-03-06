// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookWorksheetProtectionRequestBuilder.
    /// </summary>
    public partial class WorkbookWorksheetProtectionRequestBuilder : EntityRequestBuilder, IWorkbookWorksheetProtectionRequestBuilder
    {

        /// <summary>
        /// Constructs a new WorkbookWorksheetProtectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WorkbookWorksheetProtectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IWorkbookWorksheetProtectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IWorkbookWorksheetProtectionRequest Request(IEnumerable<Option> options)
        {
            return new WorkbookWorksheetProtectionRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for WorkbookWorksheetProtectionProtect.
        /// </summary>
        /// <returns>The <see cref="IWorkbookWorksheetProtectionProtectRequestBuilder"/>.</returns>
        public IWorkbookWorksheetProtectionProtectRequestBuilder Protect(
            WorkbookWorksheetProtectionOptions options = null)
        {
            return new WorkbookWorksheetProtectionProtectRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.protect"),
                this.Client,
                options);
        }

        /// <summary>
        /// Gets the request builder for WorkbookWorksheetProtectionUnprotect.
        /// </summary>
        /// <returns>The <see cref="IWorkbookWorksheetProtectionUnprotectRequestBuilder"/>.</returns>
        public IWorkbookWorksheetProtectionUnprotectRequestBuilder Unprotect()
        {
            return new WorkbookWorksheetProtectionUnprotectRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.unprotect"),
                this.Client);
        }
    
    }
}
