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
    public partial class BreCategoryResource :  IEquatable<BreCategoryResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BreCategoryResource" /> class.
        /// </summary>
        /// <param name="AdditionalProperties">A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type.</param>
        /// <param name="Name">The name of the category. Serves as the unique id.</param>
        /// <param name="Template">A template this BRE category is validated against (private). May be null and no validation of additional_properties will be done.</param>
        public BreCategoryResource(Dictionary<string, Property> AdditionalProperties = null, string Name = null, string Template = null)
        {
            this.AdditionalProperties = AdditionalProperties;
            this.Name = Name;
            this.Template = Template;
            
        }

        /// <summary>
        /// A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type
        /// </summary>
        /// <value>A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type</value>
        [DataMember(Name="additional_properties")]
        public Dictionary<string, Property> AdditionalProperties { get; set; }

        /// <summary>
        /// The name of the category. Serves as the unique id
        /// </summary>
        /// <value>The name of the category. Serves as the unique id</value>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// A template this BRE category is validated against (private). May be null and no validation of additional_properties will be done
        /// </summary>
        /// <value>A template this BRE category is validated against (private). May be null and no validation of additional_properties will be done</value>
        [DataMember(Name="template")]
        public string Template { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BreCategoryResource {\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
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
            return Equals((BreCategoryResource)obj);
        }

        /// <summary>
        /// Returns true if BreCategoryResource instances are equal
        /// </summary>
        /// <param name="other">Instance of BreCategoryResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BreCategoryResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Template == other.Template ||
                    this.Template != null &&
                    this.Template.Equals(other.Template)
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
                    if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                    if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                    if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(BreCategoryResource left, BreCategoryResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BreCategoryResource left, BreCategoryResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
