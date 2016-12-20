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
    public class InvoicesApiController : Controller
    { 

        /// <summary>
        /// Create an invoice
        /// </summary>
        /// <remarks>Create an invoice(s) by providing a cart GUID. Note that there may be multiple invoices created, one per vendor.</remarks>
        /// <param name="req">Invoice to be created</param>
        /// <response code="200">OK</response>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//invoices")]
        [SwaggerOperation("CreateInvoiceUsingPOST")]
        [SwaggerResponse(200, type: typeof(List<InvoiceResource>))]
        public virtual IActionResult CreateInvoiceUsingPOST([FromBody]InvoiceCreateRequest req)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<InvoiceResource>>(exampleJson)
            : default(List<InvoiceResource>);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Retrieve invoices
        /// </summary>
        /// <remarks>Without INVOICES_ADMIN permission the results are automatically filtered for only the logged in user&#39;s invoices. It is recomended however that filter_user be added to avoid issues for admin users accidentally getting additional invoices.</remarks>
        /// <param name="filterUser">The id of a user to get invoices for. Automtically added if not being called with admin permissions.</param>
        /// <param name="filterEmail">Filters invoices by customer&#39;s email. Admins only.</param>
        /// <param name="filterFulfillmentStatus">Filters invoices by fulfillment status type. Can be a comma separated list of statuses</param>
        /// <param name="filterPaymentStatus">Filters invoices by payment status type. Can be a comma separated list of statuses</param>
        /// <param name="filterItemName">Filters invoices by item name containing the given string</param>
        /// <param name="filterCreatedDate">Filters invoices by creation date. Multiple values possible for range search. Format: filter_created_date&#x3D;OP,ts&amp;... where OP in (GT, LT, GOE, LOE, EQ) and ts is a unix timestamp in seconds. Ex: filter_created_date&#x3D;GT,1452154258,LT,1554254874</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//invoices")]
        [SwaggerOperation("GetInvoiceHistoryUsingGET")]
        [SwaggerResponse(200, type: typeof(PageInvoiceResource))]
        public virtual IActionResult GetInvoiceHistoryUsingGET([FromQuery]int? filterUser, [FromQuery]string filterEmail, [FromQuery]string filterFulfillmentStatus, [FromQuery]string filterPaymentStatus, [FromQuery]string filterItemName, [FromQuery]string filterCreatedDate, [FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageInvoiceResource>(exampleJson)
            : default(PageInvoiceResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Retrieve an invoice
        /// </summary>
        /// <remarks>The postal code associated with the invoice may be required for security purposes if the invoice has one set and the config postal_code_required is set to true. Send &#39;none&#39; if the invoice has no postal code.</remarks>
        /// <param name="id">The id of the invoice</param>
        /// <param name="postalCode">The postal code of the invoice or &#39;none&#39;.</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//invoices/{id}")]
        [SwaggerOperation("GetInvoiceUsingGET")]
        [SwaggerResponse(200, type: typeof(InvoiceResource))]
        public virtual IActionResult GetInvoiceUsingGET([FromRoute]int? id, [FromQuery]string postalCode)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InvoiceResource>(exampleJson)
            : default(InvoiceResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List invoice logs
        /// </summary>
        
        /// <param name="id">The id of the invoice</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//invoices/{id}/logs")]
        [SwaggerOperation("GetLogsUsingGET")]
        [SwaggerResponse(200, type: typeof(PageInvoiceLogEntry))]
        public virtual IActionResult GetLogsUsingGET([FromRoute]int? id, [FromQuery]int? size, [FromQuery]int? page)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageInvoiceLogEntry>(exampleJson)
            : default(PageInvoiceLogEntry);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Lists available fulfillment statuses
        /// </summary>
        
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//invoices/fulfillment-statuses")]
        [SwaggerOperation("ListFulFillmentStatusesUsingGET")]
        [SwaggerResponse(200, type: typeof(List<string>))]
        public virtual IActionResult ListFulFillmentStatusesUsingGET()
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<string>>(exampleJson)
            : default(List<string>);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Lists available payment statuses
        /// </summary>
        
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//invoices/payment-statuses")]
        [SwaggerOperation("ListPaymentStatusesUsingGET")]
        [SwaggerResponse(200, type: typeof(List<string>))]
        public virtual IActionResult ListPaymentStatusesUsingGET()
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<string>>(exampleJson)
            : default(List<string>);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Trigger payment of an invoice
        /// </summary>
        
        /// <param name="id">The id of the invoice</param>
        /// <param name="request">Payment info</param>
        /// <response code="200">OK</response>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//invoices/{id}/payments")]
        [SwaggerOperation("PayInvoiceUsingPOST")]
        public virtual void PayInvoiceUsingPOST([FromRoute]int? id, [FromBody]PayBySavedMethodRequest request)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Set the fulfillment status of an invoice item
        /// </summary>
        /// <remarks>This allows external fulfillment systems to report success or failure. Fulfillment status changes are restricted by a specific flow determining which status can lead to which.</remarks>
        /// <param name="id">The id of the invoice</param>
        /// <param name="sku">The sku of an item in the invoice</param>
        /// <param name="status">The new fulfillment status for the item. Additional options may be available based on configuration.  Allowable values:  &#39;unfulfilled&#39;, &#39;fulfilled&#39;, &#39;not fulfillable&#39;, &#39;failed&#39;, &#39;processing&#39;, &#39;failed_permanent&#39;, &#39;delayed&#39;</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//invoices/{id}/items/{sku}/fulfillment-status")]
        [SwaggerOperation("SetItemFulfillmentStatusUsingPUT")]
        public virtual void SetItemFulfillmentStatusUsingPUT([FromRoute]int? id, [FromRoute]string sku, [FromBody]string status)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Set the order notes of an invoice
        /// </summary>
        
        /// <param name="id">The id of the invoice</param>
        /// <param name="orderNotes">Payment status info</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//invoices/{id}/order-notes")]
        [SwaggerOperation("SetOrderNotesUsingPUT")]
        public virtual void SetOrderNotesUsingPUT([FromRoute]int? id, [FromBody]string orderNotes)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Set the payment status of an invoice
        /// </summary>
        /// <remarks>This may trigger fulfillment if setting the status to &#39;paid&#39;. This is mainly intended to support external payment systems that cannot be incorporated into the payment method system. Payment status changes are restricted by a specific flow determining which status can lead to which.</remarks>
        /// <param name="id">The id of the invoice</param>
        /// <param name="request">Payment status info</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//invoices/{id}/payment-status")]
        [SwaggerOperation("SetPaymentStatusUsingPUT")]
        public virtual void SetPaymentStatusUsingPUT([FromRoute]int? id, [FromBody]InvoicePaymentStatusRequest request)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Set or update billing info
        /// </summary>
        
        /// <param name="id">The id of the invoice</param>
        /// <param name="billingInfoRequest">Address info</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//invoices/{id}/billing-address")]
        [SwaggerOperation("UpdateBillingInfoUsingPUT")]
        public virtual void UpdateBillingInfoUsingPUT([FromRoute]int? id, [FromBody]AddressResource billingInfoRequest)
        { 
            throw new NotImplementedException();
        }
    }
}
