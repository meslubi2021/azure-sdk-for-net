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
    public partial class ContainerAppHttpScaleRule : IUtf8JsonSerializable, IJsonModel<ContainerAppHttpScaleRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppHttpScaleRule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerAppHttpScaleRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppHttpScaleRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppHttpScaleRule)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartObject();
                foreach (var item in Metadata)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Auth))
            {
                writer.WritePropertyName("auth"u8);
                writer.WriteStartArray();
                foreach (var item in Auth)
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

        ContainerAppHttpScaleRule IJsonModel<ContainerAppHttpScaleRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppHttpScaleRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppHttpScaleRule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppHttpScaleRule(document.RootElement, options);
        }

        internal static ContainerAppHttpScaleRule DeserializeContainerAppHttpScaleRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> metadata = default;
            IList<ContainerAppScaleRuleAuth> auth = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    metadata = dictionary;
                    continue;
                }
                if (property.NameEquals("auth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppScaleRuleAuth> array = new List<ContainerAppScaleRuleAuth>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppScaleRuleAuth.DeserializeContainerAppScaleRuleAuth(item, options));
                    }
                    auth = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerAppHttpScaleRule(metadata ?? new ChangeTrackingDictionary<string, string>(), auth ?? new ChangeTrackingList<ContainerAppScaleRuleAuth>(), serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Metadata), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  metadata: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Metadata))
                {
                    if (Metadata.Any())
                    {
                        builder.Append("  metadata: ");
                        builder.AppendLine("{");
                        foreach (var item in Metadata)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Value.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("'''");
                                builder.AppendLine($"{item.Value}'''");
                            }
                            else
                            {
                                builder.AppendLine($"'{item.Value}'");
                            }
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Auth), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  auth: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Auth))
                {
                    if (Auth.Any())
                    {
                        builder.Append("  auth: ");
                        builder.AppendLine("[");
                        foreach (var item in Auth)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  auth: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerAppHttpScaleRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppHttpScaleRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppHttpScaleRule)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerAppHttpScaleRule IPersistableModel<ContainerAppHttpScaleRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppHttpScaleRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppHttpScaleRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppHttpScaleRule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppHttpScaleRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
