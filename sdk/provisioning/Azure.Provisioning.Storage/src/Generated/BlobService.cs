// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// BlobService.
/// </summary>
public partial class BlobService : Resource
{
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The blob service properties for change feed events.
    /// </summary>
    public BicepValue<BlobServiceChangeFeed> ChangeFeed { get => _changeFeed; set => _changeFeed.Assign(value); }
    private readonly BicepValue<BlobServiceChangeFeed> _changeFeed;

    /// <summary>
    /// The blob service properties for container soft delete.
    /// </summary>
    public BicepValue<DeleteRetentionPolicy> ContainerDeleteRetentionPolicy { get => _containerDeleteRetentionPolicy; set => _containerDeleteRetentionPolicy.Assign(value); }
    private readonly BicepValue<DeleteRetentionPolicy> _containerDeleteRetentionPolicy;

    /// <summary>
    /// The List of CORS rules. You can include up to five CorsRule elements in
    /// the request.
    /// </summary>
    public BicepList<StorageCorsRule> CorsRules { get => _corsRules; set => _corsRules.Assign(value); }
    private readonly BicepList<StorageCorsRule> _corsRules;

    /// <summary>
    /// DefaultServiceVersion indicates the default version to use for requests
    /// to the Blob service if an incoming request’s version is not specified.
    /// Possible values include version 2008-10-27 and all more recent
    /// versions.
    /// </summary>
    public BicepValue<string> DefaultServiceVersion { get => _defaultServiceVersion; set => _defaultServiceVersion.Assign(value); }
    private readonly BicepValue<string> _defaultServiceVersion;

    /// <summary>
    /// The blob service properties for blob soft delete.
    /// </summary>
    public BicepValue<DeleteRetentionPolicy> DeleteRetentionPolicy { get => _deleteRetentionPolicy; set => _deleteRetentionPolicy.Assign(value); }
    private readonly BicepValue<DeleteRetentionPolicy> _deleteRetentionPolicy;

    /// <summary>
    /// Deprecated in favor of isVersioningEnabled property.
    /// </summary>
    public BicepValue<bool> IsAutomaticSnapshotPolicyEnabled { get => _isAutomaticSnapshotPolicyEnabled; set => _isAutomaticSnapshotPolicyEnabled.Assign(value); }
    private readonly BicepValue<bool> _isAutomaticSnapshotPolicyEnabled;

    /// <summary>
    /// Versioning is enabled if set to true.
    /// </summary>
    public BicepValue<bool> IsVersioningEnabled { get => _isVersioningEnabled; set => _isVersioningEnabled.Assign(value); }
    private readonly BicepValue<bool> _isVersioningEnabled;

    /// <summary>
    /// The blob service property to configure last access time based tracking
    /// policy.
    /// </summary>
    public BicepValue<LastAccessTimeTrackingPolicy> LastAccessTimeTrackingPolicy { get => _lastAccessTimeTrackingPolicy; set => _lastAccessTimeTrackingPolicy.Assign(value); }
    private readonly BicepValue<LastAccessTimeTrackingPolicy> _lastAccessTimeTrackingPolicy;

    /// <summary>
    /// The blob service properties for blob restore policy.
    /// </summary>
    public BicepValue<RestorePolicy> RestorePolicy { get => _restorePolicy; set => _restorePolicy.Assign(value); }
    private readonly BicepValue<RestorePolicy> _restorePolicy;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Sku name and tier.
    /// </summary>
    public BicepValue<StorageSku> Sku { get => _sku; }
    private readonly BicepValue<StorageSku> _sku;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent StorageAccount.
    /// </summary>
    public StorageAccount? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<StorageAccount> _parent;

    /// <summary>
    /// Get the default value for the Name property.
    /// </summary>
    private partial BicepValue<string> GetNameDefaultValue();

    /// <summary>
    /// Creates a new BlobService.
    /// </summary>
    /// <param name="resourceName">Name of the BlobService.</param>
    /// <param name="resourceVersion">Version of the BlobService.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public BlobService(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.Storage/storageAccounts/blobServices", resourceVersion ?? "2023-01-01", context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], defaultValue: GetNameDefaultValue());
        _changeFeed = BicepValue<BlobServiceChangeFeed>.DefineProperty(this, "ChangeFeed", ["properties", "changeFeed"]);
        _containerDeleteRetentionPolicy = BicepValue<DeleteRetentionPolicy>.DefineProperty(this, "ContainerDeleteRetentionPolicy", ["properties", "containerDeleteRetentionPolicy"]);
        _corsRules = BicepList<StorageCorsRule>.DefineProperty(this, "CorsRules", ["properties", "cors", "corsRules"]);
        _defaultServiceVersion = BicepValue<string>.DefineProperty(this, "DefaultServiceVersion", ["properties", "defaultServiceVersion"]);
        _deleteRetentionPolicy = BicepValue<DeleteRetentionPolicy>.DefineProperty(this, "DeleteRetentionPolicy", ["properties", "deleteRetentionPolicy"]);
        _isAutomaticSnapshotPolicyEnabled = BicepValue<bool>.DefineProperty(this, "IsAutomaticSnapshotPolicyEnabled", ["properties", "automaticSnapshotPolicyEnabled"]);
        _isVersioningEnabled = BicepValue<bool>.DefineProperty(this, "IsVersioningEnabled", ["properties", "isVersioningEnabled"]);
        _lastAccessTimeTrackingPolicy = BicepValue<LastAccessTimeTrackingPolicy>.DefineProperty(this, "LastAccessTimeTrackingPolicy", ["properties", "lastAccessTimeTrackingPolicy"]);
        _restorePolicy = BicepValue<RestorePolicy>.DefineProperty(this, "RestorePolicy", ["properties", "restorePolicy"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _sku = BicepValue<StorageSku>.DefineProperty(this, "Sku", ["sku"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<StorageAccount>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported BlobService resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-01-01.
        /// </summary>
        public static readonly string V2024_01_01 = "2024-01-01";

        /// <summary>
        /// 2023-05-01.
        /// </summary>
        public static readonly string V2023_05_01 = "2023-05-01";

        /// <summary>
        /// 2023-04-01.
        /// </summary>
        public static readonly string V2023_04_01 = "2023-04-01";

        /// <summary>
        /// 2023-01-01.
        /// </summary>
        public static readonly string V2023_01_01 = "2023-01-01";

        /// <summary>
        /// 2022-09-01.
        /// </summary>
        public static readonly string V2022_09_01 = "2022-09-01";

        /// <summary>
        /// 2022-05-01.
        /// </summary>
        public static readonly string V2022_05_01 = "2022-05-01";

        /// <summary>
        /// 2021-09-01.
        /// </summary>
        public static readonly string V2021_09_01 = "2021-09-01";

        /// <summary>
        /// 2021-08-01.
        /// </summary>
        public static readonly string V2021_08_01 = "2021-08-01";

        /// <summary>
        /// 2021-06-01.
        /// </summary>
        public static readonly string V2021_06_01 = "2021-06-01";

        /// <summary>
        /// 2021-05-01.
        /// </summary>
        public static readonly string V2021_05_01 = "2021-05-01";

        /// <summary>
        /// 2021-04-01.
        /// </summary>
        public static readonly string V2021_04_01 = "2021-04-01";

        /// <summary>
        /// 2021-02-01.
        /// </summary>
        public static readonly string V2021_02_01 = "2021-02-01";

        /// <summary>
        /// 2021-01-01.
        /// </summary>
        public static readonly string V2021_01_01 = "2021-01-01";

        /// <summary>
        /// 2019-06-01.
        /// </summary>
        public static readonly string V2019_06_01 = "2019-06-01";

        /// <summary>
        /// 2019-04-01.
        /// </summary>
        public static readonly string V2019_04_01 = "2019-04-01";

        /// <summary>
        /// 2018-11-01.
        /// </summary>
        public static readonly string V2018_11_01 = "2018-11-01";

        /// <summary>
        /// 2018-07-01.
        /// </summary>
        public static readonly string V2018_07_01 = "2018-07-01";

        /// <summary>
        /// 2018-02-01.
        /// </summary>
        public static readonly string V2018_02_01 = "2018-02-01";

        /// <summary>
        /// 2017-10-01.
        /// </summary>
        public static readonly string V2017_10_01 = "2017-10-01";

        /// <summary>
        /// 2017-06-01.
        /// </summary>
        public static readonly string V2017_06_01 = "2017-06-01";

        /// <summary>
        /// 2016-12-01.
        /// </summary>
        public static readonly string V2016_12_01 = "2016-12-01";

        /// <summary>
        /// 2016-05-01.
        /// </summary>
        public static readonly string V2016_05_01 = "2016-05-01";
    }

    /// <summary>
    /// Creates a reference to an existing BlobService.
    /// </summary>
    /// <param name="resourceName">Name of the BlobService.</param>
    /// <param name="resourceVersion">Version of the BlobService.</param>
    /// <returns>The existing BlobService resource.</returns>
    public static BlobService FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
