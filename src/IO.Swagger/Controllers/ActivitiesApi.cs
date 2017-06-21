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
    public class ActivitiesApiController : Controller
    { 

        /// <summary>
        /// Create an activity
        /// </summary>
        
        /// <param name="activityResource">The activity resource object</param>
        /// <response code="201">Created</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//activities")]
        [SwaggerOperation("CreateActivity")]
        [SwaggerResponse(200, type: typeof(RepresentsAnActivityThatCanBeParameterizedAndTrackedThroughMetricsScoresEtc))]
        public virtual IActionResult CreateActivity([FromBody]RepresentsAnActivityThatCanBeParameterizedAndTrackedThroughMetricsScoresEtc activityResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<RepresentsAnActivityThatCanBeParameterizedAndTrackedThroughMetricsScoresEtc>(exampleJson)
            : default(RepresentsAnActivityThatCanBeParameterizedAndTrackedThroughMetricsScoresEtc);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Create a new activity occurrence. Ex: start a game
        /// </summary>
        /// <remarks>Has to enforce extra rules if not used as an admin</remarks>
        /// <param name="test">if true, indicates that the occurrence should NOT be created. This can be used to test for eligibility and valid settings</param>
        /// <param name="activityOccurrenceResource">The activity occurrence object</param>
        /// <response code="201">Sucessful creation</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Attempted to set an admin only field (no &#39;result&#39; returned), or missing an entitlement/wallet balance (result is an array of ActivityOccurrenceJoinResult explaining which users had what problems)</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//activity-occurrences")]
        [SwaggerOperation("CreateActivityOccurrence")]
        [SwaggerResponse(200, type: typeof(AOccurrenceOfAnActivityTheActualGameForExampleUsedToTrackScoresParticipantsAndProvideSettings))]
        public virtual IActionResult CreateActivityOccurrence([FromQuery]bool? test, [FromBody]AOccurrenceOfAnActivityTheActualGameForExampleUsedToTrackScoresParticipantsAndProvideSettings activityOccurrenceResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<AOccurrenceOfAnActivityTheActualGameForExampleUsedToTrackScoresParticipantsAndProvideSettings>(exampleJson)
            : default(AOccurrenceOfAnActivityTheActualGameForExampleUsedToTrackScoresParticipantsAndProvideSettings);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Create a activity template
        /// </summary>
        /// <remarks>Activity Templates define a type of activity and the properties they have</remarks>
        /// <param name="activityTemplateResource">The activity template resource object</param>
        /// <response code="201">Created</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//activities/templates")]
        [SwaggerOperation("CreateActivityTemplate")]
        [SwaggerResponse(200, type: typeof(TemplateResource))]
        public virtual IActionResult CreateActivityTemplate([FromBody]TemplateResource activityTemplateResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<TemplateResource>(exampleJson)
            : default(TemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Delete an activity
        /// </summary>
        
        /// <param name="id">The id of the activity</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpDelete]
        [Route("//activities/{id}")]
        [SwaggerOperation("DeleteActivity")]
        public virtual void DeleteActivity([FromRoute]long? id)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete a activity template
        /// </summary>
        /// <remarks>If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects</remarks>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">The value needed to delete used templates</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpDelete]
        [Route("//activities/templates/{id}")]
        [SwaggerOperation("DeleteActivityTemplate")]
        public virtual void DeleteActivityTemplate([FromRoute]string id, [FromQuery]string cascade)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// List activity definitions
        /// </summary>
        
        /// <param name="filterTemplate">Filter for activities that are templates, or specifically not if false</param>
        /// <param name="filterName">Filter for activities that have a name starting with specified string</param>
        /// <param name="filterId">Filter for activities with an id in the given comma separated list of ids</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//activities")]
        [SwaggerOperation("GetActivities")]
        [SwaggerResponse(200, type: typeof(PageResourceBareActivityResource))]
        public virtual IActionResult GetActivities([FromQuery]bool? filterTemplate, [FromQuery]string filterName, [FromQuery]Object filterId, [FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceBareActivityResource>(exampleJson)
            : default(PageResourceBareActivityResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get a single activity
        /// </summary>
        
        /// <param name="id">The id of the activity</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//activities/{id}")]
        [SwaggerOperation("GetActivity")]
        [SwaggerResponse(200, type: typeof(RepresentsAnActivityThatCanBeParameterizedAndTrackedThroughMetricsScoresEtc))]
        public virtual IActionResult GetActivity([FromRoute]long? id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<RepresentsAnActivityThatCanBeParameterizedAndTrackedThroughMetricsScoresEtc>(exampleJson)
            : default(RepresentsAnActivityThatCanBeParameterizedAndTrackedThroughMetricsScoresEtc);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get a single activity template
        /// </summary>
        
        /// <param name="id">The id of the template</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//activities/templates/{id}")]
        [SwaggerOperation("GetActivityTemplate")]
        [SwaggerResponse(200, type: typeof(TemplateResource))]
        public virtual IActionResult GetActivityTemplate([FromRoute]string id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<TemplateResource>(exampleJson)
            : default(TemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List and search activity templates
        /// </summary>
        
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//activities/templates")]
        [SwaggerOperation("GetActivityTemplates")]
        [SwaggerResponse(200, type: typeof(PageResourceTemplateResource))]
        public virtual IActionResult GetActivityTemplates([FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceTemplateResource>(exampleJson)
            : default(PageResourceTemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Sets the status of an activity occurrence to FINISHED and logs metrics
        /// </summary>
        
        /// <param name="activityOccurrenceId">The id of the activity occurrence</param>
        /// <param name="activityOccurrenceResults">The activity occurrence object</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//activity-occurrences/{activity_occurrence_id}/results")]
        [SwaggerOperation("SetActivityOccurrenceResults")]
        [SwaggerResponse(200, type: typeof(ActivityOccurrenceResults))]
        public virtual IActionResult SetActivityOccurrenceResults([FromRoute]long? activityOccurrenceId, [FromBody]ActivityOccurrenceResults activityOccurrenceResults)
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
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//activities/{id}")]
        [SwaggerOperation("UpdateActivity")]
        [SwaggerResponse(200, type: typeof(RepresentsAnActivityThatCanBeParameterizedAndTrackedThroughMetricsScoresEtc))]
        public virtual IActionResult UpdateActivity([FromRoute]long? id, [FromBody]RepresentsAnActivityThatCanBeParameterizedAndTrackedThroughMetricsScoresEtc activityResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<RepresentsAnActivityThatCanBeParameterizedAndTrackedThroughMetricsScoresEtc>(exampleJson)
            : default(RepresentsAnActivityThatCanBeParameterizedAndTrackedThroughMetricsScoresEtc);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Updated the status of an activity occurrence
        /// </summary>
        /// <remarks>If setting to &#39;FINISHED&#39; you must POST to /results instead to record the metrics and get synchronous reward results</remarks>
        /// <param name="activityOccurrenceId">The id of the activity occurrence</param>
        /// <param name="activityCccurrenceStatus">The activity occurrence status object</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//activity-occurrences/{activity_occurrence_id}/status")]
        [SwaggerOperation("UpdateActivityOccurrence")]
        public virtual void UpdateActivityOccurrence([FromRoute]long? activityOccurrenceId, [FromBody]string activityCccurrenceStatus)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Update an activity template
        /// </summary>
        
        /// <param name="id">The id of the template</param>
        /// <param name="activityTemplateResource">The activity template resource object</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//activities/templates/{id}")]
        [SwaggerOperation("UpdateActivityTemplate")]
        [SwaggerResponse(200, type: typeof(TemplateResource))]
        public virtual IActionResult UpdateActivityTemplate([FromRoute]string id, [FromBody]TemplateResource activityTemplateResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<TemplateResource>(exampleJson)
            : default(TemplateResource);
            return new ObjectResult(example);
        }
    }
}
