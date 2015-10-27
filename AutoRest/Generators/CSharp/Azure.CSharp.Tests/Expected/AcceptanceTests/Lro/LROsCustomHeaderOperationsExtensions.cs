// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsLro
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class LROsCustomHeaderOperationsExtensions
    {
            /// <summary>
            /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required
            /// message header for all requests. Long running put request, service
            /// returns a 200 to the initial request, with an entity that contains
            /// ProvisioningState=’Creating’. Poll the endpoint indicated in the
            /// Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static Product PutAsyncRetrySucceeded(this ILROsCustomHeaderOperations operations, Product product = default(Product))
            {
                return Task.Factory.StartNew(s => ((ILROsCustomHeaderOperations)s).PutAsyncRetrySucceededAsync(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required
            /// message header for all requests. Long running put request, service
            /// returns a 200 to the initial request, with an entity that contains
            /// ProvisioningState=’Creating’. Poll the endpoint indicated in the
            /// Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Product> PutAsyncRetrySucceededAsync( this ILROsCustomHeaderOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.PutAsyncRetrySucceededWithHttpMessagesAsync(product, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required
            /// message header for all requests. Long running put request, service
            /// returns a 200 to the initial request, with an entity that contains
            /// ProvisioningState=’Creating’. Poll the endpoint indicated in the
            /// Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static Product BeginPutAsyncRetrySucceeded(this ILROsCustomHeaderOperations operations, Product product = default(Product))
            {
                return Task.Factory.StartNew(s => ((ILROsCustomHeaderOperations)s).BeginPutAsyncRetrySucceededAsync(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required
            /// message header for all requests. Long running put request, service
            /// returns a 200 to the initial request, with an entity that contains
            /// ProvisioningState=’Creating’. Poll the endpoint indicated in the
            /// Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Product> BeginPutAsyncRetrySucceededAsync( this ILROsCustomHeaderOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.BeginPutAsyncRetrySucceededWithHttpMessagesAsync(product, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required
            /// message header for all requests. Long running put request, service
            /// returns a 201 to the initial request, with an entity that contains
            /// ProvisioningState=’Creating’.  Polls return this value until the last
            /// poll returns a ‘200’ with ProvisioningState=’Succeeded’
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static Product Put201CreatingSucceeded200(this ILROsCustomHeaderOperations operations, Product product = default(Product))
            {
                return Task.Factory.StartNew(s => ((ILROsCustomHeaderOperations)s).Put201CreatingSucceeded200Async(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required
            /// message header for all requests. Long running put request, service
            /// returns a 201 to the initial request, with an entity that contains
            /// ProvisioningState=’Creating’.  Polls return this value until the last
            /// poll returns a ‘200’ with ProvisioningState=’Succeeded’
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Product> Put201CreatingSucceeded200Async( this ILROsCustomHeaderOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.Put201CreatingSucceeded200WithHttpMessagesAsync(product, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required
            /// message header for all requests. Long running put request, service
            /// returns a 201 to the initial request, with an entity that contains
            /// ProvisioningState=’Creating’.  Polls return this value until the last
            /// poll returns a ‘200’ with ProvisioningState=’Succeeded’
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static Product BeginPut201CreatingSucceeded200(this ILROsCustomHeaderOperations operations, Product product = default(Product))
            {
                return Task.Factory.StartNew(s => ((ILROsCustomHeaderOperations)s).BeginPut201CreatingSucceeded200Async(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required
            /// message header for all requests. Long running put request, service
            /// returns a 201 to the initial request, with an entity that contains
            /// ProvisioningState=’Creating’.  Polls return this value until the last
            /// poll returns a ‘200’ with ProvisioningState=’Succeeded’
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Product> BeginPut201CreatingSucceeded200Async( this ILROsCustomHeaderOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.BeginPut201CreatingSucceeded200WithHttpMessagesAsync(product, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required
            /// message header for all requests. Long running post request, service
            /// returns a 202 to the initial request, with 'Location' and 'Retry-After'
            /// headers, Polls return a 200 with a response body after success
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static void Post202Retry200(this ILROsCustomHeaderOperations operations, Product product = default(Product))
            {
                Task.Factory.StartNew(s => ((ILROsCustomHeaderOperations)s).Post202Retry200Async(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required
            /// message header for all requests. Long running post request, service
            /// returns a 202 to the initial request, with 'Location' and 'Retry-After'
            /// headers, Polls return a 200 with a response body after success
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task Post202Retry200Async( this ILROsCustomHeaderOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.Post202Retry200WithHttpMessagesAsync(product, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required
            /// message header for all requests. Long running post request, service
            /// returns a 202 to the initial request, with 'Location' and 'Retry-After'
            /// headers, Polls return a 200 with a response body after success
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static void BeginPost202Retry200(this ILROsCustomHeaderOperations operations, Product product = default(Product))
            {
                Task.Factory.StartNew(s => ((ILROsCustomHeaderOperations)s).BeginPost202Retry200Async(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required
            /// message header for all requests. Long running post request, service
            /// returns a 202 to the initial request, with 'Location' and 'Retry-After'
            /// headers, Polls return a 200 with a response body after success
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginPost202Retry200Async( this ILROsCustomHeaderOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginPost202Retry200WithHttpMessagesAsync(product, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required
            /// message header for all requests. Long running post request, service
            /// returns a 202 to the initial request, with an entity that contains
            /// ProvisioningState=’Creating’. Poll the endpoint indicated in the
            /// Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static void PostAsyncRetrySucceeded(this ILROsCustomHeaderOperations operations, Product product = default(Product))
            {
                Task.Factory.StartNew(s => ((ILROsCustomHeaderOperations)s).PostAsyncRetrySucceededAsync(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required
            /// message header for all requests. Long running post request, service
            /// returns a 202 to the initial request, with an entity that contains
            /// ProvisioningState=’Creating’. Poll the endpoint indicated in the
            /// Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PostAsyncRetrySucceededAsync( this ILROsCustomHeaderOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PostAsyncRetrySucceededWithHttpMessagesAsync(product, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required
            /// message header for all requests. Long running post request, service
            /// returns a 202 to the initial request, with an entity that contains
            /// ProvisioningState=’Creating’. Poll the endpoint indicated in the
            /// Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static void BeginPostAsyncRetrySucceeded(this ILROsCustomHeaderOperations operations, Product product = default(Product))
            {
                Task.Factory.StartNew(s => ((ILROsCustomHeaderOperations)s).BeginPostAsyncRetrySucceededAsync(product), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required
            /// message header for all requests. Long running post request, service
            /// returns a 202 to the initial request, with an entity that contains
            /// ProvisioningState=’Creating’. Poll the endpoint indicated in the
            /// Azure-AsyncOperation header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginPostAsyncRetrySucceededAsync( this ILROsCustomHeaderOperations operations, Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginPostAsyncRetrySucceededWithHttpMessagesAsync(product, null, cancellationToken).ConfigureAwait(false);
            }

    }
}
