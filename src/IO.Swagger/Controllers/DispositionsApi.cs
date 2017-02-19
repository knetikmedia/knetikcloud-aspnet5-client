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
    public class DispositionsApiController : Controller
    { 

        /// <summary>
        /// Add a new disposition
        /// </summary>
        
        /// <param name="disposition">The new disposition record</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//dispositions")]
        [SwaggerOperation("AddDisposition")]
        [SwaggerResponse(200, type: typeof(DispositionResource))]
        public virtual IActionResult AddDisposition([FromBody]DispositionResource disposition)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<DispositionResource>(exampleJson)
            : default(DispositionResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Delete a disposition
        /// </summary>
        
        /// <param name="id">The id of the disposition record</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpDelete]
        [Route("//dispositions/{id}")]
        [SwaggerOperation("DeleteDisposition")]
        public virtual void DeleteDisposition([FromRoute]long? id)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Returns a disposition
        /// </summary>
        
        /// <param name="id">The id of the disposition record</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//dispositions/{id}")]
        [SwaggerOperation("GetDisposition")]
        [SwaggerResponse(200, type: typeof(DispositionResource))]
        public virtual IActionResult GetDisposition([FromRoute]long? id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<DispositionResource>(exampleJson)
            : default(DispositionResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Returns a list of disposition counts
        /// </summary>
        
        /// <param name="filterContext">Filter for dispositions within a context type (games, articles, polls, etc). Optionally with a specific id like filter_context&#x3D;video:47</param>
        /// <param name="filterOwner">Filter for dispositions from a specific user by id or &#39;me&#39;</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//dispositions/count")]
        [SwaggerOperation("GetDispositionCounts")]
        [SwaggerResponse(200, type: typeof(List<DispositionCount>))]
        public virtual IActionResult GetDispositionCounts([FromQuery]string filterContext, [FromQuery]string filterOwner)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<DispositionCount>>(exampleJson)
            : default(List<DispositionCount>);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Returns a page of dispositions
        /// </summary>
        
        /// <param name="filterContext">Filter for dispositions within a context type (games, articles, polls, etc). Optionally with a specific id like filter_context&#x3D;video:47</param>
        /// <param name="filterOwner">Filter for dispositions from a specific user by id or &#39;me&#39;</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//dispositions")]
        [SwaggerOperation("GetDispositions")]
        [SwaggerResponse(200, type: typeof(PageResourceDispositionResource))]
        public virtual IActionResult GetDispositions([FromQuery]string filterContext, [FromQuery]string filterOwner, [FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceDispositionResource>(exampleJson)
            : default(PageResourceDispositionResource);
            return new ObjectResult(example);
        }
    }
}
