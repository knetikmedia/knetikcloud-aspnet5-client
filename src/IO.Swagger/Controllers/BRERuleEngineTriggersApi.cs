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
    public class BRERuleEngineTriggersApiController : Controller
    { 

        /// <summary>
        /// Create a trigger
        /// </summary>
        /// <remarks>Customer added triggers will not be fired automatically or have rules associated with them by default. Custom rules must be added to get use from the trigger and it must then be fired from the outside. See the Bre Event services</remarks>
        /// <param name="breTriggerResource">The BRE trigger resource object</param>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//bre/triggers")]
        [SwaggerOperation("CreateBRETrigger")]
        [SwaggerResponse(200, type: typeof(BreTriggerResource))]
        public virtual IActionResult CreateBRETrigger([FromBody]BreTriggerResource breTriggerResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<BreTriggerResource>(exampleJson)
            : default(BreTriggerResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Delete a trigger
        /// </summary>
        /// <remarks>May fail if there are existing rules against it. Cannot delete core triggers</remarks>
        /// <param name="eventName">The trigger event name</param>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpDelete]
        [Route("//bre/triggers/{event_name}")]
        [SwaggerOperation("DeleteBRETrigger")]
        public virtual void DeleteBRETrigger([FromRoute]string eventName)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get a single trigger
        /// </summary>
        
        /// <param name="eventName">The trigger event name</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//bre/triggers/{event_name}")]
        [SwaggerOperation("GetBRETrigger")]
        [SwaggerResponse(200, type: typeof(BreTriggerResource))]
        public virtual IActionResult GetBRETrigger([FromRoute]string eventName)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<BreTriggerResource>(exampleJson)
            : default(BreTriggerResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List triggers
        /// </summary>
        
        /// <param name="filterSystem">Filter for triggers that are system triggers when true, or not when false. Leave off for both mixed</param>
        /// <param name="filterCategory">Filter for triggers that are within a specific category</param>
        /// <param name="filterName">Filter for triggers that have names containing the given string</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//bre/triggers")]
        [SwaggerOperation("GetBRETriggers")]
        [SwaggerResponse(200, type: typeof(PageResourceBreTriggerResource))]
        public virtual IActionResult GetBRETriggers([FromQuery]bool? filterSystem, [FromQuery]string filterCategory, [FromQuery]string filterName, [FromQuery]int? size, [FromQuery]int? page)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceBreTriggerResource>(exampleJson)
            : default(PageResourceBreTriggerResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Update a trigger
        /// </summary>
        /// <remarks>May fail if new parameters mismatch requirements of existing rules. Cannot update core triggers</remarks>
        /// <param name="eventName">The trigger event name</param>
        /// <param name="breTriggerResource">The BRE trigger resource object</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//bre/triggers/{event_name}")]
        [SwaggerOperation("UpdateBRETrigger")]
        public virtual void UpdateBRETrigger([FromRoute]string eventName, [FromBody]BreTriggerResource breTriggerResource)
        { 
            throw new NotImplementedException();
        }
    }
}
