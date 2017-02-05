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
    public partial class CurrencyResource :  IEquatable<CurrencyResource>
    {
                /// <summary>
        /// The type of currency. Default 'real'
        /// </summary>
        /// <value>The type of currency. Default 'real'</value>
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum RealEnum for "real"
            /// </summary>
            [EnumMember(Value = "real")]
            RealEnum,
            
            /// <summary>
            /// Enum VirtualEnum for "virtual"
            /// </summary>
            [EnumMember(Value = "virtual")]
            VirtualEnum
        }
        /// <summary>
        /// The type of currency. Default 'real'
        /// </summary>
        /// <value>The type of currency. Default 'real'</value>
        [DataMember(Name="type")]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyResource" /> class.
        /// </summary>
        /// <param name="Active">Whether the currency is active. Default true.</param>
        /// <param name="Code">The unique id code for the currency. Maximum 5 characters (required).</param>
        /// <param name="CreatedDate">The unix timestamp in seconds the currency was added to the system.</param>
        /// <param name="Factor">The decimal to multiply the system base currency (from config &#39;currency&#39;) to localize to this one. Should be 1 for the base currency itself. (required).</param>
        /// <param name="Icon">The url for an icon of the currency.</param>
        /// <param name="Name">The name of the currency (required).</param>
        /// <param name="Type">The type of currency. Default &#39;real&#39;.</param>
        /// <param name="UpdatedDate">The unix timestamp in seconds the currency was last updated in the system..</param>
        public CurrencyResource(bool? Active = default(bool?), string Code = default(string), double? Factor = default(double?), string Icon = default(string), string Name = default(string), TypeEnum? Type = default(TypeEnum?))
        {
            // to ensure "Code" is required (not null)
            if (Code == null)
            {
                throw new InvalidDataException("Code is a required property for CurrencyResource and cannot be null");
            }
            else
            {
                this.Code = Code;
            }
            // to ensure "Factor" is required (not null)
            if (Factor == null)
            {
                throw new InvalidDataException("Factor is a required property for CurrencyResource and cannot be null");
            }
            else
            {
                this.Factor = Factor;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for CurrencyResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Active = Active;
            this.CreatedDate = CreatedDate;
            this.Icon = Icon;
            this.Type = Type;
            this.UpdatedDate = UpdatedDate;
            
        }

        /// <summary>
        /// Whether the currency is active. Default true
        /// </summary>
        /// <value>Whether the currency is active. Default true</value>
        [DataMember(Name="active")]
        public bool? Active { get; set; }
        /// <summary>
        /// The unique id code for the currency. Maximum 5 characters
        /// </summary>
        /// <value>The unique id code for the currency. Maximum 5 characters</value>
        [DataMember(Name="code")]
        public string Code { get; set; }
        /// <summary>
        /// The unix timestamp in seconds the currency was added to the system
        /// </summary>
        /// <value>The unix timestamp in seconds the currency was added to the system</value>
        [DataMember(Name="created_date")]
        public long? CreatedDate { get; private set; }
        /// <summary>
        /// The decimal to multiply the system base currency (from config &#39;currency&#39;) to localize to this one. Should be 1 for the base currency itself.
        /// </summary>
        /// <value>The decimal to multiply the system base currency (from config &#39;currency&#39;) to localize to this one. Should be 1 for the base currency itself.</value>
        [DataMember(Name="factor")]
        public double? Factor { get; set; }
        /// <summary>
        /// The url for an icon of the currency
        /// </summary>
        /// <value>The url for an icon of the currency</value>
        [DataMember(Name="icon")]
        public string Icon { get; set; }
        /// <summary>
        /// The name of the currency
        /// </summary>
        /// <value>The name of the currency</value>
        [DataMember(Name="name")]
        public string Name { get; set; }
        /// <summary>
        /// The unix timestamp in seconds the currency was last updated in the system.
        /// </summary>
        /// <value>The unix timestamp in seconds the currency was last updated in the system.</value>
        [DataMember(Name="updated_date")]
        public long? UpdatedDate { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CurrencyResource {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Factor: ").Append(Factor).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return Equals((CurrencyResource)obj);
        }

        /// <summary>
        /// Returns true if CurrencyResource instances are equal
        /// </summary>
        /// <param name="other">Instance of CurrencyResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrencyResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) && 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.Factor == other.Factor ||
                    this.Factor != null &&
                    this.Factor.Equals(other.Factor)
                ) && 
                (
                    this.Icon == other.Icon ||
                    this.Icon != null &&
                    this.Icon.Equals(other.Icon)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                    if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                    if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                    if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                    if (this.Factor != null)
                    hash = hash * 59 + this.Factor.GetHashCode();
                    if (this.Icon != null)
                    hash = hash * 59 + this.Icon.GetHashCode();
                    if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                    if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                    if (this.UpdatedDate != null)
                    hash = hash * 59 + this.UpdatedDate.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(CurrencyResource left, CurrencyResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CurrencyResource left, CurrencyResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
