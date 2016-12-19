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
    public partial class FlagReportResource :  IEquatable<FlagReportResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlagReportResource" /> class.
        /// </summary>
        /// <param name="Context">The context of that resource .</param>
        /// <param name="ContextId">The context ID of that resource.</param>
        /// <param name="CreatedDate">The date/time this resource was created in seconds since epoch.</param>
        /// <param name="Id">The unique ID for that resource.</param>
        /// <param name="Reason">The reason of that resource required only in case of active resolution.</param>
        /// <param name="Resolution">The resolution of that resource (required).</param>
        /// <param name="Resolved">The date/time this report was resolved in seconds since epoch. Null if not resolved yet.</param>
        /// <param name="UpdatedDate">The date/time this resource was last updated in seconds since epoch.</param>
        public FlagReportResource(string Context = null, string ContextId = null, long? CreatedDate = null, long? Id = null, string Reason = null, string Resolution = null, long? Resolved = null, long? UpdatedDate = null)
        {
            // to ensure "Resolution" is required (not null)
            if (Resolution == null)
            {
                throw new InvalidDataException("Resolution is a required property for FlagReportResource and cannot be null");
            }
            else
            {
                this.Resolution = Resolution;
            }
            this.Context = Context;
            this.ContextId = ContextId;
            this.CreatedDate = CreatedDate;
            this.Id = Id;
            this.Reason = Reason;
            this.Resolved = Resolved;
            this.UpdatedDate = UpdatedDate;
            
        }

        /// <summary>
        /// The context of that resource 
        /// </summary>
        /// <value>The context of that resource </value>
        [DataMember(Name="context")]
        public string Context { get; set; }

        /// <summary>
        /// The context ID of that resource
        /// </summary>
        /// <value>The context ID of that resource</value>
        [DataMember(Name="context_id")]
        public string ContextId { get; set; }

        /// <summary>
        /// The date/time this resource was created in seconds since epoch
        /// </summary>
        /// <value>The date/time this resource was created in seconds since epoch</value>
        [DataMember(Name="created_date")]
        public long? CreatedDate { get; set; }

        /// <summary>
        /// The unique ID for that resource
        /// </summary>
        /// <value>The unique ID for that resource</value>
        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// The reason of that resource required only in case of active resolution
        /// </summary>
        /// <value>The reason of that resource required only in case of active resolution</value>
        [DataMember(Name="reason")]
        public string Reason { get; set; }

        /// <summary>
        /// The resolution of that resource
        /// </summary>
        /// <value>The resolution of that resource</value>
        [DataMember(Name="resolution")]
        public string Resolution { get; set; }

        /// <summary>
        /// The date/time this report was resolved in seconds since epoch. Null if not resolved yet
        /// </summary>
        /// <value>The date/time this report was resolved in seconds since epoch. Null if not resolved yet</value>
        [DataMember(Name="resolved")]
        public long? Resolved { get; set; }

        /// <summary>
        /// The date/time this resource was last updated in seconds since epoch
        /// </summary>
        /// <value>The date/time this resource was last updated in seconds since epoch</value>
        [DataMember(Name="updated_date")]
        public long? UpdatedDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlagReportResource {\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  ContextId: ").Append(ContextId).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Resolution: ").Append(Resolution).Append("\n");
            sb.Append("  Resolved: ").Append(Resolved).Append("\n");
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
            return Equals((FlagReportResource)obj);
        }

        /// <summary>
        /// Returns true if FlagReportResource instances are equal
        /// </summary>
        /// <param name="other">Instance of FlagReportResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlagReportResource other)
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
                    this.Resolution == other.Resolution ||
                    this.Resolution != null &&
                    this.Resolution.Equals(other.Resolution)
                ) && 
                (
                    this.Resolved == other.Resolved ||
                    this.Resolved != null &&
                    this.Resolved.Equals(other.Resolved)
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
                    if (this.Resolution != null)
                    hash = hash * 59 + this.Resolution.GetHashCode();
                    if (this.Resolved != null)
                    hash = hash * 59 + this.Resolved.GetHashCode();
                    if (this.UpdatedDate != null)
                    hash = hash * 59 + this.UpdatedDate.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(FlagReportResource left, FlagReportResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FlagReportResource left, FlagReportResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
