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
    public partial class ContainerAppDiagnosticDataProviderMetadata : IUtf8JsonSerializable, IJsonModel<ContainerAppDiagnosticDataProviderMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppDiagnosticDataProviderMetadata>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerAppDiagnosticDataProviderMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppDiagnosticDataProviderMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppDiagnosticDataProviderMetadata)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ProviderName))
            {
                writer.WritePropertyName("providerName"u8);
                writer.WriteStringValue(ProviderName);
            }
            if (Optional.IsCollectionDefined(PropertyBag))
            {
                writer.WritePropertyName("propertyBag"u8);
                writer.WriteStartArray();
                foreach (var item in PropertyBag)
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

        ContainerAppDiagnosticDataProviderMetadata IJsonModel<ContainerAppDiagnosticDataProviderMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppDiagnosticDataProviderMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppDiagnosticDataProviderMetadata)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppDiagnosticDataProviderMetadata(document.RootElement, options);
        }

        internal static ContainerAppDiagnosticDataProviderMetadata DeserializeContainerAppDiagnosticDataProviderMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string providerName = default;
            IList<ContainerAppDiagnosticDataProviderMetadataPropertyBagItem> propertyBag = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("providerName"u8))
                {
                    providerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("propertyBag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppDiagnosticDataProviderMetadataPropertyBagItem> array = new List<ContainerAppDiagnosticDataProviderMetadataPropertyBagItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppDiagnosticDataProviderMetadataPropertyBagItem.DeserializeContainerAppDiagnosticDataProviderMetadataPropertyBagItem(item, options));
                    }
                    propertyBag = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerAppDiagnosticDataProviderMetadata(providerName, propertyBag ?? new ChangeTrackingList<ContainerAppDiagnosticDataProviderMetadataPropertyBagItem>(), serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProviderName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  providerName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProviderName))
                {
                    builder.Append("  providerName: ");
                    if (ProviderName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ProviderName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ProviderName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PropertyBag), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  propertyBag: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(PropertyBag))
                {
                    if (PropertyBag.Any())
                    {
                        builder.Append("  propertyBag: ");
                        builder.AppendLine("[");
                        foreach (var item in PropertyBag)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  propertyBag: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerAppDiagnosticDataProviderMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppDiagnosticDataProviderMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppDiagnosticDataProviderMetadata)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerAppDiagnosticDataProviderMetadata IPersistableModel<ContainerAppDiagnosticDataProviderMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppDiagnosticDataProviderMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppDiagnosticDataProviderMetadata(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppDiagnosticDataProviderMetadata)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppDiagnosticDataProviderMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
