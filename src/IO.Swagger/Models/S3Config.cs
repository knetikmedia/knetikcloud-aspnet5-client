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
    public partial class S3Config :  IEquatable<S3Config>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="S3Config" /> class.
        /// </summary>
        /// <param name="BucketName">BucketName.</param>
        /// <param name="CdnUrl">CdnUrl.</param>
        /// <param name="Region">Region.</param>
        /// <param name="UploadPrefix">UploadPrefix.</param>
        public S3Config(string BucketName = default(string), string CdnUrl = default(string), string Region = default(string), string UploadPrefix = default(string))
        {
            this.BucketName = BucketName;
            this.CdnUrl = CdnUrl;
            this.Region = Region;
            this.UploadPrefix = UploadPrefix;
            
        }

        /// <summary>
        /// Gets or Sets BucketName
        /// </summary>
        [DataMember(Name="bucket_name")]
        public string BucketName { get; set; }
        /// <summary>
        /// Gets or Sets CdnUrl
        /// </summary>
        [DataMember(Name="cdn_url")]
        public string CdnUrl { get; set; }
        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name="region")]
        public string Region { get; set; }
        /// <summary>
        /// Gets or Sets UploadPrefix
        /// </summary>
        [DataMember(Name="upload_prefix")]
        public string UploadPrefix { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class S3Config {\n");
            sb.Append("  BucketName: ").Append(BucketName).Append("\n");
            sb.Append("  CdnUrl: ").Append(CdnUrl).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  UploadPrefix: ").Append(UploadPrefix).Append("\n");
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
            return Equals((S3Config)obj);
        }

        /// <summary>
        /// Returns true if S3Config instances are equal
        /// </summary>
        /// <param name="other">Instance of S3Config to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(S3Config other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.BucketName == other.BucketName ||
                    this.BucketName != null &&
                    this.BucketName.Equals(other.BucketName)
                ) && 
                (
                    this.CdnUrl == other.CdnUrl ||
                    this.CdnUrl != null &&
                    this.CdnUrl.Equals(other.CdnUrl)
                ) && 
                (
                    this.Region == other.Region ||
                    this.Region != null &&
                    this.Region.Equals(other.Region)
                ) && 
                (
                    this.UploadPrefix == other.UploadPrefix ||
                    this.UploadPrefix != null &&
                    this.UploadPrefix.Equals(other.UploadPrefix)
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
                    if (this.BucketName != null)
                    hash = hash * 59 + this.BucketName.GetHashCode();
                    if (this.CdnUrl != null)
                    hash = hash * 59 + this.CdnUrl.GetHashCode();
                    if (this.Region != null)
                    hash = hash * 59 + this.Region.GetHashCode();
                    if (this.UploadPrefix != null)
                    hash = hash * 59 + this.UploadPrefix.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(S3Config left, S3Config right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(S3Config left, S3Config right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
