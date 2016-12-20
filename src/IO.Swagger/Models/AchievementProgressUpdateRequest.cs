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
    public partial class AchievementProgressUpdateRequest :  IEquatable<AchievementProgressUpdateRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AchievementProgressUpdateRequest" /> class.
        /// </summary>
        /// <param name="IncrementValue">Whether to add one to the current progress instead of setting it to progress_value. Default: false.</param>
        /// <param name="ProgressValue">The amount of progress towards earning the achievement. The max/target depends on the achievement. Required if increment_value is false/missing..</param>
        public AchievementProgressUpdateRequest(bool? IncrementValue = null, int? ProgressValue = null)
        {
            this.IncrementValue = IncrementValue;
            this.ProgressValue = ProgressValue;
            
        }

        /// <summary>
        /// Whether to add one to the current progress instead of setting it to progress_value. Default: false
        /// </summary>
        /// <value>Whether to add one to the current progress instead of setting it to progress_value. Default: false</value>
        [DataMember(Name="increment_value")]
        public bool? IncrementValue { get; set; }

        /// <summary>
        /// The amount of progress towards earning the achievement. The max/target depends on the achievement. Required if increment_value is false/missing.
        /// </summary>
        /// <value>The amount of progress towards earning the achievement. The max/target depends on the achievement. Required if increment_value is false/missing.</value>
        [DataMember(Name="progress_value")]
        public int? ProgressValue { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AchievementProgressUpdateRequest {\n");
            sb.Append("  IncrementValue: ").Append(IncrementValue).Append("\n");
            sb.Append("  ProgressValue: ").Append(ProgressValue).Append("\n");
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
            return Equals((AchievementProgressUpdateRequest)obj);
        }

        /// <summary>
        /// Returns true if AchievementProgressUpdateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AchievementProgressUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AchievementProgressUpdateRequest other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.IncrementValue == other.IncrementValue ||
                    this.IncrementValue != null &&
                    this.IncrementValue.Equals(other.IncrementValue)
                ) && 
                (
                    this.ProgressValue == other.ProgressValue ||
                    this.ProgressValue != null &&
                    this.ProgressValue.Equals(other.ProgressValue)
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
                    if (this.IncrementValue != null)
                    hash = hash * 59 + this.IncrementValue.GetHashCode();
                    if (this.ProgressValue != null)
                    hash = hash * 59 + this.ProgressValue.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(AchievementProgressUpdateRequest left, AchievementProgressUpdateRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AchievementProgressUpdateRequest left, AchievementProgressUpdateRequest right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
