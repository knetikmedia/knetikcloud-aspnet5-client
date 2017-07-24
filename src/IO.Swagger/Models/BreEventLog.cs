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
    public partial class BreEventLog :  IEquatable<BreEventLog>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BreEventLog" /> class.
        /// </summary>
        /// <param name="Customer">The customer of the BRE event log.</param>
        /// <param name="EventId">The event id of the BRE event log.</param>
        /// <param name="EventName">The event name of the BRE event log.</param>
        /// <param name="EventStartDate">The event start date of the BRE event log.</param>
        /// <param name="Id">The id of the BRE event log.</param>
        /// <param name="Parameters">The event paramters of the BRE event log.</param>
        /// <param name="Rules">The rules of the BRE event log.</param>
        public BreEventLog(Object Parameters = default(Object), List<BreRuleLog> Rules = default(List<BreRuleLog>))
        {
            this.Customer = Customer;
            this.EventId = EventId;
            this.EventName = EventName;
            this.EventStartDate = EventStartDate;
            this.Id = Id;
            this.Parameters = Parameters;
            this.Rules = Rules;
            
        }

        /// <summary>
        /// The customer of the BRE event log
        /// </summary>
        /// <value>The customer of the BRE event log</value>
        [DataMember(Name="customer")]
        public string Customer { get; private set; }
        /// <summary>
        /// The event id of the BRE event log
        /// </summary>
        /// <value>The event id of the BRE event log</value>
        [DataMember(Name="event_id")]
        public string EventId { get; private set; }
        /// <summary>
        /// The event name of the BRE event log
        /// </summary>
        /// <value>The event name of the BRE event log</value>
        [DataMember(Name="event_name")]
        public string EventName { get; private set; }
        /// <summary>
        /// The event start date of the BRE event log
        /// </summary>
        /// <value>The event start date of the BRE event log</value>
        [DataMember(Name="event_start_date")]
        public long? EventStartDate { get; private set; }
        /// <summary>
        /// The id of the BRE event log
        /// </summary>
        /// <value>The id of the BRE event log</value>
        [DataMember(Name="id")]
        public string Id { get; private set; }
        /// <summary>
        /// The event paramters of the BRE event log
        /// </summary>
        /// <value>The event paramters of the BRE event log</value>
        [DataMember(Name="parameters")]
        public Object Parameters { get; set; }
        /// <summary>
        /// The rules of the BRE event log
        /// </summary>
        /// <value>The rules of the BRE event log</value>
        [DataMember(Name="rules")]
        public List<BreRuleLog> Rules { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BreEventLog {\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  EventStartDate: ").Append(EventStartDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
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
            return Equals((BreEventLog)obj);
        }

        /// <summary>
        /// Returns true if BreEventLog instances are equal
        /// </summary>
        /// <param name="other">Instance of BreEventLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BreEventLog other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Customer == other.Customer ||
                    this.Customer != null &&
                    this.Customer.Equals(other.Customer)
                ) && 
                (
                    this.EventId == other.EventId ||
                    this.EventId != null &&
                    this.EventId.Equals(other.EventId)
                ) && 
                (
                    this.EventName == other.EventName ||
                    this.EventName != null &&
                    this.EventName.Equals(other.EventName)
                ) && 
                (
                    this.EventStartDate == other.EventStartDate ||
                    this.EventStartDate != null &&
                    this.EventStartDate.Equals(other.EventStartDate)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Parameters == other.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.Equals(other.Parameters)
                ) && 
                (
                    this.Rules == other.Rules ||
                    this.Rules != null &&
                    this.Rules.SequenceEqual(other.Rules)
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
                    if (this.Customer != null)
                    hash = hash * 59 + this.Customer.GetHashCode();
                    if (this.EventId != null)
                    hash = hash * 59 + this.EventId.GetHashCode();
                    if (this.EventName != null)
                    hash = hash * 59 + this.EventName.GetHashCode();
                    if (this.EventStartDate != null)
                    hash = hash * 59 + this.EventStartDate.GetHashCode();
                    if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                    if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();
                    if (this.Rules != null)
                    hash = hash * 59 + this.Rules.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(BreEventLog left, BreEventLog right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BreEventLog left, BreEventLog right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
