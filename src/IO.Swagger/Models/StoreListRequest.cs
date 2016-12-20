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
    public partial class StoreListRequest :  IEquatable<StoreListRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreListRequest" /> class.
        /// </summary>
        /// <param name="IgnoreLocation">Whether the location is ignored.</param>
        /// <param name="InStockOnly">Whether the item is in stock.</param>
        /// <param name="Limit">The amount of items returned.</param>
        /// <param name="Page">The page of the request.</param>
        /// <param name="UseCatalog">Whether the catalog is used.</param>
        public StoreListRequest(bool? IgnoreLocation = null, bool? InStockOnly = null, int? Limit = null, int? Page = null, bool? UseCatalog = null)
        {
            this.IgnoreLocation = IgnoreLocation;
            this.InStockOnly = InStockOnly;
            this.Limit = Limit;
            this.Page = Page;
            this.UseCatalog = UseCatalog;
            
        }

        /// <summary>
        /// Whether the location is ignored
        /// </summary>
        /// <value>Whether the location is ignored</value>
        [DataMember(Name="ignore_location")]
        public bool? IgnoreLocation { get; set; }

        /// <summary>
        /// Whether the item is in stock
        /// </summary>
        /// <value>Whether the item is in stock</value>
        [DataMember(Name="in_stock_only")]
        public bool? InStockOnly { get; set; }

        /// <summary>
        /// The amount of items returned
        /// </summary>
        /// <value>The amount of items returned</value>
        [DataMember(Name="limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// The page of the request
        /// </summary>
        /// <value>The page of the request</value>
        [DataMember(Name="page")]
        public int? Page { get; set; }

        /// <summary>
        /// Whether the catalog is used
        /// </summary>
        /// <value>Whether the catalog is used</value>
        [DataMember(Name="use_catalog")]
        public bool? UseCatalog { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoreListRequest {\n");
            sb.Append("  IgnoreLocation: ").Append(IgnoreLocation).Append("\n");
            sb.Append("  InStockOnly: ").Append(InStockOnly).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  UseCatalog: ").Append(UseCatalog).Append("\n");
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
            return Equals((StoreListRequest)obj);
        }

        /// <summary>
        /// Returns true if StoreListRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of StoreListRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoreListRequest other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.IgnoreLocation == other.IgnoreLocation ||
                    this.IgnoreLocation != null &&
                    this.IgnoreLocation.Equals(other.IgnoreLocation)
                ) && 
                (
                    this.InStockOnly == other.InStockOnly ||
                    this.InStockOnly != null &&
                    this.InStockOnly.Equals(other.InStockOnly)
                ) && 
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
                ) && 
                (
                    this.Page == other.Page ||
                    this.Page != null &&
                    this.Page.Equals(other.Page)
                ) && 
                (
                    this.UseCatalog == other.UseCatalog ||
                    this.UseCatalog != null &&
                    this.UseCatalog.Equals(other.UseCatalog)
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
                    if (this.IgnoreLocation != null)
                    hash = hash * 59 + this.IgnoreLocation.GetHashCode();
                    if (this.InStockOnly != null)
                    hash = hash * 59 + this.InStockOnly.GetHashCode();
                    if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
                    if (this.Page != null)
                    hash = hash * 59 + this.Page.GetHashCode();
                    if (this.UseCatalog != null)
                    hash = hash * 59 + this.UseCatalog.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(StoreListRequest left, StoreListRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(StoreListRequest left, StoreListRequest right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
