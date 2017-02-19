/*
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://knetikcloud.com
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
    public partial class RewardItemResource :  IEquatable<RewardItemResource>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RewardItemResource" /> class.
        /// </summary>
        /// <param name="ItemId">The id of the item to reward (required).</param>
        /// <param name="ItemName">The name of the item to reward (read only, set by id).</param>
        /// <param name="MaxRank">The highest number (worst) rank to give the reward to. Must be greater than or equal to minRank (required).</param>
        /// <param name="MinRank">The lowest number (best) rank to give the reward to. Must be greater than zero (required).</param>
        /// <param name="Quantity">How many copies to give (required).</param>
        public RewardItemResource(int? ItemId = default(int?), string ItemName = default(string), int? MaxRank = default(int?), int? MinRank = default(int?), int? Quantity = default(int?))
        {
            // to ensure "ItemId" is required (not null)
            if (ItemId == null)
            {
                throw new InvalidDataException("ItemId is a required property for RewardItemResource and cannot be null");
            }
            else
            {
                this.ItemId = ItemId;
            }
            // to ensure "MaxRank" is required (not null)
            if (MaxRank == null)
            {
                throw new InvalidDataException("MaxRank is a required property for RewardItemResource and cannot be null");
            }
            else
            {
                this.MaxRank = MaxRank;
            }
            // to ensure "MinRank" is required (not null)
            if (MinRank == null)
            {
                throw new InvalidDataException("MinRank is a required property for RewardItemResource and cannot be null");
            }
            else
            {
                this.MinRank = MinRank;
            }
            // to ensure "Quantity" is required (not null)
            if (Quantity == null)
            {
                throw new InvalidDataException("Quantity is a required property for RewardItemResource and cannot be null");
            }
            else
            {
                this.Quantity = Quantity;
            }
            this.ItemName = ItemName;
            
        }

        /// <summary>
        /// The id of the item to reward
        /// </summary>
        /// <value>The id of the item to reward</value>
        [DataMember(Name="item_id")]
        public int? ItemId { get; set; }
        /// <summary>
        /// The name of the item to reward (read only, set by id)
        /// </summary>
        /// <value>The name of the item to reward (read only, set by id)</value>
        [DataMember(Name="item_name")]
        public string ItemName { get; set; }
        /// <summary>
        /// The highest number (worst) rank to give the reward to. Must be greater than or equal to minRank
        /// </summary>
        /// <value>The highest number (worst) rank to give the reward to. Must be greater than or equal to minRank</value>
        [DataMember(Name="max_rank")]
        public int? MaxRank { get; set; }
        /// <summary>
        /// The lowest number (best) rank to give the reward to. Must be greater than zero
        /// </summary>
        /// <value>The lowest number (best) rank to give the reward to. Must be greater than zero</value>
        [DataMember(Name="min_rank")]
        public int? MinRank { get; set; }
        /// <summary>
        /// How many copies to give
        /// </summary>
        /// <value>How many copies to give</value>
        [DataMember(Name="quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RewardItemResource {\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  ItemName: ").Append(ItemName).Append("\n");
            sb.Append("  MaxRank: ").Append(MaxRank).Append("\n");
            sb.Append("  MinRank: ").Append(MinRank).Append("\n");
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
            return Equals((RewardItemResource)obj);
        }

        /// <summary>
        /// Returns true if RewardItemResource instances are equal
        /// </summary>
        /// <param name="other">Instance of RewardItemResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RewardItemResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.ItemId == other.ItemId ||
                    this.ItemId != null &&
                    this.ItemId.Equals(other.ItemId)
                ) && 
                (
                    this.ItemName == other.ItemName ||
                    this.ItemName != null &&
                    this.ItemName.Equals(other.ItemName)
                ) && 
                (
                    this.MaxRank == other.MaxRank ||
                    this.MaxRank != null &&
                    this.MaxRank.Equals(other.MaxRank)
                ) && 
                (
                    this.MinRank == other.MinRank ||
                    this.MinRank != null &&
                    this.MinRank.Equals(other.MinRank)
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
                    if (this.ItemId != null)
                    hash = hash * 59 + this.ItemId.GetHashCode();
                    if (this.ItemName != null)
                    hash = hash * 59 + this.ItemName.GetHashCode();
                    if (this.MaxRank != null)
                    hash = hash * 59 + this.MaxRank.GetHashCode();
                    if (this.MinRank != null)
                    hash = hash * 59 + this.MinRank.GetHashCode();
                    if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(RewardItemResource left, RewardItemResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RewardItemResource left, RewardItemResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
