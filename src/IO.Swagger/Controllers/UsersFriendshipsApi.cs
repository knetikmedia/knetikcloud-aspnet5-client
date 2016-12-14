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
    public class UsersFriendshipsApiController : Controller
    { 

        /// <summary>
        /// Add a friend
        /// </summary>
        /// <remarks>As a user, either creates or confirm a pending request. As an admin, call this endpoint twice while inverting the IDs to create a confirmed friendship.</remarks>
        /// <param name="userId">The id of the user or &#39;me&#39; if logged in</param>
        /// <param name="id">The id of the user to befriend</param>
        /// <response code="200">OK</response>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//users/{user_id}/friends/{id}")]
        [SwaggerOperation("AddFriendUsingPOST")]
        public virtual void AddFriendUsingPOST([FromRoute]string userId, [FromRoute]int? id)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Redeem friendship token
        /// </summary>
        /// <remarks>Immediately connects the requested user with the user mapped by the provided invite token</remarks>
        /// <param name="userId">The id of the user or &#39;me&#39; if logged in</param>
        /// <param name="token">The invite token</param>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//users/{user_id}/friends/tokens")]
        [SwaggerOperation("ConnectUsingTokenUsingPOST")]
        public virtual void ConnectUsingTokenUsingPOST([FromRoute]string userId, [FromBody]string token)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get friends list
        /// </summary>
        
        /// <param name="userId">The id of the user or &#39;me&#39;</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/{user_id}/friends")]
        [SwaggerOperation("GetFriendsUsingGET")]
        [SwaggerResponse(200, type: typeof(PageSimpleUserResource))]
        public virtual IActionResult GetFriendsUsingGET([FromRoute]string userId, [FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageSimpleUserResource>(exampleJson)
            : default(PageSimpleUserResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Returns the invite token
        /// </summary>
        /// <remarks>This is a unique invite token that allows direct connection to the request user.  Exposing that token presents privacy issues if the token is leaked. Use friend request flow instead if confirmation is required</remarks>
        /// <param name="userId">The id of the user or &#39;me&#39; if logged in</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/{user_id}/invite-token")]
        [SwaggerOperation("GetInviteTokenUsingGET")]
        [SwaggerResponse(200, type: typeof(string))]
        public virtual IActionResult GetInviteTokenUsingGET([FromRoute]string userId)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<string>(exampleJson)
            : default(string);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get pending invites
        /// </summary>
        /// <remarks>Invites that the specified user received</remarks>
        /// <param name="userId">The id of the user or &#39;me&#39;</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/{user_id}/invites")]
        [SwaggerOperation("GetInvitesUsingGET")]
        [SwaggerResponse(200, type: typeof(PageSimpleUserResource))]
        public virtual IActionResult GetInvitesUsingGET([FromRoute]string userId, [FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageSimpleUserResource>(exampleJson)
            : default(PageSimpleUserResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Remove or decline a friend
        /// </summary>
        
        /// <param name="userId">The id of the user or &#39;me&#39; if logged in</param>
        /// <param name="id">The id of the user to befriend</param>
        /// <response code="200">OK</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpDelete]
        [Route("//users/{user_id}/friends/{id}")]
        [SwaggerOperation("RemoveFriendUsingDELETE")]
        public virtual void RemoveFriendUsingDELETE([FromRoute]string userId, [FromRoute]int? id)
        { 
            throw new NotImplementedException();
        }
    }
}
