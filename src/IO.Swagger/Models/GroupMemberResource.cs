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
    public partial class GroupMemberResource :  IEquatable<GroupMemberResource>
    {
                /// <summary>
        /// The member's access level. Default: member
        /// </summary>
        /// <value>The member's access level. Default: member</value>
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum ModeratorEnum for "moderator"
            /// </summary>
            [EnumMember(Value = "moderator")]
            ModeratorEnum,
            
            /// <summary>
            /// Enum MemberEnum for "member"
            /// </summary>
            [EnumMember(Value = "member")]
            MemberEnum
        }
        /// <summary>
        /// The member&#39;s access level. Default: member
        /// </summary>
        /// <value>The member&#39;s access level. Default: member</value>
        [DataMember(Name="status")]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupMemberResource" /> class.
        /// </summary>
        /// <param name="AvatarUrl">The url of the user&#39;s avatar image.</param>
        /// <param name="DisplayName">The public username of the user.</param>
        /// <param name="Id">The id of the user (required).</param>
        /// <param name="Status">The member&#39;s access level. Default: member.</param>
        /// <param name="Username">The username of the user.</param>
        public GroupMemberResource(int? Id = default(int?), StatusEnum? Status = default(StatusEnum?))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for GroupMemberResource and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            this.AvatarUrl = AvatarUrl;
            this.DisplayName = DisplayName;
            this.Status = Status;
            this.Username = Username;
            
        }

        /// <summary>
        /// The url of the user&#39;s avatar image
        /// </summary>
        /// <value>The url of the user&#39;s avatar image</value>
        [DataMember(Name="avatar_url")]
        public string AvatarUrl { get; private set; }
        /// <summary>
        /// The public username of the user
        /// </summary>
        /// <value>The public username of the user</value>
        [DataMember(Name="display_name")]
        public string DisplayName { get; private set; }
        /// <summary>
        /// The id of the user
        /// </summary>
        /// <value>The id of the user</value>
        [DataMember(Name="id")]
        public int? Id { get; set; }
        /// <summary>
        /// The username of the user
        /// </summary>
        /// <value>The username of the user</value>
        [DataMember(Name="username")]
        public string Username { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupMemberResource {\n");
            sb.Append("  AvatarUrl: ").Append(AvatarUrl).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return Equals((GroupMemberResource)obj);
        }

        /// <summary>
        /// Returns true if GroupMemberResource instances are equal
        /// </summary>
        /// <param name="other">Instance of GroupMemberResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupMemberResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.AvatarUrl == other.AvatarUrl ||
                    this.AvatarUrl != null &&
                    this.AvatarUrl.Equals(other.AvatarUrl)
                ) && 
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
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
                    if (this.AvatarUrl != null)
                    hash = hash * 59 + this.AvatarUrl.GetHashCode();
                    if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                    if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                    if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                    if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(GroupMemberResource left, GroupMemberResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GroupMemberResource left, GroupMemberResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
