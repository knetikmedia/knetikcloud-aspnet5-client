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
    public class StoreSubscriptionsApiController : Controller
    { 

        /// <summary>
        /// Create a subscription template
        /// </summary>
        /// <remarks>Subscription Templates define a type of subscription and the properties they have.</remarks>
        /// <param name="subscriptionTemplateResource">The new subscription template</param>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//subscriptions/templates")]
        [SwaggerOperation("CreateSubscriptionTemplateUsingPOST")]
        [SwaggerResponse(200, type: typeof(SubscriptionTemplateResource))]
        public virtual IActionResult CreateSubscriptionTemplateUsingPOST([FromBody]SubscriptionTemplateResource subscriptionTemplateResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<SubscriptionTemplateResource>(exampleJson)
            : default(SubscriptionTemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Creates a subscription item and associated plans
        /// </summary>
        
        /// <param name="subscriptionResource">The subscription to be created</param>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//subscriptions")]
        [SwaggerOperation("CreateSubscriptionUsingPOST")]
        [SwaggerResponse(200, type: typeof(SubscriptionResource))]
        public virtual IActionResult CreateSubscriptionUsingPOST([FromBody]SubscriptionResource subscriptionResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<SubscriptionResource>(exampleJson)
            : default(SubscriptionResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Delete a subscription plan
        /// </summary>
        /// <remarks>Must not be locked or a migration target</remarks>
        /// <param name="id">The id of the subscription</param>
        /// <param name="planId">The id of the plan</param>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpDelete]
        [Route("//subscriptions/{id}/plans/{plan_id}")]
        [SwaggerOperation("DeletePlanUsingDELETE")]
        public virtual void DeletePlanUsingDELETE([FromRoute]int? id, [FromRoute]string planId)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete a subscription template
        /// </summary>
        
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">force deleting the template if it&#39;s attached to other objects, cascade &#x3D; detach</param>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpDelete]
        [Route("//subscriptions/templates/{id}")]
        [SwaggerOperation("DeleteSubscriptionTemplateUsingDELETE")]
        public virtual void DeleteSubscriptionTemplateUsingDELETE([FromRoute]string id, [FromQuery]string cascade)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get a single subscription template
        /// </summary>
        /// <remarks>Subscription Templates define a type of subscription and the properties they have.</remarks>
        /// <param name="id">The id of the template</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//subscriptions/templates/{id}")]
        [SwaggerOperation("GetSubscriptionTemplateUsingGET")]
        [SwaggerResponse(200, type: typeof(SubscriptionTemplateResource))]
        public virtual IActionResult GetSubscriptionTemplateUsingGET([FromRoute]string id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<SubscriptionTemplateResource>(exampleJson)
            : default(SubscriptionTemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List and search subscription templates
        /// </summary>
        
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//subscriptions/templates")]
        [SwaggerOperation("GetSubscriptionTemplatesUsingGET")]
        [SwaggerResponse(200, type: typeof(PageResourceSubscriptionTemplateResource))]
        public virtual IActionResult GetSubscriptionTemplatesUsingGET([FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceSubscriptionTemplateResource>(exampleJson)
            : default(PageResourceSubscriptionTemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Retrieve a single subscription item and associated plans
        /// </summary>
        
        /// <param name="id">The id of the subscription</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//subscriptions/{id}")]
        [SwaggerOperation("GetSubscriptionUsingGET")]
        [SwaggerResponse(200, type: typeof(SubscriptionResource))]
        public virtual IActionResult GetSubscriptionUsingGET([FromRoute]int? id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<SubscriptionResource>(exampleJson)
            : default(SubscriptionResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List available subscription items and associated plans
        /// </summary>
        
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//subscriptions")]
        [SwaggerOperation("ListSubscriptionsUsingGET")]
        [SwaggerResponse(200, type: typeof(PageResourceSubscriptionResource))]
        public virtual IActionResult ListSubscriptionsUsingGET([FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceSubscriptionResource>(exampleJson)
            : default(PageResourceSubscriptionResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Processes subscriptions and charge dues
        /// </summary>
        
        /// <response code="200">OK</response>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//subscriptions/process")]
        [SwaggerOperation("ProcessUsingPOST")]
        public virtual void ProcessUsingPOST()
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Update a subscription template
        /// </summary>
        
        /// <param name="id">The id of the template</param>
        /// <param name="subscriptionTemplateResource">The subscription template resource object</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//subscriptions/templates/{id}")]
        [SwaggerOperation("UpdateSubscriptionTemplateUsingPUT")]
        public virtual void UpdateSubscriptionTemplateUsingPUT([FromRoute]string id, [FromBody]SubscriptionTemplateResource subscriptionTemplateResource)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Updates a subscription item and associated plans
        /// </summary>
        /// <remarks>Will not remove plans left out</remarks>
        /// <param name="id">The id of the subscription</param>
        /// <param name="subscriptionResource">The subscription resource object</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//subscriptions/{id}")]
        [SwaggerOperation("UpdateSubscriptionUsingPUT")]
        public virtual void UpdateSubscriptionUsingPUT([FromRoute]int? id, [FromBody]SubscriptionResource subscriptionResource)
        { 
            throw new NotImplementedException();
        }
    }
}
