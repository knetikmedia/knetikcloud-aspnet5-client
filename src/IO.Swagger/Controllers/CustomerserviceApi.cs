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
    public class CustomerserviceApiController : Controller
    { 

        /// <summary>
        /// Create a customer
        /// </summary>
        
        /// <param name="customer">customer</param>
        /// <response code="201">Created</response>
        /// <response code="202">Accepted</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//customers")]
        [SwaggerOperation("CreateCustomerUsingPOST")]
        public virtual void CreateCustomerUsingPOST([FromBody]CustomerConfig customer)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// List and search customers
        /// </summary>
        /// <remarks>Get a list of customers with optional filtering</remarks>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//customers")]
        [SwaggerOperation("GetCustomersUsingGET")]
        [SwaggerResponse(200, type: typeof(List<CustomerResource>))]
        public virtual IActionResult GetCustomersUsingGET([FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<CustomerResource>>(exampleJson)
            : default(List<CustomerResource>);
            return new ObjectResult(example);
        }
    }
}
