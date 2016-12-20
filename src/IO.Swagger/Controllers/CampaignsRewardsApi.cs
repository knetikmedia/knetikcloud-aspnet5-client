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
    public class CampaignsRewardsApiController : Controller
    { 

        /// <summary>
        /// Create a reward set
        /// </summary>
        
        /// <param name="rewardSetResource">The reward set resource object</param>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//rewards")]
        [SwaggerOperation("CreateRewardSetUsingPOST")]
        [SwaggerResponse(200, type: typeof(RewardSetResource))]
        public virtual IActionResult CreateRewardSetUsingPOST([FromBody]RewardSetResource rewardSetResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<RewardSetResource>(exampleJson)
            : default(RewardSetResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Delete a reward set
        /// </summary>
        
        /// <param name="id">The reward id</param>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpDelete]
        [Route("//rewards/{id}")]
        [SwaggerOperation("DeleteRewardSetUsingDELETE")]
        public virtual void DeleteRewardSetUsingDELETE([FromRoute]int? id)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get a single reward set
        /// </summary>
        
        /// <param name="id">The reward id</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//rewards/{id}")]
        [SwaggerOperation("GetRewardSetUsingGET")]
        [SwaggerResponse(200, type: typeof(RewardSetResource))]
        public virtual IActionResult GetRewardSetUsingGET([FromRoute]int? id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<RewardSetResource>(exampleJson)
            : default(RewardSetResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List and search reward sets
        /// </summary>
        
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//rewards")]
        [SwaggerOperation("GetRewardSetsUsingGET")]
        [SwaggerResponse(200, type: typeof(PageRewardSetResource))]
        public virtual IActionResult GetRewardSetsUsingGET([FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageRewardSetResource>(exampleJson)
            : default(PageRewardSetResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Update a reward set
        /// </summary>
        
        /// <param name="id">The reward id</param>
        /// <param name="rewardSetResource">The reward set resource object</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//rewards/{id}")]
        [SwaggerOperation("UpdateRewardSetUsingPUT")]
        public virtual void UpdateRewardSetUsingPUT([FromRoute]int? id, [FromBody]RewardSetResource rewardSetResource)
        { 
            throw new NotImplementedException();
        }
    }
}
