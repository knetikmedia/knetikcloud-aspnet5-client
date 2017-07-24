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
    public partial class CountryResource :  IEquatable<CountryResource>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CountryResource" /> class.
        /// </summary>
        /// <param name="Iso2">The iso2 of the country.</param>
        /// <param name="Iso3">The iso3 of the country.</param>
        /// <param name="Name">The name of the country resource.</param>
        public CountryResource()
        {
            this.Iso2 = Iso2;
            this.Iso3 = Iso3;
            this.Name = Name;
            
        }

        /// <summary>
        /// The iso2 of the country
        /// </summary>
        /// <value>The iso2 of the country</value>
        [DataMember(Name="iso2")]
        public string Iso2 { get; private set; }
        /// <summary>
        /// The iso3 of the country
        /// </summary>
        /// <value>The iso3 of the country</value>
        [DataMember(Name="iso3")]
        public string Iso3 { get; private set; }
        /// <summary>
        /// The name of the country resource
        /// </summary>
        /// <value>The name of the country resource</value>
        [DataMember(Name="name")]
        public string Name { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CountryResource {\n");
            sb.Append("  Iso2: ").Append(Iso2).Append("\n");
            sb.Append("  Iso3: ").Append(Iso3).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return Equals((CountryResource)obj);
        }

        /// <summary>
        /// Returns true if CountryResource instances are equal
        /// </summary>
        /// <param name="other">Instance of CountryResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CountryResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Iso2 == other.Iso2 ||
                    this.Iso2 != null &&
                    this.Iso2.Equals(other.Iso2)
                ) && 
                (
                    this.Iso3 == other.Iso3 ||
                    this.Iso3 != null &&
                    this.Iso3.Equals(other.Iso3)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                    if (this.Iso2 != null)
                    hash = hash * 59 + this.Iso2.GetHashCode();
                    if (this.Iso3 != null)
                    hash = hash * 59 + this.Iso3.GetHashCode();
                    if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(CountryResource left, CountryResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CountryResource left, CountryResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
