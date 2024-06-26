// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Extensions;

    /// <summary>Properties of reservation purchase request</summary>
    public partial class PurchaseRequestProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AppliedScopeProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IAppliedScopeProperties _appliedScopeProperty;

        /// <summary>
        /// Properties specific to applied scope type. Not required if not applicable. Required and need to provide tenantId and managementGroupId
        /// if AppliedScopeType is ManagementGroup
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IAppliedScopeProperties AppliedScopeProperty { get => (this._appliedScopeProperty = this._appliedScopeProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.AppliedScopeProperties()); set => this._appliedScopeProperty = value; }

        /// <summary>Display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public string AppliedScopePropertyDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IAppliedScopePropertiesInternal)AppliedScopeProperty).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IAppliedScopePropertiesInternal)AppliedScopeProperty).DisplayName = value ?? null; }

        /// <summary>
        /// Fully-qualified identifier of the management group where the benefit must be applied.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public string AppliedScopePropertyManagementGroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IAppliedScopePropertiesInternal)AppliedScopeProperty).ManagementGroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IAppliedScopePropertiesInternal)AppliedScopeProperty).ManagementGroupId = value ?? null; }

        /// <summary>Fully-qualified identifier of the resource group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public string AppliedScopePropertyResourceGroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IAppliedScopePropertiesInternal)AppliedScopeProperty).ResourceGroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IAppliedScopePropertiesInternal)AppliedScopeProperty).ResourceGroupId = value ?? null; }

        /// <summary>Fully-qualified identifier of the subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public string AppliedScopePropertySubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IAppliedScopePropertiesInternal)AppliedScopeProperty).SubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IAppliedScopePropertiesInternal)AppliedScopeProperty).SubscriptionId = value ?? null; }

        /// <summary>Tenant ID where the savings plan should apply benefit.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public string AppliedScopePropertyTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IAppliedScopePropertiesInternal)AppliedScopeProperty).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IAppliedScopePropertiesInternal)AppliedScopeProperty).TenantId = value ?? null; }

        /// <summary>Backing field for <see cref="AppliedScopeType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.AppliedScopeType? _appliedScopeType;

        /// <summary>Type of the Applied Scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.AppliedScopeType? AppliedScopeType { get => this._appliedScopeType; set => this._appliedScopeType = value; }

        /// <summary>Backing field for <see cref="AppliedScopes" /> property.</summary>
        private string[] _appliedScopes;

        /// <summary>
        /// List of the subscriptions that the benefit will be applied. Do not specify if AppliedScopeType is Shared. This property
        /// will be deprecated and replaced by appliedScopeProperties instead for Single AppliedScopeType.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public string[] AppliedScopes { get => this._appliedScopes; set => this._appliedScopes = value; }

        /// <summary>Backing field for <see cref="BillingPlan" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservationBillingPlan? _billingPlan;

        /// <summary>Represent the billing plans.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservationBillingPlan? BillingPlan { get => this._billingPlan; set => this._billingPlan = value; }

        /// <summary>Backing field for <see cref="BillingScopeId" /> property.</summary>
        private string _billingScopeId;

        /// <summary>Subscription that will be charged for purchasing reservation or savings plan</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public string BillingScopeId { get => this._billingScopeId; set => this._billingScopeId = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Friendly name of the reservation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Internal Acessors for AppliedScopeProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IAppliedScopeProperties Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal.AppliedScopeProperty { get => (this._appliedScopeProperty = this._appliedScopeProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.AppliedScopeProperties()); set { {_appliedScopeProperty = value;} } }

        /// <summary>Internal Acessors for ReservedResourceProperties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesReservedResourceProperties Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal.ReservedResourceProperties { get => (this._reservedResourceProperties = this._reservedResourceProperties ?? new Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.PurchaseRequestPropertiesReservedResourceProperties()); set { {_reservedResourceProperties = value;} } }

        /// <summary>Backing field for <see cref="Quantity" /> property.</summary>
        private int? _quantity;

        /// <summary>Quantity of the skus that are part of the reservation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public int? Quantity { get => this._quantity; set => this._quantity = value; }

        /// <summary>Backing field for <see cref="Renew" /> property.</summary>
        private bool? _renew;

        /// <summary>
        /// Setting this to true will automatically purchase a new reservation on the expiration date time.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public bool? Renew { get => this._renew; set => this._renew = value; }

        /// <summary>Backing field for <see cref="ReservedResourceProperties" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesReservedResourceProperties _reservedResourceProperties;

        /// <summary>
        /// Properties specific to each reserved resource type. Not required if not applicable.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesReservedResourceProperties ReservedResourceProperties { get => (this._reservedResourceProperties = this._reservedResourceProperties ?? new Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.PurchaseRequestPropertiesReservedResourceProperties()); set => this._reservedResourceProperties = value; }

        /// <summary>
        /// Turning this on will apply the reservation discount to other VMs in the same VM size group. Only specify for VirtualMachines
        /// reserved resource type.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.InstanceFlexibility? ReservedResourcePropertyInstanceFlexibility { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesReservedResourcePropertiesInternal)ReservedResourceProperties).InstanceFlexibility; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesReservedResourcePropertiesInternal)ReservedResourceProperties).InstanceFlexibility = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.InstanceFlexibility)""); }

        /// <summary>Backing field for <see cref="ReservedResourceType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservedResourceType? _reservedResourceType;

        /// <summary>The type of the resource that is being reserved.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservedResourceType? ReservedResourceType { get => this._reservedResourceType; set => this._reservedResourceType = value; }

        /// <summary>Backing field for <see cref="ReviewDateTime" /> property.</summary>
        private global::System.DateTime? _reviewDateTime;

        /// <summary>This is the date-time when the Azure hybrid benefit needs to be reviewed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public global::System.DateTime? ReviewDateTime { get => this._reviewDateTime; set => this._reviewDateTime = value; }

        /// <summary>Backing field for <see cref="Term" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservationTerm? _term;

        /// <summary>Represent the term of reservation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservationTerm? Term { get => this._term; set => this._term = value; }

        /// <summary>Creates an new <see cref="PurchaseRequestProperties" /> instance.</summary>
        public PurchaseRequestProperties()
        {

        }
    }
    /// Properties of reservation purchase request
    public partial interface IPurchaseRequestProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.IJsonSerializable
    {
        /// <summary>Display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string AppliedScopePropertyDisplayName { get; set; }
        /// <summary>
        /// Fully-qualified identifier of the management group where the benefit must be applied.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully-qualified identifier of the management group where the benefit must be applied.",
        SerializedName = @"managementGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string AppliedScopePropertyManagementGroupId { get; set; }
        /// <summary>Fully-qualified identifier of the resource group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully-qualified identifier of the resource group.",
        SerializedName = @"resourceGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string AppliedScopePropertyResourceGroupId { get; set; }
        /// <summary>Fully-qualified identifier of the subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully-qualified identifier of the subscription.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string AppliedScopePropertySubscriptionId { get; set; }
        /// <summary>Tenant ID where the savings plan should apply benefit.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Tenant ID where the savings plan should apply benefit.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string AppliedScopePropertyTenantId { get; set; }
        /// <summary>Type of the Applied Scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the Applied Scope.",
        SerializedName = @"appliedScopeType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.AppliedScopeType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.AppliedScopeType? AppliedScopeType { get; set; }
        /// <summary>
        /// List of the subscriptions that the benefit will be applied. Do not specify if AppliedScopeType is Shared. This property
        /// will be deprecated and replaced by appliedScopeProperties instead for Single AppliedScopeType.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of the subscriptions that the benefit will be applied. Do not specify if AppliedScopeType is Shared. This property will be deprecated and replaced by appliedScopeProperties instead for Single AppliedScopeType.",
        SerializedName = @"appliedScopes",
        PossibleTypes = new [] { typeof(string) })]
        string[] AppliedScopes { get; set; }
        /// <summary>Represent the billing plans.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Represent the billing plans.",
        SerializedName = @"billingPlan",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservationBillingPlan) })]
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservationBillingPlan? BillingPlan { get; set; }
        /// <summary>Subscription that will be charged for purchasing reservation or savings plan</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Subscription that will be charged for purchasing reservation or savings plan",
        SerializedName = @"billingScopeId",
        PossibleTypes = new [] { typeof(string) })]
        string BillingScopeId { get; set; }
        /// <summary>Friendly name of the reservation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Friendly name of the reservation",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>Quantity of the skus that are part of the reservation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Quantity of the skus that are part of the reservation.",
        SerializedName = @"quantity",
        PossibleTypes = new [] { typeof(int) })]
        int? Quantity { get; set; }
        /// <summary>
        /// Setting this to true will automatically purchase a new reservation on the expiration date time.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Setting this to true will automatically purchase a new reservation on the expiration date time.",
        SerializedName = @"renew",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Renew { get; set; }
        /// <summary>
        /// Turning this on will apply the reservation discount to other VMs in the same VM size group. Only specify for VirtualMachines
        /// reserved resource type.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Turning this on will apply the reservation discount to other VMs in the same VM size group. Only specify for VirtualMachines reserved resource type.",
        SerializedName = @"instanceFlexibility",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.InstanceFlexibility) })]
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.InstanceFlexibility? ReservedResourcePropertyInstanceFlexibility { get; set; }
        /// <summary>The type of the resource that is being reserved.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of the resource that is being reserved.",
        SerializedName = @"reservedResourceType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservedResourceType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservedResourceType? ReservedResourceType { get; set; }
        /// <summary>This is the date-time when the Azure hybrid benefit needs to be reviewed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This is the date-time when the Azure hybrid benefit needs to be reviewed.",
        SerializedName = @"reviewDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ReviewDateTime { get; set; }
        /// <summary>Represent the term of reservation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Represent the term of reservation.",
        SerializedName = @"term",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservationTerm) })]
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservationTerm? Term { get; set; }

    }
    /// Properties of reservation purchase request
    internal partial interface IPurchaseRequestPropertiesInternal

    {
        /// <summary>
        /// Properties specific to applied scope type. Not required if not applicable. Required and need to provide tenantId and managementGroupId
        /// if AppliedScopeType is ManagementGroup
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IAppliedScopeProperties AppliedScopeProperty { get; set; }
        /// <summary>Display name</summary>
        string AppliedScopePropertyDisplayName { get; set; }
        /// <summary>
        /// Fully-qualified identifier of the management group where the benefit must be applied.
        /// </summary>
        string AppliedScopePropertyManagementGroupId { get; set; }
        /// <summary>Fully-qualified identifier of the resource group.</summary>
        string AppliedScopePropertyResourceGroupId { get; set; }
        /// <summary>Fully-qualified identifier of the subscription.</summary>
        string AppliedScopePropertySubscriptionId { get; set; }
        /// <summary>Tenant ID where the savings plan should apply benefit.</summary>
        string AppliedScopePropertyTenantId { get; set; }
        /// <summary>Type of the Applied Scope.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.AppliedScopeType? AppliedScopeType { get; set; }
        /// <summary>
        /// List of the subscriptions that the benefit will be applied. Do not specify if AppliedScopeType is Shared. This property
        /// will be deprecated and replaced by appliedScopeProperties instead for Single AppliedScopeType.
        /// </summary>
        string[] AppliedScopes { get; set; }
        /// <summary>Represent the billing plans.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservationBillingPlan? BillingPlan { get; set; }
        /// <summary>Subscription that will be charged for purchasing reservation or savings plan</summary>
        string BillingScopeId { get; set; }
        /// <summary>Friendly name of the reservation</summary>
        string DisplayName { get; set; }
        /// <summary>Quantity of the skus that are part of the reservation.</summary>
        int? Quantity { get; set; }
        /// <summary>
        /// Setting this to true will automatically purchase a new reservation on the expiration date time.
        /// </summary>
        bool? Renew { get; set; }
        /// <summary>
        /// Properties specific to each reserved resource type. Not required if not applicable.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesReservedResourceProperties ReservedResourceProperties { get; set; }
        /// <summary>
        /// Turning this on will apply the reservation discount to other VMs in the same VM size group. Only specify for VirtualMachines
        /// reserved resource type.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.InstanceFlexibility? ReservedResourcePropertyInstanceFlexibility { get; set; }
        /// <summary>The type of the resource that is being reserved.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservedResourceType? ReservedResourceType { get; set; }
        /// <summary>This is the date-time when the Azure hybrid benefit needs to be reviewed.</summary>
        global::System.DateTime? ReviewDateTime { get; set; }
        /// <summary>Represent the term of reservation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservationTerm? Term { get; set; }

    }
}