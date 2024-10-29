// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Text
{
    public partial class CustomSingleLabelClassificationOperationResult : IUtf8JsonSerializable, IJsonModel<CustomSingleLabelClassificationOperationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CustomSingleLabelClassificationOperationResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CustomSingleLabelClassificationOperationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomSingleLabelClassificationOperationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomSingleLabelClassificationOperationResult)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("results"u8);
            writer.WriteObjectValue(Results, options);
        }

        CustomSingleLabelClassificationOperationResult IJsonModel<CustomSingleLabelClassificationOperationResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomSingleLabelClassificationOperationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomSingleLabelClassificationOperationResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomSingleLabelClassificationOperationResult(document.RootElement, options);
        }

        internal static CustomSingleLabelClassificationOperationResult DeserializeCustomSingleLabelClassificationOperationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CustomLabelClassificationActionResult results = default;
            DateTimeOffset lastUpdateDateTime = default;
            TextActionState status = default;
            string taskName = default;
            AnalyzeTextOperationResultsKind kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"u8))
                {
                    results = CustomLabelClassificationActionResult.DeserializeCustomLabelClassificationActionResult(property.Value, options);
                    continue;
                }
                if (property.NameEquals("lastUpdateDateTime"u8))
                {
                    lastUpdateDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new TextActionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("taskName"u8))
                {
                    taskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new AnalyzeTextOperationResultsKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CustomSingleLabelClassificationOperationResult(
                lastUpdateDateTime,
                status,
                taskName,
                kind,
                serializedAdditionalRawData,
                results);
        }

        BinaryData IPersistableModel<CustomSingleLabelClassificationOperationResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomSingleLabelClassificationOperationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CustomSingleLabelClassificationOperationResult)} does not support writing '{options.Format}' format.");
            }
        }

        CustomSingleLabelClassificationOperationResult IPersistableModel<CustomSingleLabelClassificationOperationResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomSingleLabelClassificationOperationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCustomSingleLabelClassificationOperationResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CustomSingleLabelClassificationOperationResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CustomSingleLabelClassificationOperationResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new CustomSingleLabelClassificationOperationResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCustomSingleLabelClassificationOperationResult(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
