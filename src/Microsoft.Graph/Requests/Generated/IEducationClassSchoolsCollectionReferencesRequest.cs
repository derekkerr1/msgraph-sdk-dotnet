// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionReferencesRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IEducationClassSchoolsCollectionReferencesRequest.
    /// </summary>
    public partial interface IEducationClassSchoolsCollectionReferencesRequest : IBaseRequest
    {
        
        System.Threading.Tasks.Task AddAsync(EducationSchool educationSchool);

        /// <summary>
        /// Adds the specified EducationSchool to the collection via POST.
        /// </summary>
        /// <param name="educationSchool">The EducationSchool to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        System.Threading.Tasks.Task AddAsync(EducationSchool educationSchool, CancellationToken cancellationToken);
    }
}
