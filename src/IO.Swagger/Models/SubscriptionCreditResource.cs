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
    public partial class SubscriptionCreditResource :  IEquatable<SubscriptionCreditResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionCreditResource" /> class.
        /// </summary>
        /// <param name="Amount">The amount of the credit, negative for debt (required).</param>
        /// <param name="CreatedDate">The date this credit was added, unix timestamp in seconds.</param>
        /// <param name="Id">The id of the credit record.</param>
        /// <param name="InventoryId">The id of the subscription inventory entry.</param>
        /// <param name="Reason">The reason for the subscription credit (required).</param>
        public SubscriptionCreditResource(double? Amount = null, long? CreatedDate = null, int? Id = null, int? InventoryId = null, string Reason = null)
        {
            // to ensure "Amount" is required (not null)
            if (Amount == null)
            {
                throw new InvalidDataException("Amount is a required property for SubscriptionCreditResource and cannot be null");
            }
            else
            {
                this.Amount = Amount;
            }
            // to ensure "Reason" is required (not null)
            if (Reason == null)
            {
                throw new InvalidDataException("Reason is a required property for SubscriptionCreditResource and cannot be null");
            }
            else
            {
                this.Reason = Reason;
            }
            this.CreatedDate = CreatedDate;
            this.Id = Id;
            this.InventoryId = InventoryId;
            
        }

        /// <summary>
        /// The amount of the credit, negative for debt
        /// </summary>
        /// <value>The amount of the credit, negative for debt</value>
        [DataMember(Name="amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// The date this credit was added, unix timestamp in seconds
        /// </summary>
        /// <value>The date this credit was added, unix timestamp in seconds</value>
        [DataMember(Name="created_date")]
        public long? CreatedDate { get; set; }

        /// <summary>
        /// The id of the credit record
        /// </summary>
        /// <value>The id of the credit record</value>
        [DataMember(Name="id")]
        public int? Id { get; set; }

        /// <summary>
        /// The id of the subscription inventory entry
        /// </summary>
        /// <value>The id of the subscription inventory entry</value>
        [DataMember(Name="inventory_id")]
        public int? InventoryId { get; set; }

        /// <summary>
        /// The reason for the subscription credit
        /// </summary>
        /// <value>The reason for the subscription credit</value>
        [DataMember(Name="reason")]
        public string Reason { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionCreditResource {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InventoryId: ").Append(InventoryId).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
            return Equals((SubscriptionCreditResource)obj);
        }

        /// <summary>
        /// Returns true if SubscriptionCreditResource instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionCreditResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionCreditResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.InventoryId == other.InventoryId ||
                    this.InventoryId != null &&
                    this.InventoryId.Equals(other.InventoryId)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
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
                    if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                    if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                    if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                    if (this.InventoryId != null)
                    hash = hash * 59 + this.InventoryId.GetHashCode();
                    if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(SubscriptionCreditResource left, SubscriptionCreditResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SubscriptionCreditResource left, SubscriptionCreditResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
