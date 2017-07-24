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
    public partial class ImageGroupPropertyDefinitionResource : FileGroupPropertyDefinitionResource,  IEquatable<ImageGroupPropertyDefinitionResource>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGroupPropertyDefinitionResource" /> class.
        /// </summary>
        /// <param name="FieldList">A list of the fields on both the property definition and property of this type.</param>
        /// <param name="Name">The name of the property (required).</param>
        /// <param name="Required">Whether the property is required (required).</param>
        /// <param name="Type">The type of the property. Used for polymorphic type recognition and thus must match an expected type with additional properties. (required).</param>
        /// <param name="FileType">If provided, a file type that the property must match.</param>
        /// <param name="MaxCount">If provided, the maximum number of files in the group.</param>
        /// <param name="MaxFileSize">If provided, the maximum allowed size per file in bytes.</param>
        /// <param name="MinCount">If provided, the minimum number of files in the group.</param>
        /// <param name="MaxHeight">If provided, the maximum height of each image.</param>
        /// <param name="MaxWidth">If provided, the maximum width of each image.</param>
        /// <param name="MinHeight">If provided, the minimum height of each image.</param>
        /// <param name="MinWidth">If provided, the minumum width of each image.</param>
        public ImageGroupPropertyDefinitionResource(PropertyFieldListResource FieldList = default(PropertyFieldListResource), string Name = default(string), bool? Required = default(bool?), string Type = default(string), string FileType = default(string), int? MaxCount = default(int?), long? MaxFileSize = default(long?), int? MinCount = default(int?), int? MaxHeight = default(int?), int? MaxWidth = default(int?), int? MinHeight = default(int?), int? MinWidth = default(int?))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ImageGroupPropertyDefinitionResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Required" is required (not null)
            if (Required == null)
            {
                throw new InvalidDataException("Required is a required property for ImageGroupPropertyDefinitionResource and cannot be null");
            }
            else
            {
                this.Required = Required;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for ImageGroupPropertyDefinitionResource and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.FieldList = FieldList;
            this.FileType = FileType;
            this.MaxCount = MaxCount;
            this.MaxFileSize = MaxFileSize;
            this.MinCount = MinCount;
            this.MaxHeight = MaxHeight;
            this.MaxWidth = MaxWidth;
            this.MinHeight = MinHeight;
            this.MinWidth = MinWidth;
            
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
        /// If provided, a file type that the property must match
        /// </summary>
        /// <value>If provided, a file type that the property must match</value>
        [DataMember(Name="file_type")]
        public string FileType { get; set; }
        /// <summary>
        /// If provided, the maximum number of files in the group
        /// </summary>
        /// <value>If provided, the maximum number of files in the group</value>
        [DataMember(Name="max_count")]
        public int? MaxCount { get; set; }
        /// <summary>
        /// If provided, the maximum allowed size per file in bytes
        /// </summary>
        /// <value>If provided, the maximum allowed size per file in bytes</value>
        [DataMember(Name="max_file_size")]
        public long? MaxFileSize { get; set; }
        /// <summary>
        /// If provided, the minimum number of files in the group
        /// </summary>
        /// <value>If provided, the minimum number of files in the group</value>
        [DataMember(Name="min_count")]
        public int? MinCount { get; set; }
        /// <summary>
        /// If provided, the maximum height of each image
        /// </summary>
        /// <value>If provided, the maximum height of each image</value>
        [DataMember(Name="max_height")]
        public int? MaxHeight { get; set; }
        /// <summary>
        /// If provided, the maximum width of each image
        /// </summary>
        /// <value>If provided, the maximum width of each image</value>
        [DataMember(Name="max_width")]
        public int? MaxWidth { get; set; }
        /// <summary>
        /// If provided, the minimum height of each image
        /// </summary>
        /// <value>If provided, the minimum height of each image</value>
        [DataMember(Name="min_height")]
        public int? MinHeight { get; set; }
        /// <summary>
        /// If provided, the minumum width of each image
        /// </summary>
        /// <value>If provided, the minumum width of each image</value>
        [DataMember(Name="min_width")]
        public int? MinWidth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageGroupPropertyDefinitionResource {\n");
            sb.Append("  FieldList: ").Append(FieldList).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
            sb.Append("  MaxCount: ").Append(MaxCount).Append("\n");
            sb.Append("  MaxFileSize: ").Append(MaxFileSize).Append("\n");
            sb.Append("  MinCount: ").Append(MinCount).Append("\n");
            sb.Append("  MaxHeight: ").Append(MaxHeight).Append("\n");
            sb.Append("  MaxWidth: ").Append(MaxWidth).Append("\n");
            sb.Append("  MinHeight: ").Append(MinHeight).Append("\n");
            sb.Append("  MinWidth: ").Append(MinWidth).Append("\n");
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
            return Equals((ImageGroupPropertyDefinitionResource)obj);
        }

        /// <summary>
        /// Returns true if ImageGroupPropertyDefinitionResource instances are equal
        /// </summary>
        /// <param name="other">Instance of ImageGroupPropertyDefinitionResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageGroupPropertyDefinitionResource other)
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
                    this.MaxCount == other.MaxCount ||
                    this.MaxCount != null &&
                    this.MaxCount.Equals(other.MaxCount)
                ) && 
                (
                    this.MaxFileSize == other.MaxFileSize ||
                    this.MaxFileSize != null &&
                    this.MaxFileSize.Equals(other.MaxFileSize)
                ) && 
                (
                    this.MinCount == other.MinCount ||
                    this.MinCount != null &&
                    this.MinCount.Equals(other.MinCount)
                ) && 
                (
                    this.MaxHeight == other.MaxHeight ||
                    this.MaxHeight != null &&
                    this.MaxHeight.Equals(other.MaxHeight)
                ) && 
                (
                    this.MaxWidth == other.MaxWidth ||
                    this.MaxWidth != null &&
                    this.MaxWidth.Equals(other.MaxWidth)
                ) && 
                (
                    this.MinHeight == other.MinHeight ||
                    this.MinHeight != null &&
                    this.MinHeight.Equals(other.MinHeight)
                ) && 
                (
                    this.MinWidth == other.MinWidth ||
                    this.MinWidth != null &&
                    this.MinWidth.Equals(other.MinWidth)
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
                    if (this.MaxCount != null)
                    hash = hash * 59 + this.MaxCount.GetHashCode();
                    if (this.MaxFileSize != null)
                    hash = hash * 59 + this.MaxFileSize.GetHashCode();
                    if (this.MinCount != null)
                    hash = hash * 59 + this.MinCount.GetHashCode();
                    if (this.MaxHeight != null)
                    hash = hash * 59 + this.MaxHeight.GetHashCode();
                    if (this.MaxWidth != null)
                    hash = hash * 59 + this.MaxWidth.GetHashCode();
                    if (this.MinHeight != null)
                    hash = hash * 59 + this.MinHeight.GetHashCode();
                    if (this.MinWidth != null)
                    hash = hash * 59 + this.MinWidth.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(ImageGroupPropertyDefinitionResource left, ImageGroupPropertyDefinitionResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ImageGroupPropertyDefinitionResource left, ImageGroupPropertyDefinitionResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
