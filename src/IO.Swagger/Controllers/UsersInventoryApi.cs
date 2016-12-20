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
    public class UsersInventoryApiController : Controller
    { 

        /// <summary>
        /// Adds an item to the user inventory
        /// </summary>
        /// <remarks>The inventory is fulfilled asynchronously UNLESS the invoice is explicitely skipped. Depending on the use case, it might require the client to verify that the entitlement was added after the fact or configure a BRE rule to get a notification in real time</remarks>
        /// <param name="id">The id of the user</param>
        /// <param name="userInventoryAddRequest">The user inventory add request object</param>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//users/{id}/inventory")]
        [SwaggerOperation("AddItemUsingPOST1")]
        [SwaggerResponse(200, type: typeof(InvoiceResource))]
        public virtual IActionResult AddItemUsingPOST1([FromRoute]int? id, [FromBody]UserInventoryAddRequest userInventoryAddRequest)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InvoiceResource>(exampleJson)
            : default(InvoiceResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Create an entitlement item
        /// </summary>
        
        /// <param name="entitlementItem">The entitlement item object</param>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//entitlements")]
        [SwaggerOperation("CreateItemUsingPOST")]
        [SwaggerResponse(200, type: typeof(EntitlementItem))]
        public virtual IActionResult CreateItemUsingPOST([FromBody]EntitlementItem entitlementItem)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<EntitlementItem>(exampleJson)
            : default(EntitlementItem);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Create an entitlement template
        /// </summary>
        /// <remarks>Entitlement templates define a type of entitlement and the properties they have</remarks>
        /// <param name="template">The entitlement template to be created</param>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//entitlements/templates")]
        [SwaggerOperation("CreateTemplateUsingPOST3")]
        [SwaggerResponse(200, type: typeof(ItemTemplateResource))]
        public virtual IActionResult CreateTemplateUsingPOST3([FromBody]ItemTemplateResource template)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ItemTemplateResource>(exampleJson)
            : default(ItemTemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Delete an entitlement template
        /// </summary>
        /// <remarks>If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects</remarks>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">The value needed to delete used templates</param>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpDelete]
        [Route("//entitlements/templates/{id}")]
        [SwaggerOperation("DeleteEntitlementTemplateUsingDELETE")]
        public virtual void DeleteEntitlementTemplateUsingDELETE([FromRoute]string id, [FromQuery]string cascade)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete an entitlement item
        /// </summary>
        
        /// <param name="entitlementId">The id of the entitlement</param>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpDelete]
        [Route("//entitlements/{entitlement_id}")]
        [SwaggerOperation("DeleteItemUsingDELETE")]
        public virtual void DeleteItemUsingDELETE([FromRoute]int? entitlementId)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Check for access to an item without consuming
        /// </summary>
        /// <remarks>Useful for pre-check and accounts for all various buisness rules</remarks>
        /// <param name="userId">The id of the user to check for or &#39;me&#39; for logged in user</param>
        /// <param name="itemId">The id of the item</param>
        /// <param name="sku">The specific sku of an entitlement list addition to check entitlement for. This is of very limited and specific use and should generally be left out</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/{user_id}/entitlements/{item_id}/check")]
        [SwaggerOperation("EntitlementCheckUsingGET")]
        public virtual void EntitlementCheckUsingGET([FromRoute]string userId, [FromRoute]int? itemId, [FromQuery]string sku)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Use an item
        /// </summary>
        
        /// <param name="userId">The id of the user to check for or &#39;me&#39; for logged in user</param>
        /// <param name="itemId">The id of the item</param>
        /// <param name="sku">The specific sku of an entitlement_list addition to check entitlement for. This is of very limited and specific use and should generally be left out</param>
        /// <param name="info">Any additional info to add to the log about this use</param>
        /// <response code="200">OK</response>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//users/{user_id}/entitlements/{item_id}/use")]
        [SwaggerOperation("EntitlementUseUsingPOST")]
        public virtual void EntitlementUseUsingPOST([FromRoute]string userId, [FromRoute]int? itemId, [FromQuery]string sku, [FromQuery]string info)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// List and search entitlement items
        /// </summary>
        
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//entitlements")]
        [SwaggerOperation("GetCurrenciesUsingGET1")]
        [SwaggerResponse(200, type: typeof(PageEntitlementItem))]
        public virtual IActionResult GetCurrenciesUsingGET1([FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageEntitlementItem>(exampleJson)
            : default(PageEntitlementItem);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get a single entitlement template
        /// </summary>
        
        /// <param name="id">The id of the template</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//entitlements/templates/{id}")]
        [SwaggerOperation("GetEntitlementTemplateUsingGET")]
        [SwaggerResponse(200, type: typeof(ItemTemplateResource))]
        public virtual IActionResult GetEntitlementTemplateUsingGET([FromRoute]string id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ItemTemplateResource>(exampleJson)
            : default(ItemTemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List and search entitlement templates
        /// </summary>
        
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//entitlements/templates")]
        [SwaggerOperation("GetEntitlementTemplatesUsingGET")]
        [SwaggerResponse(200, type: typeof(PageItemTemplateResource))]
        public virtual IActionResult GetEntitlementTemplatesUsingGET([FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageItemTemplateResource>(exampleJson)
            : default(PageItemTemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List the user inventory entries for all users
        /// </summary>
        
        /// <param name="inactive">If true, accepts inactive user inventories</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="filterItemName">Filter by items whose name starts with a string</param>
        /// <param name="filterUsername">Filter by entries owned by the user with the specified username</param>
        /// <param name="filterGroup">Filter by entries owned by the users in a given group, by unique name</param>
        /// <param name="filterDate">A comma separated string without spaces.  First value is the operator to search on, second value is the log start date, a unix timestamp in seconds. Can be repeated for a range, eg: GT,123,LT,456  Allowed operators: (GT, LT, EQ, GOE, LOE).</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//inventories")]
        [SwaggerOperation("GetInventoryListUsingGET")]
        [SwaggerResponse(200, type: typeof(PageUserInventoryResource))]
        public virtual IActionResult GetInventoryListUsingGET([FromQuery]bool? inactive, [FromQuery]int? size, [FromQuery]int? page, [FromQuery]string filterItemName, [FromQuery]string filterUsername, [FromQuery]string filterGroup, [FromQuery]string filterDate)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageUserInventoryResource>(exampleJson)
            : default(PageUserInventoryResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get an inventory entry
        /// </summary>
        
        /// <param name="userId">The id of the inventory owner or &#39;me&#39; for the logged in user</param>
        /// <param name="id">The id of the user inventory</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/{user_id}/inventory/{id}")]
        [SwaggerOperation("GetInventoryUsingGET")]
        [SwaggerResponse(200, type: typeof(UserInventoryResource))]
        public virtual IActionResult GetInventoryUsingGET([FromRoute]int? userId, [FromRoute]int? id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<UserInventoryResource>(exampleJson)
            : default(UserInventoryResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get a single entitlement item
        /// </summary>
        
        /// <param name="entitlementId">The id of the entitlement</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//entitlements/{entitlement_id}")]
        [SwaggerOperation("GetItemUsingGET")]
        [SwaggerResponse(200, type: typeof(EntitlementItem))]
        public virtual IActionResult GetItemUsingGET([FromRoute]int? entitlementId)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<EntitlementItem>(exampleJson)
            : default(EntitlementItem);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List the user inventory entries for a given user
        /// </summary>
        
        /// <param name="id">The id of the user</param>
        /// <param name="inactive">If true, accepts inactive user inventories</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="filterItemName">Filter by items whose name starts with a string</param>
        /// <param name="filterMinDate">Filter for inventory added after the specified date, unix timestamp in seconds</param>
        /// <param name="filterMaxDate">Filter for inventory added before the specified date, unix timestamp in seconds</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/{id}/inventory")]
        [SwaggerOperation("GetUserInventoryListUsingGET")]
        [SwaggerResponse(200, type: typeof(PageUserInventoryResource))]
        public virtual IActionResult GetUserInventoryListUsingGET([FromRoute]int? id, [FromQuery]bool? inactive, [FromQuery]int? size, [FromQuery]int? page, [FromQuery]string filterItemName, [FromQuery]long? filterMinDate, [FromQuery]long? filterMaxDate)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageUserInventoryResource>(exampleJson)
            : default(PageUserInventoryResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List the log entries for this inventory entry.
        /// </summary>
        
        /// <param name="userId">The id of the inventory owner or &#39;me&#39; for the logged in user</param>
        /// <param name="id">The id of the user inventory</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/{user_id}/inventory/{id}/log")]
        [SwaggerOperation("GetUserInventoryLogUsingGET")]
        [SwaggerResponse(200, type: typeof(PageUserItemLogResource))]
        public virtual IActionResult GetUserInventoryLogUsingGET([FromRoute]string userId, [FromRoute]int? id, [FromQuery]int? size, [FromQuery]int? page)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageUserItemLogResource>(exampleJson)
            : default(PageUserItemLogResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Update an entitlement item
        /// </summary>
        
        /// <param name="entitlementId">The id of the entitlement</param>
        /// <param name="entitlementItem">The entitlement item object</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//entitlements/{entitlement_id}")]
        [SwaggerOperation("UpdateItemUsingPUT1")]
        public virtual void UpdateItemUsingPUT1([FromRoute]int? entitlementId, [FromBody]EntitlementItem entitlementItem)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Update an entitlement template
        /// </summary>
        
        /// <param name="id">The id of the template</param>
        /// <param name="template">The updated template</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//entitlements/templates/{id}")]
        [SwaggerOperation("UpdateTemplateUsingPUT3")]
        public virtual void UpdateTemplateUsingPUT3([FromRoute]string id, [FromBody]ItemTemplateResource template)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Set the behavior data for an inventory entry
        /// </summary>
        
        /// <param name="userId">The id of the user</param>
        /// <param name="id">The id of the user inventory</param>
        /// <param name="data">The data map</param>
        /// <response code="200">OK</response>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//users/{user_id}/inventory/{id}/behavior-data")]
        [SwaggerOperation("UpdateUserInventoryBehaviorDataUsingPUT")]
        public virtual void UpdateUserInventoryBehaviorDataUsingPUT([FromRoute]int? userId, [FromRoute]int? id, [FromBody]Object data)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Set the expiration date
        /// </summary>
        /// <remarks>Will change the current grace period for a subscription but not the bill date (possibly even ending before having the chance to re-bill)</remarks>
        /// <param name="userId">user_id</param>
        /// <param name="id">The id of the user inventory</param>
        /// <param name="timestamp">The new expiration date as a unix timestamp in seconds. May be null (no body).</param>
        /// <response code="200">OK</response>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//users/{user_id}/inventory/{id}/expires")]
        [SwaggerOperation("UpdateUserInventoryExpiresUsingPUT")]
        public virtual void UpdateUserInventoryExpiresUsingPUT([FromRoute]int? userId, [FromRoute]int? id, [FromBody]long? timestamp)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Set the status for an inventory entry
        /// </summary>
        
        /// <param name="userId">The id of the user</param>
        /// <param name="id">The id of the user inventory</param>
        /// <param name="inventoryStatus">The inventory status object</param>
        /// <response code="200">OK</response>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//users/{user_id}/inventory/{id}/status")]
        [SwaggerOperation("UpdateUserInventoryStatusUsingPUT")]
        public virtual void UpdateUserInventoryStatusUsingPUT([FromRoute]int? userId, [FromRoute]int? id, [FromBody]string inventoryStatus)
        { 
            throw new NotImplementedException();
        }
    }
}
