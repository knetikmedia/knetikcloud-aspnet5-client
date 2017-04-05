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
    public class UsersRelationshipsApiController : Controller
    { 

        /// <summary>
        /// Create a user relationship
        /// </summary>
        
        /// <param name="relationship">The new relationship</param>
        /// <response code="201">Created</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//users/relationships")]
        [SwaggerOperation("CreateUserRelationship")]
        [SwaggerResponse(200, type: typeof(UserRelationshipResource))]
        public virtual IActionResult CreateUserRelationship([FromBody]UserRelationshipResource relationship)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<UserRelationshipResource>(exampleJson)
            : default(UserRelationshipResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Delete a user relationship
        /// </summary>
        
        /// <param name="id">The id of the relationship</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpDelete]
        [Route("//users/relationships/{id}")]
        [SwaggerOperation("DeleteUserRelationship")]
        public virtual void DeleteUserRelationship([FromRoute]long? id)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get a user relationship
        /// </summary>
        
        /// <param name="id">The id of the relationship</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/relationships/{id}")]
        [SwaggerOperation("GetUserRelationship")]
        [SwaggerResponse(200, type: typeof(UserRelationshipResource))]
        public virtual IActionResult GetUserRelationship([FromRoute]long? id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<UserRelationshipResource>(exampleJson)
            : default(UserRelationshipResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get a list of user relationships
        /// </summary>
        
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/relationships")]
        [SwaggerOperation("GetUserRelationships")]
        [SwaggerResponse(200, type: typeof(PageResourceUserRelationshipResource))]
        public virtual IActionResult GetUserRelationships()
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceUserRelationshipResource>(exampleJson)
            : default(PageResourceUserRelationshipResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Update a user relationship
        /// </summary>
        
        /// <param name="id">The id of the relationship</param>
        /// <param name="relationship">The new relationship</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//users/relationships/{id}")]
        [SwaggerOperation("UpdateUserRelationship")]
        [SwaggerResponse(200, type: typeof(UserRelationshipResource))]
        public virtual IActionResult UpdateUserRelationship([FromRoute]long? id, [FromBody]UserRelationshipResource relationship)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<UserRelationshipResource>(exampleJson)
            : default(UserRelationshipResource);
            return new ObjectResult(example);
        }
    }
}
