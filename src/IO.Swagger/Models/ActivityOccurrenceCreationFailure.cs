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
    public partial class ActivityOccurrenceCreationFailure :  IEquatable<ActivityOccurrenceCreationFailure>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityOccurrenceCreationFailure" /> class.
        /// </summary>
        /// <param name="UserResults">The details of each user&#39;s entry, or just the current user&#39;s if not run with ACTIVITIES_ADMIN permission.</param>
        public ActivityOccurrenceCreationFailure(List<ActivityOccurrenceJoinResult> UserResults = null)
        {
            this.UserResults = UserResults;
            
        }

        /// <summary>
        /// The details of each user's entry, or just the current user's if not run with ACTIVITIES_ADMIN permission
        /// </summary>
        /// <value>The details of each user's entry, or just the current user's if not run with ACTIVITIES_ADMIN permission</value>
        [DataMember(Name="user_results")]
        public List<ActivityOccurrenceJoinResult> UserResults { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivityOccurrenceCreationFailure {\n");
            sb.Append("  UserResults: ").Append(UserResults).Append("\n");
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
            return Equals((ActivityOccurrenceCreationFailure)obj);
        }

        /// <summary>
        /// Returns true if ActivityOccurrenceCreationFailure instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivityOccurrenceCreationFailure to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityOccurrenceCreationFailure other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.UserResults == other.UserResults ||
                    this.UserResults != null &&
                    this.UserResults.SequenceEqual(other.UserResults)
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
                    if (this.UserResults != null)
                    hash = hash * 59 + this.UserResults.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(ActivityOccurrenceCreationFailure left, ActivityOccurrenceCreationFailure right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ActivityOccurrenceCreationFailure left, ActivityOccurrenceCreationFailure right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
