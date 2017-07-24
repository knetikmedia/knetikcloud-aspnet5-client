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
    public partial class StripePaymentRequest :  IEquatable<StripePaymentRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="StripePaymentRequest" /> class.
        /// </summary>
        /// <param name="InvoiceId">The id of the invoice to pay (required).</param>
        /// <param name="Token">A token from Stripe to identify payment info to be tied to the customer (required).</param>
        public StripePaymentRequest(int? InvoiceId = default(int?), string Token = default(string))
        {
            // to ensure "InvoiceId" is required (not null)
            if (InvoiceId == null)
            {
                throw new InvalidDataException("InvoiceId is a required property for StripePaymentRequest and cannot be null");
            }
            else
            {
                this.InvoiceId = InvoiceId;
            }
            // to ensure "Token" is required (not null)
            if (Token == null)
            {
                throw new InvalidDataException("Token is a required property for StripePaymentRequest and cannot be null");
            }
            else
            {
                this.Token = Token;
            }
            
        }

        /// <summary>
        /// The id of the invoice to pay
        /// </summary>
        /// <value>The id of the invoice to pay</value>
        [DataMember(Name="invoice_id")]
        public int? InvoiceId { get; set; }
        /// <summary>
        /// A token from Stripe to identify payment info to be tied to the customer
        /// </summary>
        /// <value>A token from Stripe to identify payment info to be tied to the customer</value>
        [DataMember(Name="token")]
        public string Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StripePaymentRequest {\n");
            sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return Equals((StripePaymentRequest)obj);
        }

        /// <summary>
        /// Returns true if StripePaymentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of StripePaymentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StripePaymentRequest other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.InvoiceId == other.InvoiceId ||
                    this.InvoiceId != null &&
                    this.InvoiceId.Equals(other.InvoiceId)
                ) && 
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
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
                    if (this.InvoiceId != null)
                    hash = hash * 59 + this.InvoiceId.GetHashCode();
                    if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(StripePaymentRequest left, StripePaymentRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(StripePaymentRequest left, StripePaymentRequest right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
