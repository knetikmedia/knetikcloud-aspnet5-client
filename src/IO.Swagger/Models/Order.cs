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
    public partial class Order :  IEquatable<Order>
    {
                /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        public enum DirectionEnum
        {
            
            /// <summary>
            /// Enum ASCEnum for "ASC"
            /// </summary>
            [EnumMember(Value = "ASC")]
            ASCEnum,
            
            /// <summary>
            /// Enum DESCEnum for "DESC"
            /// </summary>
            [EnumMember(Value = "DESC")]
            DESCEnum
        }
                /// <summary>
        /// Gets or Sets NullHandling
        /// </summary>
        public enum NullHandlingEnum
        {
            
            /// <summary>
            /// Enum NATIVEEnum for "NATIVE"
            /// </summary>
            [EnumMember(Value = "NATIVE")]
            NATIVEEnum,
            
            /// <summary>
            /// Enum NULLSFIRSTEnum for "NULLS_FIRST"
            /// </summary>
            [EnumMember(Value = "NULLS_FIRST")]
            NULLSFIRSTEnum,
            
            /// <summary>
            /// Enum NULLSLASTEnum for "NULLS_LAST"
            /// </summary>
            [EnumMember(Value = "NULLS_LAST")]
            NULLSLASTEnum
        }
        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name="direction")]
        public DirectionEnum? Direction { get; set; }
        /// <summary>
        /// Gets or Sets NullHandling
        /// </summary>
        [DataMember(Name="null_handling")]
        public NullHandlingEnum? NullHandling { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Order" /> class.
        /// </summary>
        /// <param name="Ascending">Ascending.</param>
        /// <param name="Direction">Direction.</param>
        /// <param name="IgnoreCase">IgnoreCase.</param>
        /// <param name="NullHandling">NullHandling.</param>
        /// <param name="Property">Property.</param>
        public Order(bool? Ascending = default(bool?), DirectionEnum? Direction = default(DirectionEnum?), bool? IgnoreCase = default(bool?), NullHandlingEnum? NullHandling = default(NullHandlingEnum?), string Property = default(string))
        {
            this.Ascending = Ascending;
            this.Direction = Direction;
            this.IgnoreCase = IgnoreCase;
            this.NullHandling = NullHandling;
            this.Property = Property;
            
        }

        /// <summary>
        /// Gets or Sets Ascending
        /// </summary>
        [DataMember(Name="ascending")]
        public bool? Ascending { get; set; }
        /// <summary>
        /// Gets or Sets IgnoreCase
        /// </summary>
        [DataMember(Name="ignore_case")]
        public bool? IgnoreCase { get; set; }
        /// <summary>
        /// Gets or Sets Property
        /// </summary>
        [DataMember(Name="property")]
        public string Property { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Order {\n");
            sb.Append("  Ascending: ").Append(Ascending).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  IgnoreCase: ").Append(IgnoreCase).Append("\n");
            sb.Append("  NullHandling: ").Append(NullHandling).Append("\n");
            sb.Append("  Property: ").Append(Property).Append("\n");
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
            return Equals((Order)obj);
        }

        /// <summary>
        /// Returns true if Order instances are equal
        /// </summary>
        /// <param name="other">Instance of Order to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Order other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Ascending == other.Ascending ||
                    this.Ascending != null &&
                    this.Ascending.Equals(other.Ascending)
                ) && 
                (
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
                ) && 
                (
                    this.IgnoreCase == other.IgnoreCase ||
                    this.IgnoreCase != null &&
                    this.IgnoreCase.Equals(other.IgnoreCase)
                ) && 
                (
                    this.NullHandling == other.NullHandling ||
                    this.NullHandling != null &&
                    this.NullHandling.Equals(other.NullHandling)
                ) && 
                (
                    this.Property == other.Property ||
                    this.Property != null &&
                    this.Property.Equals(other.Property)
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
                    if (this.Ascending != null)
                    hash = hash * 59 + this.Ascending.GetHashCode();
                    if (this.Direction != null)
                    hash = hash * 59 + this.Direction.GetHashCode();
                    if (this.IgnoreCase != null)
                    hash = hash * 59 + this.IgnoreCase.GetHashCode();
                    if (this.NullHandling != null)
                    hash = hash * 59 + this.NullHandling.GetHashCode();
                    if (this.Property != null)
                    hash = hash * 59 + this.Property.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(Order left, Order right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Order left, Order right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
