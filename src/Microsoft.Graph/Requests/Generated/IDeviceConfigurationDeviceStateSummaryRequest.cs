// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDeviceConfigurationDeviceStateSummaryRequest.
    /// </summary>
    public partial interface IDeviceConfigurationDeviceStateSummaryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceConfigurationDeviceStateSummary using PUT.
        /// </summary>
        /// <param name="deviceConfigurationDeviceStateSummaryToCreate">The DeviceConfigurationDeviceStateSummary to create.</param>
        /// <returns>The created DeviceConfigurationDeviceStateSummary.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationDeviceStateSummary> CreateAsync(DeviceConfigurationDeviceStateSummary deviceConfigurationDeviceStateSummaryToCreate);        /// <summary>
        /// Creates the specified DeviceConfigurationDeviceStateSummary using PUT.
        /// </summary>
        /// <param name="deviceConfigurationDeviceStateSummaryToCreate">The DeviceConfigurationDeviceStateSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceConfigurationDeviceStateSummary.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationDeviceStateSummary> CreateAsync(DeviceConfigurationDeviceStateSummary deviceConfigurationDeviceStateSummaryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceConfigurationDeviceStateSummary.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceConfigurationDeviceStateSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceConfigurationDeviceStateSummary.
        /// </summary>
        /// <returns>The DeviceConfigurationDeviceStateSummary.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationDeviceStateSummary> GetAsync();

        /// <summary>
        /// Gets the specified DeviceConfigurationDeviceStateSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceConfigurationDeviceStateSummary.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationDeviceStateSummary> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceConfigurationDeviceStateSummary using PATCH.
        /// </summary>
        /// <param name="deviceConfigurationDeviceStateSummaryToUpdate">The DeviceConfigurationDeviceStateSummary to update.</param>
        /// <returns>The updated DeviceConfigurationDeviceStateSummary.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationDeviceStateSummary> UpdateAsync(DeviceConfigurationDeviceStateSummary deviceConfigurationDeviceStateSummaryToUpdate);

        /// <summary>
        /// Updates the specified DeviceConfigurationDeviceStateSummary using PATCH.
        /// </summary>
        /// <param name="deviceConfigurationDeviceStateSummaryToUpdate">The DeviceConfigurationDeviceStateSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated DeviceConfigurationDeviceStateSummary.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationDeviceStateSummary> UpdateAsync(DeviceConfigurationDeviceStateSummary deviceConfigurationDeviceStateSummaryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationDeviceStateSummaryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationDeviceStateSummaryRequest Expand(Expression<Func<DeviceConfigurationDeviceStateSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationDeviceStateSummaryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationDeviceStateSummaryRequest Select(Expression<Func<DeviceConfigurationDeviceStateSummary, object>> selectExpression);

    }
}
