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
    public partial class GrantTypeResource :  IEquatable<GrantTypeResource>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GrantTypeResource" /> class.
        /// </summary>
        /// <param name="Description">The description of the grant type.</param>
        /// <param name="Name">The name of the grant type.</param>
        public GrantTypeResource(string Description = default(string), string Name = default(string))
        {
            this.Description = Description;
            this.Name = Name;
            
        }

        /// <summary>
        /// The description of the grant type
        /// </summary>
        /// <value>The description of the grant type</value>
        [DataMember(Name="description")]
        public string Description { get; set; }
        /// <summary>
        /// The name of the grant type
        /// </summary>
        /// <value>The name of the grant type</value>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GrantTypeResource {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return Equals((GrantTypeResource)obj);
        }

        /// <summary>
        /// Returns true if GrantTypeResource instances are equal
        /// </summary>
        /// <param name="other">Instance of GrantTypeResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GrantTypeResource other)
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
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(GrantTypeResource left, GrantTypeResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GrantTypeResource left, GrantTypeResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
