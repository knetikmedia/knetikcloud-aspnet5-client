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
    public partial class BatchResult :  IEquatable<BatchResult>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchResult" /> class.
        /// </summary>
        /// <param name="BatchReturn">List of batch responses.  Returns in the order requested.</param>
        /// <param name="CreatedDate">The date the batch call started processing.</param>
        /// <param name="Id">The token to use at the /batch/{token} endpoint if the request times out.</param>
        /// <param name="UpdatedDate">The date the batch call finished processing.</param>
        public BatchResult(List<BatchReturn> BatchReturn = default(List<BatchReturn>))
        {
            this.BatchReturn = BatchReturn;
            this.CreatedDate = CreatedDate;
            this.Id = Id;
            this.UpdatedDate = UpdatedDate;
            
        }

        /// <summary>
        /// List of batch responses.  Returns in the order requested
        /// </summary>
        /// <value>List of batch responses.  Returns in the order requested</value>
        [DataMember(Name="batch_return")]
        public List<BatchReturn> BatchReturn { get; set; }
        /// <summary>
        /// The date the batch call started processing
        /// </summary>
        /// <value>The date the batch call started processing</value>
        [DataMember(Name="created_date")]
        public long? CreatedDate { get; private set; }
        /// <summary>
        /// The token to use at the /batch/{token} endpoint if the request times out
        /// </summary>
        /// <value>The token to use at the /batch/{token} endpoint if the request times out</value>
        [DataMember(Name="id")]
        public string Id { get; private set; }
        /// <summary>
        /// The date the batch call finished processing
        /// </summary>
        /// <value>The date the batch call finished processing</value>
        [DataMember(Name="updated_date")]
        public long? UpdatedDate { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchResult {\n");
            sb.Append("  BatchReturn: ").Append(BatchReturn).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
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
            return Equals((BatchResult)obj);
        }

        /// <summary>
        /// Returns true if BatchResult instances are equal
        /// </summary>
        /// <param name="other">Instance of BatchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchResult other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.BatchReturn == other.BatchReturn ||
                    this.BatchReturn != null &&
                    this.BatchReturn.SequenceEqual(other.BatchReturn)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.UpdatedDate == other.UpdatedDate ||
                    this.UpdatedDate != null &&
                    this.UpdatedDate.Equals(other.UpdatedDate)
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
                    if (this.BatchReturn != null)
                    hash = hash * 59 + this.BatchReturn.GetHashCode();
                    if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                    if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                    if (this.UpdatedDate != null)
                    hash = hash * 59 + this.UpdatedDate.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(BatchResult left, BatchResult right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BatchResult left, BatchResult right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
