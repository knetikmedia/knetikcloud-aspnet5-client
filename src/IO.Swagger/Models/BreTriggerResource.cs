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
    public partial class BreTriggerResource :  IEquatable<BreTriggerResource>
    {
                /// <summary>
        /// The category this trigger belongs to. See endpoints for related asset information. All new triggers are in category 'custom'
        /// </summary>
        /// <value>The category this trigger belongs to. See endpoints for related asset information. All new triggers are in category 'custom'</value>
        public enum CategoryEnum
        {
            
            /// <summary>
            /// Enum AchievementEnum for "achievement"
            /// </summary>
            [EnumMember(Value = "achievement")]
            AchievementEnum,
            
            /// <summary>
            /// Enum BehaviorEnum for "behavior"
            /// </summary>
            [EnumMember(Value = "behavior")]
            BehaviorEnum,
            
            /// <summary>
            /// Enum CommentEnum for "comment"
            /// </summary>
            [EnumMember(Value = "comment")]
            CommentEnum,
            
            /// <summary>
            /// Enum DispositionEnum for "disposition"
            /// </summary>
            [EnumMember(Value = "disposition")]
            DispositionEnum,
            
            /// <summary>
            /// Enum EntitlementEnum for "entitlement"
            /// </summary>
            [EnumMember(Value = "entitlement")]
            EntitlementEnum,
            
            /// <summary>
            /// Enum FriendsEnum for "friends"
            /// </summary>
            [EnumMember(Value = "friends")]
            FriendsEnum,
            
            /// <summary>
            /// Enum FulfillmentEnum for "fulfillment"
            /// </summary>
            [EnumMember(Value = "fulfillment")]
            FulfillmentEnum,
            
            /// <summary>
            /// Enum GamificationEnum for "gamification"
            /// </summary>
            [EnumMember(Value = "gamification")]
            GamificationEnum,
            
            /// <summary>
            /// Enum InventoryEnum for "inventory"
            /// </summary>
            [EnumMember(Value = "inventory")]
            InventoryEnum,
            
            /// <summary>
            /// Enum InvoiceEnum for "invoice"
            /// </summary>
            [EnumMember(Value = "invoice")]
            InvoiceEnum,
            
            /// <summary>
            /// Enum MediaEnum for "media"
            /// </summary>
            [EnumMember(Value = "media")]
            MediaEnum,
            
            /// <summary>
            /// Enum SchedulerEnum for "scheduler"
            /// </summary>
            [EnumMember(Value = "scheduler")]
            SchedulerEnum,
            
            /// <summary>
            /// Enum StoreEnum for "store"
            /// </summary>
            [EnumMember(Value = "store")]
            StoreEnum,
            
            /// <summary>
            /// Enum SubscriptionEnum for "subscription"
            /// </summary>
            [EnumMember(Value = "subscription")]
            SubscriptionEnum,
            
            /// <summary>
            /// Enum UserEnum for "user"
            /// </summary>
            [EnumMember(Value = "user")]
            UserEnum,
            
            /// <summary>
            /// Enum WalletEnum for "wallet"
            /// </summary>
            [EnumMember(Value = "wallet")]
            WalletEnum,
            
            /// <summary>
            /// Enum CustomEnum for "custom"
            /// </summary>
            [EnumMember(Value = "custom")]
            CustomEnum,
            
            /// <summary>
            /// Enum ChallengeEnum for "challenge"
            /// </summary>
            [EnumMember(Value = "challenge")]
            ChallengeEnum,
            
            /// <summary>
            /// Enum ActivityEnum for "activity"
            /// </summary>
            [EnumMember(Value = "activity")]
            ActivityEnum,
            
            /// <summary>
            /// Enum CampaignEnum for "campaign"
            /// </summary>
            [EnumMember(Value = "campaign")]
            CampaignEnum,
            
            /// <summary>
            /// Enum EventEnum for "event"
            /// </summary>
            [EnumMember(Value = "event")]
            EventEnum
        }
        /// <summary>
        /// The category this trigger belongs to. See endpoints for related asset information. All new triggers are in category 'custom'
        /// </summary>
        /// <value>The category this trigger belongs to. See endpoints for related asset information. All new triggers are in category 'custom'</value>
        [DataMember(Name="category")]
        public CategoryEnum? Category { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BreTriggerResource" /> class.
        /// </summary>
        /// <param name="Category">The category this trigger belongs to. See endpoints for related asset information. All new triggers are in category &#39;custom&#39;.</param>
        /// <param name="EventName">The unique name for the event. This serves as the unique identifier. Cannot be changed after creation (required).</param>
        /// <param name="Parameters">A list af parameters that will be sent with the event when the trigger is fired. These must be included in the event and match the described types.</param>
        /// <param name="SystemTrigger">Where this trigger came from. System triggers cannot be removed or updated.</param>
        /// <param name="TriggerDescription">A description of the trigger (required).</param>
        /// <param name="TriggerName">A human readable name for this trigger (required).</param>
        public BreTriggerResource(string EventName = default(string), List<BreTriggerParameterDefinition> Parameters = default(List<BreTriggerParameterDefinition>), string TriggerDescription = default(string), string TriggerName = default(string))
        {
            // to ensure "EventName" is required (not null)
            if (EventName == null)
            {
                throw new InvalidDataException("EventName is a required property for BreTriggerResource and cannot be null");
            }
            else
            {
                this.EventName = EventName;
            }
            // to ensure "TriggerDescription" is required (not null)
            if (TriggerDescription == null)
            {
                throw new InvalidDataException("TriggerDescription is a required property for BreTriggerResource and cannot be null");
            }
            else
            {
                this.TriggerDescription = TriggerDescription;
            }
            // to ensure "TriggerName" is required (not null)
            if (TriggerName == null)
            {
                throw new InvalidDataException("TriggerName is a required property for BreTriggerResource and cannot be null");
            }
            else
            {
                this.TriggerName = TriggerName;
            }
            this.Category = Category;
            this.Parameters = Parameters;
            this.SystemTrigger = SystemTrigger;
            
        }

        /// <summary>
        /// The unique name for the event. This serves as the unique identifier. Cannot be changed after creation
        /// </summary>
        /// <value>The unique name for the event. This serves as the unique identifier. Cannot be changed after creation</value>
        [DataMember(Name="event_name")]
        public string EventName { get; set; }
        /// <summary>
        /// A list af parameters that will be sent with the event when the trigger is fired. These must be included in the event and match the described types
        /// </summary>
        /// <value>A list af parameters that will be sent with the event when the trigger is fired. These must be included in the event and match the described types</value>
        [DataMember(Name="parameters")]
        public List<BreTriggerParameterDefinition> Parameters { get; set; }
        /// <summary>
        /// Where this trigger came from. System triggers cannot be removed or updated
        /// </summary>
        /// <value>Where this trigger came from. System triggers cannot be removed or updated</value>
        [DataMember(Name="system_trigger")]
        public bool? SystemTrigger { get; private set; }
        /// <summary>
        /// A description of the trigger
        /// </summary>
        /// <value>A description of the trigger</value>
        [DataMember(Name="trigger_description")]
        public string TriggerDescription { get; set; }
        /// <summary>
        /// A human readable name for this trigger
        /// </summary>
        /// <value>A human readable name for this trigger</value>
        [DataMember(Name="trigger_name")]
        public string TriggerName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BreTriggerResource {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  SystemTrigger: ").Append(SystemTrigger).Append("\n");
            sb.Append("  TriggerDescription: ").Append(TriggerDescription).Append("\n");
            sb.Append("  TriggerName: ").Append(TriggerName).Append("\n");
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
            return Equals((BreTriggerResource)obj);
        }

        /// <summary>
        /// Returns true if BreTriggerResource instances are equal
        /// </summary>
        /// <param name="other">Instance of BreTriggerResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BreTriggerResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) && 
                (
                    this.EventName == other.EventName ||
                    this.EventName != null &&
                    this.EventName.Equals(other.EventName)
                ) && 
                (
                    this.Parameters == other.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(other.Parameters)
                ) && 
                (
                    this.SystemTrigger == other.SystemTrigger ||
                    this.SystemTrigger != null &&
                    this.SystemTrigger.Equals(other.SystemTrigger)
                ) && 
                (
                    this.TriggerDescription == other.TriggerDescription ||
                    this.TriggerDescription != null &&
                    this.TriggerDescription.Equals(other.TriggerDescription)
                ) && 
                (
                    this.TriggerName == other.TriggerName ||
                    this.TriggerName != null &&
                    this.TriggerName.Equals(other.TriggerName)
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
                    if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                    if (this.EventName != null)
                    hash = hash * 59 + this.EventName.GetHashCode();
                    if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();
                    if (this.SystemTrigger != null)
                    hash = hash * 59 + this.SystemTrigger.GetHashCode();
                    if (this.TriggerDescription != null)
                    hash = hash * 59 + this.TriggerDescription.GetHashCode();
                    if (this.TriggerName != null)
                    hash = hash * 59 + this.TriggerName.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(BreTriggerResource left, BreTriggerResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BreTriggerResource left, BreTriggerResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
