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
    public partial class RoleResource :  IEquatable<RoleResource>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleResource" /> class.
        /// </summary>
        /// <param name="ClientCount">The number of clients this role is assigned to.</param>
        /// <param name="CreatedDate">The date the role was added. Unix timestamp in seconds.</param>
        /// <param name="Locked">Whether a role is locked from being deleted.</param>
        /// <param name="Name">The name of the role used for display purposes (required).</param>
        /// <param name="Role">The keyword that defines the role (required).</param>
        /// <param name="RolePermission">The list of permissions this role has.</param>
        /// <param name="UserCount">The number of users this role is assigned to.</param>
        public RoleResource(bool? Locked = default(bool?), string Name = default(string), string Role = default(string), List<PermissionResource> RolePermission = default(List<PermissionResource>))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for RoleResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Role" is required (not null)
            if (Role == null)
            {
                throw new InvalidDataException("Role is a required property for RoleResource and cannot be null");
            }
            else
            {
                this.Role = Role;
            }
            this.ClientCount = ClientCount;
            this.CreatedDate = CreatedDate;
            this.Locked = Locked;
            this.RolePermission = RolePermission;
            this.UserCount = UserCount;
            
        }

        /// <summary>
        /// The number of clients this role is assigned to
        /// </summary>
        /// <value>The number of clients this role is assigned to</value>
        [DataMember(Name="client_count")]
        public int? ClientCount { get; private set; }
        /// <summary>
        /// The date the role was added. Unix timestamp in seconds
        /// </summary>
        /// <value>The date the role was added. Unix timestamp in seconds</value>
        [DataMember(Name="created_date")]
        public long? CreatedDate { get; private set; }
        /// <summary>
        /// Whether a role is locked from being deleted
        /// </summary>
        /// <value>Whether a role is locked from being deleted</value>
        [DataMember(Name="locked")]
        public bool? Locked { get; set; }
        /// <summary>
        /// The name of the role used for display purposes
        /// </summary>
        /// <value>The name of the role used for display purposes</value>
        [DataMember(Name="name")]
        public string Name { get; set; }
        /// <summary>
        /// The keyword that defines the role
        /// </summary>
        /// <value>The keyword that defines the role</value>
        [DataMember(Name="role")]
        public string Role { get; set; }
        /// <summary>
        /// The list of permissions this role has
        /// </summary>
        /// <value>The list of permissions this role has</value>
        [DataMember(Name="role_permission")]
        public List<PermissionResource> RolePermission { get; set; }
        /// <summary>
        /// The number of users this role is assigned to
        /// </summary>
        /// <value>The number of users this role is assigned to</value>
        [DataMember(Name="user_count")]
        public int? UserCount { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoleResource {\n");
            sb.Append("  ClientCount: ").Append(ClientCount).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  RolePermission: ").Append(RolePermission).Append("\n");
            sb.Append("  UserCount: ").Append(UserCount).Append("\n");
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
            return Equals((RoleResource)obj);
        }

        /// <summary>
        /// Returns true if RoleResource instances are equal
        /// </summary>
        /// <param name="other">Instance of RoleResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoleResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.ClientCount == other.ClientCount ||
                    this.ClientCount != null &&
                    this.ClientCount.Equals(other.ClientCount)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
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
                    this.Role == other.Role ||
                    this.Role != null &&
                    this.Role.Equals(other.Role)
                ) && 
                (
                    this.RolePermission == other.RolePermission ||
                    this.RolePermission != null &&
                    this.RolePermission.SequenceEqual(other.RolePermission)
                ) && 
                (
                    this.UserCount == other.UserCount ||
                    this.UserCount != null &&
                    this.UserCount.Equals(other.UserCount)
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
                    if (this.ClientCount != null)
                    hash = hash * 59 + this.ClientCount.GetHashCode();
                    if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                    if (this.Locked != null)
                    hash = hash * 59 + this.Locked.GetHashCode();
                    if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                    if (this.Role != null)
                    hash = hash * 59 + this.Role.GetHashCode();
                    if (this.RolePermission != null)
                    hash = hash * 59 + this.RolePermission.GetHashCode();
                    if (this.UserCount != null)
                    hash = hash * 59 + this.UserCount.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(RoleResource left, RoleResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RoleResource left, RoleResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
