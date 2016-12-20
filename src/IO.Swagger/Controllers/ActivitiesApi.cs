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
    public class ActivitiesApiController : Controller
    { 

        /// <summary>
        /// Updated the status of an activity occurrence
        /// </summary>
        /// <remarks>If setting to &#39;FINISHED&#39; you must POST to /results instead to record the metrics and get synchronous reward results</remarks>
        /// <param name="activityOccurrenceId">The id of the activity occurrence</param>
        /// <param name="activityCccurrenceStatus">The activity occurrence status object</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//activity-occurrences/{activity_occurrence_id}/status")]
        [SwaggerOperation("CompleteActivityOccurrenceUsingPUT")]
        public virtual void CompleteActivityOccurrenceUsingPUT([FromRoute]long? activityOccurrenceId, [FromBody]string activityCccurrenceStatus)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Create a new activity occurrence
        /// </summary>
        /// <remarks>Has to enforce extra rules if not used as an admin</remarks>
        /// <param name="test">if true, indicates that the occurrence should NOT be created. This can be used to test for eligibility and valid settings</param>
        /// <param name="activityOccurrenceResource">The activity occurrence object</param>
        /// <response code="201">Sucessful creation</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Attempted to set an admin only field (no &#39;result&#39; returned), or missing an entitlement/wallet balance (result is an array of ActivityOccurrenceJoinResult explaining which users had what problems)</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//activity-occurrences")]
        [SwaggerOperation("CreateActivityOccurrenceUsingPOST")]
        [SwaggerResponse(200, type: typeof(ActivityOccurrenceResource))]
        public virtual IActionResult CreateActivityOccurrenceUsingPOST([FromQuery]bool? test, [FromBody]ActivityOccurrenceResource activityOccurrenceResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ActivityOccurrenceResource>(exampleJson)
            : default(ActivityOccurrenceResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Create an activity
        /// </summary>
        
        /// <param name="activityResource">The activity resource object</param>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//activities")]
        [SwaggerOperation("CreateActivityUsingPOST")]
        [SwaggerResponse(200, type: typeof(ActivityResource))]
        public virtual IActionResult CreateActivityUsingPOST([FromBody]ActivityResource activityResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ActivityResource>(exampleJson)
            : default(ActivityResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Delete an activity
        /// </summary>
        
        /// <param name="id">The id of the activity</param>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpDelete]
        [Route("//activities/{id}")]
        [SwaggerOperation("DeleteActivityUsingDELETE")]
        public virtual void DeleteActivityUsingDELETE([FromRoute]long? id)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// List activity definitions
        /// </summary>
        
        /// <param name="filterTemplate">Filter for activities that are templates, or specifically not if false</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//activities")]
        [SwaggerOperation("GetActivitiesUsingGET")]
        [SwaggerResponse(200, type: typeof(PageBareActivityResource))]
        public virtual IActionResult GetActivitiesUsingGET([FromQuery]bool? filterTemplate, [FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageBareActivityResource>(exampleJson)
            : default(PageBareActivityResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get a single activity
        /// </summary>
        
        /// <param name="id">The id of the activity</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//activities/{id}")]
        [SwaggerOperation("GetActivityUsingGET")]
        [SwaggerResponse(200, type: typeof(ActivityResource))]
        public virtual IActionResult GetActivityUsingGET([FromRoute]long? id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ActivityResource>(exampleJson)
            : default(ActivityResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Sets the status of an activity occurrence to FINISHED and logs metrics
        /// </summary>
        
        /// <param name="activityOccurrenceId">The id of the activity occurrence</param>
        /// <param name="activityOccurrenceResults">The activity occurrence object</param>
        /// <response code="200">OK</response>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//activity-occurrences/{activity_occurrence_id}/results")]
        [SwaggerOperation("PostResultsUsingPOST")]
        [SwaggerResponse(200, type: typeof(ActivityOccurrenceResults))]
        public virtual IActionResult PostResultsUsingPOST([FromRoute]long? activityOccurrenceId, [FromBody]ActivityOccurrenceResults activityOccurrenceResults)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ActivityOccurrenceResults>(exampleJson)
            : default(ActivityOccurrenceResults);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Update an activity
        /// </summary>
        
        /// <param name="id">The id of the activity</param>
        /// <param name="activityResource">The activity resource object</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//activities/{id}")]
        [SwaggerOperation("UpdateActivityUsingPUT")]
        public virtual void UpdateActivityUsingPUT([FromRoute]long? id, [FromBody]ActivityResource activityResource)
        { 
            throw new NotImplementedException();
        }
    }
}
