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
    public partial class InvoiceLogEntry :  IEquatable<InvoiceLogEntry>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceLogEntry" /> class.
        /// </summary>
        /// <param name="Date">The date this event occured as a unix timestamp in seconds.</param>
        /// <param name="InvoiceId">The ID of the invoice.</param>
        /// <param name="Message">A message describing the event.</param>
        /// <param name="Type">The type of event.</param>
        public InvoiceLogEntry(long? Date = null, int? InvoiceId = null, string Message = null, string Type = null)
        {
            this.Date = Date;
            this.InvoiceId = InvoiceId;
            this.Message = Message;
            this.Type = Type;
            
        }

        /// <summary>
        /// The date this event occured as a unix timestamp in seconds
        /// </summary>
        /// <value>The date this event occured as a unix timestamp in seconds</value>
        [DataMember(Name="date")]
        public long? Date { get; set; }

        /// <summary>
        /// The ID of the invoice
        /// </summary>
        /// <value>The ID of the invoice</value>
        [DataMember(Name="invoice_id")]
        public int? InvoiceId { get; set; }

        /// <summary>
        /// A message describing the event
        /// </summary>
        /// <value>A message describing the event</value>
        [DataMember(Name="message")]
        public string Message { get; set; }

        /// <summary>
        /// The type of event
        /// </summary>
        /// <value>The type of event</value>
        [DataMember(Name="type")]
        public string Type { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoiceLogEntry {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return Equals((InvoiceLogEntry)obj);
        }

        /// <summary>
        /// Returns true if InvoiceLogEntry instances are equal
        /// </summary>
        /// <param name="other">Instance of InvoiceLogEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceLogEntry other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) && 
                (
                    this.InvoiceId == other.InvoiceId ||
                    this.InvoiceId != null &&
                    this.InvoiceId.Equals(other.InvoiceId)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
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
                    if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                    if (this.InvoiceId != null)
                    hash = hash * 59 + this.InvoiceId.GetHashCode();
                    if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                    if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(InvoiceLogEntry left, InvoiceLogEntry right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InvoiceLogEntry left, InvoiceLogEntry right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
