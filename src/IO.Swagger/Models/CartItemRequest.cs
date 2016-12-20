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
    public partial class CartItemRequest :  IEquatable<CartItemRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartItemRequest" /> class.
        /// </summary>
        /// <param name="AffiliateKey">The affiliate key of the item.</param>
        /// <param name="CatalogSku">The catalog SKU of the item (required).</param>
        /// <param name="Quantity">The quantity of the item (required).</param>
        public CartItemRequest(string AffiliateKey = null, string CatalogSku = null, int? Quantity = null)
        {
            // to ensure "CatalogSku" is required (not null)
            if (CatalogSku == null)
            {
                throw new InvalidDataException("CatalogSku is a required property for CartItemRequest and cannot be null");
            }
            else
            {
                this.CatalogSku = CatalogSku;
            }
            // to ensure "Quantity" is required (not null)
            if (Quantity == null)
            {
                throw new InvalidDataException("Quantity is a required property for CartItemRequest and cannot be null");
            }
            else
            {
                this.Quantity = Quantity;
            }
            this.AffiliateKey = AffiliateKey;
            
        }

        /// <summary>
        /// The affiliate key of the item
        /// </summary>
        /// <value>The affiliate key of the item</value>
        [DataMember(Name="affiliate_key")]
        public string AffiliateKey { get; set; }

        /// <summary>
        /// The catalog SKU of the item
        /// </summary>
        /// <value>The catalog SKU of the item</value>
        [DataMember(Name="catalog_sku")]
        public string CatalogSku { get; set; }

        /// <summary>
        /// The quantity of the item
        /// </summary>
        /// <value>The quantity of the item</value>
        [DataMember(Name="quantity")]
        public int? Quantity { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartItemRequest {\n");
            sb.Append("  AffiliateKey: ").Append(AffiliateKey).Append("\n");
            sb.Append("  CatalogSku: ").Append(CatalogSku).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            return Equals((CartItemRequest)obj);
        }

        /// <summary>
        /// Returns true if CartItemRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CartItemRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartItemRequest other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.AffiliateKey == other.AffiliateKey ||
                    this.AffiliateKey != null &&
                    this.AffiliateKey.Equals(other.AffiliateKey)
                ) && 
                (
                    this.CatalogSku == other.CatalogSku ||
                    this.CatalogSku != null &&
                    this.CatalogSku.Equals(other.CatalogSku)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
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
                    if (this.AffiliateKey != null)
                    hash = hash * 59 + this.AffiliateKey.GetHashCode();
                    if (this.CatalogSku != null)
                    hash = hash * 59 + this.CatalogSku.GetHashCode();
                    if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(CartItemRequest left, CartItemRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CartItemRequest left, CartItemRequest right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
