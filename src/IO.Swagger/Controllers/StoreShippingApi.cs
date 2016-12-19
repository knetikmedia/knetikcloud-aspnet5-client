/*
 * Knetik Platform API Documentation Latest
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
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
    public class StoreShippingApiController : Controller
    { 

        /// <summary>
        /// Create a shipping item
        /// </summary>
        /// <remarks>A shipping item represents a shipping option and cost. SKUs have to be unique in the entire store.</remarks>
        /// <param name="shippingItem">The shipping item object</param>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//store/shipping")]
        [SwaggerOperation("CreateShippingItemUsingPOST")]
        [SwaggerResponse(200, type: typeof(ShippingItem))]
        public virtual IActionResult CreateShippingItemUsingPOST([FromBody]ShippingItem shippingItem)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ShippingItem>(exampleJson)
            : default(ShippingItem);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Create a shipping template
        /// </summary>
        /// <remarks>Shipping Templates define a type of shipping and the properties they have.</remarks>
        /// <param name="shippingTemplateResource">The new shipping template</param>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//store/shipping/templates")]
        [SwaggerOperation("CreateShippingTemplateUsingPOST")]
        [SwaggerResponse(200, type: typeof(ItemTemplateResource))]
        public virtual IActionResult CreateShippingTemplateUsingPOST([FromBody]ItemTemplateResource shippingTemplateResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ItemTemplateResource>(exampleJson)
            : default(ItemTemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Delete a shipping item
        /// </summary>
        
        /// <param name="id">The id of the shipping item</param>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpDelete]
        [Route("//store/shipping/{id}")]
        [SwaggerOperation("DeleteShippingItemUsingDELETE")]
        public virtual void DeleteShippingItemUsingDELETE([FromRoute]int? id)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete a shipping template
        /// </summary>
        
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">force deleting the template if it&#39;s attached to other objects, cascade &#x3D; detach</param>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpDelete]
        [Route("//store/shipping/templates/{id}")]
        [SwaggerOperation("DeleteShippingTemplateUsingDELETE")]
        public virtual void DeleteShippingTemplateUsingDELETE([FromRoute]string id, [FromQuery]string cascade)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get a single shipping item
        /// </summary>
        
        /// <param name="id">The id of the shipping item</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//store/shipping/{id}")]
        [SwaggerOperation("GetShippingItemUsingGET")]
        [SwaggerResponse(200, type: typeof(ShippingItem))]
        public virtual IActionResult GetShippingItemUsingGET([FromRoute]int? id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ShippingItem>(exampleJson)
            : default(ShippingItem);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get a single shipping template
        /// </summary>
        /// <remarks>Shipping Templates define a type of shipping and the properties they have.</remarks>
        /// <param name="id">The id of the template</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//store/shipping/templates/{id}")]
        [SwaggerOperation("GetShippingTemplateUsingGET")]
        [SwaggerResponse(200, type: typeof(ItemTemplateResource))]
        public virtual IActionResult GetShippingTemplateUsingGET([FromRoute]string id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ItemTemplateResource>(exampleJson)
            : default(ItemTemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List and search shipping templates
        /// </summary>
        
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//store/shipping/templates")]
        [SwaggerOperation("GetShippingTemplatesUsingGET")]
        [SwaggerResponse(200, type: typeof(PageItemTemplateResource))]
        public virtual IActionResult GetShippingTemplatesUsingGET([FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageItemTemplateResource>(exampleJson)
            : default(PageItemTemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Update a shipping item
        /// </summary>
        
        /// <param name="id">The id of the shipping item</param>
        /// <param name="shippingItem">The shipping item object</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//store/shipping/{id}")]
        [SwaggerOperation("UpdateShippingItemUsingPUT")]
        public virtual void UpdateShippingItemUsingPUT([FromRoute]int? id, [FromBody]ShippingItem shippingItem)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Update a shipping template
        /// </summary>
        
        /// <param name="id">The id of the template</param>
        /// <param name="shippingTemplateResource">The shipping template resource object</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//store/shipping/templates/{id}")]
        [SwaggerOperation("UpdateShippingTemplateUsingPUT")]
        public virtual void UpdateShippingTemplateUsingPUT([FromRoute]string id, [FromBody]ItemTemplateResource shippingTemplateResource)
        { 
            throw new NotImplementedException();
        }
    }
}
