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
    public partial class IOConfig :  IEquatable<IOConfig>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="IOConfig" /> class.
        /// </summary>
        /// <param name="Customer">Customer.</param>
        /// <param name="Enabled">Enabled.</param>
        /// <param name="Environment">Environment.</param>
        /// <param name="Product">Product.</param>
        public IOConfig(string Customer = default(string), bool? Enabled = default(bool?), string Environment = default(string), string Product = default(string))
        {
            this.Customer = Customer;
            this.Enabled = Enabled;
            this.Environment = Environment;
            this.Product = Product;
            
        }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name="customer")]
        public string Customer { get; set; }
        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Gets or Sets Environment
        /// </summary>
        [DataMember(Name="environment")]
        public string Environment { get; set; }
        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name="product")]
        public string Product { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IOConfig {\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
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
            return Equals((IOConfig)obj);
        }

        /// <summary>
        /// Returns true if IOConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of IOConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IOConfig other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Customer == other.Customer ||
                    this.Customer != null &&
                    this.Customer.Equals(other.Customer)
                ) && 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.Environment == other.Environment ||
                    this.Environment != null &&
                    this.Environment.Equals(other.Environment)
                ) && 
                (
                    this.Product == other.Product ||
                    this.Product != null &&
                    this.Product.Equals(other.Product)
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
                    if (this.Customer != null)
                    hash = hash * 59 + this.Customer.GetHashCode();
                    if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                    if (this.Environment != null)
                    hash = hash * 59 + this.Environment.GetHashCode();
                    if (this.Product != null)
                    hash = hash * 59 + this.Product.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(IOConfig left, IOConfig right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(IOConfig left, IOConfig right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
