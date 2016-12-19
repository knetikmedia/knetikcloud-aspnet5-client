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
    public class GamificationLevelingApiController : Controller
    { 

        /// <summary>
        /// Update or create a leveling progress record for a user
        /// </summary>
        /// <remarks>If no progress record yet exists for the user, it will be created. Otherwise it will be updated. If progress meets or exceeds the level&#39;s max_value it will be marked as earned and a BRE event will be triggered for the &lt;code&gt;BreAchievementEarnedTrigger&lt;/code&gt;.</remarks>
        /// <param name="userId">The id of the user</param>
        /// <param name="name">The level schema name</param>
        /// <param name="progress">The current progress amount</param>
        /// <response code="200">OK</response>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//users/{user_id}/leveling/{name}")]
        [SwaggerOperation("ChangeUserLevelExperienceUsingPUT")]
        public virtual void ChangeUserLevelExperienceUsingPUT([FromRoute]int? userId, [FromRoute]string name, [FromBody]int? progress)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Create a level schema
        /// </summary>
        
        /// <param name="level">The level schema definition</param>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//leveling")]
        [SwaggerOperation("CreateLevelUsingPOST")]
        [SwaggerResponse(200, type: typeof(LevelingResource))]
        public virtual IActionResult CreateLevelUsingPOST([FromBody]LevelingResource level)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<LevelingResource>(exampleJson)
            : default(LevelingResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Delete a level
        /// </summary>
        
        /// <param name="name">The level schema name</param>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpDelete]
        [Route("//leveling/{name}")]
        [SwaggerOperation("DeleteLevelUsingDELETE")]
        public virtual void DeleteLevelUsingDELETE([FromRoute]string name)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get the list of triggers that can be used to trigger a leveling progress update
        /// </summary>
        
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//leveling/triggers")]
        [SwaggerOperation("GetAvailableTriggersUsingGET1")]
        [SwaggerResponse(200, type: typeof(List<BreTriggerResource>))]
        public virtual IActionResult GetAvailableTriggersUsingGET1()
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<BreTriggerResource>>(exampleJson)
            : default(List<BreTriggerResource>);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Retrieve a particular level
        /// </summary>
        
        /// <param name="name">The level schema name</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//leveling/{name}")]
        [SwaggerOperation("GetLevelUsingGET")]
        [SwaggerResponse(200, type: typeof(LevelingResource))]
        public virtual IActionResult GetLevelUsingGET([FromRoute]string name)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<LevelingResource>(exampleJson)
            : default(LevelingResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List and search levels
        /// </summary>
        /// <remarks>Get a list of levels schemas with optional filtering</remarks>
        /// <param name="filterName">Filter for level schemas whose name contains a given string</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//leveling")]
        [SwaggerOperation("GetLevelsUsingGET")]
        [SwaggerResponse(200, type: typeof(PageLevelingResource))]
        public virtual IActionResult GetLevelsUsingGET([FromQuery]string filterName, [FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageLevelingResource>(exampleJson)
            : default(PageLevelingResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get a user&#39;s progress for a given level schema
        /// </summary>
        
        /// <param name="userId">The id of the user</param>
        /// <param name="name">The level schema name</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/{user_id}/leveling/{name}")]
        [SwaggerOperation("GetUserLevelUsingGET")]
        [SwaggerResponse(200, type: typeof(UserLevelingResource))]
        public virtual IActionResult GetUserLevelUsingGET([FromRoute]int? userId, [FromRoute]string name)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<UserLevelingResource>(exampleJson)
            : default(UserLevelingResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get a user&#39;s progress for all level schemas
        /// </summary>
        
        /// <param name="userId">The id of the user</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/{user_id}/leveling")]
        [SwaggerOperation("GetUserLevelsUsingGET")]
        [SwaggerResponse(200, type: typeof(PageUserLevelingResource))]
        public virtual IActionResult GetUserLevelsUsingGET([FromRoute]int? userId)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageUserLevelingResource>(exampleJson)
            : default(PageUserLevelingResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Update a level
        /// </summary>
        
        /// <param name="name">The level schema name</param>
        /// <param name="newLevel">The level schema definition</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//leveling/{name}")]
        [SwaggerOperation("UpdateLevelUsingPUT")]
        public virtual void UpdateLevelUsingPUT([FromRoute]string name, [FromBody]LevelingResource newLevel)
        { 
            throw new NotImplementedException();
        }
    }
}
