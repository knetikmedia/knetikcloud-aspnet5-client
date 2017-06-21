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
    public partial class GlobalCheckAndIncrementResource :  IEquatable<GlobalCheckAndIncrementResource>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalCheckAndIncrementResource" /> class.
        /// </summary>
        /// <param name="CheckValueResource">CheckValueResource.</param>
        /// <param name="GlobalResource">GlobalResource.</param>
        /// <param name="Type">Type.</param>
        public GlobalCheckAndIncrementResource(ExpressionResource CheckValueResource = default(ExpressionResource), ExpressionResource GlobalResource = default(ExpressionResource), string Type = default(string))
        {
            this.CheckValueResource = CheckValueResource;
            this.GlobalResource = GlobalResource;
            this.Type = Type;
            
        }

        /// <summary>
        /// Gets or Sets CheckValueResource
        /// </summary>
        [DataMember(Name="check_value_resource")]
        public ExpressionResource CheckValueResource { get; set; }
        /// <summary>
        /// Gets or Sets GlobalResource
        /// </summary>
        [DataMember(Name="global_resource")]
        public ExpressionResource GlobalResource { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type")]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlobalCheckAndIncrementResource {\n");
            sb.Append("  CheckValueResource: ").Append(CheckValueResource).Append("\n");
            sb.Append("  GlobalResource: ").Append(GlobalResource).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return Equals((GlobalCheckAndIncrementResource)obj);
        }

        /// <summary>
        /// Returns true if GlobalCheckAndIncrementResource instances are equal
        /// </summary>
        /// <param name="other">Instance of GlobalCheckAndIncrementResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GlobalCheckAndIncrementResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.CheckValueResource == other.CheckValueResource ||
                    this.CheckValueResource != null &&
                    this.CheckValueResource.Equals(other.CheckValueResource)
                ) && 
                (
                    this.GlobalResource == other.GlobalResource ||
                    this.GlobalResource != null &&
                    this.GlobalResource.Equals(other.GlobalResource)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                    if (this.CheckValueResource != null)
                    hash = hash * 59 + this.CheckValueResource.GetHashCode();
                    if (this.GlobalResource != null)
                    hash = hash * 59 + this.GlobalResource.GetHashCode();
                    if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(GlobalCheckAndIncrementResource left, GlobalCheckAndIncrementResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GlobalCheckAndIncrementResource left, GlobalCheckAndIncrementResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
