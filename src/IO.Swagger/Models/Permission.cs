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
    public partial class Permission :  IEquatable<Permission>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Permission" /> class.
        /// </summary>
        /// <param name="CreatedDate">CreatedDate.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Locked">Locked.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Parent">Parent.</param>
        /// <param name="_Permission">_Permission.</param>
        /// <param name="PermissionRole">PermissionRole.</param>
        /// <param name="UpdatedDate">UpdatedDate.</param>
        public Permission(long? CreatedDate = default(long?), string Description = default(string), int? Id = default(int?), bool? Locked = default(bool?), string Name = default(string), string Parent = default(string), string _Permission = default(string), List<Role> PermissionRole = default(List<Role>), long? UpdatedDate = default(long?))
        {
            this.CreatedDate = CreatedDate;
            this.Description = Description;
            this.Id = Id;
            this.Locked = Locked;
            this.Name = Name;
            this.Parent = Parent;
            this._Permission = _Permission;
            this.PermissionRole = PermissionRole;
            this.UpdatedDate = UpdatedDate;
            
        }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="created_date")]
        public long? CreatedDate { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description")]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public int? Id { get; set; }
        /// <summary>
        /// Gets or Sets Locked
        /// </summary>
        [DataMember(Name="locked")]
        public bool? Locked { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name")]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name="parent")]
        public string Parent { get; set; }
        /// <summary>
        /// Gets or Sets _Permission
        /// </summary>
        [DataMember(Name="permission")]
        public string _Permission { get; set; }
        /// <summary>
        /// Gets or Sets PermissionRole
        /// </summary>
        [DataMember(Name="permission_role")]
        public List<Role> PermissionRole { get; set; }
        /// <summary>
        /// Gets or Sets UpdatedDate
        /// </summary>
        [DataMember(Name="updated_date")]
        public long? UpdatedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Permission {\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  _Permission: ").Append(_Permission).Append("\n");
            sb.Append("  PermissionRole: ").Append(PermissionRole).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
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
            return Equals((Permission)obj);
        }

        /// <summary>
        /// Returns true if Permission instances are equal
        /// </summary>
        /// <param name="other">Instance of Permission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Permission other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
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
                    this.Locked == other.Locked ||
                    this.Locked != null &&
                    this.Locked.Equals(other.Locked)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Parent == other.Parent ||
                    this.Parent != null &&
                    this.Parent.Equals(other.Parent)
                ) && 
                (
                    this._Permission == other._Permission ||
                    this._Permission != null &&
                    this._Permission.Equals(other._Permission)
                ) && 
                (
                    this.PermissionRole == other.PermissionRole ||
                    this.PermissionRole != null &&
                    this.PermissionRole.SequenceEqual(other.PermissionRole)
                ) && 
                (
                    this.UpdatedDate == other.UpdatedDate ||
                    this.UpdatedDate != null &&
                    this.UpdatedDate.Equals(other.UpdatedDate)
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
                    if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                    if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                    if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                    if (this.Locked != null)
                    hash = hash * 59 + this.Locked.GetHashCode();
                    if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                    if (this.Parent != null)
                    hash = hash * 59 + this.Parent.GetHashCode();
                    if (this._Permission != null)
                    hash = hash * 59 + this._Permission.GetHashCode();
                    if (this.PermissionRole != null)
                    hash = hash * 59 + this.PermissionRole.GetHashCode();
                    if (this.UpdatedDate != null)
                    hash = hash * 59 + this.UpdatedDate.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(Permission left, Permission right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Permission left, Permission right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
