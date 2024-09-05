// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure;
using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.CognitiveServices;

/// <summary>
/// CognitiveServicesAccountDeployment.
/// </summary>
public partial class CognitiveServicesAccountDeployment : Resource
{
    /// <summary>
    /// The name of the deployment associated with the Cognitive Services
    /// Account.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Properties of Cognitive Services account deployment.
    /// </summary>
    public BicepValue<CognitiveServicesAccountDeploymentProperties> Properties { get => _properties; set => _properties.Assign(value); }
    private readonly BicepValue<CognitiveServicesAccountDeploymentProperties> _properties;

    /// <summary>
    /// The resource model definition representing SKU.
    /// </summary>
    public BicepValue<CognitiveServicesSku> Sku { get => _sku; set => _sku.Assign(value); }
    private readonly BicepValue<CognitiveServicesSku> _sku;

    /// <summary>
    /// Resource Etag.
    /// </summary>
    public BicepValue<ETag> ETag { get => _eTag; }
    private readonly BicepValue<ETag> _eTag;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent CognitiveServicesAccount.
    /// </summary>
    public CognitiveServicesAccount? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<CognitiveServicesAccount> _parent;

    /// <summary>
    /// Creates a new CognitiveServicesAccountDeployment.
    /// </summary>
    /// <param name="resourceName">Name of the CognitiveServicesAccountDeployment.</param>
    /// <param name="resourceVersion">Version of the CognitiveServicesAccountDeployment.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public CognitiveServicesAccountDeployment(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.CognitiveServices/accounts/deployments", resourceVersion, context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _properties = BicepValue<CognitiveServicesAccountDeploymentProperties>.DefineProperty(this, "Properties", ["properties"]);
        _sku = BicepValue<CognitiveServicesSku>.DefineProperty(this, "Sku", ["sku"]);
        _eTag = BicepValue<ETag>.DefineProperty(this, "ETag", ["etag"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<CognitiveServicesAccount>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Creates a reference to an existing CognitiveServicesAccountDeployment.
    /// </summary>
    /// <param name="resourceName">Name of the CognitiveServicesAccountDeployment.</param>
    /// <param name="resourceVersion">Version of the CognitiveServicesAccountDeployment.</param>
    /// <returns>The existing CognitiveServicesAccountDeployment resource.</returns>
    public static CognitiveServicesAccountDeployment FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
