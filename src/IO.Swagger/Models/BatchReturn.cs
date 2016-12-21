/*
 * Knetik Platform API Documentation Latest
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://demo.sandbox.knetikcloud.com
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
    public partial class BatchReturn :  IEquatable<BatchReturn>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchReturn" /> class.
        /// </summary>
        /// <param name="Body">The result body (required).</param>
        /// <param name="Code">The HTTP response code (required).</param>
        /// <param name="Uri">Full URI of REST call (required).</param>
        public BatchReturn(Result Body = null, int? Code = null, string Uri = null)
        {
            // to ensure "Body" is required (not null)
            if (Body == null)
            {
                throw new InvalidDataException("Body is a required property for BatchReturn and cannot be null");
            }
            else
            {
                this.Body = Body;
            }
            // to ensure "Code" is required (not null)
            if (Code == null)
            {
                throw new InvalidDataException("Code is a required property for BatchReturn and cannot be null");
            }
            else
            {
                this.Code = Code;
            }
            // to ensure "Uri" is required (not null)
            if (Uri == null)
            {
                throw new InvalidDataException("Uri is a required property for BatchReturn and cannot be null");
            }
            else
            {
                this.Uri = Uri;
            }
            
        }

        /// <summary>
        /// The result body
        /// </summary>
        /// <value>The result body</value>
        [DataMember(Name="body")]
        public Result Body { get; set; }

        /// <summary>
        /// The HTTP response code
        /// </summary>
        /// <value>The HTTP response code</value>
        [DataMember(Name="code")]
        public int? Code { get; set; }

        /// <summary>
        /// Full URI of REST call
        /// </summary>
        /// <value>Full URI of REST call</value>
        [DataMember(Name="uri")]
        public string Uri { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchReturn {\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
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
            return Equals((BatchReturn)obj);
        }

        /// <summary>
        /// Returns true if BatchReturn instances are equal
        /// </summary>
        /// <param name="other">Instance of BatchReturn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchReturn other)
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
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
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
                    if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                    if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(BatchReturn left, BatchReturn right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BatchReturn left, BatchReturn right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
