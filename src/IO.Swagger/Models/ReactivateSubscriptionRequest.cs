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
    public partial class ReactivateSubscriptionRequest :  IEquatable<ReactivateSubscriptionRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReactivateSubscriptionRequest" /> class.
        /// </summary>
        /// <param name="InventoryId">The inventory to reactivate. Only required if using the deprecated subscriptions service.</param>
        /// <param name="ReactivationFee">Whether to add the additional reactivation fee in addition to the recurring fee.</param>
        public ReactivateSubscriptionRequest(int? InventoryId = null, bool? ReactivationFee = null)
        {
            this.InventoryId = InventoryId;
            this.ReactivationFee = ReactivationFee;
            
        }

        /// <summary>
        /// The inventory to reactivate. Only required if using the deprecated subscriptions service
        /// </summary>
        /// <value>The inventory to reactivate. Only required if using the deprecated subscriptions service</value>
        [DataMember(Name="inventory_id")]
        public int? InventoryId { get; set; }

        /// <summary>
        /// Whether to add the additional reactivation fee in addition to the recurring fee
        /// </summary>
        /// <value>Whether to add the additional reactivation fee in addition to the recurring fee</value>
        [DataMember(Name="reactivation_fee")]
        public bool? ReactivationFee { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReactivateSubscriptionRequest {\n");
            sb.Append("  InventoryId: ").Append(InventoryId).Append("\n");
            sb.Append("  ReactivationFee: ").Append(ReactivationFee).Append("\n");
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
            return Equals((ReactivateSubscriptionRequest)obj);
        }

        /// <summary>
        /// Returns true if ReactivateSubscriptionRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ReactivateSubscriptionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReactivateSubscriptionRequest other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.InventoryId == other.InventoryId ||
                    this.InventoryId != null &&
                    this.InventoryId.Equals(other.InventoryId)
                ) && 
                (
                    this.ReactivationFee == other.ReactivationFee ||
                    this.ReactivationFee != null &&
                    this.ReactivationFee.Equals(other.ReactivationFee)
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
                    if (this.InventoryId != null)
                    hash = hash * 59 + this.InventoryId.GetHashCode();
                    if (this.ReactivationFee != null)
                    hash = hash * 59 + this.ReactivationFee.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(ReactivateSubscriptionRequest left, ReactivateSubscriptionRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ReactivateSubscriptionRequest left, ReactivateSubscriptionRequest right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
