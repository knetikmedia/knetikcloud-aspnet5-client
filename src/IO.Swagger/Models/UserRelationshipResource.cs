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
    public partial class UserRelationshipResource :  IEquatable<UserRelationshipResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRelationshipResource" /> class.
        /// </summary>
        /// <param name="Child">The child in the relationship (required).</param>
        /// <param name="Context">Context about the relationship or its type.</param>
        /// <param name="Id">A generated unique id. Read-Only.</param>
        /// <param name="Parent">The parent in the relationship (required).</param>
        public UserRelationshipResource(SimpleUserResource Child = null, string Context = null, long? Id = null, SimpleUserResource Parent = null)
        {
            // to ensure "Child" is required (not null)
            if (Child == null)
            {
                throw new InvalidDataException("Child is a required property for UserRelationshipResource and cannot be null");
            }
            else
            {
                this.Child = Child;
            }
            // to ensure "Parent" is required (not null)
            if (Parent == null)
            {
                throw new InvalidDataException("Parent is a required property for UserRelationshipResource and cannot be null");
            }
            else
            {
                this.Parent = Parent;
            }
            this.Context = Context;
            this.Id = Id;
            
        }

        /// <summary>
        /// The child in the relationship
        /// </summary>
        /// <value>The child in the relationship</value>
        [DataMember(Name="child")]
        public SimpleUserResource Child { get; set; }

        /// <summary>
        /// Context about the relationship or its type
        /// </summary>
        /// <value>Context about the relationship or its type</value>
        [DataMember(Name="context")]
        public string Context { get; set; }

        /// <summary>
        /// A generated unique id. Read-Only
        /// </summary>
        /// <value>A generated unique id. Read-Only</value>
        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// The parent in the relationship
        /// </summary>
        /// <value>The parent in the relationship</value>
        [DataMember(Name="parent")]
        public SimpleUserResource Parent { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserRelationshipResource {\n");
            sb.Append("  Child: ").Append(Child).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
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
            return Equals((UserRelationshipResource)obj);
        }

        /// <summary>
        /// Returns true if UserRelationshipResource instances are equal
        /// </summary>
        /// <param name="other">Instance of UserRelationshipResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserRelationshipResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Child == other.Child ||
                    this.Child != null &&
                    this.Child.Equals(other.Child)
                ) && 
                (
                    this.Context == other.Context ||
                    this.Context != null &&
                    this.Context.Equals(other.Context)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Parent == other.Parent ||
                    this.Parent != null &&
                    this.Parent.Equals(other.Parent)
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
                    if (this.Child != null)
                    hash = hash * 59 + this.Child.GetHashCode();
                    if (this.Context != null)
                    hash = hash * 59 + this.Context.GetHashCode();
                    if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                    if (this.Parent != null)
                    hash = hash * 59 + this.Parent.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(UserRelationshipResource left, UserRelationshipResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UserRelationshipResource left, UserRelationshipResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
