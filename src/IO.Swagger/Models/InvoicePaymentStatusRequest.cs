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
    public partial class InvoicePaymentStatusRequest :  IEquatable<InvoicePaymentStatusRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicePaymentStatusRequest" /> class.
        /// </summary>
        /// <param name="PaymentMethodId">If included, will set the payment method used on the invoice.</param>
        /// <param name="Status">The new status for the invoice. Additional options may be available based on configuration.  Allowable values: &#39;new&#39;, &#39;paid&#39;, &#39;hold&#39;, &#39;canceled&#39;, &#39;payment failed&#39;, &#39;partial refund&#39;, &#39;refund&#39; (required).</param>
        public InvoicePaymentStatusRequest(int? PaymentMethodId = default(int?), string Status = default(string))
        {
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for InvoicePaymentStatusRequest and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            this.PaymentMethodId = PaymentMethodId;
            
        }

        /// <summary>
        /// If included, will set the payment method used on the invoice
        /// </summary>
        /// <value>If included, will set the payment method used on the invoice</value>
        [DataMember(Name="payment_method_id")]
        public int? PaymentMethodId { get; set; }
        /// <summary>
        /// The new status for the invoice. Additional options may be available based on configuration.  Allowable values: &#39;new&#39;, &#39;paid&#39;, &#39;hold&#39;, &#39;canceled&#39;, &#39;payment failed&#39;, &#39;partial refund&#39;, &#39;refund&#39;
        /// </summary>
        /// <value>The new status for the invoice. Additional options may be available based on configuration.  Allowable values: &#39;new&#39;, &#39;paid&#39;, &#39;hold&#39;, &#39;canceled&#39;, &#39;payment failed&#39;, &#39;partial refund&#39;, &#39;refund&#39;</value>
        [DataMember(Name="status")]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoicePaymentStatusRequest {\n");
            sb.Append("  PaymentMethodId: ").Append(PaymentMethodId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return Equals((InvoicePaymentStatusRequest)obj);
        }

        /// <summary>
        /// Returns true if InvoicePaymentStatusRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of InvoicePaymentStatusRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoicePaymentStatusRequest other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.PaymentMethodId == other.PaymentMethodId ||
                    this.PaymentMethodId != null &&
                    this.PaymentMethodId.Equals(other.PaymentMethodId)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                    if (this.PaymentMethodId != null)
                    hash = hash * 59 + this.PaymentMethodId.GetHashCode();
                    if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(InvoicePaymentStatusRequest left, InvoicePaymentStatusRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InvoicePaymentStatusRequest left, InvoicePaymentStatusRequest right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
