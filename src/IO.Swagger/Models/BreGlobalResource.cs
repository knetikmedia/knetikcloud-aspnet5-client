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
    public partial class BreGlobalResource :  IEquatable<BreGlobalResource>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BreGlobalResource" /> class.
        /// </summary>
        /// <param name="Description">A human readable description for display in admin pages.</param>
        /// <param name="Id">The id of the global definition. Default is a random guid. Cannot be updated.</param>
        /// <param name="Key">The key for the global. Must be unique when combined with scope names. Usually a single descriptive word like &#39;purchases&#39; or &#39;logins&#39; (required).</param>
        /// <param name="Name">A human readable name for display in admin pages.</param>
        /// <param name="Scopes">A list of scoping parameters. Allows the global to have a different value in different context such as a count of purchases for each user (by putting a &#39;user&#39; scope in this list). When using this global in a rule these scopes will need to be mapped with an expression to provide a value, similar to the parameters in an action.</param>
        /// <param name="SystemGlobal">Where this global came from. System globals cannot be removed or updated.</param>
        /// <param name="Type">The variable type the global stores. See the See Bre Variables enpoint for list (required).</param>
        public BreGlobalResource(string Description = default(string), string Id = default(string), string Key = default(string), string Name = default(string), List<BreGlobalScopeDefinition> Scopes = default(List<BreGlobalScopeDefinition>), string Type = default(string))
        {
            // to ensure "Key" is required (not null)
            if (Key == null)
            {
                throw new InvalidDataException("Key is a required property for BreGlobalResource and cannot be null");
            }
            else
            {
                this.Key = Key;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for BreGlobalResource and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.Description = Description;
            this.Id = Id;
            this.Name = Name;
            this.Scopes = Scopes;
            this.SystemGlobal = SystemGlobal;
            
        }

        /// <summary>
        /// A human readable description for display in admin pages
        /// </summary>
        /// <value>A human readable description for display in admin pages</value>
        [DataMember(Name="description")]
        public string Description { get; set; }
        /// <summary>
        /// The id of the global definition. Default is a random guid. Cannot be updated
        /// </summary>
        /// <value>The id of the global definition. Default is a random guid. Cannot be updated</value>
        [DataMember(Name="id")]
        public string Id { get; set; }
        /// <summary>
        /// The key for the global. Must be unique when combined with scope names. Usually a single descriptive word like &#39;purchases&#39; or &#39;logins&#39;
        /// </summary>
        /// <value>The key for the global. Must be unique when combined with scope names. Usually a single descriptive word like &#39;purchases&#39; or &#39;logins&#39;</value>
        [DataMember(Name="key")]
        public string Key { get; set; }
        /// <summary>
        /// A human readable name for display in admin pages
        /// </summary>
        /// <value>A human readable name for display in admin pages</value>
        [DataMember(Name="name")]
        public string Name { get; set; }
        /// <summary>
        /// A list of scoping parameters. Allows the global to have a different value in different context such as a count of purchases for each user (by putting a &#39;user&#39; scope in this list). When using this global in a rule these scopes will need to be mapped with an expression to provide a value, similar to the parameters in an action
        /// </summary>
        /// <value>A list of scoping parameters. Allows the global to have a different value in different context such as a count of purchases for each user (by putting a &#39;user&#39; scope in this list). When using this global in a rule these scopes will need to be mapped with an expression to provide a value, similar to the parameters in an action</value>
        [DataMember(Name="scopes")]
        public List<BreGlobalScopeDefinition> Scopes { get; set; }
        /// <summary>
        /// Where this global came from. System globals cannot be removed or updated
        /// </summary>
        /// <value>Where this global came from. System globals cannot be removed or updated</value>
        [DataMember(Name="system_global")]
        public bool? SystemGlobal { get; private set; }
        /// <summary>
        /// The variable type the global stores. See the See Bre Variables enpoint for list
        /// </summary>
        /// <value>The variable type the global stores. See the See Bre Variables enpoint for list</value>
        [DataMember(Name="type")]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BreGlobalResource {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Scopes: ").Append(Scopes).Append("\n");
            sb.Append("  SystemGlobal: ").Append(SystemGlobal).Append("\n");
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
            return Equals((BreGlobalResource)obj);
        }

        /// <summary>
        /// Returns true if BreGlobalResource instances are equal
        /// </summary>
        /// <param name="other">Instance of BreGlobalResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BreGlobalResource other)
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
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Scopes == other.Scopes ||
                    this.Scopes != null &&
                    this.Scopes.SequenceEqual(other.Scopes)
                ) && 
                (
                    this.SystemGlobal == other.SystemGlobal ||
                    this.SystemGlobal != null &&
                    this.SystemGlobal.Equals(other.SystemGlobal)
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
                    if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                    if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                    if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();
                    if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                    if (this.Scopes != null)
                    hash = hash * 59 + this.Scopes.GetHashCode();
                    if (this.SystemGlobal != null)
                    hash = hash * 59 + this.SystemGlobal.GetHashCode();
                    if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(BreGlobalResource left, BreGlobalResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BreGlobalResource left, BreGlobalResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
