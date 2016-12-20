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
    public class MediaModerationApiController : Controller
    { 

        /// <summary>
        /// Get a flag report
        /// </summary>
        
        /// <param name="id">The flag report id</param>
        /// <response code="200">OK</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//moderation/reports/{id}")]
        [SwaggerOperation("GetFlagReportUsingGET")]
        public virtual void GetFlagReportUsingGET([FromRoute]long? id)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Returns a page of flag reports
        /// </summary>
        /// <remarks>Context can be either a free-form string or a pre-defined context name</remarks>
        /// <param name="excludeResolved">Ignore resolved context</param>
        /// <param name="filterContext">Filter by moderation context</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//moderation/reports")]
        [SwaggerOperation("GetFlagsReportUsingGET")]
        [SwaggerResponse(200, type: typeof(PageFlagReportResource))]
        public virtual IActionResult GetFlagsReportUsingGET([FromQuery]bool? excludeResolved, [FromQuery]string filterContext, [FromQuery]int? size, [FromQuery]int? page)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageFlagReportResource>(exampleJson)
            : default(PageFlagReportResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Update a flag report
        /// </summary>
        /// <remarks>Lets you set the resolution of a report. Resolution types is {banned,ignore} in case of &#39;banned&#39; you will need to pass the reason.</remarks>
        /// <param name="id">The flag report id</param>
        /// <param name="flagReportResource">The new flag report</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//moderation/reports/{id}")]
        [SwaggerOperation("SetFlagResolutionUsingPUT")]
        public virtual void SetFlagResolutionUsingPUT([FromRoute]long? id, [FromBody]FlagReportResource flagReportResource)
        { 
            throw new NotImplementedException();
        }
    }
}
