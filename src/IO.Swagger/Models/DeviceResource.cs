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
    public partial class DeviceResource :  IEquatable<DeviceResource>
    {
                /// <summary>
        /// The current condition of the device (New, Defective, Reconditioned)
        /// </summary>
        /// <value>The current condition of the device (New, Defective, Reconditioned)</value>
        public enum ConditionEnum
        {
            
            /// <summary>
            /// Enum NewEnum for "New"
            /// </summary>
            [EnumMember(Value = "New")]
            NewEnum,
            
            /// <summary>
            /// Enum DefectiveEnum for "Defective"
            /// </summary>
            [EnumMember(Value = "Defective")]
            DefectiveEnum,
            
            /// <summary>
            /// Enum ReconditionedEnum for "Reconditioned"
            /// </summary>
            [EnumMember(Value = "Reconditioned")]
            ReconditionedEnum
        }
                /// <summary>
        /// The current status the device (Active, Pending Active, Inactive, Repair
        /// </summary>
        /// <value>The current status the device (Active, Pending Active, Inactive, Repair</value>
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum ActiveEnum for "Active"
            /// </summary>
            [EnumMember(Value = "Active")]
            ActiveEnum,
            
            /// <summary>
            /// Enum PendingActiveEnum for "PendingActive"
            /// </summary>
            [EnumMember(Value = "PendingActive")]
            PendingActiveEnum,
            
            /// <summary>
            /// Enum InactiveEnum for "Inactive"
            /// </summary>
            [EnumMember(Value = "Inactive")]
            InactiveEnum,
            
            /// <summary>
            /// Enum RepairEnum for "Repair"
            /// </summary>
            [EnumMember(Value = "Repair")]
            RepairEnum
        }
        /// <summary>
        /// The current condition of the device (New, Defective, Reconditioned)
        /// </summary>
        /// <value>The current condition of the device (New, Defective, Reconditioned)</value>
        [DataMember(Name="condition")]
        public ConditionEnum? Condition { get; set; }
        /// <summary>
        /// The current status the device (Active, Pending Active, Inactive, Repair
        /// </summary>
        /// <value>The current status the device (Active, Pending Active, Inactive, Repair</value>
        [DataMember(Name="status")]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceResource" /> class.
        /// </summary>
        /// <param name="Authorization">The authorization code for the device.</param>
        /// <param name="Condition">The current condition of the device (New, Defective, Reconditioned).</param>
        /// <param name="CreatedDate">The date the device log was created.</param>
        /// <param name="Data">The key/value pairs for extended data.</param>
        /// <param name="Description">The description of the device.</param>
        /// <param name="DeviceType">The type of the device.</param>
        /// <param name="Id">The unique ID for this device. Cannot be changed once created (required).</param>
        /// <param name="Location">The location of the device.</param>
        /// <param name="MacAddress">The MAC (media access control) address of the device.</param>
        /// <param name="Make">The make of the device.</param>
        /// <param name="Model">The model of the device.</param>
        /// <param name="Name">The name of the device.</param>
        /// <param name="Os">The OS (operating system) on the device.</param>
        /// <param name="Serial">The serial number of the device.</param>
        /// <param name="Status">The current status the device (Active, Pending Active, Inactive, Repair.</param>
        /// <param name="UpdatedDate">The date the device log was updated.</param>
        /// <param name="User">The user that owns the device.</param>
        public DeviceResource(string Authorization = default(string), ConditionEnum? Condition = default(ConditionEnum?), Dictionary<string, string> Data = default(Dictionary<string, string>), string Description = default(string), string DeviceType = default(string), int? Id = default(int?), string Location = default(string), string MacAddress = default(string), string Make = default(string), string Model = default(string), string Name = default(string), string Os = default(string), string Serial = default(string), StatusEnum? Status = default(StatusEnum?), SimpleUserResource User = default(SimpleUserResource))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for DeviceResource and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            this.Authorization = Authorization;
            this.Condition = Condition;
            this.CreatedDate = CreatedDate;
            this.Data = Data;
            this.Description = Description;
            this.DeviceType = DeviceType;
            this.Location = Location;
            this.MacAddress = MacAddress;
            this.Make = Make;
            this.Model = Model;
            this.Name = Name;
            this.Os = Os;
            this.Serial = Serial;
            this.Status = Status;
            this.UpdatedDate = UpdatedDate;
            this.User = User;
            
        }

        /// <summary>
        /// The authorization code for the device
        /// </summary>
        /// <value>The authorization code for the device</value>
        [DataMember(Name="authorization")]
        public string Authorization { get; set; }
        /// <summary>
        /// The date the device log was created
        /// </summary>
        /// <value>The date the device log was created</value>
        [DataMember(Name="created_date")]
        public long? CreatedDate { get; private set; }
        /// <summary>
        /// The key/value pairs for extended data
        /// </summary>
        /// <value>The key/value pairs for extended data</value>
        [DataMember(Name="data")]
        public Dictionary<string, string> Data { get; set; }
        /// <summary>
        /// The description of the device
        /// </summary>
        /// <value>The description of the device</value>
        [DataMember(Name="description")]
        public string Description { get; set; }
        /// <summary>
        /// The type of the device
        /// </summary>
        /// <value>The type of the device</value>
        [DataMember(Name="device_type")]
        public string DeviceType { get; set; }
        /// <summary>
        /// The unique ID for this device. Cannot be changed once created
        /// </summary>
        /// <value>The unique ID for this device. Cannot be changed once created</value>
        [DataMember(Name="id")]
        public int? Id { get; set; }
        /// <summary>
        /// The location of the device
        /// </summary>
        /// <value>The location of the device</value>
        [DataMember(Name="location")]
        public string Location { get; set; }
        /// <summary>
        /// The MAC (media access control) address of the device
        /// </summary>
        /// <value>The MAC (media access control) address of the device</value>
        [DataMember(Name="mac_address")]
        public string MacAddress { get; set; }
        /// <summary>
        /// The make of the device
        /// </summary>
        /// <value>The make of the device</value>
        [DataMember(Name="make")]
        public string Make { get; set; }
        /// <summary>
        /// The model of the device
        /// </summary>
        /// <value>The model of the device</value>
        [DataMember(Name="model")]
        public string Model { get; set; }
        /// <summary>
        /// The name of the device
        /// </summary>
        /// <value>The name of the device</value>
        [DataMember(Name="name")]
        public string Name { get; set; }
        /// <summary>
        /// The OS (operating system) on the device
        /// </summary>
        /// <value>The OS (operating system) on the device</value>
        [DataMember(Name="os")]
        public string Os { get; set; }
        /// <summary>
        /// The serial number of the device
        /// </summary>
        /// <value>The serial number of the device</value>
        [DataMember(Name="serial")]
        public string Serial { get; set; }
        /// <summary>
        /// The date the device log was updated
        /// </summary>
        /// <value>The date the device log was updated</value>
        [DataMember(Name="updated_date")]
        public long? UpdatedDate { get; private set; }
        /// <summary>
        /// The user that owns the device
        /// </summary>
        /// <value>The user that owns the device</value>
        [DataMember(Name="user")]
        public SimpleUserResource User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceResource {\n");
            sb.Append("  Authorization: ").Append(Authorization).Append("\n");
            sb.Append("  Condition: ").Append(Condition).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  MacAddress: ").Append(MacAddress).Append("\n");
            sb.Append("  Make: ").Append(Make).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Os: ").Append(Os).Append("\n");
            sb.Append("  Serial: ").Append(Serial).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return Equals((DeviceResource)obj);
        }

        /// <summary>
        /// Returns true if DeviceResource instances are equal
        /// </summary>
        /// <param name="other">Instance of DeviceResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Authorization == other.Authorization ||
                    this.Authorization != null &&
                    this.Authorization.Equals(other.Authorization)
                ) && 
                (
                    this.Condition == other.Condition ||
                    this.Condition != null &&
                    this.Condition.Equals(other.Condition)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(other.Data)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.DeviceType == other.DeviceType ||
                    this.DeviceType != null &&
                    this.DeviceType.Equals(other.DeviceType)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) && 
                (
                    this.MacAddress == other.MacAddress ||
                    this.MacAddress != null &&
                    this.MacAddress.Equals(other.MacAddress)
                ) && 
                (
                    this.Make == other.Make ||
                    this.Make != null &&
                    this.Make.Equals(other.Make)
                ) && 
                (
                    this.Model == other.Model ||
                    this.Model != null &&
                    this.Model.Equals(other.Model)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Os == other.Os ||
                    this.Os != null &&
                    this.Os.Equals(other.Os)
                ) && 
                (
                    this.Serial == other.Serial ||
                    this.Serial != null &&
                    this.Serial.Equals(other.Serial)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.UpdatedDate == other.UpdatedDate ||
                    this.UpdatedDate != null &&
                    this.UpdatedDate.Equals(other.UpdatedDate)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                    if (this.Authorization != null)
                    hash = hash * 59 + this.Authorization.GetHashCode();
                    if (this.Condition != null)
                    hash = hash * 59 + this.Condition.GetHashCode();
                    if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                    if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                    if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                    if (this.DeviceType != null)
                    hash = hash * 59 + this.DeviceType.GetHashCode();
                    if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                    if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                    if (this.MacAddress != null)
                    hash = hash * 59 + this.MacAddress.GetHashCode();
                    if (this.Make != null)
                    hash = hash * 59 + this.Make.GetHashCode();
                    if (this.Model != null)
                    hash = hash * 59 + this.Model.GetHashCode();
                    if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                    if (this.Os != null)
                    hash = hash * 59 + this.Os.GetHashCode();
                    if (this.Serial != null)
                    hash = hash * 59 + this.Serial.GetHashCode();
                    if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                    if (this.UpdatedDate != null)
                    hash = hash * 59 + this.UpdatedDate.GetHashCode();
                    if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(DeviceResource left, DeviceResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DeviceResource left, DeviceResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
