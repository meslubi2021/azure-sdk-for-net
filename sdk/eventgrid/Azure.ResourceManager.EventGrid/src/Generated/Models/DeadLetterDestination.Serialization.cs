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

namespace Azure.ResourceManager.EventGrid.Models
{
    [PersistableModelProxy(typeof(UnknownDeadLetterDestination))]
    public partial class DeadLetterDestination : IUtf8JsonSerializable, IJsonModel<DeadLetterDestination>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeadLetterDestination>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DeadLetterDestination>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeadLetterDestination>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeadLetterDestination)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("endpointType"u8);
            writer.WriteStringValue(EndpointType.ToString());
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

        DeadLetterDestination IJsonModel<DeadLetterDestination>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeadLetterDestination>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeadLetterDestination)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeadLetterDestination(document.RootElement, options);
        }

        internal static DeadLetterDestination DeserializeDeadLetterDestination(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("endpointType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "StorageBlob": return StorageBlobDeadLetterDestination.DeserializeStorageBlobDeadLetterDestination(element, options);
                }
            }
            return UnknownDeadLetterDestination.DeserializeUnknownDeadLetterDestination(element, options);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EndpointType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  endpointType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  endpointType: ");
                builder.AppendLine($"'{EndpointType.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<DeadLetterDestination>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeadLetterDestination>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DeadLetterDestination)} does not support writing '{options.Format}' format.");
            }
        }

        DeadLetterDestination IPersistableModel<DeadLetterDestination>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeadLetterDestination>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeadLetterDestination(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeadLetterDestination)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeadLetterDestination>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
