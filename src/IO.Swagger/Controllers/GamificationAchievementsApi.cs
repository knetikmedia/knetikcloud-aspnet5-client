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
    public class GamificationAchievementsApiController : Controller
    { 

        /// <summary>
        /// Create a new achievement definition
        /// </summary>
        /// <remarks>If the definition contains a trigger event name, a BRE rule is created, so that tracking logic is executed when the triggering event occurs. If no trigger event name is specified, the user&#39;s achievement status must manually be updated via the API.</remarks>
        /// <param name="achievement">The achievement definition</param>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//achievements")]
        [SwaggerOperation("CreateAchievementUsingPOST")]
        [SwaggerResponse(200, type: typeof(AchievementDefinitionResource))]
        public virtual IActionResult CreateAchievementUsingPOST([FromBody]AchievementDefinitionResource achievement)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<AchievementDefinitionResource>(exampleJson)
            : default(AchievementDefinitionResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Create an achievement template
        /// </summary>
        /// <remarks>Achievement templates define a type of achievement and the properties they have</remarks>
        /// <param name="template">The achievement template to be created</param>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//achievements/templates")]
        [SwaggerOperation("CreateTemplateUsingPOST")]
        [SwaggerResponse(200, type: typeof(TemplateResource))]
        public virtual IActionResult CreateTemplateUsingPOST([FromBody]TemplateResource template)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<TemplateResource>(exampleJson)
            : default(TemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Delete an achievement template
        /// </summary>
        /// <remarks>If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects</remarks>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">The value needed to delete used templates</param>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpDelete]
        [Route("//achievements/templates/{id}")]
        [SwaggerOperation("DeleteAchievementTemplateUsingDELETE")]
        public virtual void DeleteAchievementTemplateUsingDELETE([FromRoute]string id, [FromQuery]string cascade)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete an achievement definition
        /// </summary>
        /// <remarks>Will also disable the associated generated rule, if any.</remarks>
        /// <param name="name">The name of the achievement</param>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpDelete]
        [Route("//achievements/{name}")]
        [SwaggerOperation("DeleteAchievementUsingDELETE")]
        public virtual void DeleteAchievementUsingDELETE([FromRoute]string name)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get a list of derived achievements
        /// </summary>
        /// <remarks>Used by other services that depend on achievements</remarks>
        /// <param name="name">The name of the derived achievement</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//achievements/derived/{name}")]
        [SwaggerOperation("FindAllByGroupNameUsingGET")]
        [SwaggerResponse(200, type: typeof(List<AchievementDefinitionResource>))]
        public virtual IActionResult FindAllByGroupNameUsingGET([FromRoute]string name)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<AchievementDefinitionResource>>(exampleJson)
            : default(List<AchievementDefinitionResource>);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get a single achievement template
        /// </summary>
        
        /// <param name="id">The id of the template</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//achievements/templates/{id}")]
        [SwaggerOperation("GetAchievementTemplateUsingGET")]
        [SwaggerResponse(200, type: typeof(TemplateResource))]
        public virtual IActionResult GetAchievementTemplateUsingGET([FromRoute]string id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<TemplateResource>(exampleJson)
            : default(TemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List and search achievement templates
        /// </summary>
        
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//achievements/templates")]
        [SwaggerOperation("GetAchievementTemplatesUsingGET")]
        [SwaggerResponse(200, type: typeof(PageResourceTemplateResource))]
        public virtual IActionResult GetAchievementTemplatesUsingGET([FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceTemplateResource>(exampleJson)
            : default(PageResourceTemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get a single achievement definition
        /// </summary>
        
        /// <param name="name">The name of the achievement</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//achievements/{name}")]
        [SwaggerOperation("GetAchievementUsingGET")]
        [SwaggerResponse(200, type: typeof(AchievementDefinitionResource))]
        public virtual IActionResult GetAchievementUsingGET([FromRoute]string name)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<AchievementDefinitionResource>(exampleJson)
            : default(AchievementDefinitionResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get all achievement definitions in the system
        /// </summary>
        
        /// <param name="filterTagset">Filter for achievements with specified tags (separated by comma)</param>
        /// <param name="filterName">Filter for achievements whose name contains a string</param>
        /// <param name="filterHidden">Filter for achievements that are hidden or not</param>
        /// <param name="filterDerived">Filter for achievements that are derived from other services</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//achievements")]
        [SwaggerOperation("GetAchievementsUsingGET")]
        [SwaggerResponse(200, type: typeof(PageResourceAchievementDefinitionResource))]
        public virtual IActionResult GetAchievementsUsingGET([FromQuery]string filterTagset, [FromQuery]string filterName, [FromQuery]bool? filterHidden, [FromQuery]bool? filterDerived, [FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceAchievementDefinitionResource>(exampleJson)
            : default(PageResourceAchievementDefinitionResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Retrieve progress on a given achievement for all users
        /// </summary>
        /// <remarks>Assets will not be filled in on the resources returned. Use &#39;Get single achievement progress for user&#39; to retrieve the full resource with assets for a given user as needed.</remarks>
        /// <param name="achievementName">The achievement&#39;s name</param>
        /// <param name="filterAchievementDerived">Filter for achievements that are derived from other services</param>
        /// <param name="filterAchievementTagset">Filter for achievements with specified tags (separated by comma)</param>
        /// <param name="filterAchievementHidden">Filter for achievements that are hidden or not</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/achievements/{achievement_name}")]
        [SwaggerOperation("GetAllUserProgressForAchievementUsingGET")]
        [SwaggerResponse(200, type: typeof(PageResourceUserAchievementGroupResource))]
        public virtual IActionResult GetAllUserProgressForAchievementUsingGET([FromRoute]string achievementName, [FromQuery]bool? filterAchievementDerived, [FromQuery]string filterAchievementTagset, [FromQuery]bool? filterAchievementHidden, [FromQuery]int? size, [FromQuery]int? page)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceUserAchievementGroupResource>(exampleJson)
            : default(PageResourceUserAchievementGroupResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Retrieve progress on achievements for all users
        /// </summary>
        /// <remarks>Assets will not be filled in on the resources returned. Use &#39;Get single achievement progress for user&#39; to retrieve the full resource with assets for a given user as needed.</remarks>
        /// <param name="filterAchievementDerived">Filter for achievements that are derived from other services</param>
        /// <param name="filterAchievementTagset">Filter for achievements with specified tags (separated by comma)</param>
        /// <param name="filterAchievementName">Filter for achievements whose name contains a string</param>
        /// <param name="filterAchievementHidden">Filter for achievements that are hidden or not</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/achievements")]
        [SwaggerOperation("GetAllUserProgressUsingGET")]
        [SwaggerResponse(200, type: typeof(PageResourceUserAchievementGroupResource))]
        public virtual IActionResult GetAllUserProgressUsingGET([FromQuery]bool? filterAchievementDerived, [FromQuery]string filterAchievementTagset, [FromQuery]string filterAchievementName, [FromQuery]bool? filterAchievementHidden, [FromQuery]int? size, [FromQuery]int? page)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceUserAchievementGroupResource>(exampleJson)
            : default(PageResourceUserAchievementGroupResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get the list of triggers that can be used to trigger an achievement progress update
        /// </summary>
        
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//achievements/triggers")]
        [SwaggerOperation("GetAvailableTriggersUsingGET")]
        [SwaggerResponse(200, type: typeof(List<BreTriggerResource>))]
        public virtual IActionResult GetAvailableTriggersUsingGET()
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<BreTriggerResource>>(exampleJson)
            : default(List<BreTriggerResource>);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Retrieve progress on a given achievement for a given user
        /// </summary>
        /// <remarks>Assets will not be filled in on the resources returned. Use &#39;Get a single poll&#39; to retrieve the full resource with assets for a given item as needed.</remarks>
        /// <param name="userId">The user&#39;s id</param>
        /// <param name="achievementName">The achievement&#39;s name</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/{user_id}/achievements/{achievement_name}")]
        [SwaggerOperation("GetUserProgressForAchievementUsingGET")]
        [SwaggerResponse(200, type: typeof(UserAchievementGroupResource))]
        public virtual IActionResult GetUserProgressForAchievementUsingGET([FromRoute]int? userId, [FromRoute]string achievementName)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<UserAchievementGroupResource>(exampleJson)
            : default(UserAchievementGroupResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Retrieve progress on achievements for a given user
        /// </summary>
        /// <remarks>Assets will not be filled in on the resources returned. Use &#39;Get a single poll&#39; to retrieve the full resource with assets for a given item as needed.</remarks>
        /// <param name="userId">The user&#39;s id</param>
        /// <param name="filterAchievementDerived">Filter for achievements that are derived from other services</param>
        /// <param name="filterAchievementTagset">Filter for achievements with specified tags (separated by comma)</param>
        /// <param name="filterAchievementName">Filter for achievements whose name contains a string</param>
        /// <param name="filterAchievementHidden">Filter for achievements that are hidden or not</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/{user_id}/achievements")]
        [SwaggerOperation("GetUserProgressUsingGET")]
        [SwaggerResponse(200, type: typeof(PageResourceUserAchievementGroupResource))]
        public virtual IActionResult GetUserProgressUsingGET([FromRoute]int? userId, [FromQuery]bool? filterAchievementDerived, [FromQuery]string filterAchievementTagset, [FromQuery]string filterAchievementName, [FromQuery]bool? filterAchievementHidden, [FromQuery]int? size, [FromQuery]int? page)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceUserAchievementGroupResource>(exampleJson)
            : default(PageResourceUserAchievementGroupResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Update an achievement definition
        /// </summary>
        /// <remarks>The existing generated rule, if any, will be deleted. A new rule will be created if a trigger event name is specified in the new version.</remarks>
        /// <param name="name">The name of the achievement</param>
        /// <param name="achievement">The achievement definition</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//achievements/{name}")]
        [SwaggerOperation("UpdateAchievementUsingPUT")]
        public virtual void UpdateAchievementUsingPUT([FromRoute]string name, [FromBody]AchievementDefinitionResource achievement)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Update or create an achievement progress record for a user
        /// </summary>
        /// <remarks>If no progress record yet exists for the user, it will be created. Otherwise it will be updated. If progress meets or exceeds the achievement&#39;s max_value it will be marked as earned and a BRE event will be triggered for the &lt;code&gt;BreAchievementEarnedTrigger&lt;/code&gt;.</remarks>
        /// <param name="userId">The user&#39;s id</param>
        /// <param name="achievementName">The achievement&#39;s name</param>
        /// <param name="request">The progress update details</param>
        /// <response code="200">OK</response>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//users/{user_id}/achievements/{achievement_name}")]
        [SwaggerOperation("UpdateProgressUsingPUT")]
        [SwaggerResponse(200, type: typeof(UserAchievementGroupResource))]
        public virtual IActionResult UpdateProgressUsingPUT([FromRoute]int? userId, [FromRoute]string achievementName, [FromBody]AchievementProgressUpdateRequest request)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<UserAchievementGroupResource>(exampleJson)
            : default(UserAchievementGroupResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Update an achievement template
        /// </summary>
        
        /// <param name="id">The id of the template</param>
        /// <param name="template">The updated template</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//achievements/templates/{id}")]
        [SwaggerOperation("UpdateTemplateUsingPUT")]
        public virtual void UpdateTemplateUsingPUT([FromRoute]string id, [FromBody]TemplateResource template)
        { 
            throw new NotImplementedException();
        }
    }
}
