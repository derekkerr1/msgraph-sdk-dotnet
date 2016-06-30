// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The interface IDeviceRequest.
    /// </summary>
    public partial interface IDeviceRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Device using PUT.
        /// </summary>
        /// <param name="deviceToCreate">The Device to create.</param>
        /// <returns>The created Device.</returns>
        Task<Device> CreateAsync(Device deviceToCreate);        /// <summary>
        /// Creates the specified Device using PUT.
        /// </summary>
        /// <param name="deviceToCreate">The Device to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Device.</returns>
        Task<Device> CreateAsync(Device deviceToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Device.
        /// </summary>
        /// <returns>The task to await.</returns>
        Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Device.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Device.
        /// </summary>
        /// <returns>The Device.</returns>
        Task<Device> GetAsync();

        /// <summary>
        /// Gets the specified Device.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Device.</returns>
        Task<Device> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Device using PATCH.
        /// </summary>
        /// <param name="deviceToUpdate">The Device to update.</param>
        /// <returns>The updated Device.</returns>
        Task<Device> UpdateAsync(Device deviceToUpdate);

        /// <summary>
        /// Updates the specified Device using PATCH.
        /// </summary>
        /// <param name="deviceToUpdate">The Device to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Device.</returns>
        Task<Device> UpdateAsync(Device deviceToUpdate, CancellationToken cancellationToken);

    }
}