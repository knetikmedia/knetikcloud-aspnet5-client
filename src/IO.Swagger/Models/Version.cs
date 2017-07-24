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
    public partial class Version :  IEquatable<Version>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Version" /> class.
        /// </summary>
        /// <param name="_Version">_Version.</param>
        public Version(string _Version = default(string))
        {
            this._Version = _Version;
            
        }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name="version")]
        public string _Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Version {\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
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
            return Equals((Version)obj);
        }

        /// <summary>
        /// Returns true if Version instances are equal
        /// </summary>
        /// <param name="other">Instance of Version to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Version other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this._Version == other._Version ||
                    this._Version != null &&
                    this._Version.Equals(other._Version)
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
                    if (this._Version != null)
                    hash = hash * 59 + this._Version.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(Version left, Version right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Version left, Version right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
