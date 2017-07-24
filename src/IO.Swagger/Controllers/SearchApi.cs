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
    public class SearchApiController : Controller
    { 

        /// <summary>
        /// Add a new object to an index
        /// </summary>
        /// <remarks>Mainly intended for internal use.</remarks>
        /// <param name="type">The index type</param>
        /// <param name="id">The ID of the object</param>
        /// <param name="object">The object to add</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//search/index/{type}/{id}")]
        [SwaggerOperation("AddSearchIndex")]
        public virtual void AddSearchIndex([FromRoute]string type, [FromRoute]string id, [FromBody]Object object)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Register reference mappings
        /// </summary>
        /// <remarks>Add a new type mapping to connect data from one index to another, or discover an exsting one. Mainly intended for internal use.</remarks>
        /// <param name="mappings">The mappings to add</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//search/mappings")]
        [SwaggerOperation("AddSearchMappings")]
        public virtual void AddSearchMappings([FromBody]List<SearchReferenceMapping> mappings)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete an object
        /// </summary>
        /// <remarks>Mainly intended for internal use. Requires SEARCH_ADMIN.</remarks>
        /// <param name="type">The index type</param>
        /// <param name="id">The ID of the object to delete</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpDelete]
        [Route("//search/index/{type}/{id}")]
        [SwaggerOperation("DeleteSearchIndex")]
        public virtual void DeleteSearchIndex([FromRoute]string type, [FromRoute]string id)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete all objects in an index
        /// </summary>
        /// <remarks>Mainly intended for internal use</remarks>
        /// <param name="type">The index type</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpDelete]
        [Route("//search/index/{type}")]
        [SwaggerOperation("DeleteSearchIndexes")]
        public virtual void DeleteSearchIndexes([FromRoute]string type)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Search an index
        /// </summary>
        /// <remarks>The body is an ElasticSearch query in JSON format. Please see their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/query-dsl.html&#39;&gt;documentation&lt;/a&gt; for details on the format and search options. The searchable object&#39;s format depends on on the type. See individual search endpoints on other resources for details on their format.</remarks>
        /// <param name="type">The index type</param>
        /// <param name="query">The query to be used for the search</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//search/index/{type}")]
        [SwaggerOperation("SearchIndex")]
        [SwaggerResponse(200, type: typeof(PageResourceMapstringobject))]
        public virtual IActionResult SearchIndex([FromRoute]string type, [FromBody]Object query, [FromQuery]int? size, [FromQuery]int? page)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceMapstringobject>(exampleJson)
            : default(PageResourceMapstringobject);
            return new ObjectResult(example);
        }
    }
}
