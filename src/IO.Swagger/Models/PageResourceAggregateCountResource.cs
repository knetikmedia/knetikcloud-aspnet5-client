/*
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://demo.sandbox.knetikcloud.com
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
    public partial class PageResourceAggregateCountResource :  IEquatable<PageResourceAggregateCountResource>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PageResourceAggregateCountResource" /> class.
        /// </summary>
        /// <param name="Content">Content.</param>
        /// <param name="First">First.</param>
        /// <param name="Last">Last.</param>
        /// <param name="Number">Number.</param>
        /// <param name="NumberOfElements">NumberOfElements.</param>
        /// <param name="Size">Size.</param>
        /// <param name="Sort">Sort.</param>
        /// <param name="TotalElements">TotalElements.</param>
        /// <param name="TotalPages">TotalPages.</param>
        public PageResourceAggregateCountResource(List<AggregateCountResource> Content = default(List<AggregateCountResource>), bool? First = default(bool?), bool? Last = default(bool?), int? Number = default(int?), int? NumberOfElements = default(int?), int? Size = default(int?), List<Order> Sort = default(List<Order>), long? TotalElements = default(long?), int? TotalPages = default(int?))
        {
            this.Content = Content;
            this.First = First;
            this.Last = Last;
            this.Number = Number;
            this.NumberOfElements = NumberOfElements;
            this.Size = Size;
            this.Sort = Sort;
            this.TotalElements = TotalElements;
            this.TotalPages = TotalPages;
            
        }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content")]
        public List<AggregateCountResource> Content { get; set; }
        /// <summary>
        /// Gets or Sets First
        /// </summary>
        [DataMember(Name="first")]
        public bool? First { get; set; }
        /// <summary>
        /// Gets or Sets Last
        /// </summary>
        [DataMember(Name="last")]
        public bool? Last { get; set; }
        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="number")]
        public int? Number { get; set; }
        /// <summary>
        /// Gets or Sets NumberOfElements
        /// </summary>
        [DataMember(Name="number_of_elements")]
        public int? NumberOfElements { get; set; }
        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size")]
        public int? Size { get; set; }
        /// <summary>
        /// Gets or Sets Sort
        /// </summary>
        [DataMember(Name="sort")]
        public List<Order> Sort { get; set; }
        /// <summary>
        /// Gets or Sets TotalElements
        /// </summary>
        [DataMember(Name="total_elements")]
        public long? TotalElements { get; set; }
        /// <summary>
        /// Gets or Sets TotalPages
        /// </summary>
        [DataMember(Name="total_pages")]
        public int? TotalPages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageResourceAggregateCountResource {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  Last: ").Append(Last).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  NumberOfElements: ").Append(NumberOfElements).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  TotalElements: ").Append(TotalElements).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
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
            return Equals((PageResourceAggregateCountResource)obj);
        }

        /// <summary>
        /// Returns true if PageResourceAggregateCountResource instances are equal
        /// </summary>
        /// <param name="other">Instance of PageResourceAggregateCountResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PageResourceAggregateCountResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.SequenceEqual(other.Content)
                ) && 
                (
                    this.First == other.First ||
                    this.First != null &&
                    this.First.Equals(other.First)
                ) && 
                (
                    this.Last == other.Last ||
                    this.Last != null &&
                    this.Last.Equals(other.Last)
                ) && 
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) && 
                (
                    this.NumberOfElements == other.NumberOfElements ||
                    this.NumberOfElements != null &&
                    this.NumberOfElements.Equals(other.NumberOfElements)
                ) && 
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
                ) && 
                (
                    this.Sort == other.Sort ||
                    this.Sort != null &&
                    this.Sort.SequenceEqual(other.Sort)
                ) && 
                (
                    this.TotalElements == other.TotalElements ||
                    this.TotalElements != null &&
                    this.TotalElements.Equals(other.TotalElements)
                ) && 
                (
                    this.TotalPages == other.TotalPages ||
                    this.TotalPages != null &&
                    this.TotalPages.Equals(other.TotalPages)
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
                    if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();
                    if (this.First != null)
                    hash = hash * 59 + this.First.GetHashCode();
                    if (this.Last != null)
                    hash = hash * 59 + this.Last.GetHashCode();
                    if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();
                    if (this.NumberOfElements != null)
                    hash = hash * 59 + this.NumberOfElements.GetHashCode();
                    if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                    if (this.Sort != null)
                    hash = hash * 59 + this.Sort.GetHashCode();
                    if (this.TotalElements != null)
                    hash = hash * 59 + this.TotalElements.GetHashCode();
                    if (this.TotalPages != null)
                    hash = hash * 59 + this.TotalPages.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(PageResourceAggregateCountResource left, PageResourceAggregateCountResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PageResourceAggregateCountResource left, PageResourceAggregateCountResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
