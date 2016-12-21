/*
 * Knetik Platform API Documentation Latest
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://demo.sandbox.knetikcloud.com
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
    public class UtilSecurityApiController : Controller
    { 

        /// <summary>
        /// Returns the authentication log for a user
        /// </summary>
        /// <remarks>A log entry is recorded everytime a user requests a new token. Standard pagination available</remarks>
        /// <param name="userId">The user id</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//security/country-log")]
        [SwaggerOperation("GetUserLocationLogUsingGET")]
        [SwaggerResponse(200, type: typeof(PageResourceLocationLogResource))]
        public virtual IActionResult GetUserLocationLogUsingGET([FromQuery]int? userId)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceLocationLogResource>(exampleJson)
            : default(PageResourceLocationLogResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Returns the authentication token details. Use /users endpoint for detailed user&#39;s info
        /// </summary>
        
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//me")]
        [SwaggerOperation("UserUsingGET")]
        [SwaggerResponse(200, type: typeof(TokenDetailsResource))]
        public virtual IActionResult UserUsingGET()
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<TokenDetailsResource>(exampleJson)
            : default(TokenDetailsResource);
            return new ObjectResult(example);
        }
    }
}
