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
    public partial class SearchReferenceMapping :  IEquatable<SearchReferenceMapping>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchReferenceMapping" /> class.
        /// </summary>
        /// <param name="Id">Unique identifier for the mapping to protect against duplicates (required).</param>
        /// <param name="RefIdField">The field within the type that contains the id from the refType (required).</param>
        /// <param name="RefType">The index type that the mapping pulls data from (required).</param>
        /// <param name="SourceFieldToDestinationField">A map whose keys are the field names in the refType and values are the field name in the type (required).</param>
        /// <param name="Type">The index type that the mapping is for (required).</param>
        public SearchReferenceMapping(string Id = default(string), string RefIdField = default(string), string RefType = default(string), Dictionary<string, string> SourceFieldToDestinationField = default(Dictionary<string, string>), string Type = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for SearchReferenceMapping and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "RefIdField" is required (not null)
            if (RefIdField == null)
            {
                throw new InvalidDataException("RefIdField is a required property for SearchReferenceMapping and cannot be null");
            }
            else
            {
                this.RefIdField = RefIdField;
            }
            // to ensure "RefType" is required (not null)
            if (RefType == null)
            {
                throw new InvalidDataException("RefType is a required property for SearchReferenceMapping and cannot be null");
            }
            else
            {
                this.RefType = RefType;
            }
            // to ensure "SourceFieldToDestinationField" is required (not null)
            if (SourceFieldToDestinationField == null)
            {
                throw new InvalidDataException("SourceFieldToDestinationField is a required property for SearchReferenceMapping and cannot be null");
            }
            else
            {
                this.SourceFieldToDestinationField = SourceFieldToDestinationField;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for SearchReferenceMapping and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            
        }

        /// <summary>
        /// Unique identifier for the mapping to protect against duplicates
        /// </summary>
        /// <value>Unique identifier for the mapping to protect against duplicates</value>
        [DataMember(Name="id")]
        public string Id { get; set; }
        /// <summary>
        /// The field within the type that contains the id from the refType
        /// </summary>
        /// <value>The field within the type that contains the id from the refType</value>
        [DataMember(Name="ref_id_field")]
        public string RefIdField { get; set; }
        /// <summary>
        /// The index type that the mapping pulls data from
        /// </summary>
        /// <value>The index type that the mapping pulls data from</value>
        [DataMember(Name="ref_type")]
        public string RefType { get; set; }
        /// <summary>
        /// A map whose keys are the field names in the refType and values are the field name in the type
        /// </summary>
        /// <value>A map whose keys are the field names in the refType and values are the field name in the type</value>
        [DataMember(Name="source_field_to_destination_field")]
        public Dictionary<string, string> SourceFieldToDestinationField { get; set; }
        /// <summary>
        /// The index type that the mapping is for
        /// </summary>
        /// <value>The index type that the mapping is for</value>
        [DataMember(Name="type")]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchReferenceMapping {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RefIdField: ").Append(RefIdField).Append("\n");
            sb.Append("  RefType: ").Append(RefType).Append("\n");
            sb.Append("  SourceFieldToDestinationField: ").Append(SourceFieldToDestinationField).Append("\n");
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
            return Equals((SearchReferenceMapping)obj);
        }

        /// <summary>
        /// Returns true if SearchReferenceMapping instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchReferenceMapping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchReferenceMapping other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.RefIdField == other.RefIdField ||
                    this.RefIdField != null &&
                    this.RefIdField.Equals(other.RefIdField)
                ) && 
                (
                    this.RefType == other.RefType ||
                    this.RefType != null &&
                    this.RefType.Equals(other.RefType)
                ) && 
                (
                    this.SourceFieldToDestinationField == other.SourceFieldToDestinationField ||
                    this.SourceFieldToDestinationField != null &&
                    this.SourceFieldToDestinationField.SequenceEqual(other.SourceFieldToDestinationField)
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
                    if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                    if (this.RefIdField != null)
                    hash = hash * 59 + this.RefIdField.GetHashCode();
                    if (this.RefType != null)
                    hash = hash * 59 + this.RefType.GetHashCode();
                    if (this.SourceFieldToDestinationField != null)
                    hash = hash * 59 + this.SourceFieldToDestinationField.GetHashCode();
                    if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(SearchReferenceMapping left, SearchReferenceMapping right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SearchReferenceMapping left, SearchReferenceMapping right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
