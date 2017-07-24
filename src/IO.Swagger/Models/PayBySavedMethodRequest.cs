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
    public partial class PayBySavedMethodRequest :  IEquatable<PayBySavedMethodRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PayBySavedMethodRequest" /> class.
        /// </summary>
        /// <param name="PaymentMethod">The id of the payment method to use. Must belong to the caller, be public or have PAYMENTS_ADMIN permission (required).</param>
        public PayBySavedMethodRequest(int? PaymentMethod = default(int?))
        {
            // to ensure "PaymentMethod" is required (not null)
            if (PaymentMethod == null)
            {
                throw new InvalidDataException("PaymentMethod is a required property for PayBySavedMethodRequest and cannot be null");
            }
            else
            {
                this.PaymentMethod = PaymentMethod;
            }
            
        }

        /// <summary>
        /// The id of the payment method to use. Must belong to the caller, be public or have PAYMENTS_ADMIN permission
        /// </summary>
        /// <value>The id of the payment method to use. Must belong to the caller, be public or have PAYMENTS_ADMIN permission</value>
        [DataMember(Name="payment_method")]
        public int? PaymentMethod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayBySavedMethodRequest {\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
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
            return Equals((PayBySavedMethodRequest)obj);
        }

        /// <summary>
        /// Returns true if PayBySavedMethodRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of PayBySavedMethodRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayBySavedMethodRequest other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.PaymentMethod == other.PaymentMethod ||
                    this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(other.PaymentMethod)
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
                    if (this.PaymentMethod != null)
                    hash = hash * 59 + this.PaymentMethod.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(PayBySavedMethodRequest left, PayBySavedMethodRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PayBySavedMethodRequest left, PayBySavedMethodRequest right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
