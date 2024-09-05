// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// NumberGreaterThan Advanced Filter.
/// </summary>
public partial class NumberGreaterThanAdvancedFilter : AdvancedFilter
{
    /// <summary>
    /// The filter value.
    /// </summary>
    public BicepValue<double> Value { get => _value; set => _value.Assign(value); }
    private readonly BicepValue<double> _value;

    /// <summary>
    /// Creates a new NumberGreaterThanAdvancedFilter.
    /// </summary>
    public NumberGreaterThanAdvancedFilter() : base()
    {
        BicepValue<string>.DefineProperty(this, "operatorType", ["operatorType"], defaultValue: "NumberGreaterThan");
        _value = BicepValue<double>.DefineProperty(this, "Value", ["value"]);
    }
}
