// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// The partner authorization details.
/// </summary>
public partial class PartnerAuthorization : ProvisionableConstruct
{
    /// <summary>
    /// Time used to validate the authorization expiration time for each
    /// authorized partner. If DefaultMaximumExpirationTimeInDays is
    /// not specified, the default is 7 days. Otherwise, allowed
    /// values are between 1 and 365 days.
    /// </summary>
    public BicepValue<int> DefaultMaximumExpirationTimeInDays 
    {
        get { Initialize(); return _defaultMaximumExpirationTimeInDays!; }
        set { Initialize(); _defaultMaximumExpirationTimeInDays!.Assign(value); }
    }
    private BicepValue<int>? _defaultMaximumExpirationTimeInDays;

    /// <summary>
    /// The list of authorized partners.
    /// </summary>
    public BicepList<EventGridPartnerContent> AuthorizedPartnersList 
    {
        get { Initialize(); return _authorizedPartnersList!; }
        set { Initialize(); _authorizedPartnersList!.Assign(value); }
    }
    private BicepList<EventGridPartnerContent>? _authorizedPartnersList;

    /// <summary>
    /// Creates a new PartnerAuthorization.
    /// </summary>
    public PartnerAuthorization()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of PartnerAuthorization.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _defaultMaximumExpirationTimeInDays = DefineProperty<int>("DefaultMaximumExpirationTimeInDays", ["defaultMaximumExpirationTimeInDays"]);
        _authorizedPartnersList = DefineListProperty<EventGridPartnerContent>("AuthorizedPartnersList", ["authorizedPartnersList"]);
    }
}
