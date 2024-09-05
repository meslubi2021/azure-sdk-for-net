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
    public partial class JobConfigurationManualTriggerConfig : IUtf8JsonSerializable, IJsonModel<JobConfigurationManualTriggerConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<JobConfigurationManualTriggerConfig>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<JobConfigurationManualTriggerConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobConfigurationManualTriggerConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JobConfigurationManualTriggerConfig)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ReplicaCompletionCount))
            {
                writer.WritePropertyName("replicaCompletionCount"u8);
                writer.WriteNumberValue(ReplicaCompletionCount.Value);
            }
            if (Optional.IsDefined(Parallelism))
            {
                writer.WritePropertyName("parallelism"u8);
                writer.WriteNumberValue(Parallelism.Value);
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

        JobConfigurationManualTriggerConfig IJsonModel<JobConfigurationManualTriggerConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobConfigurationManualTriggerConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JobConfigurationManualTriggerConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeJobConfigurationManualTriggerConfig(document.RootElement, options);
        }

        internal static JobConfigurationManualTriggerConfig DeserializeJobConfigurationManualTriggerConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? replicaCompletionCount = default;
            int? parallelism = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("replicaCompletionCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicaCompletionCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("parallelism"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parallelism = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new JobConfigurationManualTriggerConfig(replicaCompletionCount, parallelism, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ReplicaCompletionCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  replicaCompletionCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ReplicaCompletionCount))
                {
                    builder.Append("  replicaCompletionCount: ");
                    builder.AppendLine($"{ReplicaCompletionCount.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Parallelism), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  parallelism: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Parallelism))
                {
                    builder.Append("  parallelism: ");
                    builder.AppendLine($"{Parallelism.Value}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<JobConfigurationManualTriggerConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobConfigurationManualTriggerConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(JobConfigurationManualTriggerConfig)} does not support writing '{options.Format}' format.");
            }
        }

        JobConfigurationManualTriggerConfig IPersistableModel<JobConfigurationManualTriggerConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobConfigurationManualTriggerConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeJobConfigurationManualTriggerConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(JobConfigurationManualTriggerConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<JobConfigurationManualTriggerConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
