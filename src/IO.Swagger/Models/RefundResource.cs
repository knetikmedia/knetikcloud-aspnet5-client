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
    public partial class RefundResource :  IEquatable<RefundResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundResource" /> class.
        /// </summary>
        /// <param name="Amount">The amount refunded.</param>
        /// <param name="RefundTransactionId">The id of the refund transaction.</param>
        /// <param name="TransactionId">The id of the original transaction.</param>
        public RefundResource(double? Amount = null, int? RefundTransactionId = null, int? TransactionId = null)
        {
            this.Amount = Amount;
            this.RefundTransactionId = RefundTransactionId;
            this.TransactionId = TransactionId;
            
        }

        /// <summary>
        /// The amount refunded
        /// </summary>
        /// <value>The amount refunded</value>
        [DataMember(Name="amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// The id of the refund transaction
        /// </summary>
        /// <value>The id of the refund transaction</value>
        [DataMember(Name="refund_transaction_id")]
        public int? RefundTransactionId { get; set; }

        /// <summary>
        /// The id of the original transaction
        /// </summary>
        /// <value>The id of the original transaction</value>
        [DataMember(Name="transaction_id")]
        public int? TransactionId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefundResource {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  RefundTransactionId: ").Append(RefundTransactionId).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
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
            return Equals((RefundResource)obj);
        }

        /// <summary>
        /// Returns true if RefundResource instances are equal
        /// </summary>
        /// <param name="other">Instance of RefundResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefundResource other)
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
                    this.RefundTransactionId == other.RefundTransactionId ||
                    this.RefundTransactionId != null &&
                    this.RefundTransactionId.Equals(other.RefundTransactionId)
                ) && 
                (
                    this.TransactionId == other.TransactionId ||
                    this.TransactionId != null &&
                    this.TransactionId.Equals(other.TransactionId)
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
                    if (this.RefundTransactionId != null)
                    hash = hash * 59 + this.RefundTransactionId.GetHashCode();
                    if (this.TransactionId != null)
                    hash = hash * 59 + this.TransactionId.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(RefundResource left, RefundResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RefundResource left, RefundResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
