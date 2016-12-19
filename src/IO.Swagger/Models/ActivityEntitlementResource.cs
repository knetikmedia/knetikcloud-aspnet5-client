/*
 * Knetik Platform API Documentation Latest
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
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
    public partial class ActivityEntitlementResource :  IEquatable<ActivityEntitlementResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityEntitlementResource" /> class.
        /// </summary>
        /// <param name="CurrencyCode">The ISO3 currency code the price is in, if available.</param>
        /// <param name="ItemId">The id of the entitlement item (required).</param>
        /// <param name="Name">The name of the entitlement item.</param>
        /// <param name="Price">The price of the sku, if available.</param>
        /// <param name="Sku">The sku id, if available. If multiple are available, then first one is returned.</param>
        public ActivityEntitlementResource(string CurrencyCode = null, int? ItemId = null, string Name = null, double? Price = null, string Sku = null)
        {
            // to ensure "ItemId" is required (not null)
            if (ItemId == null)
            {
                throw new InvalidDataException("ItemId is a required property for ActivityEntitlementResource and cannot be null");
            }
            else
            {
                this.ItemId = ItemId;
            }
            this.CurrencyCode = CurrencyCode;
            this.Name = Name;
            this.Price = Price;
            this.Sku = Sku;
            
        }

        /// <summary>
        /// The ISO3 currency code the price is in, if available
        /// </summary>
        /// <value>The ISO3 currency code the price is in, if available</value>
        [DataMember(Name="currency_code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The id of the entitlement item
        /// </summary>
        /// <value>The id of the entitlement item</value>
        [DataMember(Name="item_id")]
        public int? ItemId { get; set; }

        /// <summary>
        /// The name of the entitlement item
        /// </summary>
        /// <value>The name of the entitlement item</value>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// The price of the sku, if available
        /// </summary>
        /// <value>The price of the sku, if available</value>
        [DataMember(Name="price")]
        public double? Price { get; set; }

        /// <summary>
        /// The sku id, if available. If multiple are available, then first one is returned
        /// </summary>
        /// <value>The sku id, if available. If multiple are available, then first one is returned</value>
        [DataMember(Name="sku")]
        public string Sku { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivityEntitlementResource {\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
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
            return Equals((ActivityEntitlementResource)obj);
        }

        /// <summary>
        /// Returns true if ActivityEntitlementResource instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivityEntitlementResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityEntitlementResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
                ) && 
                (
                    this.ItemId == other.ItemId ||
                    this.ItemId != null &&
                    this.ItemId.Equals(other.ItemId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Price == other.Price ||
                    this.Price != null &&
                    this.Price.Equals(other.Price)
                ) && 
                (
                    this.Sku == other.Sku ||
                    this.Sku != null &&
                    this.Sku.Equals(other.Sku)
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
                    if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
                    if (this.ItemId != null)
                    hash = hash * 59 + this.ItemId.GetHashCode();
                    if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                    if (this.Price != null)
                    hash = hash * 59 + this.Price.GetHashCode();
                    if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(ActivityEntitlementResource left, ActivityEntitlementResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ActivityEntitlementResource left, ActivityEntitlementResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
