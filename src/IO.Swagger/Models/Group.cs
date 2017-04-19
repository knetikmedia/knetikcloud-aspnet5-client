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
    public partial class Group :  IEquatable<Group>
    {
                /// <summary>
        /// Gets or Sets Status
        /// </summary>
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum OpenEnum for "open"
            /// </summary>
            [EnumMember(Value = "open")]
            OpenEnum,
            
            /// <summary>
            /// Enum ClosedEnum for "closed"
            /// </summary>
            [EnumMember(Value = "closed")]
            ClosedEnum
        }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status")]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Group" /> class.
        /// </summary>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Id">Id.</param>
        /// <param name="MemberCount">MemberCount.</param>
        /// <param name="MessageOfTheDay">MessageOfTheDay.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Parent">Parent.</param>
        /// <param name="PropertiesString">PropertiesString.</param>
        /// <param name="Status">Status.</param>
        /// <param name="SubMemberCount">SubMemberCount.</param>
        /// <param name="Template">Template.</param>
        /// <param name="UniqueName">UniqueName.</param>
        public Group(Dictionary<string, Property> AdditionalProperties = default(Dictionary<string, Property>), string Description = default(string), int? Id = default(int?), int? MemberCount = default(int?), string MessageOfTheDay = default(string), string Name = default(string), Group Parent = default(Group), string PropertiesString = default(string), StatusEnum? Status = default(StatusEnum?), int? SubMemberCount = default(int?), string Template = default(string), string UniqueName = default(string))
        {
            this.AdditionalProperties = AdditionalProperties;
            this.Description = Description;
            this.Id = Id;
            this.MemberCount = MemberCount;
            this.MessageOfTheDay = MessageOfTheDay;
            this.Name = Name;
            this.Parent = Parent;
            this.PropertiesString = PropertiesString;
            this.Status = Status;
            this.SubMemberCount = SubMemberCount;
            this.Template = Template;
            this.UniqueName = UniqueName;
            
        }

        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additional_properties")]
        public Dictionary<string, Property> AdditionalProperties { get; set; }
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
        /// Gets or Sets MemberCount
        /// </summary>
        [DataMember(Name="member_count")]
        public int? MemberCount { get; set; }
        /// <summary>
        /// Gets or Sets MessageOfTheDay
        /// </summary>
        [DataMember(Name="message_of_the_day")]
        public string MessageOfTheDay { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name")]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name="parent")]
        public Group Parent { get; set; }
        /// <summary>
        /// Gets or Sets PropertiesString
        /// </summary>
        [DataMember(Name="properties_string")]
        public string PropertiesString { get; set; }
        /// <summary>
        /// Gets or Sets SubMemberCount
        /// </summary>
        [DataMember(Name="sub_member_count")]
        public int? SubMemberCount { get; set; }
        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name="template")]
        public string Template { get; set; }
        /// <summary>
        /// Gets or Sets UniqueName
        /// </summary>
        [DataMember(Name="unique_name")]
        public string UniqueName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Group {\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
            sb.Append("  MessageOfTheDay: ").Append(MessageOfTheDay).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  PropertiesString: ").Append(PropertiesString).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SubMemberCount: ").Append(SubMemberCount).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  UniqueName: ").Append(UniqueName).Append("\n");
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
            return Equals((Group)obj);
        }

        /// <summary>
        /// Returns true if Group instances are equal
        /// </summary>
        /// <param name="other">Instance of Group to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Group other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
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
                    this.MemberCount == other.MemberCount ||
                    this.MemberCount != null &&
                    this.MemberCount.Equals(other.MemberCount)
                ) && 
                (
                    this.MessageOfTheDay == other.MessageOfTheDay ||
                    this.MessageOfTheDay != null &&
                    this.MessageOfTheDay.Equals(other.MessageOfTheDay)
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
                    this.PropertiesString == other.PropertiesString ||
                    this.PropertiesString != null &&
                    this.PropertiesString.Equals(other.PropertiesString)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.SubMemberCount == other.SubMemberCount ||
                    this.SubMemberCount != null &&
                    this.SubMemberCount.Equals(other.SubMemberCount)
                ) && 
                (
                    this.Template == other.Template ||
                    this.Template != null &&
                    this.Template.Equals(other.Template)
                ) && 
                (
                    this.UniqueName == other.UniqueName ||
                    this.UniqueName != null &&
                    this.UniqueName.Equals(other.UniqueName)
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
                    if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                    if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                    if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                    if (this.MemberCount != null)
                    hash = hash * 59 + this.MemberCount.GetHashCode();
                    if (this.MessageOfTheDay != null)
                    hash = hash * 59 + this.MessageOfTheDay.GetHashCode();
                    if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                    if (this.Parent != null)
                    hash = hash * 59 + this.Parent.GetHashCode();
                    if (this.PropertiesString != null)
                    hash = hash * 59 + this.PropertiesString.GetHashCode();
                    if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                    if (this.SubMemberCount != null)
                    hash = hash * 59 + this.SubMemberCount.GetHashCode();
                    if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();
                    if (this.UniqueName != null)
                    hash = hash * 59 + this.UniqueName.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(Group left, Group right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Group left, Group right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
