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
    public partial class SampleCountriesResponse :  IEquatable<SampleCountriesResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleCountriesResponse" /> class.
        /// </summary>
        /// <param name="VendorId1">VendorId1.</param>
        /// <param name="VendorId2">VendorId2.</param>
        public SampleCountriesResponse(List<Country> VendorId1 = null, List<Country> VendorId2 = null)
        {
            this.VendorId1 = VendorId1;
            this.VendorId2 = VendorId2;
            
        }

        /// <summary>
        /// Gets or Sets VendorId1
        /// </summary>
        [DataMember(Name="vendor_id1")]
        public List<Country> VendorId1 { get; set; }

        /// <summary>
        /// Gets or Sets VendorId2
        /// </summary>
        [DataMember(Name="vendor_id2")]
        public List<Country> VendorId2 { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SampleCountriesResponse {\n");
            sb.Append("  VendorId1: ").Append(VendorId1).Append("\n");
            sb.Append("  VendorId2: ").Append(VendorId2).Append("\n");
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
            return Equals((SampleCountriesResponse)obj);
        }

        /// <summary>
        /// Returns true if SampleCountriesResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SampleCountriesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SampleCountriesResponse other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.VendorId1 == other.VendorId1 ||
                    this.VendorId1 != null &&
                    this.VendorId1.SequenceEqual(other.VendorId1)
                ) && 
                (
                    this.VendorId2 == other.VendorId2 ||
                    this.VendorId2 != null &&
                    this.VendorId2.SequenceEqual(other.VendorId2)
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
                    if (this.VendorId1 != null)
                    hash = hash * 59 + this.VendorId1.GetHashCode();
                    if (this.VendorId2 != null)
                    hash = hash * 59 + this.VendorId2.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(SampleCountriesResponse left, SampleCountriesResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SampleCountriesResponse left, SampleCountriesResponse right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
