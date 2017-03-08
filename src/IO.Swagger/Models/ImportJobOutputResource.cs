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
    public partial class ImportJobOutputResource :  IEquatable<ImportJobOutputResource>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportJobOutputResource" /> class.
        /// </summary>
        /// <param name="Description">The description of the import job.</param>
        /// <param name="LineNumber">The line number of the import job.</param>
        public ImportJobOutputResource(string Description = default(string), long? LineNumber = default(long?))
        {
            this.Description = Description;
            this.LineNumber = LineNumber;
            
        }

        /// <summary>
        /// The description of the import job
        /// </summary>
        /// <value>The description of the import job</value>
        [DataMember(Name="description")]
        public string Description { get; set; }
        /// <summary>
        /// The line number of the import job
        /// </summary>
        /// <value>The line number of the import job</value>
        [DataMember(Name="line_number")]
        public long? LineNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportJobOutputResource {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LineNumber: ").Append(LineNumber).Append("\n");
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
            return Equals((ImportJobOutputResource)obj);
        }

        /// <summary>
        /// Returns true if ImportJobOutputResource instances are equal
        /// </summary>
        /// <param name="other">Instance of ImportJobOutputResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportJobOutputResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.LineNumber == other.LineNumber ||
                    this.LineNumber != null &&
                    this.LineNumber.Equals(other.LineNumber)
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
                    if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                    if (this.LineNumber != null)
                    hash = hash * 59 + this.LineNumber.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(ImportJobOutputResource left, ImportJobOutputResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ImportJobOutputResource left, ImportJobOutputResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
