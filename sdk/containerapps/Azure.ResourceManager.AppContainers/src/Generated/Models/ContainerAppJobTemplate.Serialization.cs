// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppJobTemplate : IUtf8JsonSerializable, IJsonModel<ContainerAppJobTemplate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppJobTemplate>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerAppJobTemplate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppJobTemplate)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(InitContainers))
            {
                writer.WritePropertyName("initContainers"u8);
                writer.WriteStartArray();
                foreach (var item in InitContainers)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Containers))
            {
                writer.WritePropertyName("containers"u8);
                writer.WriteStartArray();
                foreach (var item in Containers)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Volumes))
            {
                writer.WritePropertyName("volumes"u8);
                writer.WriteStartArray();
                foreach (var item in Volumes)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ContainerAppJobTemplate IJsonModel<ContainerAppJobTemplate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppJobTemplate)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppJobTemplate(document.RootElement, options);
        }

        internal static ContainerAppJobTemplate DeserializeContainerAppJobTemplate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ContainerAppInitContainer> initContainers = default;
            IList<ContainerAppContainer> containers = default;
            IList<ContainerAppVolume> volumes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("initContainers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppInitContainer> array = new List<ContainerAppInitContainer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppInitContainer.DeserializeContainerAppInitContainer(item, options));
                    }
                    initContainers = array;
                    continue;
                }
                if (property.NameEquals("containers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppContainer> array = new List<ContainerAppContainer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppContainer.DeserializeContainerAppContainer(item, options));
                    }
                    containers = array;
                    continue;
                }
                if (property.NameEquals("volumes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppVolume> array = new List<ContainerAppVolume>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppVolume.DeserializeContainerAppVolume(item, options));
                    }
                    volumes = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerAppJobTemplate(initContainers ?? new ChangeTrackingList<ContainerAppInitContainer>(), containers ?? new ChangeTrackingList<ContainerAppContainer>(), volumes ?? new ChangeTrackingList<ContainerAppVolume>(), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(InitContainers), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  initContainers: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(InitContainers))
                {
                    if (InitContainers.Any())
                    {
                        builder.Append("  initContainers: ");
                        builder.AppendLine("[");
                        foreach (var item in InitContainers)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  initContainers: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Containers), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  containers: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Containers))
                {
                    if (Containers.Any())
                    {
                        builder.Append("  containers: ");
                        builder.AppendLine("[");
                        foreach (var item in Containers)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  containers: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Volumes), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  volumes: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Volumes))
                {
                    if (Volumes.Any())
                    {
                        builder.Append("  volumes: ");
                        builder.AppendLine("[");
                        foreach (var item in Volumes)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  volumes: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerAppJobTemplate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppJobTemplate)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerAppJobTemplate IPersistableModel<ContainerAppJobTemplate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppJobTemplate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppJobTemplate)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppJobTemplate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
