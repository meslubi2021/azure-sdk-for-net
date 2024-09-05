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
    public partial class ContainerAppOpenIdConnectRegistration : IUtf8JsonSerializable, IJsonModel<ContainerAppOpenIdConnectRegistration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppOpenIdConnectRegistration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerAppOpenIdConnectRegistration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppOpenIdConnectRegistration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppOpenIdConnectRegistration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteStringValue(ClientId);
            }
            if (Optional.IsDefined(ClientCredential))
            {
                writer.WritePropertyName("clientCredential"u8);
                writer.WriteObjectValue(ClientCredential, options);
            }
            if (Optional.IsDefined(OpenIdConnectConfiguration))
            {
                writer.WritePropertyName("openIdConnectConfiguration"u8);
                writer.WriteObjectValue(OpenIdConnectConfiguration, options);
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

        ContainerAppOpenIdConnectRegistration IJsonModel<ContainerAppOpenIdConnectRegistration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppOpenIdConnectRegistration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppOpenIdConnectRegistration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppOpenIdConnectRegistration(document.RootElement, options);
        }

        internal static ContainerAppOpenIdConnectRegistration DeserializeContainerAppOpenIdConnectRegistration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string clientId = default;
            ContainerAppOpenIdConnectClientCredential clientCredential = default;
            ContainerAppOpenIdConnectConfig openIdConnectConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientId"u8))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientCredential"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientCredential = ContainerAppOpenIdConnectClientCredential.DeserializeContainerAppOpenIdConnectClientCredential(property.Value, options);
                    continue;
                }
                if (property.NameEquals("openIdConnectConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    openIdConnectConfiguration = ContainerAppOpenIdConnectConfig.DeserializeContainerAppOpenIdConnectConfig(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerAppOpenIdConnectRegistration(clientId, clientCredential, openIdConnectConfiguration, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ClientId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  clientId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ClientId))
                {
                    builder.Append("  clientId: ");
                    if (ClientId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ClientId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ClientId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ClientCredential), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  clientCredential: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ClientCredential))
                {
                    builder.Append("  clientCredential: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ClientCredential, options, 2, false, "  clientCredential: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OpenIdConnectConfiguration), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  openIdConnectConfiguration: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(OpenIdConnectConfiguration))
                {
                    builder.Append("  openIdConnectConfiguration: ");
                    BicepSerializationHelpers.AppendChildObject(builder, OpenIdConnectConfiguration, options, 2, false, "  openIdConnectConfiguration: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerAppOpenIdConnectRegistration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppOpenIdConnectRegistration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppOpenIdConnectRegistration)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerAppOpenIdConnectRegistration IPersistableModel<ContainerAppOpenIdConnectRegistration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppOpenIdConnectRegistration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppOpenIdConnectRegistration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppOpenIdConnectRegistration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppOpenIdConnectRegistration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
