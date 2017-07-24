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
    public class UsersAddressesApiController : Controller
    { 

        /// <summary>
        /// Create a new address
        /// </summary>
        
        /// <param name="userId">The id of the user</param>
        /// <param name="savedAddressResource">The new address</param>
        /// <response code="201">Created</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//users/{user_id}/addresses")]
        [SwaggerOperation("CreateAddress")]
        [SwaggerResponse(200, type: typeof(SavedAddressResource))]
        public virtual IActionResult CreateAddress([FromRoute]string userId, [FromBody]SavedAddressResource savedAddressResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<SavedAddressResource>(exampleJson)
            : default(SavedAddressResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Delete an address
        /// </summary>
        
        /// <param name="userId">The id of the user</param>
        /// <param name="id">The id of the address</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpDelete]
        [Route("//users/{user_id}/addresses/{id}")]
        [SwaggerOperation("DeleteAddress")]
        public virtual void DeleteAddress([FromRoute]string userId, [FromRoute]int? id)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get a single address
        /// </summary>
        
        /// <param name="userId">The id of the user</param>
        /// <param name="id">The id of the address</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/{user_id}/addresses/{id}")]
        [SwaggerOperation("GetAddress")]
        [SwaggerResponse(200, type: typeof(SavedAddressResource))]
        public virtual IActionResult GetAddress([FromRoute]string userId, [FromRoute]int? id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<SavedAddressResource>(exampleJson)
            : default(SavedAddressResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List and search addresses
        /// </summary>
        
        /// <param name="userId">The id of the user</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/{user_id}/addresses")]
        [SwaggerOperation("GetAddresses")]
        [SwaggerResponse(200, type: typeof(PageResourceSavedAddressResource))]
        public virtual IActionResult GetAddresses([FromRoute]string userId, [FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceSavedAddressResource>(exampleJson)
            : default(PageResourceSavedAddressResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Update an address
        /// </summary>
        
        /// <param name="userId">The id of the user</param>
        /// <param name="id">The id of the address</param>
        /// <param name="savedAddressResource">The saved address resource object</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//users/{user_id}/addresses/{id}")]
        [SwaggerOperation("UpdateAddress")]
        [SwaggerResponse(200, type: typeof(SavedAddressResource))]
        public virtual IActionResult UpdateAddress([FromRoute]string userId, [FromRoute]int? id, [FromBody]SavedAddressResource savedAddressResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<SavedAddressResource>(exampleJson)
            : default(SavedAddressResource);
            return new ObjectResult(example);
        }
    }
}
