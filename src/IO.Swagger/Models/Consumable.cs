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
    public partial class Consumable : Behavior,  IEquatable<Consumable>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Consumable" /> class.
        /// </summary>
        /// <param name="Description">Description.</param>
        /// <param name="TypeHint">Used for polymorphic type recognition and thus must match an expected type with additional properties.</param>
        /// <param name="MaxUse">The maximum number of times an item can be used.</param>
        public Consumable(string Description = default(string), string TypeHint = default(string), int? MaxUse = default(int?))
        {
            this.Description = Description;
            this.TypeHint = TypeHint;
            this.MaxUse = MaxUse;
            
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description")]
        public string Description { get; set; }
        /// <summary>
        /// Used for polymorphic type recognition and thus must match an expected type with additional properties
        /// </summary>
        /// <value>Used for polymorphic type recognition and thus must match an expected type with additional properties</value>
        [DataMember(Name="type_hint")]
        public string TypeHint { get; set; }
        /// <summary>
        /// The maximum number of times an item can be used
        /// </summary>
        /// <value>The maximum number of times an item can be used</value>
        [DataMember(Name="max_use")]
        public int? MaxUse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Consumable {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  TypeHint: ").Append(TypeHint).Append("\n");
            sb.Append("  MaxUse: ").Append(MaxUse).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            return Equals((Consumable)obj);
        }

        /// <summary>
        /// Returns true if Consumable instances are equal
        /// </summary>
        /// <param name="other">Instance of Consumable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Consumable other)
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
                    this.TypeHint == other.TypeHint ||
                    this.TypeHint != null &&
                    this.TypeHint.Equals(other.TypeHint)
                ) && 
                (
                    this.MaxUse == other.MaxUse ||
                    this.MaxUse != null &&
                    this.MaxUse.Equals(other.MaxUse)
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
                    if (this.TypeHint != null)
                    hash = hash * 59 + this.TypeHint.GetHashCode();
                    if (this.MaxUse != null)
                    hash = hash * 59 + this.MaxUse.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(Consumable left, Consumable right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Consumable left, Consumable right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
