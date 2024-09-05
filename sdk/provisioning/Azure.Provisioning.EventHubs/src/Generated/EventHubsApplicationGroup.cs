// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.EventHubs;

/// <summary>
/// EventHubsApplicationGroup.
/// </summary>
public partial class EventHubsApplicationGroup : Resource
{
    /// <summary>
    /// The Application Group name.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The Unique identifier for application group.Supports
    /// SAS(SASKeyName=KeyName) or AAD(AADAppID=Guid).
    /// </summary>
    public BicepValue<string> ClientAppGroupIdentifier { get => _clientAppGroupIdentifier; set => _clientAppGroupIdentifier.Assign(value); }
    private readonly BicepValue<string> _clientAppGroupIdentifier;

    /// <summary>
    /// Determines if Application Group is allowed to create connection with
    /// namespace or not. Once the isEnabled is set to false, all the existing
    /// connections of application group gets dropped and no new connections
    /// will be allowed.
    /// </summary>
    public BicepValue<bool> IsEnabled { get => _isEnabled; set => _isEnabled.Assign(value); }
    private readonly BicepValue<bool> _isEnabled;

    /// <summary>
    /// List of group policies that define the behavior of application group.
    /// The policies can support resource governance scenarios such as
    /// limiting ingress or egress traffic.             Please note
    /// Azure.ResourceManager.EventHubs.Models.EventHubsApplicationGroupPolicy
    /// is the base class. According to the scenario, a derived class of the
    /// base class might need to be assigned here, or this property needs to
    /// be casted to one of the possible derived classes.             The
    /// available derived classes include
    /// Azure.ResourceManager.EventHubs.Models.EventHubsThrottlingPolicy.
    /// </summary>
    public BicepList<EventHubsApplicationGroupPolicy> Policies { get => _policies; set => _policies.Assign(value); }
    private readonly BicepList<EventHubsApplicationGroupPolicy> _policies;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// The geo-location where the resource lives.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent EventHubsNamespace.
    /// </summary>
    public EventHubsNamespace? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<EventHubsNamespace> _parent;

    /// <summary>
    /// Creates a new EventHubsApplicationGroup.
    /// </summary>
    /// <param name="resourceName">Name of the EventHubsApplicationGroup.</param>
    /// <param name="resourceVersion">Version of the EventHubsApplicationGroup.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public EventHubsApplicationGroup(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.EventHub/namespaces/applicationGroups", resourceVersion ?? "2024-01-01", context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _clientAppGroupIdentifier = BicepValue<string>.DefineProperty(this, "ClientAppGroupIdentifier", ["properties", "clientAppGroupIdentifier"]);
        _isEnabled = BicepValue<bool>.DefineProperty(this, "IsEnabled", ["properties", "isEnabled"]);
        _policies = BicepList<EventHubsApplicationGroupPolicy>.DefineProperty(this, "Policies", ["properties", "policies"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<EventHubsNamespace>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported EventHubsApplicationGroup resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-05-01-preview.
        /// </summary>
        public static readonly string V2024_05_01_preview = "2024-05-01-preview";

        /// <summary>
        /// 2024-01-01.
        /// </summary>
        public static readonly string V2024_01_01 = "2024-01-01";
    }

    /// <summary>
    /// Creates a reference to an existing EventHubsApplicationGroup.
    /// </summary>
    /// <param name="resourceName">Name of the EventHubsApplicationGroup.</param>
    /// <param name="resourceVersion">Version of the EventHubsApplicationGroup.</param>
    /// <returns>The existing EventHubsApplicationGroup resource.</returns>
    public static EventHubsApplicationGroup FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
