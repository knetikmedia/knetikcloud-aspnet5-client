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
    public class ReportingOrdersApiController : Controller
    { 

        /// <summary>
        /// Retrieve invoice counts aggregated by time ranges
        /// </summary>
        
        /// <param name="currencyCode">The code for a currency to get sales data for</param>
        /// <param name="granularity">The time duration to aggregate by</param>
        /// <param name="filterPaymentStatus">A payment status to filter results by, can be a comma separated list</param>
        /// <param name="filterFulfillmentStatus">An invoice fulfillment status to filter results by, can be a comma separated list</param>
        /// <param name="startDate">The start of the time range to return, unix timestamp in seconds. Default is beginning of time</param>
        /// <param name="endDate">The end of the time range to return, unix timestamp in seconds. Default is end of time</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//reporting/orders/count/{currency_code}")]
        [SwaggerOperation("GetInvoiceReports")]
        [SwaggerResponse(200, type: typeof(PageResourceAggregateInvoiceReportResource))]
        public virtual IActionResult GetInvoiceReports([FromRoute]string currencyCode, [FromQuery]string granularity, [FromQuery]string filterPaymentStatus, [FromQuery]string filterFulfillmentStatus, [FromQuery]long? startDate, [FromQuery]long? endDate, [FromQuery]int? size, [FromQuery]int? page)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceAggregateInvoiceReportResource>(exampleJson)
            : default(PageResourceAggregateInvoiceReportResource);
            return new ObjectResult(example);
        }
    }
}
