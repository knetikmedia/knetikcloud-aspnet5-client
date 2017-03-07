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
    public class CurrenciesApiController : Controller
    { 

        /// <summary>
        /// Create a currency
        /// </summary>
        
        /// <param name="currency">The currency object</param>
        /// <response code="201">Created</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//currencies")]
        [SwaggerOperation("CreateCurrency")]
        [SwaggerResponse(200, type: typeof(CurrencyResource))]
        public virtual IActionResult CreateCurrency([FromBody]CurrencyResource currency)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CurrencyResource>(exampleJson)
            : default(CurrencyResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Delete a currency
        /// </summary>
        
        /// <param name="code">The currency code</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpDelete]
        [Route("//currencies/{code}")]
        [SwaggerOperation("DeleteCurrency")]
        public virtual void DeleteCurrency([FromRoute]string code)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// List and search currencies
        /// </summary>
        
        /// <param name="filterEnabledCurrencies">Filter for alternate currencies setup explicitely in system config</param>
        /// <param name="filterType">Filter currencies by type.  Allowable values: (&#39;virtual&#39;, &#39;real&#39;)</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//currencies")]
        [SwaggerOperation("GetCurrencies")]
        [SwaggerResponse(200, type: typeof(PageResourceCurrencyResource))]
        public virtual IActionResult GetCurrencies([FromQuery]bool? filterEnabledCurrencies, [FromQuery]string filterType, [FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceCurrencyResource>(exampleJson)
            : default(PageResourceCurrencyResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get a single currency
        /// </summary>
        
        /// <param name="code">The currency code</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//currencies/{code}")]
        [SwaggerOperation("GetCurrency")]
        [SwaggerResponse(200, type: typeof(CurrencyResource))]
        public virtual IActionResult GetCurrency([FromRoute]string code)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CurrencyResource>(exampleJson)
            : default(CurrencyResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Update a currency
        /// </summary>
        
        /// <param name="code">The currency code</param>
        /// <param name="currency">The currency object</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//currencies/{code}")]
        [SwaggerOperation("UpdateCurrency")]
        public virtual void UpdateCurrency([FromRoute]string code, [FromBody]CurrencyResource currency)
        { 
            throw new NotImplementedException();
        }
    }
}
