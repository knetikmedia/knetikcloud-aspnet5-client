/*
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://knetikcloud.com.
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
    public class ReportingUsageApiController : Controller
    { 

        /// <summary>
        /// Returns aggregated endpoint usage information by day
        /// </summary>
        
        /// <param name="startDate">The beginning of the range being requested, unix timestamp in seconds</param>
        /// <param name="endDate">The ending of the range being requested, unix timestamp in seconds</param>
        /// <param name="combineEndpoints">Whether to combine counts from different endpoint. Removes the url and method from the result object</param>
        /// <param name="method">Filter for a certain endpoint method.  Must include url as well to work</param>
        /// <param name="url">Filter for a certain endpoint.  Must include method as well to work</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//reporting/usage/day")]
        [SwaggerOperation("GetUsageByDay")]
        [SwaggerResponse(200, type: typeof(PageResourceUsageInfo))]
        public virtual IActionResult GetUsageByDay([FromQuery]long? startDate, [FromQuery]long? endDate, [FromQuery]bool? combineEndpoints, [FromQuery]string method, [FromQuery]string url, [FromQuery]int? size, [FromQuery]int? page)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceUsageInfo>(exampleJson)
            : default(PageResourceUsageInfo);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Returns aggregated endpoint usage information by hour
        /// </summary>
        
        /// <param name="startDate">The beginning of the range being requested, unix timestamp in seconds</param>
        /// <param name="endDate">The ending of the range being requested, unix timestamp in seconds</param>
        /// <param name="combineEndpoints">Whether to combine counts from different endpoint. Removes the url and method from the result object</param>
        /// <param name="method">Filter for a certain endpoint method.  Must include url as well to work</param>
        /// <param name="url">Filter for a certain endpoint.  Must include method as well to work</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//reporting/usage/hour")]
        [SwaggerOperation("GetUsageByHour")]
        [SwaggerResponse(200, type: typeof(PageResourceUsageInfo))]
        public virtual IActionResult GetUsageByHour([FromQuery]long? startDate, [FromQuery]long? endDate, [FromQuery]bool? combineEndpoints, [FromQuery]string method, [FromQuery]string url, [FromQuery]int? size, [FromQuery]int? page)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceUsageInfo>(exampleJson)
            : default(PageResourceUsageInfo);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Returns aggregated endpoint usage information by minute
        /// </summary>
        
        /// <param name="startDate">The beginning of the range being requested, unix timestamp in seconds</param>
        /// <param name="endDate">The ending of the range being requested, unix timestamp in seconds</param>
        /// <param name="combineEndpoints">Whether to combine counts from different endpoint. Removes the url and method from the result object</param>
        /// <param name="method">Filter for a certain endpoint method.  Must include url as well to work</param>
        /// <param name="url">Filter for a certain endpoint.  Must include method as well to work</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//reporting/usage/minute")]
        [SwaggerOperation("GetUsageByMinute")]
        [SwaggerResponse(200, type: typeof(PageResourceUsageInfo))]
        public virtual IActionResult GetUsageByMinute([FromQuery]long? startDate, [FromQuery]long? endDate, [FromQuery]bool? combineEndpoints, [FromQuery]string method, [FromQuery]string url, [FromQuery]int? size, [FromQuery]int? page)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceUsageInfo>(exampleJson)
            : default(PageResourceUsageInfo);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Returns aggregated endpoint usage information by month
        /// </summary>
        
        /// <param name="startDate">The beginning of the range being requested, unix timestamp in seconds</param>
        /// <param name="endDate">The ending of the range being requested, unix timestamp in seconds</param>
        /// <param name="combineEndpoints">Whether to combine counts from different endpoint. Removes the url and method from the result object</param>
        /// <param name="method">Filter for a certain endpoint method.  Must include url as well to work</param>
        /// <param name="url">Filter for a certain endpoint.  Must include method as well to work</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//reporting/usage/month")]
        [SwaggerOperation("GetUsageByMonth")]
        [SwaggerResponse(200, type: typeof(PageResourceUsageInfo))]
        public virtual IActionResult GetUsageByMonth([FromQuery]long? startDate, [FromQuery]long? endDate, [FromQuery]bool? combineEndpoints, [FromQuery]string method, [FromQuery]string url, [FromQuery]int? size, [FromQuery]int? page)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceUsageInfo>(exampleJson)
            : default(PageResourceUsageInfo);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Returns aggregated endpoint usage information by year
        /// </summary>
        
        /// <param name="startDate">The beginning of the range being requested, unix timestamp in seconds</param>
        /// <param name="endDate">The ending of the range being requested, unix timestamp in seconds</param>
        /// <param name="combineEndpoints">Whether to combine counts from different endpoints. Removes the url and method from the result object</param>
        /// <param name="method">Filter for a certain endpoint method.  Must include url as well to work</param>
        /// <param name="url">Filter for a certain endpoint.  Must include method as well to work</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//reporting/usage/year")]
        [SwaggerOperation("GetUsageByYear")]
        [SwaggerResponse(200, type: typeof(PageResourceUsageInfo))]
        public virtual IActionResult GetUsageByYear([FromQuery]long? startDate, [FromQuery]long? endDate, [FromQuery]bool? combineEndpoints, [FromQuery]string method, [FromQuery]string url, [FromQuery]int? size, [FromQuery]int? page)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceUsageInfo>(exampleJson)
            : default(PageResourceUsageInfo);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Returns list of endpoints called (method and url)
        /// </summary>
        
        /// <param name="startDate">The beginning of the range being requested, unix timestamp in seconds</param>
        /// <param name="endDate">The ending of the range being requested, unix timestamp in seconds</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//reporting/usage/endpoints")]
        [SwaggerOperation("GetUsageEndpoints")]
        [SwaggerResponse(200, type: typeof(List<string>))]
        public virtual IActionResult GetUsageEndpoints([FromQuery]long? startDate, [FromQuery]long? endDate)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<string>>(exampleJson)
            : default(List<string>);
            return new ObjectResult(example);
        }
    }
}
