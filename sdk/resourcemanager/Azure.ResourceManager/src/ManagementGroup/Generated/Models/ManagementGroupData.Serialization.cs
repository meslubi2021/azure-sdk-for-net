// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Management.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Management
{
    public partial class ManagementGroupData
    {
        internal static ManagementGroupData DeserializeManagementGroupData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<Guid> tenantId = default;
            Optional<string> displayName = default;
            Optional<ManagementGroupInfo> details = default;
            Optional<IReadOnlyList<ManagementGroupChildInfo>> children = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("tenantId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("details"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            details = ManagementGroupInfo.DeserializeManagementGroupInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("children"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                children = null;
                                continue;
                            }
                            List<ManagementGroupChildInfo> array = new List<ManagementGroupChildInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ManagementGroupChildInfo.DeserializeManagementGroupChildInfo(item));
                            }
                            children = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ManagementGroupData(id, name, type, systemData, Optional.ToNullable(tenantId), displayName.Value, details.Value, Optional.ToList(children));
        }
    }
}
