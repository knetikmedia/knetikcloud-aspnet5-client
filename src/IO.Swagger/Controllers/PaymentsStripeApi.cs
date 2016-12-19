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
    public class PaymentsStripeApiController : Controller
    { 

        /// <summary>
        /// Create a Stripe payment method for a user
        /// </summary>
        /// <remarks>Stores customer information and creates a payment method that can be used to pay invoices through the payments endpoints.</remarks>
        /// <param name="request">The request to create a Stripe customer with payment info</param>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//payment/provider/stripe/payment-methods")]
        [SwaggerOperation("CreateCustomerUsingPOST1")]
        [SwaggerResponse(200, type: typeof(PaymentMethodResource))]
        public virtual IActionResult CreateCustomerUsingPOST1([FromBody]StripeCreatePaymentMethod request)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PaymentMethodResource>(exampleJson)
            : default(PaymentMethodResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Pay with a single use token
        /// </summary>
        
        /// <param name="request">The request to pay an invoice</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//payment/provider/stripe/payments")]
        [SwaggerOperation("PayInvoiceUsingPOST1")]
        public virtual void PayInvoiceUsingPOST1([FromBody]StripePaymentRequest request)
        { 
            throw new NotImplementedException();
        }
    }
}
