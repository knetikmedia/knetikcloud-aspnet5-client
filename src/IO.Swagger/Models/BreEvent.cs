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
    public partial class BreEvent :  IEquatable<BreEvent>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BreEvent" /> class.
        /// </summary>
        /// <param name="EventName">The event name of the trigger to be fired (required).</param>
        /// <param name="Params">The parameters to the event. A Map (assosiative array) with a key for each trigger parameter name and a corrosponding value. (required).</param>
        public BreEvent(string EventName = default(string), Object Params = default(Object))
        {
            // to ensure "EventName" is required (not null)
            if (EventName == null)
            {
                throw new InvalidDataException("EventName is a required property for BreEvent and cannot be null");
            }
            else
            {
                this.EventName = EventName;
            }
            // to ensure "Params" is required (not null)
            if (Params == null)
            {
                throw new InvalidDataException("Params is a required property for BreEvent and cannot be null");
            }
            else
            {
                this.Params = Params;
            }
            
        }

        /// <summary>
        /// The event name of the trigger to be fired
        /// </summary>
        /// <value>The event name of the trigger to be fired</value>
        [DataMember(Name="event_name")]
        public string EventName { get; set; }
        /// <summary>
        /// The parameters to the event. A Map (assosiative array) with a key for each trigger parameter name and a corrosponding value.
        /// </summary>
        /// <value>The parameters to the event. A Map (assosiative array) with a key for each trigger parameter name and a corrosponding value.</value>
        [DataMember(Name="params")]
        public Object Params { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BreEvent {\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
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
            return Equals((BreEvent)obj);
        }

        /// <summary>
        /// Returns true if BreEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of BreEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BreEvent other)
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
                    this.Params == other.Params ||
                    this.Params != null &&
                    this.Params.Equals(other.Params)
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
                    if (this.Params != null)
                    hash = hash * 59 + this.Params.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(BreEvent left, BreEvent right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BreEvent left, BreEvent right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
