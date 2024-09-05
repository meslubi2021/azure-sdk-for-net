// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// Application logs azure blob storage configuration.
/// </summary>
public partial class AppServiceBlobStorageApplicationLogsConfig : ProvisioningConstruct
{
    /// <summary>
    /// Log level.
    /// </summary>
    public BicepValue<WebAppLogLevel> Level { get => _level; set => _level.Assign(value); }
    private readonly BicepValue<WebAppLogLevel> _level;

    /// <summary>
    /// SAS url to a azure blob container with read/write/list/delete
    /// permissions.
    /// </summary>
    public BicepValue<Uri> SasUri { get => _sasUri; set => _sasUri.Assign(value); }
    private readonly BicepValue<Uri> _sasUri;

    /// <summary>
    /// Retention in days.             Remove blobs older than X days.
    /// 0 or lower means no retention.
    /// </summary>
    public BicepValue<int> RetentionInDays { get => _retentionInDays; set => _retentionInDays.Assign(value); }
    private readonly BicepValue<int> _retentionInDays;

    /// <summary>
    /// Creates a new AppServiceBlobStorageApplicationLogsConfig.
    /// </summary>
    public AppServiceBlobStorageApplicationLogsConfig()
    {
        _level = BicepValue<WebAppLogLevel>.DefineProperty(this, "Level", ["level"]);
        _sasUri = BicepValue<Uri>.DefineProperty(this, "SasUri", ["sasUrl"]);
        _retentionInDays = BicepValue<int>.DefineProperty(this, "RetentionInDays", ["retentionInDays"]);
    }
}
