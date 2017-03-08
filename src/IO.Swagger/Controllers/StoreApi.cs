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
    public class StoreApiController : Controller
    { 

        /// <summary>
        /// Create an item template
        /// </summary>
        /// <remarks>Item Templates define a type of item and the properties they have.</remarks>
        /// <param name="itemTemplateResource">The new item template</param>
        /// <response code="201">Created</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//store/items/templates")]
        [SwaggerOperation("CreateItemTemplate")]
        [SwaggerResponse(200, type: typeof(StoreItemTemplateResource))]
        public virtual IActionResult CreateItemTemplate([FromBody]StoreItemTemplateResource itemTemplateResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<StoreItemTemplateResource>(exampleJson)
            : default(StoreItemTemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Create a store item
        /// </summary>
        /// <remarks>SKUs have to be unique in the entire store. If a duplicate SKU is found, a 400 error is generated and the response will have a \&quot;parameters\&quot; field that is a list of duplicates. A duplicate is an object like {item_id, offending_sku_list}. Ex:&lt;br /&gt; {..., parameters: [[{item: 1, skus: [\&quot;SKU-1\&quot;]}]]}&lt;br /&gt; If an item is brand new and has duplicate SKUs within itself, the item ID will be 0.  Item subclasses are not allowed here, you will have to use their respective endpoints.</remarks>
        /// <param name="cascade">Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values.</param>
        /// <param name="storeItem">The store item object</param>
        /// <response code="201">Created</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//store/items")]
        [SwaggerOperation("CreateStoreItem")]
        [SwaggerResponse(200, type: typeof(StoreItem))]
        public virtual IActionResult CreateStoreItem([FromQuery]bool? cascade, [FromBody]StoreItem storeItem)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<StoreItem>(exampleJson)
            : default(StoreItem);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Delete an item template
        /// </summary>
        
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">force deleting the template if it&#39;s attached to other objects, cascade &#x3D; detach</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpDelete]
        [Route("//store/items/templates/{id}")]
        [SwaggerOperation("DeleteItemTemplate")]
        public virtual void DeleteItemTemplate([FromRoute]string id, [FromQuery]string cascade)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete a store item
        /// </summary>
        
        /// <param name="id">The id of the item</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpDelete]
        [Route("//store/items/{id}")]
        [SwaggerOperation("DeleteStoreItem")]
        public virtual void DeleteStoreItem([FromRoute]int? id)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get a single item template
        /// </summary>
        /// <remarks>Item Templates define a type of item and the properties they have.</remarks>
        /// <param name="id">The id of the template</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//store/items/templates/{id}")]
        [SwaggerOperation("GetItemTemplate")]
        [SwaggerResponse(200, type: typeof(StoreItemTemplateResource))]
        public virtual IActionResult GetItemTemplate([FromRoute]string id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<StoreItemTemplateResource>(exampleJson)
            : default(StoreItemTemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List and search item templates
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
        [Route("//store/items/templates")]
        [SwaggerOperation("GetItemTemplates")]
        [SwaggerResponse(200, type: typeof(PageResourceStoreItemTemplateResource))]
        public virtual IActionResult GetItemTemplates([FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceStoreItemTemplateResource>(exampleJson)
            : default(PageResourceStoreItemTemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get a listing of store items
        /// </summary>
        /// <remarks>The exact structure of each items may differ to include fields specific to the type. The same is true for behaviors.</remarks>
        /// <param name="limit">The amount of items returned</param>
        /// <param name="page">The page of the request</param>
        /// <param name="useCatalog">Whether to remove items that are not intended for display or not in date</param>
        /// <param name="ignoreLocation">Whether to ignore country restrictions based on the caller&#39;s location</param>
        /// <param name="inStockOnly">Whether only in-stock items should be returned.  Default value is false</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//store")]
        [SwaggerOperation("GetStore")]
        [SwaggerResponse(200, type: typeof(PageResourceStoreItem))]
        public virtual IActionResult GetStore([FromQuery]int? limit, [FromQuery]int? page, [FromQuery]bool? useCatalog, [FromQuery]bool? ignoreLocation, [FromQuery]bool? inStockOnly)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceStoreItem>(exampleJson)
            : default(PageResourceStoreItem);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get a single store item
        /// </summary>
        
        /// <param name="id">The id of the item</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//store/items/{id}")]
        [SwaggerOperation("GetStoreItem")]
        [SwaggerResponse(200, type: typeof(StoreItem))]
        public virtual IActionResult GetStoreItem([FromRoute]int? id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<StoreItem>(exampleJson)
            : default(StoreItem);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List and search store items
        /// </summary>
        
        /// <param name="filterNameSearch">Filter for items whose name starts with a given string.</param>
        /// <param name="filterUniqueKey">Filter for items whose unique_key is a given string.</param>
        /// <param name="filterPublished">Filter for skus that have been published.</param>
        /// <param name="filterDisplayable">Filter for items that are displayable.</param>
        /// <param name="filterStart">A comma separated string without spaces.  First value is the operator to search on, second value is the store start date, a unix timestamp in seconds.  Allowed operators: (LT, GT, LTE, GTE, EQ).</param>
        /// <param name="filterEnd">A comma separated string without spaces.  First value is the operator to search on, second value is the store end date, a unix timestamp in seconds.  Allowed operators: (LT, GT, LTE, GTE, EQ).</param>
        /// <param name="filterStartDate">A comma separated string without spaces.  First value is the operator to search on, second value is the sku start date, a unix timestamp in seconds.  Allowed operators: (LT, GT, LTE, GTE, EQ).</param>
        /// <param name="filterStopDate">A comma separated string without spaces.  First value is the operator to search on, second value is the sku end date, a unix timestamp in seconds.  Allowed operators: (LT, GT, LTE, GTE, EQ).</param>
        /// <param name="filterSku">Filter for skus whose name starts with a given string.</param>
        /// <param name="filterPrice">A colon separated string without spaces.  First value is the operator to search on, second value is the price of a sku.  Allowed operators: (LT, GT, LTE, GTE, EQ).</param>
        /// <param name="filterTag">A comma separated list without spaces of the names of tags. Will only return items with at least one of the tags.</param>
        /// <param name="filterItemsByType">Filter for item type based on its type hint.</param>
        /// <param name="filterBundledSkus">Filter for skus inside bundles whose name starts with a given string.  Used only when type hint is &#39;bundle_item&#39;</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//store/items")]
        [SwaggerOperation("GetStoreItems")]
        [SwaggerResponse(200, type: typeof(PageResourceStoreItem))]
        public virtual IActionResult GetStoreItems([FromQuery]string filterNameSearch, [FromQuery]string filterUniqueKey, [FromQuery]bool? filterPublished, [FromQuery]bool? filterDisplayable, [FromQuery]string filterStart, [FromQuery]string filterEnd, [FromQuery]string filterStartDate, [FromQuery]string filterStopDate, [FromQuery]string filterSku, [FromQuery]string filterPrice, [FromQuery]string filterTag, [FromQuery]string filterItemsByType, [FromQuery]string filterBundledSkus, [FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceStoreItem>(exampleJson)
            : default(PageResourceStoreItem);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Update an item template
        /// </summary>
        
        /// <param name="id">The id of the template</param>
        /// <param name="itemTemplateResource">The item template resource object</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//store/items/templates/{id}")]
        [SwaggerOperation("UpdateItemTemplate")]
        [SwaggerResponse(200, type: typeof(StoreItemTemplateResource))]
        public virtual IActionResult UpdateItemTemplate([FromRoute]string id, [FromBody]StoreItemTemplateResource itemTemplateResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<StoreItemTemplateResource>(exampleJson)
            : default(StoreItemTemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Update a store item
        /// </summary>
        
        /// <param name="id">The id of the item</param>
        /// <param name="cascade">Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values.</param>
        /// <param name="storeItem">The store item object</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//store/items/{id}")]
        [SwaggerOperation("UpdateStoreItem")]
        [SwaggerResponse(200, type: typeof(StoreItem))]
        public virtual IActionResult UpdateStoreItem([FromRoute]int? id, [FromQuery]bool? cascade, [FromBody]StoreItem storeItem)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<StoreItem>(exampleJson)
            : default(StoreItem);
            return new ObjectResult(example);
        }
    }
}
