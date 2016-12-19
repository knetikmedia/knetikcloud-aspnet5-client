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
    public partial class GroupMember :  IEquatable<GroupMember>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupMember" /> class.
        /// </summary>
        /// <param name="Group">Group.</param>
        /// <param name="Secondary">Secondary.</param>
        /// <param name="Status">Status.</param>
        /// <param name="User">User.</param>
        public GroupMember(Group Group = null, bool? Secondary = null, string Status = null, User User = null)
        {
            this.Group = Group;
            this.Secondary = Secondary;
            this.Status = Status;
            this.User = User;
            
        }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name="group")]
        public Group Group { get; set; }

        /// <summary>
        /// Gets or Sets Secondary
        /// </summary>
        [DataMember(Name="secondary")]
        public bool? Secondary { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user")]
        public User User { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupMember {\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Secondary: ").Append(Secondary).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return Equals((GroupMember)obj);
        }

        /// <summary>
        /// Returns true if GroupMember instances are equal
        /// </summary>
        /// <param name="other">Instance of GroupMember to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupMember other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.Equals(other.Group)
                ) && 
                (
                    this.Secondary == other.Secondary ||
                    this.Secondary != null &&
                    this.Secondary.Equals(other.Secondary)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                    if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();
                    if (this.Secondary != null)
                    hash = hash * 59 + this.Secondary.GetHashCode();
                    if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                    if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(GroupMember left, GroupMember right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GroupMember left, GroupMember right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
