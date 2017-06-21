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
    public class ReportingChallengesApiController : Controller
    { 

        /// <summary>
        /// Retrieve a challenge event leaderboard details
        /// </summary>
        /// <remarks>Lists all leaderboard entries with additional user details</remarks>
        /// <param name="filterEvent">A sepecific challenge event id</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//reporting/events/leaderboard")]
        [SwaggerOperation("GetChallengeEventLeaderboard")]
        [SwaggerResponse(200, type: typeof(PageResourceChallengeEventParticipantResource))]
        public virtual IActionResult GetChallengeEventLeaderboard([FromQuery]long? filterEvent, [FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceChallengeEventParticipantResource>(exampleJson)
            : default(PageResourceChallengeEventParticipantResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Retrieve a challenge event participant details
        /// </summary>
        /// <remarks>Lists all user submitted scores sorted by value, including those that do not apear in the leaderboard due to value or aggregation</remarks>
        /// <param name="filterEvent">A sepecific challenge event id</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//reporting/events/participants")]
        [SwaggerOperation("GetChallengeEventParticipants")]
        [SwaggerResponse(200, type: typeof(PageResourceChallengeEventParticipantResource))]
        public virtual IActionResult GetChallengeEventParticipants([FromQuery]long? filterEvent, [FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceChallengeEventParticipantResource>(exampleJson)
            : default(PageResourceChallengeEventParticipantResource);
            return new ObjectResult(example);
        }
    }
}
