/*
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://knetikcloud.com.
 *
 * OpenAPI spec version: latest 
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
    public partial class SubscriptionPlan :  IEquatable<SubscriptionPlan>
    {
                /// <summary>
        /// Gets or Sets Availability
        /// </summary>
        public enum AvailabilityEnum
        {
            
            /// <summary>
            /// Enum AllEnum for "all"
            /// </summary>
            [EnumMember(Value = "all")]
            AllEnum,
            
            /// <summary>
            /// Enum NewSubscribersEnum for "new_subscribers"
            /// </summary>
            [EnumMember(Value = "new_subscribers")]
            NewSubscribersEnum
        }
                /// <summary>
        /// Gets or Sets FirstBillUnitOfTime
        /// </summary>
        public enum FirstBillUnitOfTimeEnum
        {
            
            /// <summary>
            /// Enum MillisecondEnum for "millisecond"
            /// </summary>
            [EnumMember(Value = "millisecond")]
            MillisecondEnum,
            
            /// <summary>
            /// Enum SecondEnum for "second"
            /// </summary>
            [EnumMember(Value = "second")]
            SecondEnum,
            
            /// <summary>
            /// Enum MinuteEnum for "minute"
            /// </summary>
            [EnumMember(Value = "minute")]
            MinuteEnum,
            
            /// <summary>
            /// Enum HourEnum for "hour"
            /// </summary>
            [EnumMember(Value = "hour")]
            HourEnum,
            
            /// <summary>
            /// Enum DayEnum for "day"
            /// </summary>
            [EnumMember(Value = "day")]
            DayEnum,
            
            /// <summary>
            /// Enum WeekEnum for "week"
            /// </summary>
            [EnumMember(Value = "week")]
            WeekEnum,
            
            /// <summary>
            /// Enum MonthEnum for "month"
            /// </summary>
            [EnumMember(Value = "month")]
            MonthEnum,
            
            /// <summary>
            /// Enum YearEnum for "year"
            /// </summary>
            [EnumMember(Value = "year")]
            YearEnum
        }
                /// <summary>
        /// Gets or Sets RenewPeriodUnitOfTime
        /// </summary>
        public enum RenewPeriodUnitOfTimeEnum
        {
            
            /// <summary>
            /// Enum MillisecondEnum for "millisecond"
            /// </summary>
            [EnumMember(Value = "millisecond")]
            MillisecondEnum,
            
            /// <summary>
            /// Enum SecondEnum for "second"
            /// </summary>
            [EnumMember(Value = "second")]
            SecondEnum,
            
            /// <summary>
            /// Enum MinuteEnum for "minute"
            /// </summary>
            [EnumMember(Value = "minute")]
            MinuteEnum,
            
            /// <summary>
            /// Enum HourEnum for "hour"
            /// </summary>
            [EnumMember(Value = "hour")]
            HourEnum,
            
            /// <summary>
            /// Enum DayEnum for "day"
            /// </summary>
            [EnumMember(Value = "day")]
            DayEnum,
            
            /// <summary>
            /// Enum WeekEnum for "week"
            /// </summary>
            [EnumMember(Value = "week")]
            WeekEnum,
            
            /// <summary>
            /// Enum MonthEnum for "month"
            /// </summary>
            [EnumMember(Value = "month")]
            MonthEnum,
            
            /// <summary>
            /// Enum YearEnum for "year"
            /// </summary>
            [EnumMember(Value = "year")]
            YearEnum
        }
        /// <summary>
        /// Gets or Sets Availability
        /// </summary>
        [DataMember(Name="availability")]
        public AvailabilityEnum? Availability { get; set; }
        /// <summary>
        /// Gets or Sets FirstBillUnitOfTime
        /// </summary>
        [DataMember(Name="first_bill_unit_of_time")]
        public FirstBillUnitOfTimeEnum? FirstBillUnitOfTime { get; set; }
        /// <summary>
        /// Gets or Sets RenewPeriodUnitOfTime
        /// </summary>
        [DataMember(Name="renew_period_unit_of_time")]
        public RenewPeriodUnitOfTimeEnum? RenewPeriodUnitOfTime { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPlan" /> class.
        /// </summary>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        /// <param name="Availability">Availability.</param>
        /// <param name="BillGraceDays">BillGraceDays.</param>
        /// <param name="Consolidated">Consolidated.</param>
        /// <param name="FirstBill">FirstBill.</param>
        /// <param name="FirstBillUnitOfTime">FirstBillUnitOfTime.</param>
        /// <param name="Id">Id.</param>
        /// <param name="LatePaymentSku">LatePaymentSku.</param>
        /// <param name="Locked">Locked.</param>
        /// <param name="MaxAutoRenew">MaxAutoRenew.</param>
        /// <param name="MaxBillAttempts">MaxBillAttempts.</param>
        /// <param name="MigrationPlan">MigrationPlan.</param>
        /// <param name="MinimumTerm">MinimumTerm.</param>
        /// <param name="Name">Name.</param>
        /// <param name="PrimarySku">PrimarySku.</param>
        /// <param name="ReactivationSku">ReactivationSku.</param>
        /// <param name="RecurringSku">RecurringSku.</param>
        /// <param name="RenewPeriod">RenewPeriod.</param>
        /// <param name="RenewPeriodUnitOfTime">RenewPeriodUnitOfTime.</param>
        /// <param name="SubscriptionId">SubscriptionId.</param>
        public SubscriptionPlan(Dictionary<string, Property> AdditionalProperties = default(Dictionary<string, Property>), AvailabilityEnum? Availability = default(AvailabilityEnum?), int? BillGraceDays = default(int?), bool? Consolidated = default(bool?), int? FirstBill = default(int?), FirstBillUnitOfTimeEnum? FirstBillUnitOfTime = default(FirstBillUnitOfTimeEnum?), string Id = default(string), string LatePaymentSku = default(string), bool? Locked = default(bool?), int? MaxAutoRenew = default(int?), int? MaxBillAttempts = default(int?), string MigrationPlan = default(string), int? MinimumTerm = default(int?), string Name = default(string), string PrimarySku = default(string), string ReactivationSku = default(string), string RecurringSku = default(string), int? RenewPeriod = default(int?), RenewPeriodUnitOfTimeEnum? RenewPeriodUnitOfTime = default(RenewPeriodUnitOfTimeEnum?), int? SubscriptionId = default(int?))
        {
            this.AdditionalProperties = AdditionalProperties;
            this.Availability = Availability;
            this.BillGraceDays = BillGraceDays;
            this.Consolidated = Consolidated;
            this.FirstBill = FirstBill;
            this.FirstBillUnitOfTime = FirstBillUnitOfTime;
            this.Id = Id;
            this.LatePaymentSku = LatePaymentSku;
            this.Locked = Locked;
            this.MaxAutoRenew = MaxAutoRenew;
            this.MaxBillAttempts = MaxBillAttempts;
            this.MigrationPlan = MigrationPlan;
            this.MinimumTerm = MinimumTerm;
            this.Name = Name;
            this.PrimarySku = PrimarySku;
            this.ReactivationSku = ReactivationSku;
            this.RecurringSku = RecurringSku;
            this.RenewPeriod = RenewPeriod;
            this.RenewPeriodUnitOfTime = RenewPeriodUnitOfTime;
            this.SubscriptionId = SubscriptionId;
            
        }

        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additional_properties")]
        public Dictionary<string, Property> AdditionalProperties { get; set; }
        /// <summary>
        /// Gets or Sets BillGraceDays
        /// </summary>
        [DataMember(Name="bill_grace_days")]
        public int? BillGraceDays { get; set; }
        /// <summary>
        /// Gets or Sets Consolidated
        /// </summary>
        [DataMember(Name="consolidated")]
        public bool? Consolidated { get; set; }
        /// <summary>
        /// Gets or Sets FirstBill
        /// </summary>
        [DataMember(Name="first_bill")]
        public int? FirstBill { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets LatePaymentSku
        /// </summary>
        [DataMember(Name="late_payment_sku")]
        public string LatePaymentSku { get; set; }
        /// <summary>
        /// Gets or Sets Locked
        /// </summary>
        [DataMember(Name="locked")]
        public bool? Locked { get; set; }
        /// <summary>
        /// Gets or Sets MaxAutoRenew
        /// </summary>
        [DataMember(Name="max_auto_renew")]
        public int? MaxAutoRenew { get; set; }
        /// <summary>
        /// Gets or Sets MaxBillAttempts
        /// </summary>
        [DataMember(Name="max_bill_attempts")]
        public int? MaxBillAttempts { get; set; }
        /// <summary>
        /// Gets or Sets MigrationPlan
        /// </summary>
        [DataMember(Name="migration_plan")]
        public string MigrationPlan { get; set; }
        /// <summary>
        /// Gets or Sets MinimumTerm
        /// </summary>
        [DataMember(Name="minimum_term")]
        public int? MinimumTerm { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name")]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets PrimarySku
        /// </summary>
        [DataMember(Name="primary_sku")]
        public string PrimarySku { get; set; }
        /// <summary>
        /// Gets or Sets ReactivationSku
        /// </summary>
        [DataMember(Name="reactivation_sku")]
        public string ReactivationSku { get; set; }
        /// <summary>
        /// Gets or Sets RecurringSku
        /// </summary>
        [DataMember(Name="recurring_sku")]
        public string RecurringSku { get; set; }
        /// <summary>
        /// Gets or Sets RenewPeriod
        /// </summary>
        [DataMember(Name="renew_period")]
        public int? RenewPeriod { get; set; }
        /// <summary>
        /// Gets or Sets SubscriptionId
        /// </summary>
        [DataMember(Name="subscription_id")]
        public int? SubscriptionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionPlan {\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  Availability: ").Append(Availability).Append("\n");
            sb.Append("  BillGraceDays: ").Append(BillGraceDays).Append("\n");
            sb.Append("  Consolidated: ").Append(Consolidated).Append("\n");
            sb.Append("  FirstBill: ").Append(FirstBill).Append("\n");
            sb.Append("  FirstBillUnitOfTime: ").Append(FirstBillUnitOfTime).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LatePaymentSku: ").Append(LatePaymentSku).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  MaxAutoRenew: ").Append(MaxAutoRenew).Append("\n");
            sb.Append("  MaxBillAttempts: ").Append(MaxBillAttempts).Append("\n");
            sb.Append("  MigrationPlan: ").Append(MigrationPlan).Append("\n");
            sb.Append("  MinimumTerm: ").Append(MinimumTerm).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PrimarySku: ").Append(PrimarySku).Append("\n");
            sb.Append("  ReactivationSku: ").Append(ReactivationSku).Append("\n");
            sb.Append("  RecurringSku: ").Append(RecurringSku).Append("\n");
            sb.Append("  RenewPeriod: ").Append(RenewPeriod).Append("\n");
            sb.Append("  RenewPeriodUnitOfTime: ").Append(RenewPeriodUnitOfTime).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
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
            return Equals((SubscriptionPlan)obj);
        }

        /// <summary>
        /// Returns true if SubscriptionPlan instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionPlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionPlan other)
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
                    this.Availability == other.Availability ||
                    this.Availability != null &&
                    this.Availability.Equals(other.Availability)
                ) && 
                (
                    this.BillGraceDays == other.BillGraceDays ||
                    this.BillGraceDays != null &&
                    this.BillGraceDays.Equals(other.BillGraceDays)
                ) && 
                (
                    this.Consolidated == other.Consolidated ||
                    this.Consolidated != null &&
                    this.Consolidated.Equals(other.Consolidated)
                ) && 
                (
                    this.FirstBill == other.FirstBill ||
                    this.FirstBill != null &&
                    this.FirstBill.Equals(other.FirstBill)
                ) && 
                (
                    this.FirstBillUnitOfTime == other.FirstBillUnitOfTime ||
                    this.FirstBillUnitOfTime != null &&
                    this.FirstBillUnitOfTime.Equals(other.FirstBillUnitOfTime)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                    this.MaxAutoRenew == other.MaxAutoRenew ||
                    this.MaxAutoRenew != null &&
                    this.MaxAutoRenew.Equals(other.MaxAutoRenew)
                ) && 
                (
                    this.MaxBillAttempts == other.MaxBillAttempts ||
                    this.MaxBillAttempts != null &&
                    this.MaxBillAttempts.Equals(other.MaxBillAttempts)
                ) && 
                (
                    this.MigrationPlan == other.MigrationPlan ||
                    this.MigrationPlan != null &&
                    this.MigrationPlan.Equals(other.MigrationPlan)
                ) && 
                (
                    this.MinimumTerm == other.MinimumTerm ||
                    this.MinimumTerm != null &&
                    this.MinimumTerm.Equals(other.MinimumTerm)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PrimarySku == other.PrimarySku ||
                    this.PrimarySku != null &&
                    this.PrimarySku.Equals(other.PrimarySku)
                ) && 
                (
                    this.ReactivationSku == other.ReactivationSku ||
                    this.ReactivationSku != null &&
                    this.ReactivationSku.Equals(other.ReactivationSku)
                ) && 
                (
                    this.RecurringSku == other.RecurringSku ||
                    this.RecurringSku != null &&
                    this.RecurringSku.Equals(other.RecurringSku)
                ) && 
                (
                    this.RenewPeriod == other.RenewPeriod ||
                    this.RenewPeriod != null &&
                    this.RenewPeriod.Equals(other.RenewPeriod)
                ) && 
                (
                    this.RenewPeriodUnitOfTime == other.RenewPeriodUnitOfTime ||
                    this.RenewPeriodUnitOfTime != null &&
                    this.RenewPeriodUnitOfTime.Equals(other.RenewPeriodUnitOfTime)
                ) && 
                (
                    this.SubscriptionId == other.SubscriptionId ||
                    this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(other.SubscriptionId)
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
                    if (this.Availability != null)
                    hash = hash * 59 + this.Availability.GetHashCode();
                    if (this.BillGraceDays != null)
                    hash = hash * 59 + this.BillGraceDays.GetHashCode();
                    if (this.Consolidated != null)
                    hash = hash * 59 + this.Consolidated.GetHashCode();
                    if (this.FirstBill != null)
                    hash = hash * 59 + this.FirstBill.GetHashCode();
                    if (this.FirstBillUnitOfTime != null)
                    hash = hash * 59 + this.FirstBillUnitOfTime.GetHashCode();
                    if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                    if (this.LatePaymentSku != null)
                    hash = hash * 59 + this.LatePaymentSku.GetHashCode();
                    if (this.Locked != null)
                    hash = hash * 59 + this.Locked.GetHashCode();
                    if (this.MaxAutoRenew != null)
                    hash = hash * 59 + this.MaxAutoRenew.GetHashCode();
                    if (this.MaxBillAttempts != null)
                    hash = hash * 59 + this.MaxBillAttempts.GetHashCode();
                    if (this.MigrationPlan != null)
                    hash = hash * 59 + this.MigrationPlan.GetHashCode();
                    if (this.MinimumTerm != null)
                    hash = hash * 59 + this.MinimumTerm.GetHashCode();
                    if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                    if (this.PrimarySku != null)
                    hash = hash * 59 + this.PrimarySku.GetHashCode();
                    if (this.ReactivationSku != null)
                    hash = hash * 59 + this.ReactivationSku.GetHashCode();
                    if (this.RecurringSku != null)
                    hash = hash * 59 + this.RecurringSku.GetHashCode();
                    if (this.RenewPeriod != null)
                    hash = hash * 59 + this.RenewPeriod.GetHashCode();
                    if (this.RenewPeriodUnitOfTime != null)
                    hash = hash * 59 + this.RenewPeriodUnitOfTime.GetHashCode();
                    if (this.SubscriptionId != null)
                    hash = hash * 59 + this.SubscriptionId.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(SubscriptionPlan left, SubscriptionPlan right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SubscriptionPlan left, SubscriptionPlan right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
