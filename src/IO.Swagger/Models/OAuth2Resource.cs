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
    public partial class OAuth2Resource :  IEquatable<OAuth2Resource>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2Resource" /> class.
        /// </summary>
        /// <param name="AccessToken">The access token issued by the authorization server.</param>
        /// <param name="ExpiresIn">The lifetime in seconds of the access token.</param>
        /// <param name="Scope">The scope of the access token. Currently these values can be ignored, as security defaults to roles and permissions.</param>
        /// <param name="TokenType">The type of the token issued.</param>
        public OAuth2Resource()
        {
            this.AccessToken = AccessToken;
            this.ExpiresIn = ExpiresIn;
            this.Scope = Scope;
            this.TokenType = TokenType;
            
        }

        /// <summary>
        /// The access token issued by the authorization server
        /// </summary>
        /// <value>The access token issued by the authorization server</value>
        [DataMember(Name="access_token")]
        public string AccessToken { get; private set; }
        /// <summary>
        /// The lifetime in seconds of the access token
        /// </summary>
        /// <value>The lifetime in seconds of the access token</value>
        [DataMember(Name="expires_in")]
        public string ExpiresIn { get; private set; }
        /// <summary>
        /// The scope of the access token. Currently these values can be ignored, as security defaults to roles and permissions
        /// </summary>
        /// <value>The scope of the access token. Currently these values can be ignored, as security defaults to roles and permissions</value>
        [DataMember(Name="scope")]
        public string Scope { get; private set; }
        /// <summary>
        /// The type of the token issued
        /// </summary>
        /// <value>The type of the token issued</value>
        [DataMember(Name="token_type")]
        public string TokenType { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OAuth2Resource {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
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
            return Equals((OAuth2Resource)obj);
        }

        /// <summary>
        /// Returns true if OAuth2Resource instances are equal
        /// </summary>
        /// <param name="other">Instance of OAuth2Resource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OAuth2Resource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.AccessToken == other.AccessToken ||
                    this.AccessToken != null &&
                    this.AccessToken.Equals(other.AccessToken)
                ) && 
                (
                    this.ExpiresIn == other.ExpiresIn ||
                    this.ExpiresIn != null &&
                    this.ExpiresIn.Equals(other.ExpiresIn)
                ) && 
                (
                    this.Scope == other.Scope ||
                    this.Scope != null &&
                    this.Scope.Equals(other.Scope)
                ) && 
                (
                    this.TokenType == other.TokenType ||
                    this.TokenType != null &&
                    this.TokenType.Equals(other.TokenType)
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
                    if (this.AccessToken != null)
                    hash = hash * 59 + this.AccessToken.GetHashCode();
                    if (this.ExpiresIn != null)
                    hash = hash * 59 + this.ExpiresIn.GetHashCode();
                    if (this.Scope != null)
                    hash = hash * 59 + this.Scope.GetHashCode();
                    if (this.TokenType != null)
                    hash = hash * 59 + this.TokenType.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(OAuth2Resource left, OAuth2Resource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(OAuth2Resource left, OAuth2Resource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
