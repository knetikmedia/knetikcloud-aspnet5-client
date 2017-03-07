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
    public partial class UserLevelingResource :  IEquatable<UserLevelingResource>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UserLevelingResource" /> class.
        /// </summary>
        /// <param name="LastTierName">The name of the last tier the user has qualified for (required).</param>
        /// <param name="LastTierProgress">The progress level of the last tier the user has qualified for (required).</param>
        /// <param name="LevelName">The name of the level schema (required).</param>
        /// <param name="NextTierName">The name of the next tier the user can qualify for (required).</param>
        /// <param name="NextTierProgress">The progress needed to qualify for the next tier (required).</param>
        /// <param name="Progress">The amount of progress the user has (required).</param>
        /// <param name="TierNames">The names of the tiers the user has qualified for (required).</param>
        /// <param name="UserId">The ID of the user (required).</param>
        public UserLevelingResource(string LastTierName = default(string), int? LastTierProgress = default(int?), string LevelName = default(string), string NextTierName = default(string), int? NextTierProgress = default(int?), int? Progress = default(int?), List<string> TierNames = default(List<string>), int? UserId = default(int?))
        {
            // to ensure "LastTierName" is required (not null)
            if (LastTierName == null)
            {
                throw new InvalidDataException("LastTierName is a required property for UserLevelingResource and cannot be null");
            }
            else
            {
                this.LastTierName = LastTierName;
            }
            // to ensure "LastTierProgress" is required (not null)
            if (LastTierProgress == null)
            {
                throw new InvalidDataException("LastTierProgress is a required property for UserLevelingResource and cannot be null");
            }
            else
            {
                this.LastTierProgress = LastTierProgress;
            }
            // to ensure "LevelName" is required (not null)
            if (LevelName == null)
            {
                throw new InvalidDataException("LevelName is a required property for UserLevelingResource and cannot be null");
            }
            else
            {
                this.LevelName = LevelName;
            }
            // to ensure "NextTierName" is required (not null)
            if (NextTierName == null)
            {
                throw new InvalidDataException("NextTierName is a required property for UserLevelingResource and cannot be null");
            }
            else
            {
                this.NextTierName = NextTierName;
            }
            // to ensure "NextTierProgress" is required (not null)
            if (NextTierProgress == null)
            {
                throw new InvalidDataException("NextTierProgress is a required property for UserLevelingResource and cannot be null");
            }
            else
            {
                this.NextTierProgress = NextTierProgress;
            }
            // to ensure "Progress" is required (not null)
            if (Progress == null)
            {
                throw new InvalidDataException("Progress is a required property for UserLevelingResource and cannot be null");
            }
            else
            {
                this.Progress = Progress;
            }
            // to ensure "TierNames" is required (not null)
            if (TierNames == null)
            {
                throw new InvalidDataException("TierNames is a required property for UserLevelingResource and cannot be null");
            }
            else
            {
                this.TierNames = TierNames;
            }
            // to ensure "UserId" is required (not null)
            if (UserId == null)
            {
                throw new InvalidDataException("UserId is a required property for UserLevelingResource and cannot be null");
            }
            else
            {
                this.UserId = UserId;
            }
            
        }

        /// <summary>
        /// The name of the last tier the user has qualified for
        /// </summary>
        /// <value>The name of the last tier the user has qualified for</value>
        [DataMember(Name="last_tier_name")]
        public string LastTierName { get; set; }
        /// <summary>
        /// The progress level of the last tier the user has qualified for
        /// </summary>
        /// <value>The progress level of the last tier the user has qualified for</value>
        [DataMember(Name="last_tier_progress")]
        public int? LastTierProgress { get; set; }
        /// <summary>
        /// The name of the level schema
        /// </summary>
        /// <value>The name of the level schema</value>
        [DataMember(Name="level_name")]
        public string LevelName { get; set; }
        /// <summary>
        /// The name of the next tier the user can qualify for
        /// </summary>
        /// <value>The name of the next tier the user can qualify for</value>
        [DataMember(Name="next_tier_name")]
        public string NextTierName { get; set; }
        /// <summary>
        /// The progress needed to qualify for the next tier
        /// </summary>
        /// <value>The progress needed to qualify for the next tier</value>
        [DataMember(Name="next_tier_progress")]
        public int? NextTierProgress { get; set; }
        /// <summary>
        /// The amount of progress the user has
        /// </summary>
        /// <value>The amount of progress the user has</value>
        [DataMember(Name="progress")]
        public int? Progress { get; set; }
        /// <summary>
        /// The names of the tiers the user has qualified for
        /// </summary>
        /// <value>The names of the tiers the user has qualified for</value>
        [DataMember(Name="tier_names")]
        public List<string> TierNames { get; set; }
        /// <summary>
        /// The ID of the user
        /// </summary>
        /// <value>The ID of the user</value>
        [DataMember(Name="user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserLevelingResource {\n");
            sb.Append("  LastTierName: ").Append(LastTierName).Append("\n");
            sb.Append("  LastTierProgress: ").Append(LastTierProgress).Append("\n");
            sb.Append("  LevelName: ").Append(LevelName).Append("\n");
            sb.Append("  NextTierName: ").Append(NextTierName).Append("\n");
            sb.Append("  NextTierProgress: ").Append(NextTierProgress).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  TierNames: ").Append(TierNames).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return Equals((UserLevelingResource)obj);
        }

        /// <summary>
        /// Returns true if UserLevelingResource instances are equal
        /// </summary>
        /// <param name="other">Instance of UserLevelingResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserLevelingResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.LastTierName == other.LastTierName ||
                    this.LastTierName != null &&
                    this.LastTierName.Equals(other.LastTierName)
                ) && 
                (
                    this.LastTierProgress == other.LastTierProgress ||
                    this.LastTierProgress != null &&
                    this.LastTierProgress.Equals(other.LastTierProgress)
                ) && 
                (
                    this.LevelName == other.LevelName ||
                    this.LevelName != null &&
                    this.LevelName.Equals(other.LevelName)
                ) && 
                (
                    this.NextTierName == other.NextTierName ||
                    this.NextTierName != null &&
                    this.NextTierName.Equals(other.NextTierName)
                ) && 
                (
                    this.NextTierProgress == other.NextTierProgress ||
                    this.NextTierProgress != null &&
                    this.NextTierProgress.Equals(other.NextTierProgress)
                ) && 
                (
                    this.Progress == other.Progress ||
                    this.Progress != null &&
                    this.Progress.Equals(other.Progress)
                ) && 
                (
                    this.TierNames == other.TierNames ||
                    this.TierNames != null &&
                    this.TierNames.SequenceEqual(other.TierNames)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
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
                    if (this.LastTierName != null)
                    hash = hash * 59 + this.LastTierName.GetHashCode();
                    if (this.LastTierProgress != null)
                    hash = hash * 59 + this.LastTierProgress.GetHashCode();
                    if (this.LevelName != null)
                    hash = hash * 59 + this.LevelName.GetHashCode();
                    if (this.NextTierName != null)
                    hash = hash * 59 + this.NextTierName.GetHashCode();
                    if (this.NextTierProgress != null)
                    hash = hash * 59 + this.NextTierProgress.GetHashCode();
                    if (this.Progress != null)
                    hash = hash * 59 + this.Progress.GetHashCode();
                    if (this.TierNames != null)
                    hash = hash * 59 + this.TierNames.GetHashCode();
                    if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(UserLevelingResource left, UserLevelingResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UserLevelingResource left, UserLevelingResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
