// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.ContainerRegistry;

/// <summary>
/// ContainerRegistryTask.
/// </summary>
public partial class ContainerRegistryTask : Resource
{
    /// <summary>
    /// The name of the container registry task.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// The CPU configuration in terms of number of cores required for the run.
    /// </summary>
    public BicepValue<int> AgentCpu { get => _agentCpu; set => _agentCpu.Assign(value); }
    private readonly BicepValue<int> _agentCpu;

    /// <summary>
    /// The dedicated agent pool for the task.
    /// </summary>
    public BicepValue<string> AgentPoolName { get => _agentPoolName; set => _agentPoolName.Assign(value); }
    private readonly BicepValue<string> _agentPoolName;

    /// <summary>
    /// The properties that describes a set of credentials that will be used
    /// when this run is invoked.
    /// </summary>
    public BicepValue<ContainerRegistryCredentials> Credentials { get => _credentials; set => _credentials.Assign(value); }
    private readonly BicepValue<ContainerRegistryCredentials> _credentials;

    /// <summary>
    /// Identity for the resource.
    /// </summary>
    public BicepValue<ManagedServiceIdentity> Identity { get => _identity; set => _identity.Assign(value); }
    private readonly BicepValue<ManagedServiceIdentity> _identity;

    /// <summary>
    /// The value of this property indicates whether the task resource is
    /// system task or not.
    /// </summary>
    public BicepValue<bool> IsSystemTask { get => _isSystemTask; set => _isSystemTask.Assign(value); }
    private readonly BicepValue<bool> _isSystemTask;

    /// <summary>
    /// The template that describes the repository and tag information for run
    /// log artifact.
    /// </summary>
    public BicepValue<string> LogTemplate { get => _logTemplate; set => _logTemplate.Assign(value); }
    private readonly BicepValue<string> _logTemplate;

    /// <summary>
    /// The platform properties against which the run has to happen.
    /// </summary>
    public BicepValue<ContainerRegistryPlatformProperties> Platform { get => _platform; set => _platform.Assign(value); }
    private readonly BicepValue<ContainerRegistryPlatformProperties> _platform;

    /// <summary>
    /// The current status of task.
    /// </summary>
    public BicepValue<ContainerRegistryTaskStatus> Status { get => _status; set => _status.Assign(value); }
    private readonly BicepValue<ContainerRegistryTaskStatus> _status;

    /// <summary>
    /// The properties of a task step.             Please note
    /// Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryTaskStepProperties
    /// is the base class. According to the scenario, a derived class of the
    /// base class might need to be assigned here, or this property needs to
    /// be casted to one of the possible derived classes.             The
    /// available derived classes include
    /// Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryDockerBuildStep,
    /// Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryEncodedTaskStep
    /// and
    /// Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryFileTaskStep.
    /// </summary>
    public BicepValue<ContainerRegistryTaskStepProperties> Step { get => _step; set => _step.Assign(value); }
    private readonly BicepValue<ContainerRegistryTaskStepProperties> _step;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Run timeout in seconds.
    /// </summary>
    public BicepValue<int> TimeoutInSeconds { get => _timeoutInSeconds; set => _timeoutInSeconds.Assign(value); }
    private readonly BicepValue<int> _timeoutInSeconds;

    /// <summary>
    /// The properties that describe all triggers for the task.
    /// </summary>
    public BicepValue<ContainerRegistryTriggerProperties> Trigger { get => _trigger; set => _trigger.Assign(value); }
    private readonly BicepValue<ContainerRegistryTriggerProperties> _trigger;

    /// <summary>
    /// The creation date of task.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn { get => _createdOn; }
    private readonly BicepValue<DateTimeOffset> _createdOn;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// The provisioning state of the task.
    /// </summary>
    public BicepValue<ContainerRegistryProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<ContainerRegistryProvisioningState> _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent ContainerRegistryService.
    /// </summary>
    public ContainerRegistryService? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<ContainerRegistryService> _parent;

    /// <summary>
    /// Creates a new ContainerRegistryTask.
    /// </summary>
    /// <param name="resourceName">Name of the ContainerRegistryTask.</param>
    /// <param name="resourceVersion">Version of the ContainerRegistryTask.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public ContainerRegistryTask(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.ContainerRegistry/registries/tasks", resourceVersion ?? "2019-04-01", context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _agentCpu = BicepValue<int>.DefineProperty(this, "AgentCpu", ["properties", "agentConfiguration", "cpu"]);
        _agentPoolName = BicepValue<string>.DefineProperty(this, "AgentPoolName", ["properties", "agentPoolName"]);
        _credentials = BicepValue<ContainerRegistryCredentials>.DefineProperty(this, "Credentials", ["properties", "credentials"]);
        _identity = BicepValue<ManagedServiceIdentity>.DefineProperty(this, "Identity", ["identity"]);
        _isSystemTask = BicepValue<bool>.DefineProperty(this, "IsSystemTask", ["properties", "isSystemTask"]);
        _logTemplate = BicepValue<string>.DefineProperty(this, "LogTemplate", ["properties", "logTemplate"]);
        _platform = BicepValue<ContainerRegistryPlatformProperties>.DefineProperty(this, "Platform", ["properties", "platform"]);
        _status = BicepValue<ContainerRegistryTaskStatus>.DefineProperty(this, "Status", ["properties", "status"]);
        _step = BicepValue<ContainerRegistryTaskStepProperties>.DefineProperty(this, "Step", ["properties", "step"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _timeoutInSeconds = BicepValue<int>.DefineProperty(this, "TimeoutInSeconds", ["properties", "timeout"]);
        _trigger = BicepValue<ContainerRegistryTriggerProperties>.DefineProperty(this, "Trigger", ["properties", "trigger"]);
        _createdOn = BicepValue<DateTimeOffset>.DefineProperty(this, "CreatedOn", ["properties", "creationDate"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _provisioningState = BicepValue<ContainerRegistryProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<ContainerRegistryService>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported ContainerRegistryTask resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2019-06-01-preview.
        /// </summary>
        public static readonly string V2019_06_01_preview = "2019-06-01-preview";

        /// <summary>
        /// 2019-04-01.
        /// </summary>
        public static readonly string V2019_04_01 = "2019-04-01";

        /// <summary>
        /// 2018-09-01.
        /// </summary>
        public static readonly string V2018_09_01 = "2018-09-01";
    }

    /// <summary>
    /// Creates a reference to an existing ContainerRegistryTask.
    /// </summary>
    /// <param name="resourceName">Name of the ContainerRegistryTask.</param>
    /// <param name="resourceVersion">Version of the ContainerRegistryTask.</param>
    /// <returns>The existing ContainerRegistryTask resource.</returns>
    public static ContainerRegistryTask FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this ContainerRegistryTask resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 5, maxLength: 50, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen | ResourceNameCharacters.Underscore);
}
