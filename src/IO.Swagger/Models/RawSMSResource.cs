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
    public partial class RawSMSResource :  IEquatable<RawSMSResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RawSMSResource" /> class.
        /// </summary>
        /// <param name="From">The phone number to attribute the outgoing message to. Optional if the config text.out_number is set..</param>
        /// <param name="Recipients">A list of user ids to send the message to. (required).</param>
        /// <param name="Text">The body of the outgoing text message. (required).</param>
        public RawSMSResource(string From = null, List<int?> Recipients = null, string Text = null)
        {
            // to ensure "Recipients" is required (not null)
            if (Recipients == null)
            {
                throw new InvalidDataException("Recipients is a required property for RawSMSResource and cannot be null");
            }
            else
            {
                this.Recipients = Recipients;
            }
            // to ensure "Text" is required (not null)
            if (Text == null)
            {
                throw new InvalidDataException("Text is a required property for RawSMSResource and cannot be null");
            }
            else
            {
                this.Text = Text;
            }
            this.From = From;
            
        }

        /// <summary>
        /// The phone number to attribute the outgoing message to. Optional if the config text.out_number is set.
        /// </summary>
        /// <value>The phone number to attribute the outgoing message to. Optional if the config text.out_number is set.</value>
        [DataMember(Name="from")]
        public string From { get; set; }

        /// <summary>
        /// A list of user ids to send the message to.
        /// </summary>
        /// <value>A list of user ids to send the message to.</value>
        [DataMember(Name="recipients")]
        public List<int?> Recipients { get; set; }

        /// <summary>
        /// The body of the outgoing text message.
        /// </summary>
        /// <value>The body of the outgoing text message.</value>
        [DataMember(Name="text")]
        public string Text { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RawSMSResource {\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return Equals((RawSMSResource)obj);
        }

        /// <summary>
        /// Returns true if RawSMSResource instances are equal
        /// </summary>
        /// <param name="other">Instance of RawSMSResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RawSMSResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.From == other.From ||
                    this.From != null &&
                    this.From.Equals(other.From)
                ) && 
                (
                    this.Recipients == other.Recipients ||
                    this.Recipients != null &&
                    this.Recipients.SequenceEqual(other.Recipients)
                ) && 
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
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
                    if (this.From != null)
                    hash = hash * 59 + this.From.GetHashCode();
                    if (this.Recipients != null)
                    hash = hash * 59 + this.Recipients.GetHashCode();
                    if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(RawSMSResource left, RawSMSResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RawSMSResource left, RawSMSResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
