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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.SwaggerGen.Annotations;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class MediaVideosApiController : Controller
    { 

        /// <summary>
        /// Adds a user to a video&#39;s whitelist
        /// </summary>
        /// <remarks>Whitelisted users can view video regardless of privacy setting.</remarks>
        /// <param name="id">The video id</param>
        /// <param name="userId">The user id</param>
        /// <response code="201">Created</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//media/videos/{id}/whitelist")]
        [SwaggerOperation("AddUserToVideoWhitelist")]
        public virtual void AddUserToVideoWhitelist([FromRoute]long? id, [FromBody]int? userId)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Adds a new video in the system
        /// </summary>
        
        /// <param name="videoResource">The video object</param>
        /// <response code="201">Created</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//media/videos")]
        [SwaggerOperation("AddVideo")]
        [SwaggerResponse(200, type: typeof(VideoResource))]
        public virtual IActionResult AddVideo([FromBody]VideoResource videoResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<VideoResource>(exampleJson)
            : default(VideoResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Add a new video comment
        /// </summary>
        
        /// <param name="videoId">The video id </param>
        /// <param name="commentResource">The comment object</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//media/videos/{video_id}/comments")]
        [SwaggerOperation("AddVideoComment")]
        [SwaggerResponse(200, type: typeof(CommentResource))]
        public virtual IActionResult AddVideoComment([FromRoute]int? videoId, [FromBody]CommentResource commentResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CommentResource>(exampleJson)
            : default(CommentResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Adds a contributor to a video
        /// </summary>
        
        /// <param name="videoId">The video id</param>
        /// <param name="contributionResource">The contribution object</param>
        /// <response code="201">Created</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//media/videos/{video_id}/contributors")]
        [SwaggerOperation("AddVideoContributor")]
        public virtual void AddVideoContributor([FromRoute]long? videoId, [FromBody]ContributionResource contributionResource)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Add a new flag
        /// </summary>
        
        /// <param name="videoId">The video id</param>
        /// <param name="reason">The flag reason</param>
        /// <response code="202">Accepted</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//media/videos/{video_id}/moderation")]
        [SwaggerOperation("AddVideoFlag")]
        [SwaggerResponse(200, type: typeof(FlagResource))]
        public virtual IActionResult AddVideoFlag([FromRoute]long? videoId, [FromBody]string reason)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<FlagResource>(exampleJson)
            : default(FlagResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Adds one or more existing videos as related to this one
        /// </summary>
        
        /// <param name="videoId">The video id</param>
        /// <param name="videoRelationshipResource">The video relationship object </param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//media/videos/{video_id}/related")]
        [SwaggerOperation("AddVideoRelationships")]
        [SwaggerResponse(200, type: typeof(VideoRelationshipResource))]
        public virtual IActionResult AddVideoRelationships([FromRoute]long? videoId, [FromBody]VideoRelationshipResource videoRelationshipResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<VideoRelationshipResource>(exampleJson)
            : default(VideoRelationshipResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Create a video disposition
        /// </summary>
        
        /// <param name="videoId">The video id</param>
        /// <param name="dispositionResource">The disposition object</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//media/videos/{video_id}/dispositions")]
        [SwaggerOperation("CreateVideoDisposition")]
        [SwaggerResponse(200, type: typeof(DispositionResource))]
        public virtual IActionResult CreateVideoDisposition([FromRoute]int? videoId, [FromBody]DispositionResource dispositionResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<DispositionResource>(exampleJson)
            : default(DispositionResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Deletes a video from the system if no resources are attached to it
        /// </summary>
        
        /// <param name="id">The video id</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpDelete]
        [Route("//media/videos/{id}")]
        [SwaggerOperation("DeleteVideo")]
        public virtual void DeleteVideo([FromRoute]long? id)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete a video comment
        /// </summary>
        
        /// <param name="videoId">The video id</param>
        /// <param name="id">The comment id</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpDelete]
        [Route("//media/videos/{video_id}/comments/{id}")]
        [SwaggerOperation("DeleteVideoComment")]
        public virtual void DeleteVideoComment([FromRoute]long? videoId, [FromRoute]long? id)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete a video disposition
        /// </summary>
        
        /// <param name="dispositionId">The disposition id</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpDelete]
        [Route("//media/videos/{video_id}/dispositions/{disposition_id}")]
        [SwaggerOperation("DeleteVideoDisposition")]
        public virtual void DeleteVideoDisposition([FromRoute]long? dispositionId)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete a flag
        /// </summary>
        
        /// <param name="videoId">The video id</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpDelete]
        [Route("//media/videos/{video_id}/moderation")]
        [SwaggerOperation("DeleteVideoFlag")]
        public virtual void DeleteVideoFlag([FromRoute]long? videoId)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete a video&#39;s relationship
        /// </summary>
        
        /// <param name="videoId">The video id</param>
        /// <param name="id">The relationship id</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpDelete]
        [Route("//media/videos/{video_id}/related/{id}")]
        [SwaggerOperation("DeleteVideoRelationship")]
        public virtual void DeleteVideoRelationship([FromRoute]long? videoId, [FromRoute]long? id)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get user videos
        /// </summary>
        
        /// <param name="userId">The user id</param>
        /// <param name="excludeFlagged">Skip videos that have been flagged by the current user</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/{user_id}/videos")]
        [SwaggerOperation("GetUserVideos")]
        [SwaggerResponse(200, type: typeof(PageResourceVideoResource))]
        public virtual IActionResult GetUserVideos([FromRoute]int? userId, [FromQuery]bool? excludeFlagged, [FromQuery]int? size, [FromQuery]int? page)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceVideoResource>(exampleJson)
            : default(PageResourceVideoResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Loads a specific video details
        /// </summary>
        
        /// <param name="id">The video id</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//media/videos/{id}")]
        [SwaggerOperation("GetVideo")]
        [SwaggerResponse(200, type: typeof(VideoResource))]
        public virtual IActionResult GetVideo([FromRoute]long? id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<VideoResource>(exampleJson)
            : default(VideoResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Returns a page of comments for a video
        /// </summary>
        
        /// <param name="videoId">The video id</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//media/videos/{video_id}/comments")]
        [SwaggerOperation("GetVideoComments")]
        [SwaggerResponse(200, type: typeof(PageResourceCommentResource))]
        public virtual IActionResult GetVideoComments([FromRoute]int? videoId, [FromQuery]int? size, [FromQuery]int? page)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceCommentResource>(exampleJson)
            : default(PageResourceCommentResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Returns a page of dispositions for a video
        /// </summary>
        
        /// <param name="videoId">The video id</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//media/videos/{video_id}/dispositions")]
        [SwaggerOperation("GetVideoDispositions")]
        [SwaggerResponse(200, type: typeof(PageResourceDispositionResource))]
        public virtual IActionResult GetVideoDispositions([FromRoute]int? videoId, [FromQuery]int? size, [FromQuery]int? page)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceDispositionResource>(exampleJson)
            : default(PageResourceDispositionResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Returns a page of video relationships
        /// </summary>
        
        /// <param name="videoId">The video id</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//media/videos/{video_id}/related")]
        [SwaggerOperation("GetVideoRelationships")]
        [SwaggerResponse(200, type: typeof(PageResourceVideoRelationshipResource))]
        public virtual IActionResult GetVideoRelationships([FromRoute]long? videoId, [FromQuery]int? size, [FromQuery]int? page)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceVideoRelationshipResource>(exampleJson)
            : default(PageResourceVideoRelationshipResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Search videos using the documented filters
        /// </summary>
        
        /// <param name="excludeFlagged">Skip videos that have been flagged by the current user</param>
        /// <param name="filterVideosByUploader">Filter for videos by uploader id</param>
        /// <param name="filterCategory">Filter for videos from a specific category by id</param>
        /// <param name="filterTagset">Filter for videos with specified tags (separated by comma)</param>
        /// <param name="filterVideosByName">Filter for videos which name *STARTS* with the given string</param>
        /// <param name="filterVideosByContributor">Filter for videos with contribution from the artist specified by ID</param>
        /// <param name="filterVideosByAuthor">Filter for videos with an artist as author specified by ID</param>
        /// <param name="filterHasAuthor">Filter for videos that have an author set if true, or that have no author if false</param>
        /// <param name="filterHasUploader">Filter for videos that have an uploader set if true, or that have no uploader if false</param>
        /// <param name="filterRelatedTo">Filter for videos that have designated a particular video as the TO of a relationship. Pattern should match VIDEO_ID or VIDEO_ID:DETAILS to match with a specific details string as well</param>
        /// <param name="filterFriends">Filter for videos uploaded by friends. &#39;true&#39; for friends of the caller (requires user token) or a user id for a specific user&#39;s friends (requires VIDEOS_ADMIN permission)</param>
        /// <param name="filterDisposition">Filter for videos a given user has a given disposition towards. USER_ID:DISPOSITION where USER_ID is the id of the user who has this disposition or &#39;me&#39; for the caller (requires user token for &#39;me&#39;) and DISPOSITION is the name of the disposition. E.G. filter_disposition&#x3D;123:like or filter_disposition&#x3D;me:favorite</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//media/videos")]
        [SwaggerOperation("GetVideos")]
        [SwaggerResponse(200, type: typeof(PageResourceVideoResource))]
        public virtual IActionResult GetVideos([FromQuery]bool? excludeFlagged, [FromQuery]Object filterVideosByUploader, [FromQuery]string filterCategory, [FromQuery]string filterTagset, [FromQuery]string filterVideosByName, [FromQuery]Object filterVideosByContributor, [FromQuery]Object filterVideosByAuthor, [FromQuery]bool? filterHasAuthor, [FromQuery]bool? filterHasUploader, [FromQuery]string filterRelatedTo, [FromQuery]bool? filterFriends, [FromQuery]string filterDisposition, [FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceVideoResource>(exampleJson)
            : default(PageResourceVideoResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Removes a user from a video&#39;s whitelist
        /// </summary>
        /// <remarks>Remove the user with the id given in the path from the whitelist of users that can view this video regardless of privacy setting.</remarks>
        /// <param name="videoId">The video id</param>
        /// <param name="id">The user id</param>
        /// <response code="202">Accepted</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpDelete]
        [Route("//media/videos/{video_id}/whitelist/{id}")]
        [SwaggerOperation("RemoveUserFromVideoWhitelist")]
        public virtual void RemoveUserFromVideoWhitelist([FromRoute]long? videoId, [FromRoute]int? id)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Removes a contributor from a video
        /// </summary>
        
        /// <param name="videoId">The video id</param>
        /// <param name="id">The contributor id</param>
        /// <response code="202">Accepted</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpDelete]
        [Route("//media/videos/{video_id}/contributors/{id}")]
        [SwaggerOperation("RemoveVideoContributor")]
        public virtual void RemoveVideoContributor([FromRoute]long? videoId, [FromRoute]int? id)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Modifies a video&#39;s details
        /// </summary>
        
        /// <param name="id">The video id</param>
        /// <param name="videoResource">The video object</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//media/videos/{id}")]
        [SwaggerOperation("UpdateVideo")]
        public virtual void UpdateVideo([FromRoute]long? id, [FromBody]VideoResource videoResource)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Update a video comment
        /// </summary>
        
        /// <param name="videoId">The video id</param>
        /// <param name="id">The comment id</param>
        /// <param name="content">The comment content</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//media/videos/{video_id}/comments/{id}/content")]
        [SwaggerOperation("UpdateVideoComment")]
        public virtual void UpdateVideoComment([FromRoute]long? videoId, [FromRoute]long? id, [FromBody]string content)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Update a video&#39;s relationship details
        /// </summary>
        
        /// <param name="videoId">The video id</param>
        /// <param name="relationshipId">The relationship id</param>
        /// <param name="details">The video relationship details</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//media/videos/{video_id}/related/{id}/relationship_details")]
        [SwaggerOperation("UpdateVideoRelationship")]
        public virtual void UpdateVideoRelationship([FromRoute]long? videoId, [FromRoute]long? relationshipId, [FromBody]string details)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Increment a video&#39;s view count
        /// </summary>
        
        /// <param name="id">The video id</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//media/videos/{id}/views")]
        [SwaggerOperation("ViewVideo")]
        public virtual void ViewVideo([FromRoute]long? id)
        { 
            throw new NotImplementedException();
        }
    }
}
