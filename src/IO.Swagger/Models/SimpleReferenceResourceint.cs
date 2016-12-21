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
    public partial class SimpleReferenceResourceint :  IEquatable<SimpleReferenceResourceint>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleReferenceResourceint" /> class.
        /// </summary>
        /// <param name="Id">The id of the referenced object (required).</param>
        /// <param name="Name">The name of the referenced object.</param>
        public SimpleReferenceResourceint(int? Id = null, string Name = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for SimpleReferenceResourceint and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            this.Name = Name;
            
        }

        /// <summary>
        /// The id of the referenced object
        /// </summary>
        /// <value>The id of the referenced object</value>
        [DataMember(Name="id")]
        public int? Id { get; set; }

        /// <summary>
        /// The name of the referenced object
        /// </summary>
        /// <value>The name of the referenced object</value>
        [DataMember(Name="name")]
        public string Name { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimpleReferenceResourceint {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return Equals((SimpleReferenceResourceint)obj);
        }

        /// <summary>
        /// Returns true if SimpleReferenceResourceint instances are equal
        /// </summary>
        /// <param name="other">Instance of SimpleReferenceResourceint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimpleReferenceResourceint other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                    if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                    if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(SimpleReferenceResourceint left, SimpleReferenceResourceint right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SimpleReferenceResourceint left, SimpleReferenceResourceint right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
