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
    public partial class ItemTemplateResource :  IEquatable<ItemTemplateResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemTemplateResource" /> class.
        /// </summary>
        /// <param name="Behaviors">The customized behaviors that are required or default for this type of item.</param>
        /// <param name="CreatedDate">The date/time this resource was created in seconds since unix epoch.</param>
        /// <param name="Id">The id of the template.</param>
        /// <param name="Name">The name of the template (required).</param>
        /// <param name="Properties">The customized properties that are present.</param>
        /// <param name="SkuTemplate">A template to apply to all skus on an item using this template.</param>
        /// <param name="UpdatedDate">The date/time this resource was last updated in seconds since unix epoch.</param>
        public ItemTemplateResource(List<ItemBehaviorDefinitionResource> Behaviors = null, long? CreatedDate = null, string Id = null, string Name = null, List<PropertyDefinitionResource> Properties = null, TemplateResource SkuTemplate = null, long? UpdatedDate = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ItemTemplateResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Behaviors = Behaviors;
            this.CreatedDate = CreatedDate;
            this.Id = Id;
            this.Properties = Properties;
            this.SkuTemplate = SkuTemplate;
            this.UpdatedDate = UpdatedDate;
            
        }

        /// <summary>
        /// The customized behaviors that are required or default for this type of item
        /// </summary>
        /// <value>The customized behaviors that are required or default for this type of item</value>
        [DataMember(Name="behaviors")]
        public List<ItemBehaviorDefinitionResource> Behaviors { get; set; }

        /// <summary>
        /// The date/time this resource was created in seconds since unix epoch
        /// </summary>
        /// <value>The date/time this resource was created in seconds since unix epoch</value>
        [DataMember(Name="created_date")]
        public long? CreatedDate { get; set; }

        /// <summary>
        /// The id of the template
        /// </summary>
        /// <value>The id of the template</value>
        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// The name of the template
        /// </summary>
        /// <value>The name of the template</value>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// The customized properties that are present
        /// </summary>
        /// <value>The customized properties that are present</value>
        [DataMember(Name="properties")]
        public List<PropertyDefinitionResource> Properties { get; set; }

        /// <summary>
        /// A template to apply to all skus on an item using this template
        /// </summary>
        /// <value>A template to apply to all skus on an item using this template</value>
        [DataMember(Name="sku_template")]
        public TemplateResource SkuTemplate { get; set; }

        /// <summary>
        /// The date/time this resource was last updated in seconds since unix epoch
        /// </summary>
        /// <value>The date/time this resource was last updated in seconds since unix epoch</value>
        [DataMember(Name="updated_date")]
        public long? UpdatedDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemTemplateResource {\n");
            sb.Append("  Behaviors: ").Append(Behaviors).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  SkuTemplate: ").Append(SkuTemplate).Append("\n");
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
            return Equals((ItemTemplateResource)obj);
        }

        /// <summary>
        /// Returns true if ItemTemplateResource instances are equal
        /// </summary>
        /// <param name="other">Instance of ItemTemplateResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemTemplateResource other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Behaviors == other.Behaviors ||
                    this.Behaviors != null &&
                    this.Behaviors.SequenceEqual(other.Behaviors)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.SequenceEqual(other.Properties)
                ) && 
                (
                    this.SkuTemplate == other.SkuTemplate ||
                    this.SkuTemplate != null &&
                    this.SkuTemplate.Equals(other.SkuTemplate)
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
                    if (this.Behaviors != null)
                    hash = hash * 59 + this.Behaviors.GetHashCode();
                    if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                    if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                    if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                    if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();
                    if (this.SkuTemplate != null)
                    hash = hash * 59 + this.SkuTemplate.GetHashCode();
                    if (this.UpdatedDate != null)
                    hash = hash * 59 + this.UpdatedDate.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(ItemTemplateResource left, ItemTemplateResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ItemTemplateResource left, ItemTemplateResource right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
