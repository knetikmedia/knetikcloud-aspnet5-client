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
    public partial class EventContextResource :  IEquatable<EventContextResource>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="EventContextResource" /> class.
        /// </summary>
        /// <param name="EventName">EventName.</param>
        /// <param name="Parameters">Parameters.</param>
        /// <param name="Type">Type.</param>
        public EventContextResource(string EventName = default(string), Dictionary<string, ExpressionResource> Parameters = default(Dictionary<string, ExpressionResource>), string Type = default(string))
        {
            this.EventName = EventName;
            this.Parameters = Parameters;
            this.Type = Type;
            
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="event_name")]
        public string EventName { get; set; }
        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="parameters")]
        public Dictionary<string, ExpressionResource> Parameters { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type")]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventContextResource {\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return Equals((EventContextResource)obj);
        }

        /// <summary>
        /// Returns true if EventContextResource instances are equal
        /// </summary>
        /// <param name="other">Instance of EventContextResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventContextResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                    if (this.EventName != null)
                    hash = hash * 59 + this.EventName.GetHashCode();
                    if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();
                    if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(EventContextResource left, EventContextResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EventContextResource left, EventContextResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
