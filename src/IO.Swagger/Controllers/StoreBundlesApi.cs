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
    public class StoreBundlesApiController : Controller
    { 

        /// <summary>
        /// Create a bundle item
        /// </summary>
        /// <remarks>The SKU for the bundle itself must be unique and there can only be one SKU.  Extra notes for price_override:  The price of all the items (multiplied by the quantity) must equal the price of the bundle.  With individual prices set, items will be processed individually and can be refunded as such.  However, if all prices are set to null, the price of the bundle will be used and will be treated as one item.</remarks>
        /// <param name="cascade">Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values.</param>
        /// <param name="bundleItem">The bundle item object</param>
        /// <response code="201">Created</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//store/bundles")]
        [SwaggerOperation("CreateBundleItem")]
        [SwaggerResponse(200, type: typeof(BundleItem))]
        public virtual IActionResult CreateBundleItem([FromQuery]bool? cascade, [FromBody]BundleItem bundleItem)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<BundleItem>(exampleJson)
            : default(BundleItem);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Create a bundle template
        /// </summary>
        /// <remarks>Bundle Templates define a type of bundle and the properties they have.</remarks>
        /// <param name="bundleTemplateResource">The new bundle template</param>
        /// <response code="201">Created</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//store/bundles/templates")]
        [SwaggerOperation("CreateBundleTemplate")]
        [SwaggerResponse(200, type: typeof(ItemTemplateResource))]
        public virtual IActionResult CreateBundleTemplate([FromBody]ItemTemplateResource bundleTemplateResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ItemTemplateResource>(exampleJson)
            : default(ItemTemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Delete a bundle item
        /// </summary>
        
        /// <param name="id">The id of the bundle</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpDelete]
        [Route("//store/bundles/{id}")]
        [SwaggerOperation("DeleteBundleItem")]
        public virtual void DeleteBundleItem([FromRoute]int? id)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete a bundle template
        /// </summary>
        
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">force deleting the template if it&#39;s attached to other objects, cascade &#x3D; detach</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpDelete]
        [Route("//store/bundles/templates/{id}")]
        [SwaggerOperation("DeleteBundleTemplate")]
        public virtual void DeleteBundleTemplate([FromRoute]string id, [FromQuery]string cascade)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get a single bundle item
        /// </summary>
        
        /// <param name="id">The id of the bundle</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//store/bundles/{id}")]
        [SwaggerOperation("GetBundleItem")]
        [SwaggerResponse(200, type: typeof(BundleItem))]
        public virtual IActionResult GetBundleItem([FromRoute]int? id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<BundleItem>(exampleJson)
            : default(BundleItem);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get a single bundle template
        /// </summary>
        /// <remarks>Bundle Templates define a type of bundle and the properties they have.</remarks>
        /// <param name="id">The id of the template</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//store/bundles/templates/{id}")]
        [SwaggerOperation("GetBundleTemplate")]
        [SwaggerResponse(200, type: typeof(ItemTemplateResource))]
        public virtual IActionResult GetBundleTemplate([FromRoute]string id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ItemTemplateResource>(exampleJson)
            : default(ItemTemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List and search bundle templates
        /// </summary>
        
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//store/bundles/templates")]
        [SwaggerOperation("GetBundleTemplates")]
        [SwaggerResponse(200, type: typeof(PageResourceItemTemplateResource))]
        public virtual IActionResult GetBundleTemplates([FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceItemTemplateResource>(exampleJson)
            : default(PageResourceItemTemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Update a bundle item
        /// </summary>
        
        /// <param name="id">The id of the bundle</param>
        /// <param name="cascade">Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values.</param>
        /// <param name="bundleItem">The bundle item object</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//store/bundles/{id}")]
        [SwaggerOperation("UpdateBundleItem")]
        [SwaggerResponse(200, type: typeof(BundleItem))]
        public virtual IActionResult UpdateBundleItem([FromRoute]int? id, [FromQuery]bool? cascade, [FromBody]BundleItem bundleItem)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<BundleItem>(exampleJson)
            : default(BundleItem);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Update a bundle template
        /// </summary>
        
        /// <param name="id">The id of the template</param>
        /// <param name="bundleTemplateResource">The bundle template resource object</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//store/bundles/templates/{id}")]
        [SwaggerOperation("UpdateBundleTemplate")]
        [SwaggerResponse(200, type: typeof(ItemTemplateResource))]
        public virtual IActionResult UpdateBundleTemplate([FromRoute]string id, [FromBody]ItemTemplateResource bundleTemplateResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ItemTemplateResource>(exampleJson)
            : default(ItemTemplateResource);
            return new ObjectResult(example);
        }
    }
}
