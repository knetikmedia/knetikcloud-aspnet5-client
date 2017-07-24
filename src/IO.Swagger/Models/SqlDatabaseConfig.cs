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
    public partial class SqlDatabaseConfig :  IEquatable<SqlDatabaseConfig>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlDatabaseConfig" /> class.
        /// </summary>
        /// <param name="ConnectionPoolSize">ConnectionPoolSize.</param>
        /// <param name="DbName">DbName.</param>
        /// <param name="Hostname">Hostname.</param>
        /// <param name="Password">Password.</param>
        /// <param name="Port">Port.</param>
        /// <param name="Username">Username.</param>
        public SqlDatabaseConfig(int? ConnectionPoolSize = default(int?), string DbName = default(string), string Hostname = default(string), string Password = default(string), int? Port = default(int?), string Username = default(string))
        {
            this.ConnectionPoolSize = ConnectionPoolSize;
            this.DbName = DbName;
            this.Hostname = Hostname;
            this.Password = Password;
            this.Port = Port;
            this.Username = Username;
            
        }

        /// <summary>
        /// Gets or Sets ConnectionPoolSize
        /// </summary>
        [DataMember(Name="connection_pool_size")]
        public int? ConnectionPoolSize { get; set; }
        /// <summary>
        /// Gets or Sets DbName
        /// </summary>
        [DataMember(Name="db_name")]
        public string DbName { get; set; }
        /// <summary>
        /// Gets or Sets Hostname
        /// </summary>
        [DataMember(Name="hostname")]
        public string Hostname { get; set; }
        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password")]
        public string Password { get; set; }
        /// <summary>
        /// Gets or Sets Port
        /// </summary>
        [DataMember(Name="port")]
        public int? Port { get; set; }
        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username")]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SqlDatabaseConfig {\n");
            sb.Append("  ConnectionPoolSize: ").Append(ConnectionPoolSize).Append("\n");
            sb.Append("  DbName: ").Append(DbName).Append("\n");
            sb.Append("  Hostname: ").Append(Hostname).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return Equals((SqlDatabaseConfig)obj);
        }

        /// <summary>
        /// Returns true if SqlDatabaseConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of SqlDatabaseConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SqlDatabaseConfig other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.ConnectionPoolSize == other.ConnectionPoolSize ||
                    this.ConnectionPoolSize != null &&
                    this.ConnectionPoolSize.Equals(other.ConnectionPoolSize)
                ) && 
                (
                    this.DbName == other.DbName ||
                    this.DbName != null &&
                    this.DbName.Equals(other.DbName)
                ) && 
                (
                    this.Hostname == other.Hostname ||
                    this.Hostname != null &&
                    this.Hostname.Equals(other.Hostname)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.Port == other.Port ||
                    this.Port != null &&
                    this.Port.Equals(other.Port)
                ) && 
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
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
                    if (this.ConnectionPoolSize != null)
                    hash = hash * 59 + this.ConnectionPoolSize.GetHashCode();
                    if (this.DbName != null)
                    hash = hash * 59 + this.DbName.GetHashCode();
                    if (this.Hostname != null)
                    hash = hash * 59 + this.Hostname.GetHashCode();
                    if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                    if (this.Port != null)
                    hash = hash * 59 + this.Port.GetHashCode();
                    if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(SqlDatabaseConfig left, SqlDatabaseConfig right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SqlDatabaseConfig left, SqlDatabaseConfig right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
