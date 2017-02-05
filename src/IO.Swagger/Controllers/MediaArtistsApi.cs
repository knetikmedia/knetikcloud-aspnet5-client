/*
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://demo.sandbox.knetikcloud.com
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
    public class MediaArtistsApiController : Controller
    { 

        /// <summary>
        /// Adds a new artist in the system
        /// </summary>
        /// <remarks>Adds a new artist in the system. Use specific media contributions endpoint to add contributions</remarks>
        /// <param name="artistResource">The new artist</param>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//media/artists")]
        [SwaggerOperation("AddArtistUsingPOST")]
        [SwaggerResponse(200, type: typeof(ArtistResource))]
        public virtual IActionResult AddArtistUsingPOST([FromBody]ArtistResource artistResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ArtistResource>(exampleJson)
            : default(ArtistResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Create an artist template
        /// </summary>
        /// <remarks>Artist Templates define a type of artist and the properties they have</remarks>
        /// <param name="artistTemplateResource">The artist template resource object</param>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//media/artists/templates")]
        [SwaggerOperation("CreateArtistTemplateUsingPOST")]
        [SwaggerResponse(200, type: typeof(TemplateResource))]
        public virtual IActionResult CreateArtistTemplateUsingPOST([FromBody]TemplateResource artistTemplateResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<TemplateResource>(exampleJson)
            : default(TemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Delete an artist template
        /// </summary>
        /// <remarks>If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects</remarks>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">The value needed to delete used templates</param>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpDelete]
        [Route("//media/artists/templates/{id}")]
        [SwaggerOperation("DeleteArtistTemplateUsingDELETE")]
        public virtual void DeleteArtistTemplateUsingDELETE([FromRoute]string id, [FromQuery]string cascade)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Removes an artist from the system IF no resources are attached to it
        /// </summary>
        
        /// <param name="id">The artist id</param>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpDelete]
        [Route("//media/artists/{id}")]
        [SwaggerOperation("DeleteArtistUsingDELETE")]
        public virtual void DeleteArtistUsingDELETE([FromRoute]long? id)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get a single artist template
        /// </summary>
        
        /// <param name="id">The id of the template</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//media/artists/templates/{id}")]
        [SwaggerOperation("GetArtistTemplateUsingGET")]
        [SwaggerResponse(200, type: typeof(TemplateResource))]
        public virtual IActionResult GetArtistTemplateUsingGET([FromRoute]string id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<TemplateResource>(exampleJson)
            : default(TemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List and search artist templates
        /// </summary>
        
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//media/artists/templates")]
        [SwaggerOperation("GetArtistTemplatesUsingGET")]
        [SwaggerResponse(200, type: typeof(PageResourceTemplateResource))]
        public virtual IActionResult GetArtistTemplatesUsingGET([FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceTemplateResource>(exampleJson)
            : default(PageResourceTemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Loads a specific artist details
        /// </summary>
        
        /// <param name="id">The artist id</param>
        /// <param name="showContributions">The number of contributions to show fetch</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//media/artists/{id}")]
        [SwaggerOperation("GetArtistUsingGET")]
        [SwaggerResponse(200, type: typeof(ArtistResource))]
        public virtual IActionResult GetArtistUsingGET([FromRoute]long? id, [FromQuery]int? showContributions)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ArtistResource>(exampleJson)
            : default(ArtistResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Search for artists
        /// </summary>
        
        /// <param name="filterArtistsByName">Filter for artists which name *STARTS* with the given string</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//media/artists")]
        [SwaggerOperation("SearchArtistsUsingGET")]
        [SwaggerResponse(200, type: typeof(PageResourceArtistResource))]
        public virtual IActionResult SearchArtistsUsingGET([FromQuery]string filterArtistsByName, [FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceArtistResource>(exampleJson)
            : default(PageResourceArtistResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Update an artist template
        /// </summary>
        
        /// <param name="id">The id of the template</param>
        /// <param name="artistTemplateResource">The artist template resource object</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//media/artists/templates/{id}")]
        [SwaggerOperation("UpdateArtistTemplateUsingPUT")]
        public virtual void UpdateArtistTemplateUsingPUT([FromRoute]string id, [FromBody]TemplateResource artistTemplateResource)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Modifies an artist details
        /// </summary>
        
        /// <param name="id">The artist id</param>
        /// <param name="artistResource">The new artist</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//media/artists/{id}")]
        [SwaggerOperation("UpdateArtistUsingPUT")]
        public virtual void UpdateArtistUsingPUT([FromRoute]long? id, [FromBody]ArtistResource artistResource)
        { 
            throw new NotImplementedException();
        }
    }
}
