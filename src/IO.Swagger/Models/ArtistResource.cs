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
    public partial class ArtistResource :  IEquatable<ArtistResource>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtistResource" /> class.
        /// </summary>
        /// <param name="AdditionalProperties">A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type.</param>
        /// <param name="Born">YYYY/MM/DD when this artist was born.</param>
        /// <param name="ContributionCount">The current number of contributions the artist has made.</param>
        /// <param name="Contributions">The list of media this artist has contributed to as well as role(s) during contribution.  Use media endpoint to add contributions.</param>
        /// <param name="CreatedDate">The date/time this resource was created in seconds since unix epoch.</param>
        /// <param name="Died">YYYY/MM/DD when this artist died.</param>
        /// <param name="Id">The unique ID for that resource.</param>
        /// <param name="LongDescription">The user friendly name of that resource. Defaults to blank string.</param>
        /// <param name="Name">The user friendly name of that resource (required).</param>
        /// <param name="Priority">The sort order priority ofr the artist.  Default 100.</param>
        /// <param name="ShortDescription">The user friendly name of that resource. Defaults to blank string.</param>
        /// <param name="Template">An artist template this artist is validated against (private). May be null and no validation of additional_properties will be done.</param>
        /// <param name="UpdatedDate">The date/time this resource was last updated in seconds since unix epoch.</param>
        public ArtistResource(Dictionary<string, Property> AdditionalProperties = default(Dictionary<string, Property>), string Born = default(string), List<ContributionResource> Contributions = default(List<ContributionResource>), string Died = default(string), string LongDescription = default(string), string Name = default(string), int? Priority = default(int?), string ShortDescription = default(string), string Template = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ArtistResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.AdditionalProperties = AdditionalProperties;
            this.Born = Born;
            this.ContributionCount = ContributionCount;
            this.Contributions = Contributions;
            this.CreatedDate = CreatedDate;
            this.Died = Died;
            this.Id = Id;
            this.LongDescription = LongDescription;
            this.Priority = Priority;
            this.ShortDescription = ShortDescription;
            this.Template = Template;
            this.UpdatedDate = UpdatedDate;
            
        }

        /// <summary>
        /// A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type
        /// </summary>
        /// <value>A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type</value>
        [DataMember(Name="additional_properties")]
        public Dictionary<string, Property> AdditionalProperties { get; set; }
        /// <summary>
        /// YYYY/MM/DD when this artist was born
        /// </summary>
        /// <value>YYYY/MM/DD when this artist was born</value>
        [DataMember(Name="born")]
        public string Born { get; set; }
        /// <summary>
        /// The current number of contributions the artist has made
        /// </summary>
        /// <value>The current number of contributions the artist has made</value>
        [DataMember(Name="contribution_count")]
        public int? ContributionCount { get; private set; }
        /// <summary>
        /// The list of media this artist has contributed to as well as role(s) during contribution.  Use media endpoint to add contributions
        /// </summary>
        /// <value>The list of media this artist has contributed to as well as role(s) during contribution.  Use media endpoint to add contributions</value>
        [DataMember(Name="contributions")]
        public List<ContributionResource> Contributions { get; set; }
        /// <summary>
        /// The date/time this resource was created in seconds since unix epoch
        /// </summary>
        /// <value>The date/time this resource was created in seconds since unix epoch</value>
        [DataMember(Name="created_date")]
        public long? CreatedDate { get; private set; }
        /// <summary>
        /// YYYY/MM/DD when this artist died
        /// </summary>
        /// <value>YYYY/MM/DD when this artist died</value>
        [DataMember(Name="died")]
        public string Died { get; set; }
        /// <summary>
        /// The unique ID for that resource
        /// </summary>
        /// <value>The unique ID for that resource</value>
        [DataMember(Name="id")]
        public long? Id { get; private set; }
        /// <summary>
        /// The user friendly name of that resource. Defaults to blank string
        /// </summary>
        /// <value>The user friendly name of that resource. Defaults to blank string</value>
        [DataMember(Name="long_description")]
        public string LongDescription { get; set; }
        /// <summary>
        /// The user friendly name of that resource
        /// </summary>
        /// <value>The user friendly name of that resource</value>
        [DataMember(Name="name")]
        public string Name { get; set; }
        /// <summary>
        /// The sort order priority ofr the artist.  Default 100
        /// </summary>
        /// <value>The sort order priority ofr the artist.  Default 100</value>
        [DataMember(Name="priority")]
        public int? Priority { get; set; }
        /// <summary>
        /// The user friendly name of that resource. Defaults to blank string
        /// </summary>
        /// <value>The user friendly name of that resource. Defaults to blank string</value>
        [DataMember(Name="short_description")]
        public string ShortDescription { get; set; }
        /// <summary>
        /// An artist template this artist is validated against (private). May be null and no validation of additional_properties will be done
        /// </summary>
        /// <value>An artist template this artist is validated against (private). May be null and no validation of additional_properties will be done</value>
        [DataMember(Name="template")]
        public string Template { get; set; }
        /// <summary>
        /// The date/time this resource was last updated in seconds since unix epoch
        /// </summary>
        /// <value>The date/time this resource was last updated in seconds since unix epoch</value>
        [DataMember(Name="updated_date")]
        public long? UpdatedDate { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArtistResource {\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  Born: ").Append(Born).Append("\n");
            sb.Append("  ContributionCount: ").Append(ContributionCount).Append("\n");
            sb.Append("  Contributions: ").Append(Contributions).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Died: ").Append(Died).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
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
            return Equals((ArtistResource)obj);
        }

        /// <summary>
        /// Returns true if ArtistResource instances are equal
        /// </summary>
        /// <param name="other">Instance of ArtistResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArtistResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
                ) && 
                (
                    this.Born == other.Born ||
                    this.Born != null &&
                    this.Born.Equals(other.Born)
                ) && 
                (
                    this.ContributionCount == other.ContributionCount ||
                    this.ContributionCount != null &&
                    this.ContributionCount.Equals(other.ContributionCount)
                ) && 
                (
                    this.Contributions == other.Contributions ||
                    this.Contributions != null &&
                    this.Contributions.SequenceEqual(other.Contributions)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.Died == other.Died ||
                    this.Died != null &&
                    this.Died.Equals(other.Died)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LongDescription == other.LongDescription ||
                    this.LongDescription != null &&
                    this.LongDescription.Equals(other.LongDescription)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
                ) && 
                (
                    this.ShortDescription == other.ShortDescription ||
                    this.ShortDescription != null &&
                    this.ShortDescription.Equals(other.ShortDescription)
                ) && 
                (
                    this.Template == other.Template ||
                    this.Template != null &&
                    this.Template.Equals(other.Template)
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
                    if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                    if (this.Born != null)
                    hash = hash * 59 + this.Born.GetHashCode();
                    if (this.ContributionCount != null)
                    hash = hash * 59 + this.ContributionCount.GetHashCode();
                    if (this.Contributions != null)
                    hash = hash * 59 + this.Contributions.GetHashCode();
                    if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                    if (this.Died != null)
                    hash = hash * 59 + this.Died.GetHashCode();
                    if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                    if (this.LongDescription != null)
                    hash = hash * 59 + this.LongDescription.GetHashCode();
                    if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                    if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();
                    if (this.ShortDescription != null)
                    hash = hash * 59 + this.ShortDescription.GetHashCode();
                    if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();
                    if (this.UpdatedDate != null)
                    hash = hash * 59 + this.UpdatedDate.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(ArtistResource left, ArtistResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ArtistResource left, ArtistResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
