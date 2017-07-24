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
    public class AccessTokenApiController : Controller
    { 

        /// <summary>
        /// Get access token
        /// </summary>
        
        /// <param name="grantType">Grant type</param>
        /// <param name="clientId">The id of the client</param>
        /// <param name="clientSecret">The secret key of the client.  Used only with a grant_type of client_credentials</param>
        /// <param name="username">The username of the client.  Used only with a grant_type of password</param>
        /// <param name="password">The password of the client.  Used only with a grant_type of password</param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("//oauth/token")]
        [SwaggerOperation("GetOAuthToken")]
        [SwaggerResponse(200, type: typeof(OAuth2Resource))]
        public virtual IActionResult GetOAuthToken([FromForm]string grantType, [FromForm]string clientId, [FromForm]string clientSecret, [FromForm]string username, [FromForm]string password)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<OAuth2Resource>(exampleJson)
            : default(OAuth2Resource);
            return new ObjectResult(example);
        }
    }
}
