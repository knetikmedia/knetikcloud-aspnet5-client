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
    public partial class LookupTypeResource :  IEquatable<LookupTypeResource>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LookupTypeResource" /> class.
        /// </summary>
        /// <param name="Description">The description of the expression type (required).</param>
        /// <param name="KeyType">The variable type the key expression must be, or null if it&#39;s dependent (see description for explanation in this case) (required).</param>
        /// <param name="Name">The name of the expression type (required).</param>
        /// <param name="ValueType">The variable type of the value this expression returns, or null if it&#39;s dependent (see description for explanation in this case) (required).</param>
        public LookupTypeResource(string Description = default(string), string KeyType = default(string), string Name = default(string), string ValueType = default(string))
        {
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for LookupTypeResource and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            // to ensure "KeyType" is required (not null)
            if (KeyType == null)
            {
                throw new InvalidDataException("KeyType is a required property for LookupTypeResource and cannot be null");
            }
            else
            {
                this.KeyType = KeyType;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for LookupTypeResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "ValueType" is required (not null)
            if (ValueType == null)
            {
                throw new InvalidDataException("ValueType is a required property for LookupTypeResource and cannot be null");
            }
            else
            {
                this.ValueType = ValueType;
            }
            
        }

        /// <summary>
        /// The description of the expression type
        /// </summary>
        /// <value>The description of the expression type</value>
        [DataMember(Name="description")]
        public string Description { get; set; }
        /// <summary>
        /// The variable type the key expression must be, or null if it&#39;s dependent (see description for explanation in this case)
        /// </summary>
        /// <value>The variable type the key expression must be, or null if it&#39;s dependent (see description for explanation in this case)</value>
        [DataMember(Name="key_type")]
        public string KeyType { get; set; }
        /// <summary>
        /// The name of the expression type
        /// </summary>
        /// <value>The name of the expression type</value>
        [DataMember(Name="name")]
        public string Name { get; set; }
        /// <summary>
        /// The variable type of the value this expression returns, or null if it&#39;s dependent (see description for explanation in this case)
        /// </summary>
        /// <value>The variable type of the value this expression returns, or null if it&#39;s dependent (see description for explanation in this case)</value>
        [DataMember(Name="value_type")]
        public string ValueType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LookupTypeResource {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  KeyType: ").Append(KeyType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
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
            return Equals((LookupTypeResource)obj);
        }

        /// <summary>
        /// Returns true if LookupTypeResource instances are equal
        /// </summary>
        /// <param name="other">Instance of LookupTypeResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LookupTypeResource other)
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
                    this.KeyType == other.KeyType ||
                    this.KeyType != null &&
                    this.KeyType.Equals(other.KeyType)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.ValueType == other.ValueType ||
                    this.ValueType != null &&
                    this.ValueType.Equals(other.ValueType)
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
                    if (this.KeyType != null)
                    hash = hash * 59 + this.KeyType.GetHashCode();
                    if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                    if (this.ValueType != null)
                    hash = hash * 59 + this.ValueType.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(LookupTypeResource left, LookupTypeResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(LookupTypeResource left, LookupTypeResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
