// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppTwitterRegistration : IUtf8JsonSerializable, IJsonModel<ContainerAppTwitterRegistration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppTwitterRegistration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerAppTwitterRegistration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppTwitterRegistration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppTwitterRegistration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ConsumerKey))
            {
                writer.WritePropertyName("consumerKey"u8);
                writer.WriteStringValue(ConsumerKey);
            }
            if (Optional.IsDefined(ConsumerSecretSettingName))
            {
                writer.WritePropertyName("consumerSecretSettingName"u8);
                writer.WriteStringValue(ConsumerSecretSettingName);
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

        ContainerAppTwitterRegistration IJsonModel<ContainerAppTwitterRegistration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppTwitterRegistration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppTwitterRegistration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppTwitterRegistration(document.RootElement, options);
        }

        internal static ContainerAppTwitterRegistration DeserializeContainerAppTwitterRegistration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string consumerKey = default;
            string consumerSecretSettingName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("consumerKey"u8))
                {
                    consumerKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("consumerSecretSettingName"u8))
                {
                    consumerSecretSettingName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerAppTwitterRegistration(consumerKey, consumerSecretSettingName, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConsumerKey), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  consumerKey: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ConsumerKey))
                {
                    builder.Append("  consumerKey: ");
                    if (ConsumerKey.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ConsumerKey}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ConsumerKey}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConsumerSecretSettingName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  consumerSecretSettingName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ConsumerSecretSettingName))
                {
                    builder.Append("  consumerSecretSettingName: ");
                    if (ConsumerSecretSettingName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ConsumerSecretSettingName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ConsumerSecretSettingName}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerAppTwitterRegistration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppTwitterRegistration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppTwitterRegistration)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerAppTwitterRegistration IPersistableModel<ContainerAppTwitterRegistration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppTwitterRegistration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppTwitterRegistration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppTwitterRegistration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppTwitterRegistration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
