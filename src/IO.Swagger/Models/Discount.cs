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
    public partial class Discount :  IEquatable<Discount>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Discount" /> class.
        /// </summary>
        /// <param name="Description">Description.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Sku">Sku.</param>
        /// <param name="UniqueKey">UniqueKey.</param>
        /// <param name="Value">Value.</param>
        public Discount(string Description = default(string), string Name = default(string), string Sku = default(string), string UniqueKey = default(string), double? Value = default(double?))
        {
            this.Description = Description;
            this.Name = Name;
            this.Sku = Sku;
            this.UniqueKey = UniqueKey;
            this.Value = Value;
            
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description")]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name")]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="sku")]
        public string Sku { get; set; }
        /// <summary>
        /// Gets or Sets UniqueKey
        /// </summary>
        [DataMember(Name="unique_key")]
        public string UniqueKey { get; set; }
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value")]
        public double? Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Discount {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  UniqueKey: ").Append(UniqueKey).Append("\n");
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
            return Equals((Discount)obj);
        }

        /// <summary>
        /// Returns true if Discount instances are equal
        /// </summary>
        /// <param name="other">Instance of Discount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Discount other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Sku == other.Sku ||
                    this.Sku != null &&
                    this.Sku.Equals(other.Sku)
                ) && 
                (
                    this.UniqueKey == other.UniqueKey ||
                    this.UniqueKey != null &&
                    this.UniqueKey.Equals(other.UniqueKey)
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
                    if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                    if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                    if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                    if (this.UniqueKey != null)
                    hash = hash * 59 + this.UniqueKey.GetHashCode();
                    if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(Discount left, Discount right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Discount left, Discount right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
