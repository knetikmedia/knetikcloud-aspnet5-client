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
    public class BRERuleEngineActionsApiController : Controller
    { 

        /// <summary>
        /// Get a list of available actions
        /// </summary>
        
        /// <param name="filterCategory">Filter for actions that are within a specific category</param>
        /// <param name="filterName">Filter for actions that have names containing the given string</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//bre/actions")]
        [SwaggerOperation("GetActionsUsingGET")]
        [SwaggerResponse(200, type: typeof(List<ActionResource>))]
        public virtual IActionResult GetActionsUsingGET([FromQuery]string filterCategory, [FromQuery]string filterName)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<ActionResource>>(exampleJson)
            : default(List<ActionResource>);
            return new ObjectResult(example);
        }
    }
}
