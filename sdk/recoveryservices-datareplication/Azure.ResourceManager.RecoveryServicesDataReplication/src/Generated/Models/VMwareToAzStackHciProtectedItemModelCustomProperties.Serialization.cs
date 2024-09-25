// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class VMwareToAzStackHciProtectedItemModelCustomProperties : IUtf8JsonSerializable, IJsonModel<VMwareToAzStackHciProtectedItemModelCustomProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VMwareToAzStackHciProtectedItemModelCustomProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VMwareToAzStackHciProtectedItemModelCustomProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareToAzStackHciProtectedItemModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareToAzStackHciProtectedItemModelCustomProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(ActiveLocation))
            {
                writer.WritePropertyName("activeLocation"u8);
                writer.WriteStringValue(ActiveLocation.Value.ToString());
            }
            writer.WritePropertyName("targetHciClusterId"u8);
            writer.WriteStringValue(TargetHciClusterId);
            writer.WritePropertyName("targetArcClusterCustomLocationId"u8);
            writer.WriteStringValue(TargetArcClusterCustomLocationId);
            if (options.Format != "W" && Optional.IsDefined(TargetAzStackHciClusterName))
            {
                writer.WritePropertyName("targetAzStackHciClusterName"u8);
                writer.WriteStringValue(TargetAzStackHciClusterName);
            }
            writer.WritePropertyName("storageContainerId"u8);
            writer.WriteStringValue(StorageContainerId);
            writer.WritePropertyName("targetResourceGroupId"u8);
            writer.WriteStringValue(TargetResourceGroupId);
            if (options.Format != "W" && Optional.IsDefined(TargetLocation))
            {
                writer.WritePropertyName("targetLocation"u8);
                writer.WriteStringValue(TargetLocation);
            }
            writer.WritePropertyName("customLocationRegion"u8);
            writer.WriteStringValue(CustomLocationRegion);
            writer.WritePropertyName("disksToInclude"u8);
            writer.WriteStartArray();
            foreach (var item in DisksToInclude)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("nicsToInclude"u8);
            writer.WriteStartArray();
            foreach (var item in NicsToInclude)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            if (options.Format != "W" && Optional.IsCollectionDefined(ProtectedDisks))
            {
                writer.WritePropertyName("protectedDisks"u8);
                writer.WriteStartArray();
                foreach (var item in ProtectedDisks)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ProtectedNics))
            {
                writer.WritePropertyName("protectedNics"u8);
                writer.WriteStartArray();
                foreach (var item in ProtectedNics)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(TargetVmBiosId))
            {
                writer.WritePropertyName("targetVmBiosId"u8);
                writer.WriteStringValue(TargetVmBiosId);
            }
            if (Optional.IsDefined(TargetVmName))
            {
                writer.WritePropertyName("targetVmName"u8);
                writer.WriteStringValue(TargetVmName);
            }
            writer.WritePropertyName("hyperVGeneration"u8);
            writer.WriteStringValue(HyperVGeneration);
            if (Optional.IsDefined(TargetNetworkId))
            {
                writer.WritePropertyName("targetNetworkId"u8);
                writer.WriteStringValue(TargetNetworkId);
            }
            if (Optional.IsDefined(TestNetworkId))
            {
                writer.WritePropertyName("testNetworkId"u8);
                writer.WriteStringValue(TestNetworkId);
            }
            if (Optional.IsDefined(TargetCpuCores))
            {
                writer.WritePropertyName("targetCpuCores"u8);
                writer.WriteNumberValue(TargetCpuCores.Value);
            }
            if (Optional.IsDefined(IsDynamicRam))
            {
                writer.WritePropertyName("isDynamicRam"u8);
                writer.WriteBooleanValue(IsDynamicRam.Value);
            }
            if (Optional.IsDefined(DynamicMemoryConfig))
            {
                writer.WritePropertyName("dynamicMemoryConfig"u8);
                writer.WriteObjectValue(DynamicMemoryConfig, options);
            }
            if (Optional.IsDefined(TargetMemoryInMegaBytes))
            {
                writer.WritePropertyName("targetMemoryInMegaBytes"u8);
                writer.WriteNumberValue(TargetMemoryInMegaBytes.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType);
            }
            if (options.Format != "W" && Optional.IsDefined(OSName))
            {
                writer.WritePropertyName("osName"u8);
                writer.WriteStringValue(OSName);
            }
            if (options.Format != "W" && Optional.IsDefined(FirmwareType))
            {
                writer.WritePropertyName("firmwareType"u8);
                writer.WriteStringValue(FirmwareType);
            }
            writer.WritePropertyName("fabricDiscoveryMachineId"u8);
            writer.WriteStringValue(FabricDiscoveryMachineId);
            if (options.Format != "W" && Optional.IsDefined(SourceVmName))
            {
                writer.WritePropertyName("sourceVmName"u8);
                writer.WriteStringValue(SourceVmName);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceCpuCores))
            {
                writer.WritePropertyName("sourceCpuCores"u8);
                writer.WriteNumberValue(SourceCpuCores.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceMemoryInMegaBytes))
            {
                writer.WritePropertyName("sourceMemoryInMegaBytes"u8);
                writer.WriteNumberValue(SourceMemoryInMegaBytes.Value);
            }
            writer.WritePropertyName("runAsAccountId"u8);
            writer.WriteStringValue(RunAsAccountId);
            writer.WritePropertyName("sourceDraName"u8);
            writer.WriteStringValue(SourceDraName);
            writer.WritePropertyName("targetDraName"u8);
            writer.WriteStringValue(TargetDraName);
            if (options.Format != "W" && Optional.IsDefined(SourceApplianceName))
            {
                writer.WritePropertyName("sourceApplianceName"u8);
                writer.WriteStringValue(SourceApplianceName);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetApplianceName))
            {
                writer.WritePropertyName("targetApplianceName"u8);
                writer.WriteStringValue(TargetApplianceName);
            }
            if (options.Format != "W" && Optional.IsDefined(FailoverRecoveryPointId))
            {
                writer.WritePropertyName("failoverRecoveryPointId"u8);
                writer.WriteStringValue(FailoverRecoveryPointId);
            }
            if (options.Format != "W" && Optional.IsDefined(LastRecoveryPointReceived))
            {
                writer.WritePropertyName("lastRecoveryPointReceived"u8);
                writer.WriteStringValue(LastRecoveryPointReceived.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastRecoveryPointId))
            {
                writer.WritePropertyName("lastRecoveryPointId"u8);
                writer.WriteStringValue(LastRecoveryPointId);
            }
            if (options.Format != "W" && Optional.IsDefined(InitialReplicationProgressPercentage))
            {
                writer.WritePropertyName("initialReplicationProgressPercentage"u8);
                writer.WriteNumberValue(InitialReplicationProgressPercentage.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MigrationProgressPercentage))
            {
                writer.WritePropertyName("migrationProgressPercentage"u8);
                writer.WriteNumberValue(MigrationProgressPercentage.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ResumeProgressPercentage))
            {
                writer.WritePropertyName("resumeProgressPercentage"u8);
                writer.WriteNumberValue(ResumeProgressPercentage.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ResyncProgressPercentage))
            {
                writer.WritePropertyName("resyncProgressPercentage"u8);
                writer.WriteNumberValue(ResyncProgressPercentage.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ResyncRetryCount))
            {
                writer.WritePropertyName("resyncRetryCount"u8);
                writer.WriteNumberValue(ResyncRetryCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ResyncRequired))
            {
                writer.WritePropertyName("resyncRequired"u8);
                writer.WriteBooleanValue(ResyncRequired.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ResyncState))
            {
                writer.WritePropertyName("resyncState"u8);
                writer.WriteStringValue(ResyncState.Value.ToString());
            }
            if (Optional.IsDefined(PerformAutoResync))
            {
                writer.WritePropertyName("performAutoResync"u8);
                writer.WriteBooleanValue(PerformAutoResync.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ResumeRetryCount))
            {
                writer.WritePropertyName("resumeRetryCount"u8);
                writer.WriteNumberValue(ResumeRetryCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(LastReplicationUpdateOn))
            {
                writer.WritePropertyName("lastReplicationUpdateTime"u8);
                writer.WriteStringValue(LastReplicationUpdateOn.Value, "O");
            }
        }

        VMwareToAzStackHciProtectedItemModelCustomProperties IJsonModel<VMwareToAzStackHciProtectedItemModelCustomProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareToAzStackHciProtectedItemModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareToAzStackHciProtectedItemModelCustomProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareToAzStackHciProtectedItemModelCustomProperties(document.RootElement, options);
        }

        internal static VMwareToAzStackHciProtectedItemModelCustomProperties DeserializeVMwareToAzStackHciProtectedItemModelCustomProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ProtectedItemActiveLocation? activeLocation = default;
            ResourceIdentifier targetHciClusterId = default;
            ResourceIdentifier targetArcClusterCustomLocationId = default;
            string targetAzStackHciClusterName = default;
            ResourceIdentifier storageContainerId = default;
            ResourceIdentifier targetResourceGroupId = default;
            string targetLocation = default;
            string customLocationRegion = default;
            IList<VMwareToAzStackHciDiskInput> disksToInclude = default;
            IList<VMwareToAzStackHciNicInput> nicsToInclude = default;
            IReadOnlyList<VMwareToAzStackHciProtectedDiskProperties> protectedDisks = default;
            IReadOnlyList<VMwareToAzStackHciProtectedNicProperties> protectedNics = default;
            string targetVmBiosId = default;
            string targetVmName = default;
            string hyperVGeneration = default;
            string targetNetworkId = default;
            string testNetworkId = default;
            int? targetCpuCores = default;
            bool? isDynamicRam = default;
            ProtectedItemDynamicMemoryConfig dynamicMemoryConfig = default;
            int? targetMemoryInMegaBytes = default;
            string osType = default;
            string osName = default;
            string firmwareType = default;
            ResourceIdentifier fabricDiscoveryMachineId = default;
            string sourceVmName = default;
            int? sourceCpuCores = default;
            double? sourceMemoryInMegaBytes = default;
            string runAsAccountId = default;
            string sourceDraName = default;
            string targetDraName = default;
            string sourceApplianceName = default;
            string targetApplianceName = default;
            string failoverRecoveryPointId = default;
            DateTimeOffset? lastRecoveryPointReceived = default;
            string lastRecoveryPointId = default;
            int? initialReplicationProgressPercentage = default;
            int? migrationProgressPercentage = default;
            int? resumeProgressPercentage = default;
            int? resyncProgressPercentage = default;
            long? resyncRetryCount = default;
            bool? resyncRequired = default;
            VMwareToAzureMigrateResyncState? resyncState = default;
            bool? performAutoResync = default;
            long? resumeRetryCount = default;
            DateTimeOffset? lastReplicationUpdateTime = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activeLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    activeLocation = new ProtectedItemActiveLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetHciClusterId"u8))
                {
                    targetHciClusterId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetArcClusterCustomLocationId"u8))
                {
                    targetArcClusterCustomLocationId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetAzStackHciClusterName"u8))
                {
                    targetAzStackHciClusterName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageContainerId"u8))
                {
                    storageContainerId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetResourceGroupId"u8))
                {
                    targetResourceGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetLocation"u8))
                {
                    targetLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customLocationRegion"u8))
                {
                    customLocationRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("disksToInclude"u8))
                {
                    List<VMwareToAzStackHciDiskInput> array = new List<VMwareToAzStackHciDiskInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VMwareToAzStackHciDiskInput.DeserializeVMwareToAzStackHciDiskInput(item, options));
                    }
                    disksToInclude = array;
                    continue;
                }
                if (property.NameEquals("nicsToInclude"u8))
                {
                    List<VMwareToAzStackHciNicInput> array = new List<VMwareToAzStackHciNicInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VMwareToAzStackHciNicInput.DeserializeVMwareToAzStackHciNicInput(item, options));
                    }
                    nicsToInclude = array;
                    continue;
                }
                if (property.NameEquals("protectedDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VMwareToAzStackHciProtectedDiskProperties> array = new List<VMwareToAzStackHciProtectedDiskProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VMwareToAzStackHciProtectedDiskProperties.DeserializeVMwareToAzStackHciProtectedDiskProperties(item, options));
                    }
                    protectedDisks = array;
                    continue;
                }
                if (property.NameEquals("protectedNics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VMwareToAzStackHciProtectedNicProperties> array = new List<VMwareToAzStackHciProtectedNicProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VMwareToAzStackHciProtectedNicProperties.DeserializeVMwareToAzStackHciProtectedNicProperties(item, options));
                    }
                    protectedNics = array;
                    continue;
                }
                if (property.NameEquals("targetVmBiosId"u8))
                {
                    targetVmBiosId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetVmName"u8))
                {
                    targetVmName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hyperVGeneration"u8))
                {
                    hyperVGeneration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetNetworkId"u8))
                {
                    targetNetworkId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testNetworkId"u8))
                {
                    testNetworkId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetCpuCores"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetCpuCores = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isDynamicRam"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDynamicRam = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dynamicMemoryConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dynamicMemoryConfig = ProtectedItemDynamicMemoryConfig.DeserializeProtectedItemDynamicMemoryConfig(property.Value, options);
                    continue;
                }
                if (property.NameEquals("targetMemoryInMegaBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetMemoryInMegaBytes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osName"u8))
                {
                    osName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("firmwareType"u8))
                {
                    firmwareType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricDiscoveryMachineId"u8))
                {
                    fabricDiscoveryMachineId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceVmName"u8))
                {
                    sourceVmName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceCpuCores"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceCpuCores = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sourceMemoryInMegaBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceMemoryInMegaBytes = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("runAsAccountId"u8))
                {
                    runAsAccountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceDraName"u8))
                {
                    sourceDraName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetDraName"u8))
                {
                    targetDraName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceApplianceName"u8))
                {
                    sourceApplianceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetApplianceName"u8))
                {
                    targetApplianceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("failoverRecoveryPointId"u8))
                {
                    failoverRecoveryPointId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastRecoveryPointReceived"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRecoveryPointReceived = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastRecoveryPointId"u8))
                {
                    lastRecoveryPointId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initialReplicationProgressPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialReplicationProgressPercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("migrationProgressPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationProgressPercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("resumeProgressPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resumeProgressPercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("resyncProgressPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncProgressPercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("resyncRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncRetryCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("resyncRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("resyncState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncState = new VMwareToAzureMigrateResyncState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("performAutoResync"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    performAutoResync = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("resumeRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resumeRetryCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastReplicationUpdateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastReplicationUpdateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VMwareToAzStackHciProtectedItemModelCustomProperties(
                instanceType,
                serializedAdditionalRawData,
                activeLocation,
                targetHciClusterId,
                targetArcClusterCustomLocationId,
                targetAzStackHciClusterName,
                storageContainerId,
                targetResourceGroupId,
                targetLocation,
                customLocationRegion,
                disksToInclude,
                nicsToInclude,
                protectedDisks ?? new ChangeTrackingList<VMwareToAzStackHciProtectedDiskProperties>(),
                protectedNics ?? new ChangeTrackingList<VMwareToAzStackHciProtectedNicProperties>(),
                targetVmBiosId,
                targetVmName,
                hyperVGeneration,
                targetNetworkId,
                testNetworkId,
                targetCpuCores,
                isDynamicRam,
                dynamicMemoryConfig,
                targetMemoryInMegaBytes,
                osType,
                osName,
                firmwareType,
                fabricDiscoveryMachineId,
                sourceVmName,
                sourceCpuCores,
                sourceMemoryInMegaBytes,
                runAsAccountId,
                sourceDraName,
                targetDraName,
                sourceApplianceName,
                targetApplianceName,
                failoverRecoveryPointId,
                lastRecoveryPointReceived,
                lastRecoveryPointId,
                initialReplicationProgressPercentage,
                migrationProgressPercentage,
                resumeProgressPercentage,
                resyncProgressPercentage,
                resyncRetryCount,
                resyncRequired,
                resyncState,
                performAutoResync,
                resumeRetryCount,
                lastReplicationUpdateTime);
        }

        BinaryData IPersistableModel<VMwareToAzStackHciProtectedItemModelCustomProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareToAzStackHciProtectedItemModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VMwareToAzStackHciProtectedItemModelCustomProperties)} does not support writing '{options.Format}' format.");
            }
        }

        VMwareToAzStackHciProtectedItemModelCustomProperties IPersistableModel<VMwareToAzStackHciProtectedItemModelCustomProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareToAzStackHciProtectedItemModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVMwareToAzStackHciProtectedItemModelCustomProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VMwareToAzStackHciProtectedItemModelCustomProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VMwareToAzStackHciProtectedItemModelCustomProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
