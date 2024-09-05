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

namespace Azure.Provisioning.ApplicationInsights;

/// <summary>
/// ApplicationInsightsWorkbook.
/// </summary>
public partial class ApplicationInsightsWorkbook : Resource
{
    /// <summary>
    /// The name of the workbook resource. The value must be an UUID.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Workbook category, as defined by the user at creation time.
    /// </summary>
    public BicepValue<string> Category { get => _category; set => _category.Assign(value); }
    private readonly BicepValue<string> _category;

    /// <summary>
    /// The description of the workbook.
    /// </summary>
    public BicepValue<string> Description { get => _description; set => _description.Assign(value); }
    private readonly BicepValue<string> _description;

    /// <summary>
    /// The user-defined name (display name) of the workbook.
    /// </summary>
    public BicepValue<string> DisplayName { get => _displayName; set => _displayName.Assign(value); }
    private readonly BicepValue<string> _displayName;

    /// <summary>
    /// Resource etag.
    /// </summary>
    public BicepValue<ETag> ETag { get => _eTag; set => _eTag.Assign(value); }
    private readonly BicepValue<ETag> _eTag;

    /// <summary>
    /// Identity used for BYOS.
    /// </summary>
    public BicepValue<ManagedServiceIdentity> Identity { get => _identity; set => _identity.Assign(value); }
    private readonly BicepValue<ManagedServiceIdentity> _identity;

    /// <summary>
    /// The kind of workbook. Only valid value is shared.
    /// </summary>
    public BicepValue<WorkbookSharedTypeKind> Kind { get => _kind; set => _kind.Assign(value); }
    private readonly BicepValue<WorkbookSharedTypeKind> _kind;

    /// <summary>
    /// Configuration of this particular workbook. Configuration data is a
    /// string containing valid JSON.
    /// </summary>
    public BicepValue<string> SerializedData { get => _serializedData; set => _serializedData.Assign(value); }
    private readonly BicepValue<string> _serializedData;

    /// <summary>
    /// Azure Resource Id that will fetch all linked workbooks.
    /// </summary>
    public BicepValue<ResourceIdentifier> SourceId { get => _sourceId; set => _sourceId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _sourceId;

    /// <summary>
    /// The resourceId to the storage account when bring your own storage is
    /// used.
    /// </summary>
    public BicepValue<Uri> StorageUri { get => _storageUri; set => _storageUri.Assign(value); }
    private readonly BicepValue<Uri> _storageUri;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Workbook schema version format, like &apos;Notebook/1.0&apos;, which
    /// should match the workbook in serializedData.
    /// </summary>
    public BicepValue<string> Version { get => _version; set => _version.Assign(value); }
    private readonly BicepValue<string> _version;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Date and time in UTC of the last modification that was made to this
    /// workbook definition.
    /// </summary>
    public BicepValue<DateTimeOffset> ModifiedOn { get => _modifiedOn; }
    private readonly BicepValue<DateTimeOffset> _modifiedOn;

    /// <summary>
    /// The unique revision id for this workbook definition.
    /// </summary>
    public BicepValue<string> Revision { get => _revision; }
    private readonly BicepValue<string> _revision;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Unique user id of the specific user that owns this workbook.
    /// </summary>
    public BicepValue<string> UserId { get => _userId; }
    private readonly BicepValue<string> _userId;

    /// <summary>
    /// Creates a new ApplicationInsightsWorkbook.
    /// </summary>
    /// <param name="resourceName">Name of the ApplicationInsightsWorkbook.</param>
    /// <param name="resourceVersion">Version of the ApplicationInsightsWorkbook.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public ApplicationInsightsWorkbook(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.Insights/workbooks", resourceVersion ?? "2023-06-01", context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _category = BicepValue<string>.DefineProperty(this, "Category", ["properties", "category"]);
        _description = BicepValue<string>.DefineProperty(this, "Description", ["properties", "description"]);
        _displayName = BicepValue<string>.DefineProperty(this, "DisplayName", ["properties", "displayName"]);
        _eTag = BicepValue<ETag>.DefineProperty(this, "ETag", ["etag"]);
        _identity = BicepValue<ManagedServiceIdentity>.DefineProperty(this, "Identity", ["identity"]);
        _kind = BicepValue<WorkbookSharedTypeKind>.DefineProperty(this, "Kind", ["kind"]);
        _serializedData = BicepValue<string>.DefineProperty(this, "SerializedData", ["properties", "serializedData"]);
        _sourceId = BicepValue<ResourceIdentifier>.DefineProperty(this, "SourceId", ["properties", "sourceId"]);
        _storageUri = BicepValue<Uri>.DefineProperty(this, "StorageUri", ["properties", "storageUri"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _version = BicepValue<string>.DefineProperty(this, "Version", ["properties", "version"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _modifiedOn = BicepValue<DateTimeOffset>.DefineProperty(this, "ModifiedOn", ["properties", "timeModified"], isOutput: true);
        _revision = BicepValue<string>.DefineProperty(this, "Revision", ["properties", "revision"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _userId = BicepValue<string>.DefineProperty(this, "UserId", ["properties", "userId"], isOutput: true);
    }

    /// <summary>
    /// Supported ApplicationInsightsWorkbook resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2023-06-01.
        /// </summary>
        public static readonly string V2023_06_01 = "2023-06-01";

        /// <summary>
        /// 2022-04-01.
        /// </summary>
        public static readonly string V2022_04_01 = "2022-04-01";

        /// <summary>
        /// 2021-08-01.
        /// </summary>
        public static readonly string V2021_08_01 = "2021-08-01";

        /// <summary>
        /// 2021-03-08.
        /// </summary>
        public static readonly string V2021_03_08 = "2021-03-08";

        /// <summary>
        /// 2020-10-20.
        /// </summary>
        public static readonly string V2020_10_20 = "2020-10-20";

        /// <summary>
        /// 2020-02-12.
        /// </summary>
        public static readonly string V2020_02_12 = "2020-02-12";
    }

    /// <summary>
    /// Creates a reference to an existing ApplicationInsightsWorkbook.
    /// </summary>
    /// <param name="resourceName">Name of the ApplicationInsightsWorkbook.</param>
    /// <param name="resourceVersion">Version of the ApplicationInsightsWorkbook.</param>
    /// <returns>The existing ApplicationInsightsWorkbook resource.</returns>
    public static ApplicationInsightsWorkbook FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
