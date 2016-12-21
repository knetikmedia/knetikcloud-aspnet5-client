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
    public partial class RevenueCountryReportResource :  IEquatable<RevenueCountryReportResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RevenueCountryReportResource" /> class.
        /// </summary>
        /// <param name="Country">Country.</param>
        /// <param name="Revenue">Revenue.</param>
        /// <param name="Volume">Volume.</param>
        public RevenueCountryReportResource(string Country = null, double? Revenue = null, long? Volume = null)
        {
            this.Country = Country;
            this.Revenue = Revenue;
            this.Volume = Volume;
            
        }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets Revenue
        /// </summary>
        [DataMember(Name="revenue")]
        public double? Revenue { get; set; }

        /// <summary>
        /// Gets or Sets Volume
        /// </summary>
        [DataMember(Name="volume")]
        public long? Volume { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RevenueCountryReportResource {\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Revenue: ").Append(Revenue).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
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
            return Equals((RevenueCountryReportResource)obj);
        }

        /// <summary>
        /// Returns true if RevenueCountryReportResource instances are equal
        /// </summary>
        /// <param name="other">Instance of RevenueCountryReportResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RevenueCountryReportResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.Revenue == other.Revenue ||
                    this.Revenue != null &&
                    this.Revenue.Equals(other.Revenue)
                ) && 
                (
                    this.Volume == other.Volume ||
                    this.Volume != null &&
                    this.Volume.Equals(other.Volume)
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
                    if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                    if (this.Revenue != null)
                    hash = hash * 59 + this.Revenue.GetHashCode();
                    if (this.Volume != null)
                    hash = hash * 59 + this.Volume.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(RevenueCountryReportResource left, RevenueCountryReportResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RevenueCountryReportResource left, RevenueCountryReportResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
