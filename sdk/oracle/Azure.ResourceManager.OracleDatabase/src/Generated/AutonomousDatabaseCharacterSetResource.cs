// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.OracleDatabase
{
    /// <summary>
    /// A Class representing an AutonomousDatabaseCharacterSet along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="AutonomousDatabaseCharacterSetResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetAutonomousDatabaseCharacterSetResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetAutonomousDatabaseCharacterSet method.
    /// </summary>
    public partial class AutonomousDatabaseCharacterSetResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AutonomousDatabaseCharacterSetResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="location"> The location. </param>
        /// <param name="adbscharsetname"> The adbscharsetname. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, AzureLocation location, string adbscharsetname)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Oracle.Database/locations/{location}/autonomousDatabaseCharacterSets/{adbscharsetname}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _autonomousDatabaseCharacterSetClientDiagnostics;
        private readonly AutonomousDatabaseCharacterSetsRestOperations _autonomousDatabaseCharacterSetRestClient;
        private readonly AutonomousDatabaseCharacterSetData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Oracle.Database/locations/autonomousDatabaseCharacterSets";

        /// <summary> Initializes a new instance of the <see cref="AutonomousDatabaseCharacterSetResource"/> class for mocking. </summary>
        protected AutonomousDatabaseCharacterSetResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutonomousDatabaseCharacterSetResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AutonomousDatabaseCharacterSetResource(ArmClient client, AutonomousDatabaseCharacterSetData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AutonomousDatabaseCharacterSetResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AutonomousDatabaseCharacterSetResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _autonomousDatabaseCharacterSetClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.OracleDatabase", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string autonomousDatabaseCharacterSetApiVersion);
            _autonomousDatabaseCharacterSetRestClient = new AutonomousDatabaseCharacterSetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, autonomousDatabaseCharacterSetApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AutonomousDatabaseCharacterSetData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a AutonomousDatabaseCharacterSet
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Oracle.Database/locations/{location}/autonomousDatabaseCharacterSets/{adbscharsetname}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutonomousDatabaseCharacterSet_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutonomousDatabaseCharacterSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AutonomousDatabaseCharacterSetResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _autonomousDatabaseCharacterSetClientDiagnostics.CreateScope("AutonomousDatabaseCharacterSetResource.Get");
            scope.Start();
            try
            {
                var response = await _autonomousDatabaseCharacterSetRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutonomousDatabaseCharacterSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a AutonomousDatabaseCharacterSet
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Oracle.Database/locations/{location}/autonomousDatabaseCharacterSets/{adbscharsetname}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutonomousDatabaseCharacterSet_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutonomousDatabaseCharacterSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AutonomousDatabaseCharacterSetResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _autonomousDatabaseCharacterSetClientDiagnostics.CreateScope("AutonomousDatabaseCharacterSetResource.Get");
            scope.Start();
            try
            {
                var response = _autonomousDatabaseCharacterSetRestClient.Get(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutonomousDatabaseCharacterSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
