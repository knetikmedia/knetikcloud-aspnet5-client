/*
 * Knetik Platform API Documentation Latest
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
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
    public partial class PaymentMethodResource :  IEquatable<PaymentMethodResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodResource" /> class.
        /// </summary>
        /// <param name="CreatedDate">The date/time this resource was created in seconds since unix epoch.</param>
        /// <param name="Default">Default.</param>
        /// <param name="Disabled">Whether this payment method is disabled or not.</param>
        /// <param name="ExpirationDate">The expiration date for the payment method, expressed as seconds since epoch. Typically used for credit card payment methods.</param>
        /// <param name="ExpirationMonth">The expiration month (1 - 12) for the payment method. Typically used for credit card payment methods.</param>
        /// <param name="ExpirationYear">The expiration year for the payment method. Typically used for credit card payment methods.</param>
        /// <param name="Id">The unique ID for that resource.</param>
        /// <param name="Last4">The last 4 digits of the account number for the payment method. Typically used for credit card payment methods.</param>
        /// <param name="LongDescription">The user friendly name of that resource. Defaults to blank string.</param>
        /// <param name="Name">The user friendly name of that resource (required).</param>
        /// <param name="PaymentMethodType">The type of payment method. Must be a pre-existing value (required).</param>
        /// <param name="PaymentType">The generic payment type. Default is card.</param>
        /// <param name="ShortDescription">The user friendly name of that resource. Defaults to blank string.</param>
        /// <param name="Sort">The sort value for the payment method.</param>
        /// <param name="Token">The unique token for the payment method.</param>
        /// <param name="UniqueKey">An optional unique identifier.</param>
        /// <param name="UpdatedDate">The date/time this resource was last updated in seconds since unix epoch.</param>
        /// <param name="UserId">The user&#39;s id. If null, indicates a shared payment method that any user can use (i.e., &#39;wallet&#39;).</param>
        /// <param name="Verified">Verified.</param>
        public PaymentMethodResource(long? CreatedDate = null, bool? Default = null, bool? Disabled = null, long? ExpirationDate = null, int? ExpirationMonth = null, int? ExpirationYear = null, long? Id = null, string Last4 = null, string LongDescription = null, string Name = null, PaymentMethodTypeResource PaymentMethodType = null, string PaymentType = null, string ShortDescription = null, int? Sort = null, string Token = null, string UniqueKey = null, long? UpdatedDate = null, int? UserId = null, bool? Verified = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for PaymentMethodResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "PaymentMethodType" is required (not null)
            if (PaymentMethodType == null)
            {
                throw new InvalidDataException("PaymentMethodType is a required property for PaymentMethodResource and cannot be null");
            }
            else
            {
                this.PaymentMethodType = PaymentMethodType;
            }
            this.CreatedDate = CreatedDate;
            this.Default = Default;
            this.Disabled = Disabled;
            this.ExpirationDate = ExpirationDate;
            this.ExpirationMonth = ExpirationMonth;
            this.ExpirationYear = ExpirationYear;
            this.Id = Id;
            this.Last4 = Last4;
            this.LongDescription = LongDescription;
            this.PaymentType = PaymentType;
            this.ShortDescription = ShortDescription;
            this.Sort = Sort;
            this.Token = Token;
            this.UniqueKey = UniqueKey;
            this.UpdatedDate = UpdatedDate;
            this.UserId = UserId;
            this.Verified = Verified;
            
        }

        /// <summary>
        /// The date/time this resource was created in seconds since unix epoch
        /// </summary>
        /// <value>The date/time this resource was created in seconds since unix epoch</value>
        [DataMember(Name="created_date")]
        public long? CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets Default
        /// </summary>
        [DataMember(Name="default")]
        public bool? Default { get; set; }

        /// <summary>
        /// Whether this payment method is disabled or not
        /// </summary>
        /// <value>Whether this payment method is disabled or not</value>
        [DataMember(Name="disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// The expiration date for the payment method, expressed as seconds since epoch. Typically used for credit card payment methods
        /// </summary>
        /// <value>The expiration date for the payment method, expressed as seconds since epoch. Typically used for credit card payment methods</value>
        [DataMember(Name="expiration_date")]
        public long? ExpirationDate { get; set; }

        /// <summary>
        /// The expiration month (1 - 12) for the payment method. Typically used for credit card payment methods
        /// </summary>
        /// <value>The expiration month (1 - 12) for the payment method. Typically used for credit card payment methods</value>
        [DataMember(Name="expiration_month")]
        public int? ExpirationMonth { get; set; }

        /// <summary>
        /// The expiration year for the payment method. Typically used for credit card payment methods
        /// </summary>
        /// <value>The expiration year for the payment method. Typically used for credit card payment methods</value>
        [DataMember(Name="expiration_year")]
        public int? ExpirationYear { get; set; }

        /// <summary>
        /// The unique ID for that resource
        /// </summary>
        /// <value>The unique ID for that resource</value>
        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// The last 4 digits of the account number for the payment method. Typically used for credit card payment methods
        /// </summary>
        /// <value>The last 4 digits of the account number for the payment method. Typically used for credit card payment methods</value>
        [DataMember(Name="last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// The user friendly name of that resource. Defaults to blank string
        /// </summary>
        /// <value>The user friendly name of that resource. Defaults to blank string</value>
        [DataMember(Name="long_description")]
        public string LongDescription { get; set; }

        /// <summary>
        /// The user friendly name of that resource
        /// </summary>
        /// <value>The user friendly name of that resource</value>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// The type of payment method. Must be a pre-existing value
        /// </summary>
        /// <value>The type of payment method. Must be a pre-existing value</value>
        [DataMember(Name="payment_method_type")]
        public PaymentMethodTypeResource PaymentMethodType { get; set; }

        /// <summary>
        /// The generic payment type. Default is card
        /// </summary>
        /// <value>The generic payment type. Default is card</value>
        [DataMember(Name="payment_type")]
        public string PaymentType { get; set; }

        /// <summary>
        /// The user friendly name of that resource. Defaults to blank string
        /// </summary>
        /// <value>The user friendly name of that resource. Defaults to blank string</value>
        [DataMember(Name="short_description")]
        public string ShortDescription { get; set; }

        /// <summary>
        /// The sort value for the payment method
        /// </summary>
        /// <value>The sort value for the payment method</value>
        [DataMember(Name="sort")]
        public int? Sort { get; set; }

        /// <summary>
        /// The unique token for the payment method
        /// </summary>
        /// <value>The unique token for the payment method</value>
        [DataMember(Name="token")]
        public string Token { get; set; }

        /// <summary>
        /// An optional unique identifier
        /// </summary>
        /// <value>An optional unique identifier</value>
        [DataMember(Name="unique_key")]
        public string UniqueKey { get; set; }

        /// <summary>
        /// The date/time this resource was last updated in seconds since unix epoch
        /// </summary>
        /// <value>The date/time this resource was last updated in seconds since unix epoch</value>
        [DataMember(Name="updated_date")]
        public long? UpdatedDate { get; set; }

        /// <summary>
        /// The user's id. If null, indicates a shared payment method that any user can use (i.e., 'wallet')
        /// </summary>
        /// <value>The user's id. If null, indicates a shared payment method that any user can use (i.e., 'wallet')</value>
        [DataMember(Name="user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or Sets Verified
        /// </summary>
        [DataMember(Name="verified")]
        public bool? Verified { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentMethodResource {\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  ExpirationMonth: ").Append(ExpirationMonth).Append("\n");
            sb.Append("  ExpirationYear: ").Append(ExpirationYear).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Last4: ").Append(Last4).Append("\n");
            sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PaymentMethodType: ").Append(PaymentMethodType).Append("\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  UniqueKey: ").Append(UniqueKey).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Verified: ").Append(Verified).Append("\n");
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
            return Equals((PaymentMethodResource)obj);
        }

        /// <summary>
        /// Returns true if PaymentMethodResource instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentMethodResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.Default == other.Default ||
                    this.Default != null &&
                    this.Default.Equals(other.Default)
                ) && 
                (
                    this.Disabled == other.Disabled ||
                    this.Disabled != null &&
                    this.Disabled.Equals(other.Disabled)
                ) && 
                (
                    this.ExpirationDate == other.ExpirationDate ||
                    this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(other.ExpirationDate)
                ) && 
                (
                    this.ExpirationMonth == other.ExpirationMonth ||
                    this.ExpirationMonth != null &&
                    this.ExpirationMonth.Equals(other.ExpirationMonth)
                ) && 
                (
                    this.ExpirationYear == other.ExpirationYear ||
                    this.ExpirationYear != null &&
                    this.ExpirationYear.Equals(other.ExpirationYear)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Last4 == other.Last4 ||
                    this.Last4 != null &&
                    this.Last4.Equals(other.Last4)
                ) && 
                (
                    this.LongDescription == other.LongDescription ||
                    this.LongDescription != null &&
                    this.LongDescription.Equals(other.LongDescription)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PaymentMethodType == other.PaymentMethodType ||
                    this.PaymentMethodType != null &&
                    this.PaymentMethodType.Equals(other.PaymentMethodType)
                ) && 
                (
                    this.PaymentType == other.PaymentType ||
                    this.PaymentType != null &&
                    this.PaymentType.Equals(other.PaymentType)
                ) && 
                (
                    this.ShortDescription == other.ShortDescription ||
                    this.ShortDescription != null &&
                    this.ShortDescription.Equals(other.ShortDescription)
                ) && 
                (
                    this.Sort == other.Sort ||
                    this.Sort != null &&
                    this.Sort.Equals(other.Sort)
                ) && 
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
                ) && 
                (
                    this.UniqueKey == other.UniqueKey ||
                    this.UniqueKey != null &&
                    this.UniqueKey.Equals(other.UniqueKey)
                ) && 
                (
                    this.UpdatedDate == other.UpdatedDate ||
                    this.UpdatedDate != null &&
                    this.UpdatedDate.Equals(other.UpdatedDate)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.Verified == other.Verified ||
                    this.Verified != null &&
                    this.Verified.Equals(other.Verified)
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
                    if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                    if (this.Default != null)
                    hash = hash * 59 + this.Default.GetHashCode();
                    if (this.Disabled != null)
                    hash = hash * 59 + this.Disabled.GetHashCode();
                    if (this.ExpirationDate != null)
                    hash = hash * 59 + this.ExpirationDate.GetHashCode();
                    if (this.ExpirationMonth != null)
                    hash = hash * 59 + this.ExpirationMonth.GetHashCode();
                    if (this.ExpirationYear != null)
                    hash = hash * 59 + this.ExpirationYear.GetHashCode();
                    if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                    if (this.Last4 != null)
                    hash = hash * 59 + this.Last4.GetHashCode();
                    if (this.LongDescription != null)
                    hash = hash * 59 + this.LongDescription.GetHashCode();
                    if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                    if (this.PaymentMethodType != null)
                    hash = hash * 59 + this.PaymentMethodType.GetHashCode();
                    if (this.PaymentType != null)
                    hash = hash * 59 + this.PaymentType.GetHashCode();
                    if (this.ShortDescription != null)
                    hash = hash * 59 + this.ShortDescription.GetHashCode();
                    if (this.Sort != null)
                    hash = hash * 59 + this.Sort.GetHashCode();
                    if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();
                    if (this.UniqueKey != null)
                    hash = hash * 59 + this.UniqueKey.GetHashCode();
                    if (this.UpdatedDate != null)
                    hash = hash * 59 + this.UpdatedDate.GetHashCode();
                    if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                    if (this.Verified != null)
                    hash = hash * 59 + this.Verified.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(PaymentMethodResource left, PaymentMethodResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PaymentMethodResource left, PaymentMethodResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
