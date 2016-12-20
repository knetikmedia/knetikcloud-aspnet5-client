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
    public partial class AddressResource :  IEquatable<AddressResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressResource" /> class.
        /// </summary>
        /// <param name="Address1">The first line of the address (required).</param>
        /// <param name="Address2">A second line of the address.</param>
        /// <param name="City">The city (required).</param>
        /// <param name="CountryCode">The iso3 code for the country (required).</param>
        /// <param name="PostalCode">The postal code.</param>
        /// <param name="StateCode">The code for the state. Required if the country has states/provinces/equivalent.</param>
        public AddressResource(string Address1 = null, string Address2 = null, string City = null, string CountryCode = null, string PostalCode = null, string StateCode = null)
        {
            // to ensure "Address1" is required (not null)
            if (Address1 == null)
            {
                throw new InvalidDataException("Address1 is a required property for AddressResource and cannot be null");
            }
            else
            {
                this.Address1 = Address1;
            }
            // to ensure "City" is required (not null)
            if (City == null)
            {
                throw new InvalidDataException("City is a required property for AddressResource and cannot be null");
            }
            else
            {
                this.City = City;
            }
            // to ensure "CountryCode" is required (not null)
            if (CountryCode == null)
            {
                throw new InvalidDataException("CountryCode is a required property for AddressResource and cannot be null");
            }
            else
            {
                this.CountryCode = CountryCode;
            }
            this.Address2 = Address2;
            this.PostalCode = PostalCode;
            this.StateCode = StateCode;
            
        }

        /// <summary>
        /// The first line of the address
        /// </summary>
        /// <value>The first line of the address</value>
        [DataMember(Name="address1")]
        public string Address1 { get; set; }

        /// <summary>
        /// A second line of the address
        /// </summary>
        /// <value>A second line of the address</value>
        [DataMember(Name="address2")]
        public string Address2 { get; set; }

        /// <summary>
        /// The city
        /// </summary>
        /// <value>The city</value>
        [DataMember(Name="city")]
        public string City { get; set; }

        /// <summary>
        /// The iso3 code for the country
        /// </summary>
        /// <value>The iso3 code for the country</value>
        [DataMember(Name="country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// The postal code
        /// </summary>
        /// <value>The postal code</value>
        [DataMember(Name="postal_code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// The code for the state. Required if the country has states/provinces/equivalent
        /// </summary>
        /// <value>The code for the state. Required if the country has states/provinces/equivalent</value>
        [DataMember(Name="state_code")]
        public string StateCode { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressResource {\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  StateCode: ").Append(StateCode).Append("\n");
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
            return Equals((AddressResource)obj);
        }

        /// <summary>
        /// Returns true if AddressResource instances are equal
        /// </summary>
        /// <param name="other">Instance of AddressResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Address1 == other.Address1 ||
                    this.Address1 != null &&
                    this.Address1.Equals(other.Address1)
                ) && 
                (
                    this.Address2 == other.Address2 ||
                    this.Address2 != null &&
                    this.Address2.Equals(other.Address2)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.CountryCode == other.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(other.CountryCode)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
                ) && 
                (
                    this.StateCode == other.StateCode ||
                    this.StateCode != null &&
                    this.StateCode.Equals(other.StateCode)
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
                    if (this.Address1 != null)
                    hash = hash * 59 + this.Address1.GetHashCode();
                    if (this.Address2 != null)
                    hash = hash * 59 + this.Address2.GetHashCode();
                    if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                    if (this.CountryCode != null)
                    hash = hash * 59 + this.CountryCode.GetHashCode();
                    if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                    if (this.StateCode != null)
                    hash = hash * 59 + this.StateCode.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(AddressResource left, AddressResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AddressResource left, AddressResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
