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
    public partial class PropertyFieldListResource :  IEquatable<PropertyFieldListResource>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyFieldListResource" /> class.
        /// </summary>
        /// <param name="PropertyDefinitionFields">A list of fields for the property definition..</param>
        /// <param name="PropertyFields">A list of fields for the property..</param>
        /// <param name="PropertyType">The type for the property this describes..</param>
        public PropertyFieldListResource(List<PropertyFieldResource> PropertyDefinitionFields = default(List<PropertyFieldResource>), List<PropertyFieldResource> PropertyFields = default(List<PropertyFieldResource>), string PropertyType = default(string))
        {
            this.PropertyDefinitionFields = PropertyDefinitionFields;
            this.PropertyFields = PropertyFields;
            this.PropertyType = PropertyType;
            
        }

        /// <summary>
        /// A list of fields for the property definition.
        /// </summary>
        /// <value>A list of fields for the property definition.</value>
        [DataMember(Name="property_definition_fields")]
        public List<PropertyFieldResource> PropertyDefinitionFields { get; set; }
        /// <summary>
        /// A list of fields for the property.
        /// </summary>
        /// <value>A list of fields for the property.</value>
        [DataMember(Name="property_fields")]
        public List<PropertyFieldResource> PropertyFields { get; set; }
        /// <summary>
        /// The type for the property this describes.
        /// </summary>
        /// <value>The type for the property this describes.</value>
        [DataMember(Name="property_type")]
        public string PropertyType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertyFieldListResource {\n");
            sb.Append("  PropertyDefinitionFields: ").Append(PropertyDefinitionFields).Append("\n");
            sb.Append("  PropertyFields: ").Append(PropertyFields).Append("\n");
            sb.Append("  PropertyType: ").Append(PropertyType).Append("\n");
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
            return Equals((PropertyFieldListResource)obj);
        }

        /// <summary>
        /// Returns true if PropertyFieldListResource instances are equal
        /// </summary>
        /// <param name="other">Instance of PropertyFieldListResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertyFieldListResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.PropertyDefinitionFields == other.PropertyDefinitionFields ||
                    this.PropertyDefinitionFields != null &&
                    this.PropertyDefinitionFields.SequenceEqual(other.PropertyDefinitionFields)
                ) && 
                (
                    this.PropertyFields == other.PropertyFields ||
                    this.PropertyFields != null &&
                    this.PropertyFields.SequenceEqual(other.PropertyFields)
                ) && 
                (
                    this.PropertyType == other.PropertyType ||
                    this.PropertyType != null &&
                    this.PropertyType.Equals(other.PropertyType)
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
                    if (this.PropertyDefinitionFields != null)
                    hash = hash * 59 + this.PropertyDefinitionFields.GetHashCode();
                    if (this.PropertyFields != null)
                    hash = hash * 59 + this.PropertyFields.GetHashCode();
                    if (this.PropertyType != null)
                    hash = hash * 59 + this.PropertyType.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(PropertyFieldListResource left, PropertyFieldListResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PropertyFieldListResource left, PropertyFieldListResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
