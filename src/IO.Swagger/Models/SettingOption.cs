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
    public partial class SettingOption :  IEquatable<SettingOption>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingOption" /> class.
        /// </summary>
        /// <param name="Name">The textual name of the option: Ex: Hard (level 10) (required).</param>
        /// <param name="Value">The unique ID for the option. Ex: 10.</param>
        public SettingOption(string Name = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for SettingOption and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Value = Value;
            
        }

        /// <summary>
        /// The textual name of the option: Ex: Hard (level 10)
        /// </summary>
        /// <value>The textual name of the option: Ex: Hard (level 10)</value>
        [DataMember(Name="name")]
        public string Name { get; set; }
        /// <summary>
        /// The unique ID for the option. Ex: 10
        /// </summary>
        /// <value>The unique ID for the option. Ex: 10</value>
        [DataMember(Name="value")]
        public string Value { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SettingOption {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return Equals((SettingOption)obj);
        }

        /// <summary>
        /// Returns true if SettingOption instances are equal
        /// </summary>
        /// <param name="other">Instance of SettingOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SettingOption other)
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
                    if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                    if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(SettingOption left, SettingOption right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SettingOption left, SettingOption right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
