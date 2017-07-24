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
    public partial class RawEmailResource :  IEquatable<RawEmailResource>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RawEmailResource" /> class.
        /// </summary>
        /// <param name="Body">The body of the outgoing message. (required).</param>
        /// <param name="From">Address to attribute the outgoing message to. Optional if the config email.out_address is set..</param>
        /// <param name="Html">Whether the body is to be treated as html. Default false..</param>
        /// <param name="Recipients">A list of user ids to send the message to. (required).</param>
        /// <param name="Subject">The subject of the outgoing message. (required).</param>
        public RawEmailResource(string Body = default(string), string From = default(string), bool? Html = default(bool?), List<int?> Recipients = default(List<int?>), string Subject = default(string))
        {
            // to ensure "Body" is required (not null)
            if (Body == null)
            {
                throw new InvalidDataException("Body is a required property for RawEmailResource and cannot be null");
            }
            else
            {
                this.Body = Body;
            }
            // to ensure "Recipients" is required (not null)
            if (Recipients == null)
            {
                throw new InvalidDataException("Recipients is a required property for RawEmailResource and cannot be null");
            }
            else
            {
                this.Recipients = Recipients;
            }
            // to ensure "Subject" is required (not null)
            if (Subject == null)
            {
                throw new InvalidDataException("Subject is a required property for RawEmailResource and cannot be null");
            }
            else
            {
                this.Subject = Subject;
            }
            this.From = From;
            this.Html = Html;
            
        }

        /// <summary>
        /// The body of the outgoing message.
        /// </summary>
        /// <value>The body of the outgoing message.</value>
        [DataMember(Name="body")]
        public string Body { get; set; }
        /// <summary>
        /// Address to attribute the outgoing message to. Optional if the config email.out_address is set.
        /// </summary>
        /// <value>Address to attribute the outgoing message to. Optional if the config email.out_address is set.</value>
        [DataMember(Name="from")]
        public string From { get; set; }
        /// <summary>
        /// Whether the body is to be treated as html. Default false.
        /// </summary>
        /// <value>Whether the body is to be treated as html. Default false.</value>
        [DataMember(Name="html")]
        public bool? Html { get; set; }
        /// <summary>
        /// A list of user ids to send the message to.
        /// </summary>
        /// <value>A list of user ids to send the message to.</value>
        [DataMember(Name="recipients")]
        public List<int?> Recipients { get; set; }
        /// <summary>
        /// The subject of the outgoing message.
        /// </summary>
        /// <value>The subject of the outgoing message.</value>
        [DataMember(Name="subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RawEmailResource {\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Html: ").Append(Html).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
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
            return Equals((RawEmailResource)obj);
        }

        /// <summary>
        /// Returns true if RawEmailResource instances are equal
        /// </summary>
        /// <param name="other">Instance of RawEmailResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RawEmailResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Body == other.Body ||
                    this.Body != null &&
                    this.Body.Equals(other.Body)
                ) && 
                (
                    this.From == other.From ||
                    this.From != null &&
                    this.From.Equals(other.From)
                ) && 
                (
                    this.Html == other.Html ||
                    this.Html != null &&
                    this.Html.Equals(other.Html)
                ) && 
                (
                    this.Recipients == other.Recipients ||
                    this.Recipients != null &&
                    this.Recipients.SequenceEqual(other.Recipients)
                ) && 
                (
                    this.Subject == other.Subject ||
                    this.Subject != null &&
                    this.Subject.Equals(other.Subject)
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
                    if (this.Body != null)
                    hash = hash * 59 + this.Body.GetHashCode();
                    if (this.From != null)
                    hash = hash * 59 + this.From.GetHashCode();
                    if (this.Html != null)
                    hash = hash * 59 + this.Html.GetHashCode();
                    if (this.Recipients != null)
                    hash = hash * 59 + this.Recipients.GetHashCode();
                    if (this.Subject != null)
                    hash = hash * 59 + this.Subject.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(RawEmailResource left, RawEmailResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RawEmailResource left, RawEmailResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
