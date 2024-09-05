// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerRegistry;

/// <summary>
/// The image update trigger that caused a build.
/// </summary>
public partial class ContainerRegistryImageUpdateTrigger : ProvisioningConstruct
{
    /// <summary>
    /// The unique ID of the trigger.
    /// </summary>
    public BicepValue<Guid> Id { get => _id; set => _id.Assign(value); }
    private readonly BicepValue<Guid> _id;

    /// <summary>
    /// The timestamp when the image update happened.
    /// </summary>
    public BicepValue<DateTimeOffset> Timestamp { get => _timestamp; set => _timestamp.Assign(value); }
    private readonly BicepValue<DateTimeOffset> _timestamp;

    /// <summary>
    /// The list of image updates that caused the build.
    /// </summary>
    public BicepList<ContainerRegistryImageDescriptor> Images { get => _images; set => _images.Assign(value); }
    private readonly BicepList<ContainerRegistryImageDescriptor> _images;

    /// <summary>
    /// Creates a new ContainerRegistryImageUpdateTrigger.
    /// </summary>
    public ContainerRegistryImageUpdateTrigger()
    {
        _id = BicepValue<Guid>.DefineProperty(this, "Id", ["id"]);
        _timestamp = BicepValue<DateTimeOffset>.DefineProperty(this, "Timestamp", ["timestamp"]);
        _images = BicepList<ContainerRegistryImageDescriptor>.DefineProperty(this, "Images", ["images"]);
    }
}
