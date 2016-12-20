/*
 * Knetik Platform API Documentation Latest
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://demo.sandbox.knetikcloud.com
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
    public partial class ActivityUserResource :  IEquatable<ActivityUserResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityUserResource" /> class.
        /// </summary>
        /// <param name="Host">Whether this user is the &#39;host&#39; of the occurrence and has increased access to settings/etc (default: false).</param>
        /// <param name="Id">The id of the activity user entry.</param>
        /// <param name="JoinedDate">The date this user last joined the occurrence, unix timestamp in seconds.</param>
        /// <param name="LeftDate">The date this user last left the occurrence, unix timestamp in seconds. Null if still present.</param>
        /// <param name="Metric">The metric for the user&#39;s results, after the game is over.</param>
        /// <param name="Status">The current status of the user in the occurrence (default: present).</param>
        /// <param name="User">The user (required).</param>
        public ActivityUserResource(bool? Host = null, long? Id = null, long? JoinedDate = null, long? LeftDate = null, MetricResource Metric = null, string Status = null, SimpleUserResource User = null)
        {
            // to ensure "User" is required (not null)
            if (User == null)
            {
                throw new InvalidDataException("User is a required property for ActivityUserResource and cannot be null");
            }
            else
            {
                this.User = User;
            }
            this.Host = Host;
            this.Id = Id;
            this.JoinedDate = JoinedDate;
            this.LeftDate = LeftDate;
            this.Metric = Metric;
            this.Status = Status;
            
        }

        /// <summary>
        /// Whether this user is the 'host' of the occurrence and has increased access to settings/etc (default: false)
        /// </summary>
        /// <value>Whether this user is the 'host' of the occurrence and has increased access to settings/etc (default: false)</value>
        [DataMember(Name="host")]
        public bool? Host { get; set; }

        /// <summary>
        /// The id of the activity user entry
        /// </summary>
        /// <value>The id of the activity user entry</value>
        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// The date this user last joined the occurrence, unix timestamp in seconds
        /// </summary>
        /// <value>The date this user last joined the occurrence, unix timestamp in seconds</value>
        [DataMember(Name="joined_date")]
        public long? JoinedDate { get; set; }

        /// <summary>
        /// The date this user last left the occurrence, unix timestamp in seconds. Null if still present
        /// </summary>
        /// <value>The date this user last left the occurrence, unix timestamp in seconds. Null if still present</value>
        [DataMember(Name="left_date")]
        public long? LeftDate { get; set; }

        /// <summary>
        /// The metric for the user's results, after the game is over
        /// </summary>
        /// <value>The metric for the user's results, after the game is over</value>
        [DataMember(Name="metric")]
        public MetricResource Metric { get; set; }

        /// <summary>
        /// The current status of the user in the occurrence (default: present)
        /// </summary>
        /// <value>The current status of the user in the occurrence (default: present)</value>
        [DataMember(Name="status")]
        public string Status { get; set; }

        /// <summary>
        /// The user
        /// </summary>
        /// <value>The user</value>
        [DataMember(Name="user")]
        public SimpleUserResource User { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivityUserResource {\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  JoinedDate: ").Append(JoinedDate).Append("\n");
            sb.Append("  LeftDate: ").Append(LeftDate).Append("\n");
            sb.Append("  Metric: ").Append(Metric).Append("\n");
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
            return Equals((ActivityUserResource)obj);
        }

        /// <summary>
        /// Returns true if ActivityUserResource instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivityUserResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityUserResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Host == other.Host ||
                    this.Host != null &&
                    this.Host.Equals(other.Host)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.JoinedDate == other.JoinedDate ||
                    this.JoinedDate != null &&
                    this.JoinedDate.Equals(other.JoinedDate)
                ) && 
                (
                    this.LeftDate == other.LeftDate ||
                    this.LeftDate != null &&
                    this.LeftDate.Equals(other.LeftDate)
                ) && 
                (
                    this.Metric == other.Metric ||
                    this.Metric != null &&
                    this.Metric.Equals(other.Metric)
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
                    if (this.Host != null)
                    hash = hash * 59 + this.Host.GetHashCode();
                    if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                    if (this.JoinedDate != null)
                    hash = hash * 59 + this.JoinedDate.GetHashCode();
                    if (this.LeftDate != null)
                    hash = hash * 59 + this.LeftDate.GetHashCode();
                    if (this.Metric != null)
                    hash = hash * 59 + this.Metric.GetHashCode();
                    if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                    if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(ActivityUserResource left, ActivityUserResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ActivityUserResource left, ActivityUserResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
