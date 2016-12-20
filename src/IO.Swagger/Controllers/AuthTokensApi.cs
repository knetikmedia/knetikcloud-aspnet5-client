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
    public class AuthTokensApiController : Controller
    { 

        /// <summary>
        /// Delete all tokens by username
        /// </summary>
        
        /// <param name="username">The username of the user</param>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpDelete]
        [Route("//auth/tokens/{username}")]
        [SwaggerOperation("DeleteTokenUsingDELETE")]
        public virtual void DeleteTokenUsingDELETE([FromRoute]string username)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete a token by username and client id
        /// </summary>
        
        /// <param name="username">The username of the user</param>
        /// <param name="clientId">The id of the client</param>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpDelete]
        [Route("//auth/tokens/{username}/{client_id}")]
        [SwaggerOperation("DeleteTokenWithClientIdUsingDELETE")]
        public virtual void DeleteTokenWithClientIdUsingDELETE([FromRoute]string username, [FromRoute]string clientId)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get a single token by username and client id
        /// </summary>
        
        /// <param name="username">The username of the user</param>
        /// <param name="clientId">The id of the client</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//auth/tokens/{username}/{client_id}")]
        [SwaggerOperation("GetTokenByUserUsingGET")]
        [SwaggerResponse(200, type: typeof(OauthAccessTokenResource))]
        public virtual IActionResult GetTokenByUserUsingGET([FromRoute]string username, [FromRoute]string clientId)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<OauthAccessTokenResource>(exampleJson)
            : default(OauthAccessTokenResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List usernames and client ids
        /// </summary>
        /// <remarks>Token value not shown</remarks>
        /// <param name="filterClientId">Filters for token whose client id matches provided string</param>
        /// <param name="filterUsername">Filters for token whose username matches provided string</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//auth/tokens")]
        [SwaggerOperation("GetTokensUsingGET")]
        [SwaggerResponse(200, type: typeof(PageOauthAccessTokenResource))]
        public virtual IActionResult GetTokensUsingGET([FromQuery]string filterClientId, [FromQuery]string filterUsername, [FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageOauthAccessTokenResource>(exampleJson)
            : default(PageOauthAccessTokenResource);
            return new ObjectResult(example);
        }
    }
}
