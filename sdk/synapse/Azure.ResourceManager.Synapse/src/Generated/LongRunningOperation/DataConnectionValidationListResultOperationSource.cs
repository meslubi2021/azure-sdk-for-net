// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    internal class DataConnectionValidationListResultOperationSource : IOperationSource<DataConnectionValidationListResult>
    {
        DataConnectionValidationListResult IOperationSource<DataConnectionValidationListResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return DataConnectionValidationListResult.DeserializeDataConnectionValidationListResult(document.RootElement);
        }

        async ValueTask<DataConnectionValidationListResult> IOperationSource<DataConnectionValidationListResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return DataConnectionValidationListResult.DeserializeDataConnectionValidationListResult(document.RootElement);
        }
    }
}
