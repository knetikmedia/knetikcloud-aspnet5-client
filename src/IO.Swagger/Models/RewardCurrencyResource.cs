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
    public partial class RewardCurrencyResource :  IEquatable<RewardCurrencyResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RewardCurrencyResource" /> class.
        /// </summary>
        /// <param name="CurrencyCode">The code of the currency type to give (required).</param>
        /// <param name="CurrencyName">The name of the currency reward to give.  Set by currency_code).</param>
        /// <param name="MaxRank">The highest number (worst) rank to give the reward to. Must be greater than or equal to minRank (required).</param>
        /// <param name="MinRank">The lowest number (best) rank to give the reward to. Must be greater than zero (required).</param>
        /// <param name="Percent">True if the value is actually a percentage of the intake (required).</param>
        /// <param name="Value">The amount of currency to give. For percentage values, 0.5 is 50% (required).</param>
        public RewardCurrencyResource(string CurrencyCode = null, string CurrencyName = null, int? MaxRank = null, int? MinRank = null, bool? Percent = null, double? Value = null)
        {
            // to ensure "CurrencyCode" is required (not null)
            if (CurrencyCode == null)
            {
                throw new InvalidDataException("CurrencyCode is a required property for RewardCurrencyResource and cannot be null");
            }
            else
            {
                this.CurrencyCode = CurrencyCode;
            }
            // to ensure "MaxRank" is required (not null)
            if (MaxRank == null)
            {
                throw new InvalidDataException("MaxRank is a required property for RewardCurrencyResource and cannot be null");
            }
            else
            {
                this.MaxRank = MaxRank;
            }
            // to ensure "MinRank" is required (not null)
            if (MinRank == null)
            {
                throw new InvalidDataException("MinRank is a required property for RewardCurrencyResource and cannot be null");
            }
            else
            {
                this.MinRank = MinRank;
            }
            // to ensure "Percent" is required (not null)
            if (Percent == null)
            {
                throw new InvalidDataException("Percent is a required property for RewardCurrencyResource and cannot be null");
            }
            else
            {
                this.Percent = Percent;
            }
            // to ensure "Value" is required (not null)
            if (Value == null)
            {
                throw new InvalidDataException("Value is a required property for RewardCurrencyResource and cannot be null");
            }
            else
            {
                this.Value = Value;
            }
            this.CurrencyName = CurrencyName;
            
        }

        /// <summary>
        /// The code of the currency type to give
        /// </summary>
        /// <value>The code of the currency type to give</value>
        [DataMember(Name="currency_code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The name of the currency reward to give.  Set by currency_code)
        /// </summary>
        /// <value>The name of the currency reward to give.  Set by currency_code)</value>
        [DataMember(Name="currency_name")]
        public string CurrencyName { get; set; }

        /// <summary>
        /// The highest number (worst) rank to give the reward to. Must be greater than or equal to minRank
        /// </summary>
        /// <value>The highest number (worst) rank to give the reward to. Must be greater than or equal to minRank</value>
        [DataMember(Name="max_rank")]
        public int? MaxRank { get; set; }

        /// <summary>
        /// The lowest number (best) rank to give the reward to. Must be greater than zero
        /// </summary>
        /// <value>The lowest number (best) rank to give the reward to. Must be greater than zero</value>
        [DataMember(Name="min_rank")]
        public int? MinRank { get; set; }

        /// <summary>
        /// True if the value is actually a percentage of the intake
        /// </summary>
        /// <value>True if the value is actually a percentage of the intake</value>
        [DataMember(Name="percent")]
        public bool? Percent { get; set; }

        /// <summary>
        /// The amount of currency to give. For percentage values, 0.5 is 50%
        /// </summary>
        /// <value>The amount of currency to give. For percentage values, 0.5 is 50%</value>
        [DataMember(Name="value")]
        public double? Value { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RewardCurrencyResource {\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CurrencyName: ").Append(CurrencyName).Append("\n");
            sb.Append("  MaxRank: ").Append(MaxRank).Append("\n");
            sb.Append("  MinRank: ").Append(MinRank).Append("\n");
            sb.Append("  Percent: ").Append(Percent).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return Equals((RewardCurrencyResource)obj);
        }

        /// <summary>
        /// Returns true if RewardCurrencyResource instances are equal
        /// </summary>
        /// <param name="other">Instance of RewardCurrencyResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RewardCurrencyResource other)
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
                    this.CurrencyName == other.CurrencyName ||
                    this.CurrencyName != null &&
                    this.CurrencyName.Equals(other.CurrencyName)
                ) && 
                (
                    this.MaxRank == other.MaxRank ||
                    this.MaxRank != null &&
                    this.MaxRank.Equals(other.MaxRank)
                ) && 
                (
                    this.MinRank == other.MinRank ||
                    this.MinRank != null &&
                    this.MinRank.Equals(other.MinRank)
                ) && 
                (
                    this.Percent == other.Percent ||
                    this.Percent != null &&
                    this.Percent.Equals(other.Percent)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                    if (this.CurrencyName != null)
                    hash = hash * 59 + this.CurrencyName.GetHashCode();
                    if (this.MaxRank != null)
                    hash = hash * 59 + this.MaxRank.GetHashCode();
                    if (this.MinRank != null)
                    hash = hash * 59 + this.MinRank.GetHashCode();
                    if (this.Percent != null)
                    hash = hash * 59 + this.Percent.GetHashCode();
                    if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(RewardCurrencyResource left, RewardCurrencyResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RewardCurrencyResource left, RewardCurrencyResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
