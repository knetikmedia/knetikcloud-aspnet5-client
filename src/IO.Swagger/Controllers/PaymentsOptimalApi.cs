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
    public class PaymentsOptimalApiController : Controller
    { 

        /// <summary>
        /// Initiate silent post with Optimal
        /// </summary>
        /// <remarks>Will return the url for a hosted payment endpoint to post to. See Optimal documentation for details.</remarks>
        /// <param name="request">The payment request to initiate</param>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//payment/provider/optimal/silent")]
        [SwaggerOperation("SilentPostUsingPOST")]
        [SwaggerResponse(200, type: typeof(string))]
        public virtual IActionResult SilentPostUsingPOST([FromBody]OptimalPaymentRequest request)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<string>(exampleJson)
            : default(string);
            return new ObjectResult(example);
        }
    }
}
