// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.ContainerRegistry;

/// <summary>
/// Variant of the CPU.
/// </summary>
public enum ContainerRegistryCpuVariant
{
    /// <summary>
    /// v6.
    /// </summary>
    [DataMember(Name = "v6")]
    V6,

    /// <summary>
    /// v7.
    /// </summary>
    [DataMember(Name = "v7")]
    V7,

    /// <summary>
    /// v8.
    /// </summary>
    [DataMember(Name = "v8")]
    V8,
}
