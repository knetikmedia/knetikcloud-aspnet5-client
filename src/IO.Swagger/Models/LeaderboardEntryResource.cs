/*
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://demo.sandbox.knetikcloud.com
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
    public partial class LeaderboardEntryResource :  IEquatable<LeaderboardEntryResource>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LeaderboardEntryResource" /> class.
        /// </summary>
        /// <param name="Rank">The position of the user in the leaderboard. Null means non-compete or disqualification.</param>
        /// <param name="Score">The raw score in this leaderboard. Null means non-compete or disqualification.</param>
        /// <param name="User">The player for this entry (required).</param>
        public LeaderboardEntryResource(long? Rank = default(long?), long? Score = default(long?), SimpleUserResource User = default(SimpleUserResource))
        {
            // to ensure "User" is required (not null)
            if (User == null)
            {
                throw new InvalidDataException("User is a required property for LeaderboardEntryResource and cannot be null");
            }
            else
            {
                this.User = User;
            }
            this.Rank = Rank;
            this.Score = Score;
            
        }

        /// <summary>
        /// The position of the user in the leaderboard. Null means non-compete or disqualification
        /// </summary>
        /// <value>The position of the user in the leaderboard. Null means non-compete or disqualification</value>
        [DataMember(Name="rank")]
        public long? Rank { get; set; }
        /// <summary>
        /// The raw score in this leaderboard. Null means non-compete or disqualification
        /// </summary>
        /// <value>The raw score in this leaderboard. Null means non-compete or disqualification</value>
        [DataMember(Name="score")]
        public long? Score { get; set; }
        /// <summary>
        /// The player for this entry
        /// </summary>
        /// <value>The player for this entry</value>
        [DataMember(Name="user")]
        public SimpleUserResource User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LeaderboardEntryResource {\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
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
            return Equals((LeaderboardEntryResource)obj);
        }

        /// <summary>
        /// Returns true if LeaderboardEntryResource instances are equal
        /// </summary>
        /// <param name="other">Instance of LeaderboardEntryResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeaderboardEntryResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Rank == other.Rank ||
                    this.Rank != null &&
                    this.Rank.Equals(other.Rank)
                ) && 
                (
                    this.Score == other.Score ||
                    this.Score != null &&
                    this.Score.Equals(other.Score)
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
                    if (this.Rank != null)
                    hash = hash * 59 + this.Rank.GetHashCode();
                    if (this.Score != null)
                    hash = hash * 59 + this.Score.GetHashCode();
                    if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(LeaderboardEntryResource left, LeaderboardEntryResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(LeaderboardEntryResource left, LeaderboardEntryResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
