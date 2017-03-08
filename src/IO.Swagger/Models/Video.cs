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
    public partial class Video :  IEquatable<Video>
    {
                /// <summary>
        /// Gets or Sets Privacy
        /// </summary>
        public enum PrivacyEnum
        {
            
            /// <summary>
            /// Enum PrivateEnum for "private"
            /// </summary>
            [EnumMember(Value = "private")]
            PrivateEnum,
            
            /// <summary>
            /// Enum FriendsEnum for "friends"
            /// </summary>
            [EnumMember(Value = "friends")]
            FriendsEnum,
            
            /// <summary>
            /// Enum PublicEnum for "public"
            /// </summary>
            [EnumMember(Value = "public")]
            PublicEnum
        }
        /// <summary>
        /// Gets or Sets Privacy
        /// </summary>
        [DataMember(Name="privacy")]
        public PrivacyEnum? Privacy { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Video" /> class.
        /// </summary>
        /// <param name="Active">Active.</param>
        /// <param name="Author">Author.</param>
        /// <param name="Authored">Authored.</param>
        /// <param name="Banned">Banned.</param>
        /// <param name="CategoryId">CategoryId.</param>
        /// <param name="CategoryName">CategoryName.</param>
        /// <param name="Contributors">Contributors.</param>
        /// <param name="Created">Created.</param>
        /// <param name="Embed">Embed.</param>
        /// <param name="Extension">Extension.</param>
        /// <param name="Height">Height.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Length">Length.</param>
        /// <param name="Location">Location.</param>
        /// <param name="LongDescription">LongDescription.</param>
        /// <param name="MimeType">MimeType.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Priority">Priority.</param>
        /// <param name="Privacy">Privacy.</param>
        /// <param name="Published">Published.</param>
        /// <param name="ShortDescription">ShortDescription.</param>
        /// <param name="Size">Size.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="Thumbnail">Thumbnail.</param>
        /// <param name="Updated">Updated.</param>
        /// <param name="Uploader">Uploader.</param>
        /// <param name="Views">Views.</param>
        /// <param name="Whitelist">Whitelist.</param>
        /// <param name="Width">Width.</param>
        public Video(bool? Active = default(bool?), Artist Author = default(Artist), long? Authored = default(long?), bool? Banned = default(bool?), string CategoryId = default(string), string CategoryName = default(string), CollectionVideoContribution Contributors = default(CollectionVideoContribution), long? Created = default(long?), string Embed = default(string), string Extension = default(string), int? Height = default(int?), long? Id = default(long?), int? Length = default(int?), string Location = default(string), string LongDescription = default(string), string MimeType = default(string), string Name = default(string), int? Priority = default(int?), PrivacyEnum? Privacy = default(PrivacyEnum?), bool? Published = default(bool?), string ShortDescription = default(string), long? Size = default(long?), List<VideoTag> Tags = default(List<VideoTag>), string Thumbnail = default(string), long? Updated = default(long?), User Uploader = default(User), long? Views = default(long?), List<User> Whitelist = default(List<User>), int? Width = default(int?))
        {
            this.Active = Active;
            this.Author = Author;
            this.Authored = Authored;
            this.Banned = Banned;
            this.CategoryId = CategoryId;
            this.CategoryName = CategoryName;
            this.Contributors = Contributors;
            this.Created = Created;
            this.Embed = Embed;
            this.Extension = Extension;
            this.Height = Height;
            this.Id = Id;
            this.Length = Length;
            this.Location = Location;
            this.LongDescription = LongDescription;
            this.MimeType = MimeType;
            this.Name = Name;
            this.Priority = Priority;
            this.Privacy = Privacy;
            this.Published = Published;
            this.ShortDescription = ShortDescription;
            this.Size = Size;
            this.Tags = Tags;
            this.Thumbnail = Thumbnail;
            this.Updated = Updated;
            this.Uploader = Uploader;
            this.Views = Views;
            this.Whitelist = Whitelist;
            this.Width = Width;
            
        }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active")]
        public bool? Active { get; set; }
        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name="author")]
        public Artist Author { get; set; }
        /// <summary>
        /// Gets or Sets Authored
        /// </summary>
        [DataMember(Name="authored")]
        public long? Authored { get; set; }
        /// <summary>
        /// Gets or Sets Banned
        /// </summary>
        [DataMember(Name="banned")]
        public bool? Banned { get; set; }
        /// <summary>
        /// Gets or Sets CategoryId
        /// </summary>
        [DataMember(Name="category_id")]
        public string CategoryId { get; set; }
        /// <summary>
        /// Gets or Sets CategoryName
        /// </summary>
        [DataMember(Name="category_name")]
        public string CategoryName { get; set; }
        /// <summary>
        /// Gets or Sets Contributors
        /// </summary>
        [DataMember(Name="contributors")]
        public CollectionVideoContribution Contributors { get; set; }
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created")]
        public long? Created { get; set; }
        /// <summary>
        /// Gets or Sets Embed
        /// </summary>
        [DataMember(Name="embed")]
        public string Embed { get; set; }
        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name="extension")]
        public string Extension { get; set; }
        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name="height")]
        public int? Height { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public long? Id { get; set; }
        /// <summary>
        /// Gets or Sets Length
        /// </summary>
        [DataMember(Name="length")]
        public int? Length { get; set; }
        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location")]
        public string Location { get; set; }
        /// <summary>
        /// Gets or Sets LongDescription
        /// </summary>
        [DataMember(Name="long_description")]
        public string LongDescription { get; set; }
        /// <summary>
        /// Gets or Sets MimeType
        /// </summary>
        [DataMember(Name="mime_type")]
        public string MimeType { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name")]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="priority")]
        public int? Priority { get; set; }
        /// <summary>
        /// Gets or Sets Published
        /// </summary>
        [DataMember(Name="published")]
        public bool? Published { get; set; }
        /// <summary>
        /// Gets or Sets ShortDescription
        /// </summary>
        [DataMember(Name="short_description")]
        public string ShortDescription { get; set; }
        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size")]
        public long? Size { get; set; }
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags")]
        public List<VideoTag> Tags { get; set; }
        /// <summary>
        /// Gets or Sets Thumbnail
        /// </summary>
        [DataMember(Name="thumbnail")]
        public string Thumbnail { get; set; }
        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name="updated")]
        public long? Updated { get; set; }
        /// <summary>
        /// Gets or Sets Uploader
        /// </summary>
        [DataMember(Name="uploader")]
        public User Uploader { get; set; }
        /// <summary>
        /// Gets or Sets Views
        /// </summary>
        [DataMember(Name="views")]
        public long? Views { get; set; }
        /// <summary>
        /// Gets or Sets Whitelist
        /// </summary>
        [DataMember(Name="whitelist")]
        public List<User> Whitelist { get; set; }
        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name="width")]
        public int? Width { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Video {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Authored: ").Append(Authored).Append("\n");
            sb.Append("  Banned: ").Append(Banned).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
            sb.Append("  Contributors: ").Append(Contributors).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Embed: ").Append(Embed).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Privacy: ").Append(Privacy).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  Uploader: ").Append(Uploader).Append("\n");
            sb.Append("  Views: ").Append(Views).Append("\n");
            sb.Append("  Whitelist: ").Append(Whitelist).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
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
            return Equals((Video)obj);
        }

        /// <summary>
        /// Returns true if Video instances are equal
        /// </summary>
        /// <param name="other">Instance of Video to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Video other)
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
                    this.Author == other.Author ||
                    this.Author != null &&
                    this.Author.Equals(other.Author)
                ) && 
                (
                    this.Authored == other.Authored ||
                    this.Authored != null &&
                    this.Authored.Equals(other.Authored)
                ) && 
                (
                    this.Banned == other.Banned ||
                    this.Banned != null &&
                    this.Banned.Equals(other.Banned)
                ) && 
                (
                    this.CategoryId == other.CategoryId ||
                    this.CategoryId != null &&
                    this.CategoryId.Equals(other.CategoryId)
                ) && 
                (
                    this.CategoryName == other.CategoryName ||
                    this.CategoryName != null &&
                    this.CategoryName.Equals(other.CategoryName)
                ) && 
                (
                    this.Contributors == other.Contributors ||
                    this.Contributors != null &&
                    this.Contributors.Equals(other.Contributors)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.Embed == other.Embed ||
                    this.Embed != null &&
                    this.Embed.Equals(other.Embed)
                ) && 
                (
                    this.Extension == other.Extension ||
                    this.Extension != null &&
                    this.Extension.Equals(other.Extension)
                ) && 
                (
                    this.Height == other.Height ||
                    this.Height != null &&
                    this.Height.Equals(other.Height)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Length == other.Length ||
                    this.Length != null &&
                    this.Length.Equals(other.Length)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) && 
                (
                    this.LongDescription == other.LongDescription ||
                    this.LongDescription != null &&
                    this.LongDescription.Equals(other.LongDescription)
                ) && 
                (
                    this.MimeType == other.MimeType ||
                    this.MimeType != null &&
                    this.MimeType.Equals(other.MimeType)
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
                    this.Privacy == other.Privacy ||
                    this.Privacy != null &&
                    this.Privacy.Equals(other.Privacy)
                ) && 
                (
                    this.Published == other.Published ||
                    this.Published != null &&
                    this.Published.Equals(other.Published)
                ) && 
                (
                    this.ShortDescription == other.ShortDescription ||
                    this.ShortDescription != null &&
                    this.ShortDescription.Equals(other.ShortDescription)
                ) && 
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) && 
                (
                    this.Thumbnail == other.Thumbnail ||
                    this.Thumbnail != null &&
                    this.Thumbnail.Equals(other.Thumbnail)
                ) && 
                (
                    this.Updated == other.Updated ||
                    this.Updated != null &&
                    this.Updated.Equals(other.Updated)
                ) && 
                (
                    this.Uploader == other.Uploader ||
                    this.Uploader != null &&
                    this.Uploader.Equals(other.Uploader)
                ) && 
                (
                    this.Views == other.Views ||
                    this.Views != null &&
                    this.Views.Equals(other.Views)
                ) && 
                (
                    this.Whitelist == other.Whitelist ||
                    this.Whitelist != null &&
                    this.Whitelist.SequenceEqual(other.Whitelist)
                ) && 
                (
                    this.Width == other.Width ||
                    this.Width != null &&
                    this.Width.Equals(other.Width)
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
                    if (this.Author != null)
                    hash = hash * 59 + this.Author.GetHashCode();
                    if (this.Authored != null)
                    hash = hash * 59 + this.Authored.GetHashCode();
                    if (this.Banned != null)
                    hash = hash * 59 + this.Banned.GetHashCode();
                    if (this.CategoryId != null)
                    hash = hash * 59 + this.CategoryId.GetHashCode();
                    if (this.CategoryName != null)
                    hash = hash * 59 + this.CategoryName.GetHashCode();
                    if (this.Contributors != null)
                    hash = hash * 59 + this.Contributors.GetHashCode();
                    if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                    if (this.Embed != null)
                    hash = hash * 59 + this.Embed.GetHashCode();
                    if (this.Extension != null)
                    hash = hash * 59 + this.Extension.GetHashCode();
                    if (this.Height != null)
                    hash = hash * 59 + this.Height.GetHashCode();
                    if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                    if (this.Length != null)
                    hash = hash * 59 + this.Length.GetHashCode();
                    if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                    if (this.LongDescription != null)
                    hash = hash * 59 + this.LongDescription.GetHashCode();
                    if (this.MimeType != null)
                    hash = hash * 59 + this.MimeType.GetHashCode();
                    if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                    if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();
                    if (this.Privacy != null)
                    hash = hash * 59 + this.Privacy.GetHashCode();
                    if (this.Published != null)
                    hash = hash * 59 + this.Published.GetHashCode();
                    if (this.ShortDescription != null)
                    hash = hash * 59 + this.ShortDescription.GetHashCode();
                    if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                    if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                    if (this.Thumbnail != null)
                    hash = hash * 59 + this.Thumbnail.GetHashCode();
                    if (this.Updated != null)
                    hash = hash * 59 + this.Updated.GetHashCode();
                    if (this.Uploader != null)
                    hash = hash * 59 + this.Uploader.GetHashCode();
                    if (this.Views != null)
                    hash = hash * 59 + this.Views.GetHashCode();
                    if (this.Whitelist != null)
                    hash = hash * 59 + this.Whitelist.GetHashCode();
                    if (this.Width != null)
                    hash = hash * 59 + this.Width.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(Video left, Video right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Video left, Video right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
