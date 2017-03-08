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
    public class GamificationMetricsApiController : Controller
    { 

        /// <summary>
        /// Add a metric
        /// </summary>
        /// <remarks>Post a new score/stat for an activity occurrence without ending the occurrence itself</remarks>
        /// <param name="metric">The new metric</param>
        /// <response code="201">Metric added</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//metrics")]
        [SwaggerOperation("AddMetric")]
        public virtual void AddMetric([FromBody]MetricResource metric)
        { 
            throw new NotImplementedException();
        }
    }
}
