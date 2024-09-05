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
    public partial class ContainerAppTokenStore : IUtf8JsonSerializable, IJsonModel<ContainerAppTokenStore>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppTokenStore>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerAppTokenStore>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppTokenStore>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppTokenStore)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(TokenRefreshExtensionHours))
            {
                writer.WritePropertyName("tokenRefreshExtensionHours"u8);
                writer.WriteNumberValue(TokenRefreshExtensionHours.Value);
            }
            if (Optional.IsDefined(AzureBlobStorage))
            {
                writer.WritePropertyName("azureBlobStorage"u8);
                writer.WriteObjectValue(AzureBlobStorage, options);
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

        ContainerAppTokenStore IJsonModel<ContainerAppTokenStore>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppTokenStore>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppTokenStore)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppTokenStore(document.RootElement, options);
        }

        internal static ContainerAppTokenStore DeserializeContainerAppTokenStore(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? enabled = default;
            double? tokenRefreshExtensionHours = default;
            BlobStorageTokenStore azureBlobStorage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("tokenRefreshExtensionHours"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tokenRefreshExtensionHours = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("azureBlobStorage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureBlobStorage = BlobStorageTokenStore.DeserializeBlobStorageTokenStore(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerAppTokenStore(enabled, tokenRefreshExtensionHours, azureBlobStorage, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enabled: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsEnabled))
                {
                    builder.Append("  enabled: ");
                    var boolValue = IsEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TokenRefreshExtensionHours), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  tokenRefreshExtensionHours: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TokenRefreshExtensionHours))
                {
                    builder.Append("  tokenRefreshExtensionHours: ");
                    builder.AppendLine($"'{TokenRefreshExtensionHours.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("AzureBlobStorageSasUrlSettingName", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  azureBlobStorage: ");
                builder.AppendLine("{");
                builder.Append("    sasUrlSettingName: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(AzureBlobStorage))
                {
                    builder.Append("  azureBlobStorage: ");
                    BicepSerializationHelpers.AppendChildObject(builder, AzureBlobStorage, options, 2, false, "  azureBlobStorage: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerAppTokenStore>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppTokenStore>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppTokenStore)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerAppTokenStore IPersistableModel<ContainerAppTokenStore>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppTokenStore>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppTokenStore(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppTokenStore)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppTokenStore>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
