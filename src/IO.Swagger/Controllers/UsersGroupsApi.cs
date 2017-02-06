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
    public class UsersGroupsApiController : Controller
    { 

        /// <summary>
        /// Adds a new member to the group
        /// </summary>
        
        /// <param name="uniqueName">The group unique name</param>
        /// <param name="username">The username of a user to add to the group</param>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//users/groups/{unique_name}/members")]
        [SwaggerOperation("AddMemberToGroup")]
        [SwaggerResponse(200, type: typeof(GroupMemberResource))]
        public virtual IActionResult AddMemberToGroup([FromRoute]string uniqueName, [FromBody]GroupMemberResource username)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<GroupMemberResource>(exampleJson)
            : default(GroupMemberResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Create a group
        /// </summary>
        
        /// <param name="groupResource">The new group</param>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//users/groups")]
        [SwaggerOperation("CreateGroup")]
        [SwaggerResponse(200, type: typeof(GroupResource))]
        public virtual IActionResult CreateGroup([FromBody]GroupResource groupResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<GroupResource>(exampleJson)
            : default(GroupResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Create a group template
        /// </summary>
        /// <remarks>Group Templates define a type of group and the properties they have</remarks>
        /// <param name="groupTemplateResource">The group template resource object</param>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//users/groups/templates")]
        [SwaggerOperation("CreateGroupTemplate")]
        [SwaggerResponse(200, type: typeof(TemplateResource))]
        public virtual IActionResult CreateGroupTemplate([FromBody]TemplateResource groupTemplateResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<TemplateResource>(exampleJson)
            : default(TemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Removes a group from the system IF no resources are attached to it
        /// </summary>
        
        /// <param name="uniqueName">The group unique name</param>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpDelete]
        [Route("//users/groups/{unique_name}")]
        [SwaggerOperation("DeleteGroup")]
        public virtual void DeleteGroup([FromRoute]string uniqueName)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete a group template
        /// </summary>
        /// <remarks>If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects</remarks>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">The value needed to delete used templates</param>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpDelete]
        [Route("//users/groups/templates/{id}")]
        [SwaggerOperation("DeleteGroupTemplate")]
        public virtual void DeleteGroupTemplate([FromRoute]string id, [FromQuery]string cascade)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Loads a specific group&#39;s details
        /// </summary>
        
        /// <param name="uniqueName">The group unique name</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/groups/{unique_name}")]
        [SwaggerOperation("GetGroup")]
        [SwaggerResponse(200, type: typeof(GroupResource))]
        public virtual IActionResult GetGroup([FromRoute]string uniqueName)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<GroupResource>(exampleJson)
            : default(GroupResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get a user from a group
        /// </summary>
        
        /// <param name="uniqueName">The group unique name</param>
        /// <param name="userId">The id of the user</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/groups/{unique_name}/members/{user_id}")]
        [SwaggerOperation("GetGroupMember")]
        [SwaggerResponse(200, type: typeof(GroupMemberResource))]
        public virtual IActionResult GetGroupMember([FromRoute]string uniqueName, [FromRoute]int? userId)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<GroupMemberResource>(exampleJson)
            : default(GroupMemberResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Lists members of the group
        /// </summary>
        
        /// <param name="uniqueName">The group unique name</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/groups/{unique_name}/members")]
        [SwaggerOperation("GetGroupMembers")]
        [SwaggerResponse(200, type: typeof(PageResourceGroupMemberResource))]
        public virtual IActionResult GetGroupMembers([FromRoute]string uniqueName, [FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceGroupMemberResource>(exampleJson)
            : default(PageResourceGroupMemberResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get a single group template
        /// </summary>
        
        /// <param name="id">The id of the template</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/groups/templates/{id}")]
        [SwaggerOperation("GetGroupTemplate")]
        [SwaggerResponse(200, type: typeof(TemplateResource))]
        public virtual IActionResult GetGroupTemplate([FromRoute]string id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<TemplateResource>(exampleJson)
            : default(TemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List and search group templates
        /// </summary>
        
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/groups/templates")]
        [SwaggerOperation("GetGroupTemplates")]
        [SwaggerResponse(200, type: typeof(PageResourceTemplateResource))]
        public virtual IActionResult GetGroupTemplates([FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceTemplateResource>(exampleJson)
            : default(PageResourceTemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List groups a user is in
        /// </summary>
        
        /// <param name="userId">The id of the user</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/{user_id}/groups")]
        [SwaggerOperation("GetGroupsForUser")]
        [SwaggerResponse(200, type: typeof(List<string>))]
        public virtual IActionResult GetGroupsForUser([FromRoute]int? userId)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<string>>(exampleJson)
            : default(List<string>);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Removes a user from a group
        /// </summary>
        
        /// <param name="uniqueName">The group unique name</param>
        /// <param name="userId">The id of the user to remove</param>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpDelete]
        [Route("//users/groups/{unique_name}/members/{user_id}")]
        [SwaggerOperation("RemoveGroupMember")]
        public virtual void RemoveGroupMember([FromRoute]string uniqueName, [FromRoute]int? userId)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Update a group
        /// </summary>
        
        /// <param name="uniqueName">The group unique name</param>
        /// <param name="groupResource">The updated group</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//users/groups/{unique_name}")]
        [SwaggerOperation("UpdateGroup")]
        public virtual void UpdateGroup([FromRoute]string uniqueName, [FromBody]GroupResource groupResource)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Change a user&#39;s status
        /// </summary>
        
        /// <param name="uniqueName">The group unique name</param>
        /// <param name="userId">The user id of the member to modify</param>
        /// <param name="status">The new status for the user</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//users/groups/{unique_name}/members/{user_id}/status")]
        [SwaggerOperation("UpdateGroupMemberStatus")]
        public virtual void UpdateGroupMemberStatus([FromRoute]string uniqueName, [FromRoute]int? userId, [FromBody]string status)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Update a group template
        /// </summary>
        
        /// <param name="id">The id of the template</param>
        /// <param name="groupTemplateResource">The group template resource object</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//users/groups/templates/{id}")]
        [SwaggerOperation("UpdateGroupTemplate")]
        public virtual void UpdateGroupTemplate([FromRoute]string id, [FromBody]TemplateResource groupTemplateResource)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// List and search groups
        /// </summary>
        
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/groups")]
        [SwaggerOperation("UpdateGroups")]
        [SwaggerResponse(200, type: typeof(PageResourceGroupResource))]
        public virtual IActionResult UpdateGroups([FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceGroupResource>(exampleJson)
            : default(PageResourceGroupResource);
            return new ObjectResult(example);
        }
    }
}
