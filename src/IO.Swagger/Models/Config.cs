/*
 * Knetik Platform API Documentation Latest
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
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
    public partial class Config :  IEquatable<Config>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Config" /> class.
        /// </summary>
        /// <param name="Name">The name of the config (required).</param>
        /// <param name="PublicRead">Whether the config is public for viewing. True means that it can be publicly viewed by all. Default: false.</param>
        /// <param name="Value">The value of the config.</param>
        public Config(string Name = null, bool? PublicRead = null, string Value = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Config and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.PublicRead = PublicRead;
            this.Value = Value;
            
        }

        /// <summary>
        /// The name of the config
        /// </summary>
        /// <value>The name of the config</value>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Whether the config is public for viewing. True means that it can be publicly viewed by all. Default: false
        /// </summary>
        /// <value>Whether the config is public for viewing. True means that it can be publicly viewed by all. Default: false</value>
        [DataMember(Name="public_read")]
        public bool? PublicRead { get; set; }

        /// <summary>
        /// The value of the config
        /// </summary>
        /// <value>The value of the config</value>
        [DataMember(Name="value")]
        public string Value { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Config {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PublicRead: ").Append(PublicRead).Append("\n");
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
            return Equals((Config)obj);
        }

        /// <summary>
        /// Returns true if Config instances are equal
        /// </summary>
        /// <param name="other">Instance of Config to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Config other)
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
                    this.PublicRead == other.PublicRead ||
                    this.PublicRead != null &&
                    this.PublicRead.Equals(other.PublicRead)
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
                    if (this.PublicRead != null)
                    hash = hash * 59 + this.PublicRead.GetHashCode();
                    if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(Config left, Config right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Config left, Config right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
