// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Parameters to regenerate the authentication key. </summary>
    public partial class IntegrationRuntimeRegenerateKeyContent
    {
        /// <summary> Initializes a new instance of IntegrationRuntimeRegenerateKeyContent. </summary>
        public IntegrationRuntimeRegenerateKeyContent()
        {
        }

        /// <summary> The name of the authentication key to regenerate. </summary>
        public IntegrationRuntimeAuthKeyName? KeyName { get; set; }
    }
}
