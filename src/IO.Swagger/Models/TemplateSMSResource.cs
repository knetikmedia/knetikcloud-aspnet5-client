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
    public partial class TemplateSMSResource :  IEquatable<TemplateSMSResource>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateSMSResource" /> class.
        /// </summary>
        /// <param name="From">The phone number to attribute the outgoing message to. Optional if the config text.out_number is set..</param>
        /// <param name="Localizer">Localizer.</param>
        /// <param name="Recipients">A list of user ids to send the message to. (required).</param>
        /// <param name="TemplateKey">The key for the template. (required).</param>
        /// <param name="TemplateVars">A list of values to fill in the template. Order matters..</param>
        public TemplateSMSResource(string From = default(string), Localizer Localizer = default(Localizer), List<int?> Recipients = default(List<int?>), string TemplateKey = default(string), List<string> TemplateVars = default(List<string>))
        {
            // to ensure "Recipients" is required (not null)
            if (Recipients == null)
            {
                throw new InvalidDataException("Recipients is a required property for TemplateSMSResource and cannot be null");
            }
            else
            {
                this.Recipients = Recipients;
            }
            // to ensure "TemplateKey" is required (not null)
            if (TemplateKey == null)
            {
                throw new InvalidDataException("TemplateKey is a required property for TemplateSMSResource and cannot be null");
            }
            else
            {
                this.TemplateKey = TemplateKey;
            }
            this.From = From;
            this.Localizer = Localizer;
            this.TemplateVars = TemplateVars;
            
        }

        /// <summary>
        /// The phone number to attribute the outgoing message to. Optional if the config text.out_number is set.
        /// </summary>
        /// <value>The phone number to attribute the outgoing message to. Optional if the config text.out_number is set.</value>
        [DataMember(Name="from")]
        public string From { get; set; }
        /// <summary>
        /// Gets or Sets Localizer
        /// </summary>
        [DataMember(Name="localizer")]
        public Localizer Localizer { get; set; }
        /// <summary>
        /// A list of user ids to send the message to.
        /// </summary>
        /// <value>A list of user ids to send the message to.</value>
        [DataMember(Name="recipients")]
        public List<int?> Recipients { get; set; }
        /// <summary>
        /// The key for the template.
        /// </summary>
        /// <value>The key for the template.</value>
        [DataMember(Name="template_key")]
        public string TemplateKey { get; set; }
        /// <summary>
        /// A list of values to fill in the template. Order matters.
        /// </summary>
        /// <value>A list of values to fill in the template. Order matters.</value>
        [DataMember(Name="template_vars")]
        public List<string> TemplateVars { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateSMSResource {\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Localizer: ").Append(Localizer).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  TemplateKey: ").Append(TemplateKey).Append("\n");
            sb.Append("  TemplateVars: ").Append(TemplateVars).Append("\n");
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
            return Equals((TemplateSMSResource)obj);
        }

        /// <summary>
        /// Returns true if TemplateSMSResource instances are equal
        /// </summary>
        /// <param name="other">Instance of TemplateSMSResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateSMSResource other)
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
                    this.Localizer == other.Localizer ||
                    this.Localizer != null &&
                    this.Localizer.Equals(other.Localizer)
                ) && 
                (
                    this.Recipients == other.Recipients ||
                    this.Recipients != null &&
                    this.Recipients.SequenceEqual(other.Recipients)
                ) && 
                (
                    this.TemplateKey == other.TemplateKey ||
                    this.TemplateKey != null &&
                    this.TemplateKey.Equals(other.TemplateKey)
                ) && 
                (
                    this.TemplateVars == other.TemplateVars ||
                    this.TemplateVars != null &&
                    this.TemplateVars.SequenceEqual(other.TemplateVars)
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
                    if (this.Localizer != null)
                    hash = hash * 59 + this.Localizer.GetHashCode();
                    if (this.Recipients != null)
                    hash = hash * 59 + this.Recipients.GetHashCode();
                    if (this.TemplateKey != null)
                    hash = hash * 59 + this.TemplateKey.GetHashCode();
                    if (this.TemplateVars != null)
                    hash = hash * 59 + this.TemplateVars.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(TemplateSMSResource left, TemplateSMSResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TemplateSMSResource left, TemplateSMSResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
