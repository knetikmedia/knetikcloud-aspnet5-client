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
    public partial class GuestPlayable : Behavior,  IEquatable<GuestPlayable>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GuestPlayable" /> class.
        /// </summary>
        /// <param name="Description">Description.</param>
        /// <param name="TypeHint">Used for polymorphic type recognition and thus must match an expected type with additional properties.</param>
        /// <param name="Allowed">Whether guests are allowed to use items.</param>
        /// <param name="Leaderboard">Whether guests are allowed on the leaderboard.</param>
        public GuestPlayable(string Description = default(string), string TypeHint = default(string), bool? Allowed = default(bool?), bool? Leaderboard = default(bool?))
        {
            this.Description = Description;
            this.TypeHint = TypeHint;
            this.Allowed = Allowed;
            this.Leaderboard = Leaderboard;
            
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description")]
        public string Description { get; set; }
        /// <summary>
        /// Used for polymorphic type recognition and thus must match an expected type with additional properties
        /// </summary>
        /// <value>Used for polymorphic type recognition and thus must match an expected type with additional properties</value>
        [DataMember(Name="type_hint")]
        public string TypeHint { get; set; }
        /// <summary>
        /// Whether guests are allowed to use items
        /// </summary>
        /// <value>Whether guests are allowed to use items</value>
        [DataMember(Name="allowed")]
        public bool? Allowed { get; set; }
        /// <summary>
        /// Whether guests are allowed on the leaderboard
        /// </summary>
        /// <value>Whether guests are allowed on the leaderboard</value>
        [DataMember(Name="leaderboard")]
        public bool? Leaderboard { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GuestPlayable {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  TypeHint: ").Append(TypeHint).Append("\n");
            sb.Append("  Allowed: ").Append(Allowed).Append("\n");
            sb.Append("  Leaderboard: ").Append(Leaderboard).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            return Equals((GuestPlayable)obj);
        }

        /// <summary>
        /// Returns true if GuestPlayable instances are equal
        /// </summary>
        /// <param name="other">Instance of GuestPlayable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GuestPlayable other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.TypeHint == other.TypeHint ||
                    this.TypeHint != null &&
                    this.TypeHint.Equals(other.TypeHint)
                ) && 
                (
                    this.Allowed == other.Allowed ||
                    this.Allowed != null &&
                    this.Allowed.Equals(other.Allowed)
                ) && 
                (
                    this.Leaderboard == other.Leaderboard ||
                    this.Leaderboard != null &&
                    this.Leaderboard.Equals(other.Leaderboard)
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
                    if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                    if (this.TypeHint != null)
                    hash = hash * 59 + this.TypeHint.GetHashCode();
                    if (this.Allowed != null)
                    hash = hash * 59 + this.Allowed.GetHashCode();
                    if (this.Leaderboard != null)
                    hash = hash * 59 + this.Leaderboard.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(GuestPlayable left, GuestPlayable right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GuestPlayable left, GuestPlayable right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
