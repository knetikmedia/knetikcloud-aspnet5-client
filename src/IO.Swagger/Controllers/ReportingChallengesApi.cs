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
    public class ReportingChallengesApiController : Controller
    { 

        /// <summary>
        /// Retrieve a challenge event leaderboard details
        /// </summary>
        /// <remarks>Lists all leaderboard entries with additional user details</remarks>
        /// <param name="filterEvent">A sepecific challenge event id</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//reporting/events/leaderboard")]
        [SwaggerOperation("GetChallengeEventLeaderboardUsingGET")]
        [SwaggerResponse(200, type: typeof(PageChallengeEventParticipantResource))]
        public virtual IActionResult GetChallengeEventLeaderboardUsingGET([FromQuery]long? filterEvent)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageChallengeEventParticipantResource>(exampleJson)
            : default(PageChallengeEventParticipantResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Retrieve a challenge event participant details
        /// </summary>
        /// <remarks>Lists all user submitted scores sorted by value, including those that do not apear in the leaderboard due to value or aggregation</remarks>
        /// <param name="filterEvent">A sepecific challenge event id</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//reporting/events/participants")]
        [SwaggerOperation("GetChallengeEventParticipantsUsingGET")]
        [SwaggerResponse(200, type: typeof(PageChallengeEventParticipantResource))]
        public virtual IActionResult GetChallengeEventParticipantsUsingGET([FromQuery]long? filterEvent)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageChallengeEventParticipantResource>(exampleJson)
            : default(PageChallengeEventParticipantResource);
            return new ObjectResult(example);
        }
    }
}
