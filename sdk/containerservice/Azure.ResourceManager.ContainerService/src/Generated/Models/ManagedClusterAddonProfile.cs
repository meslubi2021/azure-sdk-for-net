// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> A Kubernetes add-on profile for a managed cluster. </summary>
    public partial class ManagedClusterAddonProfile
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedClusterAddonProfile"/>. </summary>
        /// <param name="isEnabled"> Whether the add-on is enabled or not. </param>
        public ManagedClusterAddonProfile(bool isEnabled)
        {
            IsEnabled = isEnabled;
            Config = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterAddonProfile"/>. </summary>
        /// <param name="isEnabled"> Whether the add-on is enabled or not. </param>
        /// <param name="config"> Key-value pairs for configuring an add-on. </param>
        /// <param name="identity"> Information of user assigned identity used by this add-on. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedClusterAddonProfile(bool isEnabled, IDictionary<string, string> config, ManagedClusterAddonProfileIdentity identity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsEnabled = isEnabled;
            Config = config;
            Identity = identity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterAddonProfile"/> for deserialization. </summary>
        internal ManagedClusterAddonProfile()
        {
        }

        /// <summary> Whether the add-on is enabled or not. </summary>
        [WirePath("enabled")]
        public bool IsEnabled { get; set; }
        /// <summary> Key-value pairs for configuring an add-on. </summary>
        [WirePath("config")]
        public IDictionary<string, string> Config { get; }
        /// <summary> Information of user assigned identity used by this add-on. </summary>
        [WirePath("identity")]
        public ManagedClusterAddonProfileIdentity Identity { get; }
    }
}
