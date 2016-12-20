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
    public partial class BareChallengeActivityResource :  IEquatable<BareChallengeActivityResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BareChallengeActivityResource" /> class.
        /// </summary>
        /// <param name="ActivityId">The id of the activity (required).</param>
        /// <param name="ChallengeId">The id of the challenge (required).</param>
        /// <param name="Id">The unique ID for this resource.</param>
        public BareChallengeActivityResource(long? ActivityId = null, long? ChallengeId = null, long? Id = null)
        {
            // to ensure "ActivityId" is required (not null)
            if (ActivityId == null)
            {
                throw new InvalidDataException("ActivityId is a required property for BareChallengeActivityResource and cannot be null");
            }
            else
            {
                this.ActivityId = ActivityId;
            }
            // to ensure "ChallengeId" is required (not null)
            if (ChallengeId == null)
            {
                throw new InvalidDataException("ChallengeId is a required property for BareChallengeActivityResource and cannot be null");
            }
            else
            {
                this.ChallengeId = ChallengeId;
            }
            this.Id = Id;
            
        }

        /// <summary>
        /// The id of the activity
        /// </summary>
        /// <value>The id of the activity</value>
        [DataMember(Name="activity_id")]
        public long? ActivityId { get; set; }

        /// <summary>
        /// The id of the challenge
        /// </summary>
        /// <value>The id of the challenge</value>
        [DataMember(Name="challenge_id")]
        public long? ChallengeId { get; set; }

        /// <summary>
        /// The unique ID for this resource
        /// </summary>
        /// <value>The unique ID for this resource</value>
        [DataMember(Name="id")]
        public long? Id { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BareChallengeActivityResource {\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  ChallengeId: ").Append(ChallengeId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return Equals((BareChallengeActivityResource)obj);
        }

        /// <summary>
        /// Returns true if BareChallengeActivityResource instances are equal
        /// </summary>
        /// <param name="other">Instance of BareChallengeActivityResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BareChallengeActivityResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.ActivityId == other.ActivityId ||
                    this.ActivityId != null &&
                    this.ActivityId.Equals(other.ActivityId)
                ) && 
                (
                    this.ChallengeId == other.ChallengeId ||
                    this.ChallengeId != null &&
                    this.ChallengeId.Equals(other.ChallengeId)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                    if (this.ActivityId != null)
                    hash = hash * 59 + this.ActivityId.GetHashCode();
                    if (this.ChallengeId != null)
                    hash = hash * 59 + this.ChallengeId.GetHashCode();
                    if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(BareChallengeActivityResource left, BareChallengeActivityResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BareChallengeActivityResource left, BareChallengeActivityResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
