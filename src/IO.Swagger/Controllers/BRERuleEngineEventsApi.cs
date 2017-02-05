/*
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://demo.sandbox.knetikcloud.com
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
    public class BRERuleEngineEventsApiController : Controller
    { 

        /// <summary>
        /// Fire a new event, based on an existing trigger
        /// </summary>
        /// <remarks>Parameters within the event must match names and types from the trigger. Actual rule execution is asynchornous.</remarks>
        /// <param name="breEvent">The BRE event object</param>
        /// <response code="200">OK</response>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//bre/events")]
        [SwaggerOperation("FireEventUsingPOST")]
        public virtual void FireEventUsingPOST([FromBody]BreEvent breEvent)
        { 
            throw new NotImplementedException();
        }
    }
}
