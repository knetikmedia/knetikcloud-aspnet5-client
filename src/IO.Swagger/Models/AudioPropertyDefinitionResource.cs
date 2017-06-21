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
    public partial class AudioPropertyDefinitionResource : PropertyDefinitionResource,  IEquatable<AudioPropertyDefinitionResource>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioPropertyDefinitionResource" /> class.
        /// </summary>
        /// <param name="FieldList">A list of the fields on both the property definition and property of this type.</param>
        /// <param name="Name">The name of the property (required).</param>
        /// <param name="Required">Whether the property is required (required).</param>
        /// <param name="Type">The type of the property. Used for polymorphic type recognition and thus must match an expected type with additional properties. (required).</param>
        /// <param name="FileType">If provided, a file type the property must match.</param>
        /// <param name="MaxLength">If provided, the maximum length of the audio.</param>
        /// <param name="MinLength">If provided, the minimum length of the audio.</param>
        public AudioPropertyDefinitionResource(PropertyFieldListResource FieldList = default(PropertyFieldListResource), string Name = default(string), bool? Required = default(bool?), string Type = default(string), string FileType = default(string), int? MaxLength = default(int?), int? MinLength = default(int?))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for AudioPropertyDefinitionResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Required" is required (not null)
            if (Required == null)
            {
                throw new InvalidDataException("Required is a required property for AudioPropertyDefinitionResource and cannot be null");
            }
            else
            {
                this.Required = Required;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for AudioPropertyDefinitionResource and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.FieldList = FieldList;
            this.FileType = FileType;
            this.MaxLength = MaxLength;
            this.MinLength = MinLength;
            
        }

        /// <summary>
        /// A list of the fields on both the property definition and property of this type
        /// </summary>
        /// <value>A list of the fields on both the property definition and property of this type</value>
        [DataMember(Name="field_list")]
        public PropertyFieldListResource FieldList { get; set; }
        /// <summary>
        /// The name of the property
        /// </summary>
        /// <value>The name of the property</value>
        [DataMember(Name="name")]
        public string Name { get; set; }
        /// <summary>
        /// Whether the property is required
        /// </summary>
        /// <value>Whether the property is required</value>
        [DataMember(Name="required")]
        public bool? Required { get; set; }
        /// <summary>
        /// The type of the property. Used for polymorphic type recognition and thus must match an expected type with additional properties.
        /// </summary>
        /// <value>The type of the property. Used for polymorphic type recognition and thus must match an expected type with additional properties.</value>
        [DataMember(Name="type")]
        public string Type { get; set; }
        /// <summary>
        /// If provided, a file type the property must match
        /// </summary>
        /// <value>If provided, a file type the property must match</value>
        [DataMember(Name="file_type")]
        public string FileType { get; set; }
        /// <summary>
        /// If provided, the maximum length of the audio
        /// </summary>
        /// <value>If provided, the maximum length of the audio</value>
        [DataMember(Name="max_length")]
        public int? MaxLength { get; set; }
        /// <summary>
        /// If provided, the minimum length of the audio
        /// </summary>
        /// <value>If provided, the minimum length of the audio</value>
        [DataMember(Name="min_length")]
        public int? MinLength { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AudioPropertyDefinitionResource {\n");
            sb.Append("  FieldList: ").Append(FieldList).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
            sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
            sb.Append("  MinLength: ").Append(MinLength).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            return Equals((AudioPropertyDefinitionResource)obj);
        }

        /// <summary>
        /// Returns true if AudioPropertyDefinitionResource instances are equal
        /// </summary>
        /// <param name="other">Instance of AudioPropertyDefinitionResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AudioPropertyDefinitionResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.FieldList == other.FieldList ||
                    this.FieldList != null &&
                    this.FieldList.Equals(other.FieldList)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Required == other.Required ||
                    this.Required != null &&
                    this.Required.Equals(other.Required)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.FileType == other.FileType ||
                    this.FileType != null &&
                    this.FileType.Equals(other.FileType)
                ) && 
                (
                    this.MaxLength == other.MaxLength ||
                    this.MaxLength != null &&
                    this.MaxLength.Equals(other.MaxLength)
                ) && 
                (
                    this.MinLength == other.MinLength ||
                    this.MinLength != null &&
                    this.MinLength.Equals(other.MinLength)
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
                    if (this.FieldList != null)
                    hash = hash * 59 + this.FieldList.GetHashCode();
                    if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                    if (this.Required != null)
                    hash = hash * 59 + this.Required.GetHashCode();
                    if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                    if (this.FileType != null)
                    hash = hash * 59 + this.FileType.GetHashCode();
                    if (this.MaxLength != null)
                    hash = hash * 59 + this.MaxLength.GetHashCode();
                    if (this.MinLength != null)
                    hash = hash * 59 + this.MinLength.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(AudioPropertyDefinitionResource left, AudioPropertyDefinitionResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AudioPropertyDefinitionResource left, AudioPropertyDefinitionResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
