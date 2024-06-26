// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for LoadBalancerNetworkInterfacesOperations
    /// </summary>
    public static partial class LoadBalancerNetworkInterfacesOperationsExtensions
    {
        /// <summary>
        /// Gets associated load balancer network interfaces.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='loadBalancerName'>
        /// The name of the load balancer.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<NetworkInterface> List(this ILoadBalancerNetworkInterfacesOperations operations, string resourceGroupName, string loadBalancerName)
        {
                return ((ILoadBalancerNetworkInterfacesOperations)operations).ListAsync(resourceGroupName, loadBalancerName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets associated load balancer network interfaces.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='loadBalancerName'>
        /// The name of the load balancer.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<NetworkInterface>> ListAsync(this ILoadBalancerNetworkInterfacesOperations operations, string resourceGroupName, string loadBalancerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, loadBalancerName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets associated load balancer network interfaces.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<NetworkInterface> ListNext(this ILoadBalancerNetworkInterfacesOperations operations, string nextPageLink)
        {
                return ((ILoadBalancerNetworkInterfacesOperations)operations).ListNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets associated load balancer network interfaces.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<NetworkInterface>> ListNextAsync(this ILoadBalancerNetworkInterfacesOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
