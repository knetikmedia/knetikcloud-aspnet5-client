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
    public class UsersApiController : Controller
    { 

        /// <summary>
        /// Create a user template
        /// </summary>
        /// <remarks>User Templates define a type of user and the properties they have</remarks>
        /// <param name="userTemplateResource">The user template resource object</param>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//users/templates")]
        [SwaggerOperation("CreateUserTemplateUsingPOST")]
        [SwaggerResponse(200, type: typeof(TemplateResource))]
        public virtual IActionResult CreateUserTemplateUsingPOST([FromBody]TemplateResource userTemplateResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<TemplateResource>(exampleJson)
            : default(TemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Delete a user template
        /// </summary>
        /// <remarks>If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects</remarks>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">The value needed to delete used templates</param>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpDelete]
        [Route("//users/templates/{id}")]
        [SwaggerOperation("DeleteUserTemplateUsingDELETE")]
        public virtual void DeleteUserTemplateUsingDELETE([FromRoute]string id, [FromQuery]string cascade)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Choose a new password after a reset
        /// </summary>
        /// <remarks>Finish resetting a user&#39;s password using the secret provided from the password-reset endpoint.  Password should be in plain text and will be encrypted on receipt. Use SSL for security.</remarks>
        /// <param name="id">The id of the user</param>
        /// <param name="newPasswordRequest">The new password request object</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//users/{id}/password-reset")]
        [SwaggerOperation("DoPasswordResetUsingPUT")]
        public virtual void DoPasswordResetUsingPUT([FromRoute]int? id, [FromBody]NewPasswordRequest newPasswordRequest)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get a single user template
        /// </summary>
        
        /// <param name="id">The id of the template</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/templates/{id}")]
        [SwaggerOperation("GetUserTemplateUsingGET")]
        [SwaggerResponse(200, type: typeof(TemplateResource))]
        public virtual IActionResult GetUserTemplateUsingGET([FromRoute]string id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<TemplateResource>(exampleJson)
            : default(TemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List and search user templates
        /// </summary>
        
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/templates")]
        [SwaggerOperation("GetUserTemplatesUsingGET")]
        [SwaggerResponse(200, type: typeof(PageTemplateResource))]
        public virtual IActionResult GetUserTemplatesUsingGET([FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageTemplateResource>(exampleJson)
            : default(PageTemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get a single user
        /// </summary>
        /// <remarks>Additional private info is included as USERS_ADMIN</remarks>
        /// <param name="id">The id of the user or &#39;me&#39;</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/{id}")]
        [SwaggerOperation("GetUserUsingGET")]
        [SwaggerResponse(200, type: typeof(UserResource))]
        public virtual IActionResult GetUserUsingGET([FromRoute]string id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<UserResource>(exampleJson)
            : default(UserResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List and search users
        /// </summary>
        /// <remarks>Additional private info is included as USERS_ADMIN</remarks>
        /// <param name="filterRole">Filter for users whose roles has the provided role</param>
        /// <param name="filterDisplayname">Filter for users whose display name starts with provided string.</param>
        /// <param name="filterEmail">Filter for users whose email starts with provided string. Requires USERS_ADMIN permission</param>
        /// <param name="filterFirstname">Filter for users whose first name starts with provided string. Requires USERS_ADMIN permission</param>
        /// <param name="filterFullname">Filter for users whose full name starts with provided string. Requires USERS_ADMIN permission</param>
        /// <param name="filterLastname">Filter for users whose last name starts with provided string. Requires USERS_ADMIN permission</param>
        /// <param name="filterUsername">Filter for users whose username starts with the provided string. Requires USERS_ADMIN permission</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users")]
        [SwaggerOperation("GetUsersUsingGET")]
        [SwaggerResponse(200, type: typeof(PageUserBaseResource))]
        public virtual IActionResult GetUsersUsingGET([FromQuery]string filterRole, [FromQuery]string filterDisplayname, [FromQuery]string filterEmail, [FromQuery]string filterFirstname, [FromQuery]string filterFullname, [FromQuery]string filterLastname, [FromQuery]string filterUsername, [FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageUserBaseResource>(exampleJson)
            : default(PageUserBaseResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Reset a user&#39;s password
        /// </summary>
        /// <remarks>A reset code will be generated and a &#39;forgot_password&#39; BRE event will be fired with that code; this can be routed to the user as needed and submitted to the &#39;choose a new password&#39; endpoint.</remarks>
        /// <param name="id">The id of the user</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//users/{id}/password-reset")]
        [SwaggerOperation("InitiatePasswordResetUsingPOST")]
        public virtual void InitiatePasswordResetUsingPOST([FromRoute]int? id)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Register a new user
        /// </summary>
        /// <remarks>Password should be in plain text and will be encrypted on receipt. Use SSL for security</remarks>
        /// <param name="userResource">The user resource object</param>
        /// <response code="200">OK</response>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//users")]
        [SwaggerOperation("RegisterUserUsingPOST")]
        [SwaggerResponse(200, type: typeof(UserResource))]
        public virtual IActionResult RegisterUserUsingPOST([FromBody]UserResource userResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<UserResource>(exampleJson)
            : default(UserResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Set a user&#39;s password
        /// </summary>
        /// <remarks>Password should be in plain text and will be encrypted on receipt. Use SSL for security.</remarks>
        /// <param name="id">The id of the user</param>
        /// <param name="password">The new plain text password</param>
        /// <response code="200">OK</response>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//users/{id}/password")]
        [SwaggerOperation("SetPasswordUsingPUT")]
        public virtual void SetPasswordUsingPUT([FromRoute]int? id, [FromBody]string password)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Update a user template
        /// </summary>
        
        /// <param name="id">The id of the template</param>
        /// <param name="userTemplateResource">The user template resource object</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//users/templates/{id}")]
        [SwaggerOperation("UpdateUserTemplateUsingPUT")]
        public virtual void UpdateUserTemplateUsingPUT([FromRoute]string id, [FromBody]TemplateResource userTemplateResource)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Update a user&#39;s info
        /// </summary>
        /// <remarks>Password will not be edited on this endpoint, use password specific endpoints.</remarks>
        /// <param name="id">The id of the user or &#39;me&#39;</param>
        /// <param name="userResource">The user resource object</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//users/{id}")]
        [SwaggerOperation("UpdateUserUsingPUT")]
        public virtual void UpdateUserUsingPUT([FromRoute]string id, [FromBody]UserResource userResource)
        { 
            throw new NotImplementedException();
        }
    }
}
