/*
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://knetikcloud.com
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
    public partial class WalletTotalResponse :  IEquatable<WalletTotalResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletTotalResponse" /> class.
        /// </summary>
        /// <param name="CurrencyCode">The currency code.</param>
        /// <param name="Total">The sum of all wallets in the system for this currency.</param>
        public WalletTotalResponse(string CurrencyCode = default(string), double? Total = default(double?))
        {
            this.CurrencyCode = CurrencyCode;
            this.Total = Total;
            
        }

        /// <summary>
        /// The currency code
        /// </summary>
        /// <value>The currency code</value>
        [DataMember(Name="currency_code")]
        public string CurrencyCode { get; set; }
        /// <summary>
        /// The sum of all wallets in the system for this currency
        /// </summary>
        /// <value>The sum of all wallets in the system for this currency</value>
        [DataMember(Name="total")]
        public double? Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WalletTotalResponse {\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return Equals((WalletTotalResponse)obj);
        }

        /// <summary>
        /// Returns true if WalletTotalResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of WalletTotalResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WalletTotalResponse other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
                ) && 
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
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
                    if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
                    if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(WalletTotalResponse left, WalletTotalResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(WalletTotalResponse left, WalletTotalResponse right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
