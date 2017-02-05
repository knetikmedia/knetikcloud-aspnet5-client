/*
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://demo.sandbox.knetikcloud.com
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
    public partial class BreTriggerParameterDefinition :  IEquatable<BreTriggerParameterDefinition>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BreTriggerParameterDefinition" /> class.
        /// </summary>
        /// <param name="Name">The name of the parameter. This is used as the unique identifier of this parameter (required).</param>
        /// <param name="Type">The variable type of this parameter. See Bre Variables endpoint for list (required).</param>
        public BreTriggerParameterDefinition(string Name = default(string), string Type = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for BreTriggerParameterDefinition and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for BreTriggerParameterDefinition and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            
        }

        /// <summary>
        /// The name of the parameter. This is used as the unique identifier of this parameter
        /// </summary>
        /// <value>The name of the parameter. This is used as the unique identifier of this parameter</value>
        [DataMember(Name="name")]
        public string Name { get; set; }
        /// <summary>
        /// The variable type of this parameter. See Bre Variables endpoint for list
        /// </summary>
        /// <value>The variable type of this parameter. See Bre Variables endpoint for list</value>
        [DataMember(Name="type")]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BreTriggerParameterDefinition {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return Equals((BreTriggerParameterDefinition)obj);
        }

        /// <summary>
        /// Returns true if BreTriggerParameterDefinition instances are equal
        /// </summary>
        /// <param name="other">Instance of BreTriggerParameterDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BreTriggerParameterDefinition other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                    if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                    if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(BreTriggerParameterDefinition left, BreTriggerParameterDefinition right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BreTriggerParameterDefinition left, BreTriggerParameterDefinition right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
