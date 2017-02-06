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
    public partial class FlagResource :  IEquatable<FlagResource>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="FlagResource" /> class.
        /// </summary>
        /// <param name="Context">The context of that resource (required).</param>
        /// <param name="ContextId">The context_id of that resource (required).</param>
        /// <param name="CreatedDate">The date/time this resource was created in seconds since epoch.</param>
        /// <param name="Id">The unique ID for that resource.</param>
        /// <param name="Reason">The flag reason of that resource.</param>
        /// <param name="UpdatedDate">The date/time this resource was last updated in seconds since epoch.</param>
        /// <param name="User">The basic user resource.</param>
        public FlagResource(string Context = default(string), string ContextId = default(string), string Reason = default(string), SimpleUserResource User = default(SimpleUserResource))
        {
            // to ensure "Context" is required (not null)
            if (Context == null)
            {
                throw new InvalidDataException("Context is a required property for FlagResource and cannot be null");
            }
            else
            {
                this.Context = Context;
            }
            // to ensure "ContextId" is required (not null)
            if (ContextId == null)
            {
                throw new InvalidDataException("ContextId is a required property for FlagResource and cannot be null");
            }
            else
            {
                this.ContextId = ContextId;
            }
            this.CreatedDate = CreatedDate;
            this.Id = Id;
            this.Reason = Reason;
            this.UpdatedDate = UpdatedDate;
            this.User = User;
            
        }

        /// <summary>
        /// The context of that resource
        /// </summary>
        /// <value>The context of that resource</value>
        [DataMember(Name="context")]
        public string Context { get; set; }
        /// <summary>
        /// The context_id of that resource
        /// </summary>
        /// <value>The context_id of that resource</value>
        [DataMember(Name="context_id")]
        public string ContextId { get; set; }
        /// <summary>
        /// The date/time this resource was created in seconds since epoch
        /// </summary>
        /// <value>The date/time this resource was created in seconds since epoch</value>
        [DataMember(Name="created_date")]
        public long? CreatedDate { get; private set; }
        /// <summary>
        /// The unique ID for that resource
        /// </summary>
        /// <value>The unique ID for that resource</value>
        [DataMember(Name="id")]
        public long? Id { get; private set; }
        /// <summary>
        /// The flag reason of that resource
        /// </summary>
        /// <value>The flag reason of that resource</value>
        [DataMember(Name="reason")]
        public string Reason { get; set; }
        /// <summary>
        /// The date/time this resource was last updated in seconds since epoch
        /// </summary>
        /// <value>The date/time this resource was last updated in seconds since epoch</value>
        [DataMember(Name="updated_date")]
        public long? UpdatedDate { get; private set; }
        /// <summary>
        /// The basic user resource
        /// </summary>
        /// <value>The basic user resource</value>
        [DataMember(Name="user")]
        public SimpleUserResource User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlagResource {\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  ContextId: ").Append(ContextId).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
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
            return Equals((FlagResource)obj);
        }

        /// <summary>
        /// Returns true if FlagResource instances are equal
        /// </summary>
        /// <param name="other">Instance of FlagResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlagResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Context == other.Context ||
                    this.Context != null &&
                    this.Context.Equals(other.Context)
                ) && 
                (
                    this.ContextId == other.ContextId ||
                    this.ContextId != null &&
                    this.ContextId.Equals(other.ContextId)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.UpdatedDate == other.UpdatedDate ||
                    this.UpdatedDate != null &&
                    this.UpdatedDate.Equals(other.UpdatedDate)
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
                    if (this.Context != null)
                    hash = hash * 59 + this.Context.GetHashCode();
                    if (this.ContextId != null)
                    hash = hash * 59 + this.ContextId.GetHashCode();
                    if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                    if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                    if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                    if (this.UpdatedDate != null)
                    hash = hash * 59 + this.UpdatedDate.GetHashCode();
                    if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(FlagResource left, FlagResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FlagResource left, FlagResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
