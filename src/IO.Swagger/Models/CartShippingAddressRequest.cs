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
    public partial class CartShippingAddressRequest :  IEquatable<CartShippingAddressRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CartShippingAddressRequest" /> class.
        /// </summary>
        /// <param name="City">The city of the user.</param>
        /// <param name="CountryCodeIso3">The country code of the user.</param>
        /// <param name="Email">The email of the user.</param>
        /// <param name="FirstName">The first name of the user.</param>
        /// <param name="LastName">The last name of the user.</param>
        /// <param name="NamePrefix">NamePrefix.</param>
        /// <param name="OrderNotes">The order notes the user.</param>
        /// <param name="PhoneNumber">The phone number of the user.</param>
        /// <param name="PostalStateCode">The postal state code of the user.</param>
        /// <param name="ShippingAddressLine1">The shipping address of the user, first line.</param>
        /// <param name="ShippingAddressLine2">The shipping address of the user, second line.</param>
        /// <param name="Zip">The zipcode of the user.</param>
        public CartShippingAddressRequest(string City = default(string), string CountryCodeIso3 = default(string), string Email = default(string), string FirstName = default(string), string LastName = default(string), string NamePrefix = default(string), string OrderNotes = default(string), string PhoneNumber = default(string), string PostalStateCode = default(string), string ShippingAddressLine1 = default(string), string ShippingAddressLine2 = default(string), string Zip = default(string))
        {
            this.City = City;
            this.CountryCodeIso3 = CountryCodeIso3;
            this.Email = Email;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.NamePrefix = NamePrefix;
            this.OrderNotes = OrderNotes;
            this.PhoneNumber = PhoneNumber;
            this.PostalStateCode = PostalStateCode;
            this.ShippingAddressLine1 = ShippingAddressLine1;
            this.ShippingAddressLine2 = ShippingAddressLine2;
            this.Zip = Zip;
            
        }

        /// <summary>
        /// The city of the user
        /// </summary>
        /// <value>The city of the user</value>
        [DataMember(Name="city")]
        public string City { get; set; }
        /// <summary>
        /// The country code of the user
        /// </summary>
        /// <value>The country code of the user</value>
        [DataMember(Name="country_code_iso3")]
        public string CountryCodeIso3 { get; set; }
        /// <summary>
        /// The email of the user
        /// </summary>
        /// <value>The email of the user</value>
        [DataMember(Name="email")]
        public string Email { get; set; }
        /// <summary>
        /// The first name of the user
        /// </summary>
        /// <value>The first name of the user</value>
        [DataMember(Name="first_name")]
        public string FirstName { get; set; }
        /// <summary>
        /// The last name of the user
        /// </summary>
        /// <value>The last name of the user</value>
        [DataMember(Name="last_name")]
        public string LastName { get; set; }
        /// <summary>
        /// Gets or Sets NamePrefix
        /// </summary>
        [DataMember(Name="name_prefix")]
        public string NamePrefix { get; set; }
        /// <summary>
        /// The order notes the user
        /// </summary>
        /// <value>The order notes the user</value>
        [DataMember(Name="order_notes")]
        public string OrderNotes { get; set; }
        /// <summary>
        /// The phone number of the user
        /// </summary>
        /// <value>The phone number of the user</value>
        [DataMember(Name="phone_number")]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// The postal state code of the user
        /// </summary>
        /// <value>The postal state code of the user</value>
        [DataMember(Name="postal_state_code")]
        public string PostalStateCode { get; set; }
        /// <summary>
        /// The shipping address of the user, first line
        /// </summary>
        /// <value>The shipping address of the user, first line</value>
        [DataMember(Name="shipping_address_line1")]
        public string ShippingAddressLine1 { get; set; }
        /// <summary>
        /// The shipping address of the user, second line
        /// </summary>
        /// <value>The shipping address of the user, second line</value>
        [DataMember(Name="shipping_address_line2")]
        public string ShippingAddressLine2 { get; set; }
        /// <summary>
        /// The zipcode of the user
        /// </summary>
        /// <value>The zipcode of the user</value>
        [DataMember(Name="zip")]
        public string Zip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartShippingAddressRequest {\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CountryCodeIso3: ").Append(CountryCodeIso3).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  NamePrefix: ").Append(NamePrefix).Append("\n");
            sb.Append("  OrderNotes: ").Append(OrderNotes).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  PostalStateCode: ").Append(PostalStateCode).Append("\n");
            sb.Append("  ShippingAddressLine1: ").Append(ShippingAddressLine1).Append("\n");
            sb.Append("  ShippingAddressLine2: ").Append(ShippingAddressLine2).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
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
            return Equals((CartShippingAddressRequest)obj);
        }

        /// <summary>
        /// Returns true if CartShippingAddressRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CartShippingAddressRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartShippingAddressRequest other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.CountryCodeIso3 == other.CountryCodeIso3 ||
                    this.CountryCodeIso3 != null &&
                    this.CountryCodeIso3.Equals(other.CountryCodeIso3)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.NamePrefix == other.NamePrefix ||
                    this.NamePrefix != null &&
                    this.NamePrefix.Equals(other.NamePrefix)
                ) && 
                (
                    this.OrderNotes == other.OrderNotes ||
                    this.OrderNotes != null &&
                    this.OrderNotes.Equals(other.OrderNotes)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.PostalStateCode == other.PostalStateCode ||
                    this.PostalStateCode != null &&
                    this.PostalStateCode.Equals(other.PostalStateCode)
                ) && 
                (
                    this.ShippingAddressLine1 == other.ShippingAddressLine1 ||
                    this.ShippingAddressLine1 != null &&
                    this.ShippingAddressLine1.Equals(other.ShippingAddressLine1)
                ) && 
                (
                    this.ShippingAddressLine2 == other.ShippingAddressLine2 ||
                    this.ShippingAddressLine2 != null &&
                    this.ShippingAddressLine2.Equals(other.ShippingAddressLine2)
                ) && 
                (
                    this.Zip == other.Zip ||
                    this.Zip != null &&
                    this.Zip.Equals(other.Zip)
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
                    if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                    if (this.CountryCodeIso3 != null)
                    hash = hash * 59 + this.CountryCodeIso3.GetHashCode();
                    if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                    if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                    if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                    if (this.NamePrefix != null)
                    hash = hash * 59 + this.NamePrefix.GetHashCode();
                    if (this.OrderNotes != null)
                    hash = hash * 59 + this.OrderNotes.GetHashCode();
                    if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                    if (this.PostalStateCode != null)
                    hash = hash * 59 + this.PostalStateCode.GetHashCode();
                    if (this.ShippingAddressLine1 != null)
                    hash = hash * 59 + this.ShippingAddressLine1.GetHashCode();
                    if (this.ShippingAddressLine2 != null)
                    hash = hash * 59 + this.ShippingAddressLine2.GetHashCode();
                    if (this.Zip != null)
                    hash = hash * 59 + this.Zip.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(CartShippingAddressRequest left, CartShippingAddressRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CartShippingAddressRequest left, CartShippingAddressRequest right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
