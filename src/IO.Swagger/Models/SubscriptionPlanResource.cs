/*
 * Knetik Platform API Documentation Latest
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://demo.sandbox.knetikcloud.com
 *
 * OpenAPI spec version: Latest
 * Contact: support@knetik.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class SubscriptionPlanResource :  IEquatable<SubscriptionPlanResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPlanResource" /> class.
        /// </summary>
        /// <param name="AdditionalProperties">A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this subscription.</param>
        /// <param name="BillingCycleLength">The length of the billing cycle in number of billing cycle unit (required).</param>
        /// <param name="BillingCycleUnit">The time period unit to apply to the length of billing cycles (required).</param>
        /// <param name="Consolidated">Whether this plan will be renewed on the consolidated billing cycle (required).</param>
        /// <param name="CurrencyCode">The ISO3 currency code to use for the fees (required).</param>
        /// <param name="EndDate">Used to schedule plan availability end date.</param>
        /// <param name="FirstBillingCycleLength">Optional override for the length of the first billing cycle before the first recurring billing.</param>
        /// <param name="FirstBillingCycleUnit">The time period unit to apply to the length of the first billing cycle. Required when first_billing_cycle_length is specified.</param>
        /// <param name="GracePeriod">The number of late payment days before a subscription is canceled (required).</param>
        /// <param name="Id">The id of the plan used to generate the SKUs.</param>
        /// <param name="InitialFee">The fee charged when the subscription is purchased (required).</param>
        /// <param name="InitialSku">The SKU to be used when purchasing the subscription through the cart.</param>
        /// <param name="LatePaymentFee">The fee to add to the bill when an invoice has gone unpaid passed the grace period (required).</param>
        /// <param name="LatePaymentSku">The SKU that will show on the invoice when the subscription is delinquent.</param>
        /// <param name="Locked">Whether this plan is locked because it has been purchased by at least one user.  When locked, a number of properties can no longer be changed.</param>
        /// <param name="MaxBillAttempts">The number of charge attempts before the subscription becomes delinquent (required).</param>
        /// <param name="MaxCycles">Maximum number of renewals. If a migration plan is provided, the subscription will automatically switch to it when this limit is reached.</param>
        /// <param name="MigrateToPlan">Automatically migrate to the specified plan when the subscription is first renewed.</param>
        /// <param name="MinCycles">The minimum number of renewals to charge for.</param>
        /// <param name="Name">The name of the plan used to generate the SKUs (required).</param>
        /// <param name="Published">Whether this plan is currently available (required).</param>
        /// <param name="ReactivationFee">The fee to charge when a suspended subscription is to be re-activated (required).</param>
        /// <param name="ReactivationSku">The SKU that will show on the invoice when the subscription is re-activated after a suspension.</param>
        /// <param name="RecurringFee">The recurring fee to charge for each renewal (required).</param>
        /// <param name="RecurringSku">The SKU that will show on the invoice when the subscription is activated.</param>
        /// <param name="StartDate">Used to schedule plan availability start date.</param>
        public SubscriptionPlanResource(Dictionary<string, Property> AdditionalProperties = null, int? BillingCycleLength = null, string BillingCycleUnit = null, bool? Consolidated = null, string CurrencyCode = null, long? EndDate = null, int? FirstBillingCycleLength = null, string FirstBillingCycleUnit = null, int? GracePeriod = null, string Id = null, double? InitialFee = null, string InitialSku = null, double? LatePaymentFee = null, string LatePaymentSku = null, bool? Locked = null, int? MaxBillAttempts = null, int? MaxCycles = null, string MigrateToPlan = null, int? MinCycles = null, string Name = null, bool? Published = null, double? ReactivationFee = null, string ReactivationSku = null, double? RecurringFee = null, string RecurringSku = null, long? StartDate = null)
        {
            // to ensure "BillingCycleLength" is required (not null)
            if (BillingCycleLength == null)
            {
                throw new InvalidDataException("BillingCycleLength is a required property for SubscriptionPlanResource and cannot be null");
            }
            else
            {
                this.BillingCycleLength = BillingCycleLength;
            }
            // to ensure "BillingCycleUnit" is required (not null)
            if (BillingCycleUnit == null)
            {
                throw new InvalidDataException("BillingCycleUnit is a required property for SubscriptionPlanResource and cannot be null");
            }
            else
            {
                this.BillingCycleUnit = BillingCycleUnit;
            }
            // to ensure "Consolidated" is required (not null)
            if (Consolidated == null)
            {
                throw new InvalidDataException("Consolidated is a required property for SubscriptionPlanResource and cannot be null");
            }
            else
            {
                this.Consolidated = Consolidated;
            }
            // to ensure "CurrencyCode" is required (not null)
            if (CurrencyCode == null)
            {
                throw new InvalidDataException("CurrencyCode is a required property for SubscriptionPlanResource and cannot be null");
            }
            else
            {
                this.CurrencyCode = CurrencyCode;
            }
            // to ensure "GracePeriod" is required (not null)
            if (GracePeriod == null)
            {
                throw new InvalidDataException("GracePeriod is a required property for SubscriptionPlanResource and cannot be null");
            }
            else
            {
                this.GracePeriod = GracePeriod;
            }
            // to ensure "InitialFee" is required (not null)
            if (InitialFee == null)
            {
                throw new InvalidDataException("InitialFee is a required property for SubscriptionPlanResource and cannot be null");
            }
            else
            {
                this.InitialFee = InitialFee;
            }
            // to ensure "LatePaymentFee" is required (not null)
            if (LatePaymentFee == null)
            {
                throw new InvalidDataException("LatePaymentFee is a required property for SubscriptionPlanResource and cannot be null");
            }
            else
            {
                this.LatePaymentFee = LatePaymentFee;
            }
            // to ensure "MaxBillAttempts" is required (not null)
            if (MaxBillAttempts == null)
            {
                throw new InvalidDataException("MaxBillAttempts is a required property for SubscriptionPlanResource and cannot be null");
            }
            else
            {
                this.MaxBillAttempts = MaxBillAttempts;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for SubscriptionPlanResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Published" is required (not null)
            if (Published == null)
            {
                throw new InvalidDataException("Published is a required property for SubscriptionPlanResource and cannot be null");
            }
            else
            {
                this.Published = Published;
            }
            // to ensure "ReactivationFee" is required (not null)
            if (ReactivationFee == null)
            {
                throw new InvalidDataException("ReactivationFee is a required property for SubscriptionPlanResource and cannot be null");
            }
            else
            {
                this.ReactivationFee = ReactivationFee;
            }
            // to ensure "RecurringFee" is required (not null)
            if (RecurringFee == null)
            {
                throw new InvalidDataException("RecurringFee is a required property for SubscriptionPlanResource and cannot be null");
            }
            else
            {
                this.RecurringFee = RecurringFee;
            }
            this.AdditionalProperties = AdditionalProperties;
            this.EndDate = EndDate;
            this.FirstBillingCycleLength = FirstBillingCycleLength;
            this.FirstBillingCycleUnit = FirstBillingCycleUnit;
            this.Id = Id;
            this.InitialSku = InitialSku;
            this.LatePaymentSku = LatePaymentSku;
            this.Locked = Locked;
            this.MaxCycles = MaxCycles;
            this.MigrateToPlan = MigrateToPlan;
            this.MinCycles = MinCycles;
            this.ReactivationSku = ReactivationSku;
            this.RecurringSku = RecurringSku;
            this.StartDate = StartDate;
            
        }

        /// <summary>
        /// A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this subscription
        /// </summary>
        /// <value>A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this subscription</value>
        [DataMember(Name="additional_properties")]
        public Dictionary<string, Property> AdditionalProperties { get; set; }

        /// <summary>
        /// The length of the billing cycle in number of billing cycle unit
        /// </summary>
        /// <value>The length of the billing cycle in number of billing cycle unit</value>
        [DataMember(Name="billing_cycle_length")]
        public int? BillingCycleLength { get; set; }

        /// <summary>
        /// The time period unit to apply to the length of billing cycles
        /// </summary>
        /// <value>The time period unit to apply to the length of billing cycles</value>
        [DataMember(Name="billing_cycle_unit")]
        public string BillingCycleUnit { get; set; }

        /// <summary>
        /// Whether this plan will be renewed on the consolidated billing cycle
        /// </summary>
        /// <value>Whether this plan will be renewed on the consolidated billing cycle</value>
        [DataMember(Name="consolidated")]
        public bool? Consolidated { get; set; }

        /// <summary>
        /// The ISO3 currency code to use for the fees
        /// </summary>
        /// <value>The ISO3 currency code to use for the fees</value>
        [DataMember(Name="currency_code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Used to schedule plan availability end date
        /// </summary>
        /// <value>Used to schedule plan availability end date</value>
        [DataMember(Name="end_date")]
        public long? EndDate { get; set; }

        /// <summary>
        /// Optional override for the length of the first billing cycle before the first recurring billing
        /// </summary>
        /// <value>Optional override for the length of the first billing cycle before the first recurring billing</value>
        [DataMember(Name="first_billing_cycle_length")]
        public int? FirstBillingCycleLength { get; set; }

        /// <summary>
        /// The time period unit to apply to the length of the first billing cycle. Required when first_billing_cycle_length is specified
        /// </summary>
        /// <value>The time period unit to apply to the length of the first billing cycle. Required when first_billing_cycle_length is specified</value>
        [DataMember(Name="first_billing_cycle_unit")]
        public string FirstBillingCycleUnit { get; set; }

        /// <summary>
        /// The number of late payment days before a subscription is canceled
        /// </summary>
        /// <value>The number of late payment days before a subscription is canceled</value>
        [DataMember(Name="grace_period")]
        public int? GracePeriod { get; set; }

        /// <summary>
        /// The id of the plan used to generate the SKUs
        /// </summary>
        /// <value>The id of the plan used to generate the SKUs</value>
        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// The fee charged when the subscription is purchased
        /// </summary>
        /// <value>The fee charged when the subscription is purchased</value>
        [DataMember(Name="initial_fee")]
        public double? InitialFee { get; set; }

        /// <summary>
        /// The SKU to be used when purchasing the subscription through the cart
        /// </summary>
        /// <value>The SKU to be used when purchasing the subscription through the cart</value>
        [DataMember(Name="initial_sku")]
        public string InitialSku { get; set; }

        /// <summary>
        /// The fee to add to the bill when an invoice has gone unpaid passed the grace period
        /// </summary>
        /// <value>The fee to add to the bill when an invoice has gone unpaid passed the grace period</value>
        [DataMember(Name="late_payment_fee")]
        public double? LatePaymentFee { get; set; }

        /// <summary>
        /// The SKU that will show on the invoice when the subscription is delinquent
        /// </summary>
        /// <value>The SKU that will show on the invoice when the subscription is delinquent</value>
        [DataMember(Name="late_payment_sku")]
        public string LatePaymentSku { get; set; }

        /// <summary>
        /// Whether this plan is locked because it has been purchased by at least one user.  When locked, a number of properties can no longer be changed
        /// </summary>
        /// <value>Whether this plan is locked because it has been purchased by at least one user.  When locked, a number of properties can no longer be changed</value>
        [DataMember(Name="locked")]
        public bool? Locked { get; set; }

        /// <summary>
        /// The number of charge attempts before the subscription becomes delinquent
        /// </summary>
        /// <value>The number of charge attempts before the subscription becomes delinquent</value>
        [DataMember(Name="max_bill_attempts")]
        public int? MaxBillAttempts { get; set; }

        /// <summary>
        /// Maximum number of renewals. If a migration plan is provided, the subscription will automatically switch to it when this limit is reached
        /// </summary>
        /// <value>Maximum number of renewals. If a migration plan is provided, the subscription will automatically switch to it when this limit is reached</value>
        [DataMember(Name="max_cycles")]
        public int? MaxCycles { get; set; }

        /// <summary>
        /// Automatically migrate to the specified plan when the subscription is first renewed
        /// </summary>
        /// <value>Automatically migrate to the specified plan when the subscription is first renewed</value>
        [DataMember(Name="migrate_to_plan")]
        public string MigrateToPlan { get; set; }

        /// <summary>
        /// The minimum number of renewals to charge for
        /// </summary>
        /// <value>The minimum number of renewals to charge for</value>
        [DataMember(Name="min_cycles")]
        public int? MinCycles { get; set; }

        /// <summary>
        /// The name of the plan used to generate the SKUs
        /// </summary>
        /// <value>The name of the plan used to generate the SKUs</value>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Whether this plan is currently available
        /// </summary>
        /// <value>Whether this plan is currently available</value>
        [DataMember(Name="published")]
        public bool? Published { get; set; }

        /// <summary>
        /// The fee to charge when a suspended subscription is to be re-activated
        /// </summary>
        /// <value>The fee to charge when a suspended subscription is to be re-activated</value>
        [DataMember(Name="reactivation_fee")]
        public double? ReactivationFee { get; set; }

        /// <summary>
        /// The SKU that will show on the invoice when the subscription is re-activated after a suspension
        /// </summary>
        /// <value>The SKU that will show on the invoice when the subscription is re-activated after a suspension</value>
        [DataMember(Name="reactivation_sku")]
        public string ReactivationSku { get; set; }

        /// <summary>
        /// The recurring fee to charge for each renewal
        /// </summary>
        /// <value>The recurring fee to charge for each renewal</value>
        [DataMember(Name="recurring_fee")]
        public double? RecurringFee { get; set; }

        /// <summary>
        /// The SKU that will show on the invoice when the subscription is activated
        /// </summary>
        /// <value>The SKU that will show on the invoice when the subscription is activated</value>
        [DataMember(Name="recurring_sku")]
        public string RecurringSku { get; set; }

        /// <summary>
        /// Used to schedule plan availability start date
        /// </summary>
        /// <value>Used to schedule plan availability start date</value>
        [DataMember(Name="start_date")]
        public long? StartDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionPlanResource {\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  BillingCycleLength: ").Append(BillingCycleLength).Append("\n");
            sb.Append("  BillingCycleUnit: ").Append(BillingCycleUnit).Append("\n");
            sb.Append("  Consolidated: ").Append(Consolidated).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  FirstBillingCycleLength: ").Append(FirstBillingCycleLength).Append("\n");
            sb.Append("  FirstBillingCycleUnit: ").Append(FirstBillingCycleUnit).Append("\n");
            sb.Append("  GracePeriod: ").Append(GracePeriod).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InitialFee: ").Append(InitialFee).Append("\n");
            sb.Append("  InitialSku: ").Append(InitialSku).Append("\n");
            sb.Append("  LatePaymentFee: ").Append(LatePaymentFee).Append("\n");
            sb.Append("  LatePaymentSku: ").Append(LatePaymentSku).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  MaxBillAttempts: ").Append(MaxBillAttempts).Append("\n");
            sb.Append("  MaxCycles: ").Append(MaxCycles).Append("\n");
            sb.Append("  MigrateToPlan: ").Append(MigrateToPlan).Append("\n");
            sb.Append("  MinCycles: ").Append(MinCycles).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  ReactivationFee: ").Append(ReactivationFee).Append("\n");
            sb.Append("  ReactivationSku: ").Append(ReactivationSku).Append("\n");
            sb.Append("  RecurringFee: ").Append(RecurringFee).Append("\n");
            sb.Append("  RecurringSku: ").Append(RecurringSku).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((SubscriptionPlanResource)obj);
        }

        /// <summary>
        /// Returns true if SubscriptionPlanResource instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionPlanResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionPlanResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
                ) && 
                (
                    this.BillingCycleLength == other.BillingCycleLength ||
                    this.BillingCycleLength != null &&
                    this.BillingCycleLength.Equals(other.BillingCycleLength)
                ) && 
                (
                    this.BillingCycleUnit == other.BillingCycleUnit ||
                    this.BillingCycleUnit != null &&
                    this.BillingCycleUnit.Equals(other.BillingCycleUnit)
                ) && 
                (
                    this.Consolidated == other.Consolidated ||
                    this.Consolidated != null &&
                    this.Consolidated.Equals(other.Consolidated)
                ) && 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
                ) && 
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) && 
                (
                    this.FirstBillingCycleLength == other.FirstBillingCycleLength ||
                    this.FirstBillingCycleLength != null &&
                    this.FirstBillingCycleLength.Equals(other.FirstBillingCycleLength)
                ) && 
                (
                    this.FirstBillingCycleUnit == other.FirstBillingCycleUnit ||
                    this.FirstBillingCycleUnit != null &&
                    this.FirstBillingCycleUnit.Equals(other.FirstBillingCycleUnit)
                ) && 
                (
                    this.GracePeriod == other.GracePeriod ||
                    this.GracePeriod != null &&
                    this.GracePeriod.Equals(other.GracePeriod)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.InitialFee == other.InitialFee ||
                    this.InitialFee != null &&
                    this.InitialFee.Equals(other.InitialFee)
                ) && 
                (
                    this.InitialSku == other.InitialSku ||
                    this.InitialSku != null &&
                    this.InitialSku.Equals(other.InitialSku)
                ) && 
                (
                    this.LatePaymentFee == other.LatePaymentFee ||
                    this.LatePaymentFee != null &&
                    this.LatePaymentFee.Equals(other.LatePaymentFee)
                ) && 
                (
                    this.LatePaymentSku == other.LatePaymentSku ||
                    this.LatePaymentSku != null &&
                    this.LatePaymentSku.Equals(other.LatePaymentSku)
                ) && 
                (
                    this.Locked == other.Locked ||
                    this.Locked != null &&
                    this.Locked.Equals(other.Locked)
                ) && 
                (
                    this.MaxBillAttempts == other.MaxBillAttempts ||
                    this.MaxBillAttempts != null &&
                    this.MaxBillAttempts.Equals(other.MaxBillAttempts)
                ) && 
                (
                    this.MaxCycles == other.MaxCycles ||
                    this.MaxCycles != null &&
                    this.MaxCycles.Equals(other.MaxCycles)
                ) && 
                (
                    this.MigrateToPlan == other.MigrateToPlan ||
                    this.MigrateToPlan != null &&
                    this.MigrateToPlan.Equals(other.MigrateToPlan)
                ) && 
                (
                    this.MinCycles == other.MinCycles ||
                    this.MinCycles != null &&
                    this.MinCycles.Equals(other.MinCycles)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Published == other.Published ||
                    this.Published != null &&
                    this.Published.Equals(other.Published)
                ) && 
                (
                    this.ReactivationFee == other.ReactivationFee ||
                    this.ReactivationFee != null &&
                    this.ReactivationFee.Equals(other.ReactivationFee)
                ) && 
                (
                    this.ReactivationSku == other.ReactivationSku ||
                    this.ReactivationSku != null &&
                    this.ReactivationSku.Equals(other.ReactivationSku)
                ) && 
                (
                    this.RecurringFee == other.RecurringFee ||
                    this.RecurringFee != null &&
                    this.RecurringFee.Equals(other.RecurringFee)
                ) && 
                (
                    this.RecurringSku == other.RecurringSku ||
                    this.RecurringSku != null &&
                    this.RecurringSku.Equals(other.RecurringSku)
                ) && 
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                    if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                    if (this.BillingCycleLength != null)
                    hash = hash * 59 + this.BillingCycleLength.GetHashCode();
                    if (this.BillingCycleUnit != null)
                    hash = hash * 59 + this.BillingCycleUnit.GetHashCode();
                    if (this.Consolidated != null)
                    hash = hash * 59 + this.Consolidated.GetHashCode();
                    if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
                    if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                    if (this.FirstBillingCycleLength != null)
                    hash = hash * 59 + this.FirstBillingCycleLength.GetHashCode();
                    if (this.FirstBillingCycleUnit != null)
                    hash = hash * 59 + this.FirstBillingCycleUnit.GetHashCode();
                    if (this.GracePeriod != null)
                    hash = hash * 59 + this.GracePeriod.GetHashCode();
                    if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                    if (this.InitialFee != null)
                    hash = hash * 59 + this.InitialFee.GetHashCode();
                    if (this.InitialSku != null)
                    hash = hash * 59 + this.InitialSku.GetHashCode();
                    if (this.LatePaymentFee != null)
                    hash = hash * 59 + this.LatePaymentFee.GetHashCode();
                    if (this.LatePaymentSku != null)
                    hash = hash * 59 + this.LatePaymentSku.GetHashCode();
                    if (this.Locked != null)
                    hash = hash * 59 + this.Locked.GetHashCode();
                    if (this.MaxBillAttempts != null)
                    hash = hash * 59 + this.MaxBillAttempts.GetHashCode();
                    if (this.MaxCycles != null)
                    hash = hash * 59 + this.MaxCycles.GetHashCode();
                    if (this.MigrateToPlan != null)
                    hash = hash * 59 + this.MigrateToPlan.GetHashCode();
                    if (this.MinCycles != null)
                    hash = hash * 59 + this.MinCycles.GetHashCode();
                    if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                    if (this.Published != null)
                    hash = hash * 59 + this.Published.GetHashCode();
                    if (this.ReactivationFee != null)
                    hash = hash * 59 + this.ReactivationFee.GetHashCode();
                    if (this.ReactivationSku != null)
                    hash = hash * 59 + this.ReactivationSku.GetHashCode();
                    if (this.RecurringFee != null)
                    hash = hash * 59 + this.RecurringFee.GetHashCode();
                    if (this.RecurringSku != null)
                    hash = hash * 59 + this.RecurringSku.GetHashCode();
                    if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(SubscriptionPlanResource left, SubscriptionPlanResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SubscriptionPlanResource left, SubscriptionPlanResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
