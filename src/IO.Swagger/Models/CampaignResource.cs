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
    public partial class CampaignResource :  IEquatable<CampaignResource>
    {
                /// <summary>
        /// Indicate if the rewards have been given out already
        /// </summary>
        /// <value>Indicate if the rewards have been given out already</value>
        public enum RewardStatusEnum
        {
            
            /// <summary>
            /// Enum PendingEnum for "pending"
            /// </summary>
            [EnumMember(Value = "pending")]
            PendingEnum,
            
            /// <summary>
            /// Enum FailedEnum for "failed"
            /// </summary>
            [EnumMember(Value = "failed")]
            FailedEnum,
            
            /// <summary>
            /// Enum CompleteEnum for "complete"
            /// </summary>
            [EnumMember(Value = "complete")]
            CompleteEnum,
            
            /// <summary>
            /// Enum PartialEnum for "partial"
            /// </summary>
            [EnumMember(Value = "partial")]
            PartialEnum
        }
        /// <summary>
        /// Indicate if the rewards have been given out already
        /// </summary>
        /// <value>Indicate if the rewards have been given out already</value>
        [DataMember(Name="reward_status")]
        public RewardStatusEnum? RewardStatus { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignResource" /> class.
        /// </summary>
        /// <param name="Active">Whether the campaign is active or not.  Defaults to false.</param>
        /// <param name="AdditionalProperties">A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type.</param>
        /// <param name="CreatedDate">The date/time this resource was created in seconds since unix epoch.</param>
        /// <param name="Id">The unique ID for that resource.</param>
        /// <param name="LeaderboardStrategy">The strategy for calculating the leaderboard. Defaults to highest score. Value MUST come from the list of available strategies from the Leaderboard Service.</param>
        /// <param name="LongDescription">The user friendly name of that resource. Defaults to blank string.</param>
        /// <param name="Name">The user friendly name of that resource (required).</param>
        /// <param name="NextChallenge">The name of the next challenge coming up.</param>
        /// <param name="NextChallengeDate">The date/time of the next challenge coming up.</param>
        /// <param name="RewardSet">The rewards to give at the end of the campaign. When creating/updating only id is used. Reward set must be pre-existing.</param>
        /// <param name="RewardStatus">Indicate if the rewards have been given out already.</param>
        /// <param name="ShortDescription">The user friendly name of that resource. Defaults to blank string.</param>
        /// <param name="Template">A campaign template this campaign is validated against (private). May be null and no validation of additional_properties will be done.</param>
        /// <param name="UpdatedDate">The date/time this resource was last updated in seconds since unix epoch.</param>
        public CampaignResource(bool? Active = default(bool?), Dictionary<string, Property> AdditionalProperties = default(Dictionary<string, Property>), string LeaderboardStrategy = default(string), string LongDescription = default(string), string Name = default(string), RewardSetResource RewardSet = default(RewardSetResource), string ShortDescription = default(string), string Template = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for CampaignResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Active = Active;
            this.AdditionalProperties = AdditionalProperties;
            this.CreatedDate = CreatedDate;
            this.Id = Id;
            this.LeaderboardStrategy = LeaderboardStrategy;
            this.LongDescription = LongDescription;
            this.NextChallenge = NextChallenge;
            this.NextChallengeDate = NextChallengeDate;
            this.RewardSet = RewardSet;
            this.RewardStatus = RewardStatus;
            this.ShortDescription = ShortDescription;
            this.Template = Template;
            this.UpdatedDate = UpdatedDate;
            
        }

        /// <summary>
        /// Whether the campaign is active or not.  Defaults to false
        /// </summary>
        /// <value>Whether the campaign is active or not.  Defaults to false</value>
        [DataMember(Name="active")]
        public bool? Active { get; set; }
        /// <summary>
        /// A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type
        /// </summary>
        /// <value>A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type</value>
        [DataMember(Name="additional_properties")]
        public Dictionary<string, Property> AdditionalProperties { get; set; }
        /// <summary>
        /// The date/time this resource was created in seconds since unix epoch
        /// </summary>
        /// <value>The date/time this resource was created in seconds since unix epoch</value>
        [DataMember(Name="created_date")]
        public long? CreatedDate { get; private set; }
        /// <summary>
        /// The unique ID for that resource
        /// </summary>
        /// <value>The unique ID for that resource</value>
        [DataMember(Name="id")]
        public long? Id { get; private set; }
        /// <summary>
        /// The strategy for calculating the leaderboard. Defaults to highest score. Value MUST come from the list of available strategies from the Leaderboard Service
        /// </summary>
        /// <value>The strategy for calculating the leaderboard. Defaults to highest score. Value MUST come from the list of available strategies from the Leaderboard Service</value>
        [DataMember(Name="leaderboard_strategy")]
        public string LeaderboardStrategy { get; set; }
        /// <summary>
        /// The user friendly name of that resource. Defaults to blank string
        /// </summary>
        /// <value>The user friendly name of that resource. Defaults to blank string</value>
        [DataMember(Name="long_description")]
        public string LongDescription { get; set; }
        /// <summary>
        /// The user friendly name of that resource
        /// </summary>
        /// <value>The user friendly name of that resource</value>
        [DataMember(Name="name")]
        public string Name { get; set; }
        /// <summary>
        /// The name of the next challenge coming up
        /// </summary>
        /// <value>The name of the next challenge coming up</value>
        [DataMember(Name="next_challenge")]
        public string NextChallenge { get; private set; }
        /// <summary>
        /// The date/time of the next challenge coming up
        /// </summary>
        /// <value>The date/time of the next challenge coming up</value>
        [DataMember(Name="next_challenge_date")]
        public long? NextChallengeDate { get; private set; }
        /// <summary>
        /// The rewards to give at the end of the campaign. When creating/updating only id is used. Reward set must be pre-existing
        /// </summary>
        /// <value>The rewards to give at the end of the campaign. When creating/updating only id is used. Reward set must be pre-existing</value>
        [DataMember(Name="reward_set")]
        public RewardSetResource RewardSet { get; set; }
        /// <summary>
        /// The user friendly name of that resource. Defaults to blank string
        /// </summary>
        /// <value>The user friendly name of that resource. Defaults to blank string</value>
        [DataMember(Name="short_description")]
        public string ShortDescription { get; set; }
        /// <summary>
        /// A campaign template this campaign is validated against (private). May be null and no validation of additional_properties will be done
        /// </summary>
        /// <value>A campaign template this campaign is validated against (private). May be null and no validation of additional_properties will be done</value>
        [DataMember(Name="template")]
        public string Template { get; set; }
        /// <summary>
        /// The date/time this resource was last updated in seconds since unix epoch
        /// </summary>
        /// <value>The date/time this resource was last updated in seconds since unix epoch</value>
        [DataMember(Name="updated_date")]
        public long? UpdatedDate { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignResource {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LeaderboardStrategy: ").Append(LeaderboardStrategy).Append("\n");
            sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NextChallenge: ").Append(NextChallenge).Append("\n");
            sb.Append("  NextChallengeDate: ").Append(NextChallengeDate).Append("\n");
            sb.Append("  RewardSet: ").Append(RewardSet).Append("\n");
            sb.Append("  RewardStatus: ").Append(RewardStatus).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
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
            return Equals((CampaignResource)obj);
        }

        /// <summary>
        /// Returns true if CampaignResource instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) && 
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
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
                    this.LeaderboardStrategy == other.LeaderboardStrategy ||
                    this.LeaderboardStrategy != null &&
                    this.LeaderboardStrategy.Equals(other.LeaderboardStrategy)
                ) && 
                (
                    this.LongDescription == other.LongDescription ||
                    this.LongDescription != null &&
                    this.LongDescription.Equals(other.LongDescription)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.NextChallenge == other.NextChallenge ||
                    this.NextChallenge != null &&
                    this.NextChallenge.Equals(other.NextChallenge)
                ) && 
                (
                    this.NextChallengeDate == other.NextChallengeDate ||
                    this.NextChallengeDate != null &&
                    this.NextChallengeDate.Equals(other.NextChallengeDate)
                ) && 
                (
                    this.RewardSet == other.RewardSet ||
                    this.RewardSet != null &&
                    this.RewardSet.Equals(other.RewardSet)
                ) && 
                (
                    this.RewardStatus == other.RewardStatus ||
                    this.RewardStatus != null &&
                    this.RewardStatus.Equals(other.RewardStatus)
                ) && 
                (
                    this.ShortDescription == other.ShortDescription ||
                    this.ShortDescription != null &&
                    this.ShortDescription.Equals(other.ShortDescription)
                ) && 
                (
                    this.Template == other.Template ||
                    this.Template != null &&
                    this.Template.Equals(other.Template)
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
                    if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                    if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                    if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                    if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                    if (this.LeaderboardStrategy != null)
                    hash = hash * 59 + this.LeaderboardStrategy.GetHashCode();
                    if (this.LongDescription != null)
                    hash = hash * 59 + this.LongDescription.GetHashCode();
                    if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                    if (this.NextChallenge != null)
                    hash = hash * 59 + this.NextChallenge.GetHashCode();
                    if (this.NextChallengeDate != null)
                    hash = hash * 59 + this.NextChallengeDate.GetHashCode();
                    if (this.RewardSet != null)
                    hash = hash * 59 + this.RewardSet.GetHashCode();
                    if (this.RewardStatus != null)
                    hash = hash * 59 + this.RewardStatus.GetHashCode();
                    if (this.ShortDescription != null)
                    hash = hash * 59 + this.ShortDescription.GetHashCode();
                    if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();
                    if (this.UpdatedDate != null)
                    hash = hash * 59 + this.UpdatedDate.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(CampaignResource left, CampaignResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CampaignResource left, CampaignResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
