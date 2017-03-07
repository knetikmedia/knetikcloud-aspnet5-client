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
    public class UtilMaintenanceApiController : Controller
    { 

        /// <summary>
        /// Delete maintenance info
        /// </summary>
        
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpDelete]
        [Route("//maintenance")]
        [SwaggerOperation("DeleteMaintenance")]
        public virtual void DeleteMaintenance()
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get current maintenance info
        /// </summary>
        /// <remarks>Get current maintenance info. 404 if no maintenance.</remarks>
        /// <response code="200">maintenance</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">no maintenance</response>
        [HttpGet]
        [Route("//maintenance")]
        [SwaggerOperation("GetMaintenance")]
        [SwaggerResponse(200, type: typeof(Maintenance))]
        public virtual IActionResult GetMaintenance()
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Maintenance>(exampleJson)
            : default(Maintenance);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Set current maintenance info
        /// </summary>
        
        /// <param name="maintenance">The maintenance object</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//maintenance")]
        [SwaggerOperation("SetMaintenance")]
        public virtual void SetMaintenance([FromBody]Maintenance maintenance)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Update current maintenance info
        /// </summary>
        
        /// <param name="maintenance">The maintenance object</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//maintenance")]
        [SwaggerOperation("UpdateMaintenance")]
        public virtual void UpdateMaintenance([FromBody]Maintenance maintenance)
        { 
            throw new NotImplementedException();
        }
    }
}
