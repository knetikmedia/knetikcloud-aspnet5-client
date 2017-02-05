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
    public class TaxesApiController : Controller
    { 

        /// <summary>
        /// Create a tax
        /// </summary>
        
        /// <param name="countryCodeIso3">The iso3 code of the country</param>
        /// <param name="taxResource">The tax object</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//tax/countries/{country_code_iso3}/states")]
        [SwaggerOperation("CreateTaxUsingPOST")]
        public virtual void CreateTaxUsingPOST([FromRoute]string countryCodeIso3, [FromBody]StateTaxResource taxResource)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete an existing tax
        /// </summary>
        
        /// <param name="countryCodeIso3">The iso3 code of the country</param>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpDelete]
        [Route("//tax/countries/{country_code_iso3}")]
        [SwaggerOperation("DeleteTaxUsingDELETE")]
        public virtual void DeleteTaxUsingDELETE([FromRoute]string countryCodeIso3)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete an existing tax
        /// </summary>
        
        /// <param name="countryCodeIso3">The iso3 code of the country</param>
        /// <param name="stateCode">The code of the state</param>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpDelete]
        [Route("//tax/countries/{country_code_iso3}/states/{state_code}")]
        [SwaggerOperation("DeleteTaxUsingDELETE1")]
        public virtual void DeleteTaxUsingDELETE1([FromRoute]string countryCodeIso3, [FromRoute]string stateCode)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// List and search taxes across all countries
        /// </summary>
        /// <remarks>Get a list of taxes</remarks>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//tax/states")]
        [SwaggerOperation("GetAllTaxesUsingGET")]
        [SwaggerResponse(200, type: typeof(PageResourceStateTaxResource))]
        public virtual IActionResult GetAllTaxesUsingGET([FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceStateTaxResource>(exampleJson)
            : default(PageResourceStateTaxResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get a single tax
        /// </summary>
        
        /// <param name="countryCodeIso3">The iso3 code of the country</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//tax/countries/{country_code_iso3}")]
        [SwaggerOperation("GetTaxUsingGET")]
        [SwaggerResponse(200, type: typeof(CountryTaxResource))]
        public virtual IActionResult GetTaxUsingGET([FromRoute]string countryCodeIso3)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CountryTaxResource>(exampleJson)
            : default(CountryTaxResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get a single tax
        /// </summary>
        
        /// <param name="countryCodeIso3">The iso3 code of the country</param>
        /// <param name="stateCode">The code of the state</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//tax/countries/{country_code_iso3}/states/{state_code}")]
        [SwaggerOperation("GetTaxUsingGET1")]
        [SwaggerResponse(200, type: typeof(StateTaxResource))]
        public virtual IActionResult GetTaxUsingGET1([FromRoute]string countryCodeIso3, [FromRoute]string stateCode)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<StateTaxResource>(exampleJson)
            : default(StateTaxResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List and search taxes
        /// </summary>
        /// <remarks>Get a list of taxes</remarks>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//tax/countries")]
        [SwaggerOperation("GetTaxesUsingGET")]
        [SwaggerResponse(200, type: typeof(PageResourceCountryTaxResource))]
        public virtual IActionResult GetTaxesUsingGET([FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceCountryTaxResource>(exampleJson)
            : default(PageResourceCountryTaxResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List and search taxes within a country
        /// </summary>
        /// <remarks>Get a list of taxes</remarks>
        /// <param name="countryCodeIso3">The iso3 code of the country</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//tax/countries/{country_code_iso3}/states")]
        [SwaggerOperation("GetTaxesUsingGET1")]
        [SwaggerResponse(200, type: typeof(PageResourceStateTaxResource))]
        public virtual IActionResult GetTaxesUsingGET1([FromRoute]string countryCodeIso3, [FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceStateTaxResource>(exampleJson)
            : default(PageResourceStateTaxResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Create a tax
        /// </summary>
        
        /// <param name="taxResource">The tax object</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//tax/countries")]
        [SwaggerOperation("UpdateTaxUsingPOST")]
        public virtual void UpdateTaxUsingPOST([FromBody]CountryTaxResource taxResource)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Create or update a tax
        /// </summary>
        
        /// <param name="countryCodeIso3">The iso3 code of the country</param>
        /// <param name="taxResource">The tax object</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//tax/countries/{country_code_iso3}")]
        [SwaggerOperation("UpdateTaxUsingPUT")]
        public virtual void UpdateTaxUsingPUT([FromRoute]string countryCodeIso3, [FromBody]CountryTaxResource taxResource)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Create or update a tax
        /// </summary>
        
        /// <param name="countryCodeIso3">The iso3 code of the country</param>
        /// <param name="stateCode">The code of the state</param>
        /// <param name="taxResource">The tax object</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//tax/countries/{country_code_iso3}/states/{state_code}")]
        [SwaggerOperation("UpdateTaxUsingPUT1")]
        public virtual void UpdateTaxUsingPUT1([FromRoute]string countryCodeIso3, [FromRoute]string stateCode, [FromBody]StateTaxResource taxResource)
        { 
            throw new NotImplementedException();
        }
    }
}
