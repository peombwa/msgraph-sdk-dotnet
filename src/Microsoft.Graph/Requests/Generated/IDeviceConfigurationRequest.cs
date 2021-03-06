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
    /// The interface IDeviceConfigurationRequest.
    /// </summary>
    public partial interface IDeviceConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceConfiguration using PUT.
        /// </summary>
        /// <param name="deviceConfigurationToCreate">The DeviceConfiguration to create.</param>
        /// <returns>The created DeviceConfiguration.</returns>
        System.Threading.Tasks.Task<DeviceConfiguration> CreateAsync(DeviceConfiguration deviceConfigurationToCreate);        /// <summary>
        /// Creates the specified DeviceConfiguration using PUT.
        /// </summary>
        /// <param name="deviceConfigurationToCreate">The DeviceConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceConfiguration.</returns>
        System.Threading.Tasks.Task<DeviceConfiguration> CreateAsync(DeviceConfiguration deviceConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceConfiguration.
        /// </summary>
        /// <returns>The DeviceConfiguration.</returns>
        System.Threading.Tasks.Task<DeviceConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified DeviceConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceConfiguration.</returns>
        System.Threading.Tasks.Task<DeviceConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceConfiguration using PATCH.
        /// </summary>
        /// <param name="deviceConfigurationToUpdate">The DeviceConfiguration to update.</param>
        /// <returns>The updated DeviceConfiguration.</returns>
        System.Threading.Tasks.Task<DeviceConfiguration> UpdateAsync(DeviceConfiguration deviceConfigurationToUpdate);

        /// <summary>
        /// Updates the specified DeviceConfiguration using PATCH.
        /// </summary>
        /// <param name="deviceConfigurationToUpdate">The DeviceConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated DeviceConfiguration.</returns>
        System.Threading.Tasks.Task<DeviceConfiguration> UpdateAsync(DeviceConfiguration deviceConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationRequest Expand(Expression<Func<DeviceConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationRequest Select(Expression<Func<DeviceConfiguration, object>> selectExpression);

    }
}
