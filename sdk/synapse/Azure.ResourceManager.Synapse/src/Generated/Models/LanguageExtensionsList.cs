// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The list of language extension objects. </summary>
    public partial class LanguageExtensionsList
    {
        /// <summary> Initializes a new instance of LanguageExtensionsList. </summary>
        public LanguageExtensionsList()
        {
            Value = new ChangeTrackingList<LanguageExtension>();
        }

        /// <summary> Initializes a new instance of LanguageExtensionsList. </summary>
        /// <param name="value"> The list of language extensions. </param>
        internal LanguageExtensionsList(IList<LanguageExtension> value)
        {
            Value = value;
        }

        /// <summary> The list of language extensions. </summary>
        public IList<LanguageExtension> Value { get; }
    }
}
