// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DomainsOperations.
    /// </summary>
    public static partial class DomainsOperationsExtensions
    {
            /// <summary>
            /// Get a domain
            /// </summary>
            /// <remarks>
            /// Get properties of a domain
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            public static Domain Get(this IDomainsOperations operations, string resourceGroupName, string domainName)
            {
                return operations.GetAsync(resourceGroupName, domainName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a domain
            /// </summary>
            /// <remarks>
            /// Get properties of a domain
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Domain> GetAsync(this IDomainsOperations operations, string resourceGroupName, string domainName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, domainName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a domain
            /// </summary>
            /// <remarks>
            /// Asynchronously creates a new domain with the specified parameters.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='domainInfo'>
            /// Domain information
            /// </param>
            public static Domain CreateOrUpdate(this IDomainsOperations operations, string resourceGroupName, string domainName, Domain domainInfo)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, domainName, domainInfo).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a domain
            /// </summary>
            /// <remarks>
            /// Asynchronously creates a new domain with the specified parameters.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='domainInfo'>
            /// Domain information
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Domain> CreateOrUpdateAsync(this IDomainsOperations operations, string resourceGroupName, string domainName, Domain domainInfo, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, domainName, domainInfo, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a domain
            /// </summary>
            /// <remarks>
            /// Delete existing domain
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            public static void Delete(this IDomainsOperations operations, string resourceGroupName, string domainName)
            {
                operations.DeleteAsync(resourceGroupName, domainName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a domain
            /// </summary>
            /// <remarks>
            /// Delete existing domain
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IDomainsOperations operations, string resourceGroupName, string domainName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, domainName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update a domain
            /// </summary>
            /// <remarks>
            /// Asynchronously updates a domain with the specified parameters.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='tags'>
            /// Tags of the domains resource
            /// </param>
            public static Domain Update(this IDomainsOperations operations, string resourceGroupName, string domainName, IDictionary<string, string> tags = default(IDictionary<string, string>))
            {
                return operations.UpdateAsync(resourceGroupName, domainName, tags).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a domain
            /// </summary>
            /// <remarks>
            /// Asynchronously updates a domain with the specified parameters.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='tags'>
            /// Tags of the domains resource
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Domain> UpdateAsync(this IDomainsOperations operations, string resourceGroupName, string domainName, IDictionary<string, string> tags = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, domainName, tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List domains under an Azure subscription
            /// </summary>
            /// <remarks>
            /// List all the domains under an Azure subscription
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IEnumerable<Domain> ListBySubscription(this IDomainsOperations operations)
            {
                return operations.ListBySubscriptionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List domains under an Azure subscription
            /// </summary>
            /// <remarks>
            /// List all the domains under an Azure subscription
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Domain>> ListBySubscriptionAsync(this IDomainsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List domains under a resource group
            /// </summary>
            /// <remarks>
            /// List all the domains under a resource group
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            public static IEnumerable<Domain> ListByResourceGroup(this IDomainsOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List domains under a resource group
            /// </summary>
            /// <remarks>
            /// List all the domains under a resource group
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Domain>> ListByResourceGroupAsync(this IDomainsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List keys for a domain
            /// </summary>
            /// <remarks>
            /// List the two keys used to publish to a domain
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            public static DomainSharedAccessKeys ListSharedAccessKeys(this IDomainsOperations operations, string resourceGroupName, string domainName)
            {
                return operations.ListSharedAccessKeysAsync(resourceGroupName, domainName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List keys for a domain
            /// </summary>
            /// <remarks>
            /// List the two keys used to publish to a domain
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DomainSharedAccessKeys> ListSharedAccessKeysAsync(this IDomainsOperations operations, string resourceGroupName, string domainName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListSharedAccessKeysWithHttpMessagesAsync(resourceGroupName, domainName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerate key for a domain
            /// </summary>
            /// <remarks>
            /// Regenerate a shared access key for a domain
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='keyName'>
            /// Key name to regenerate key1 or key2
            /// </param>
            public static DomainSharedAccessKeys RegenerateKey(this IDomainsOperations operations, string resourceGroupName, string domainName, string keyName)
            {
                return operations.RegenerateKeyAsync(resourceGroupName, domainName, keyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerate key for a domain
            /// </summary>
            /// <remarks>
            /// Regenerate a shared access key for a domain
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='keyName'>
            /// Key name to regenerate key1 or key2
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DomainSharedAccessKeys> RegenerateKeyAsync(this IDomainsOperations operations, string resourceGroupName, string domainName, string keyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegenerateKeyWithHttpMessagesAsync(resourceGroupName, domainName, keyName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a domain
            /// </summary>
            /// <remarks>
            /// Asynchronously creates a new domain with the specified parameters.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='domainInfo'>
            /// Domain information
            /// </param>
            public static Domain BeginCreateOrUpdate(this IDomainsOperations operations, string resourceGroupName, string domainName, Domain domainInfo)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, domainName, domainInfo).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a domain
            /// </summary>
            /// <remarks>
            /// Asynchronously creates a new domain with the specified parameters.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='domainInfo'>
            /// Domain information
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Domain> BeginCreateOrUpdateAsync(this IDomainsOperations operations, string resourceGroupName, string domainName, Domain domainInfo, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, domainName, domainInfo, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a domain
            /// </summary>
            /// <remarks>
            /// Delete existing domain
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            public static void BeginDelete(this IDomainsOperations operations, string resourceGroupName, string domainName)
            {
                operations.BeginDeleteAsync(resourceGroupName, domainName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a domain
            /// </summary>
            /// <remarks>
            /// Delete existing domain
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IDomainsOperations operations, string resourceGroupName, string domainName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, domainName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update a domain
            /// </summary>
            /// <remarks>
            /// Asynchronously updates a domain with the specified parameters.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='tags'>
            /// Tags of the domains resource
            /// </param>
            public static Domain BeginUpdate(this IDomainsOperations operations, string resourceGroupName, string domainName, IDictionary<string, string> tags = default(IDictionary<string, string>))
            {
                return operations.BeginUpdateAsync(resourceGroupName, domainName, tags).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a domain
            /// </summary>
            /// <remarks>
            /// Asynchronously updates a domain with the specified parameters.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='tags'>
            /// Tags of the domains resource
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Domain> BeginUpdateAsync(this IDomainsOperations operations, string resourceGroupName, string domainName, IDictionary<string, string> tags = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, domainName, tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
