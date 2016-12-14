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
    public class PaymentsWalletsApiController : Controller
    { 

        /// <summary>
        /// Retrieves a summation of wallet balances by currency code
        /// </summary>
        
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//wallets/totals")]
        [SwaggerOperation("GetWalletTotalsUsingGET")]
        [SwaggerResponse(200, type: typeof(PageWalletTotalResponse))]
        public virtual IActionResult GetWalletTotalsUsingGET()
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageWalletTotalResponse>(exampleJson)
            : default(PageWalletTotalResponse);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Returns the user&#39;s wallet for the given currency code
        /// </summary>
        
        /// <param name="userId">The ID of the user for whom wallet is being retrieved</param>
        /// <param name="currencyCode">Currency code of the user&#39;s wallet</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/{user_id}/wallets/{currency_code}")]
        [SwaggerOperation("GetWalletUsingGET")]
        [SwaggerResponse(200, type: typeof(SimpleWallet))]
        public virtual IActionResult GetWalletUsingGET([FromRoute]int? userId, [FromRoute]string currencyCode)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<SimpleWallet>(exampleJson)
            : default(SimpleWallet);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List all of a user&#39;s wallets
        /// </summary>
        
        /// <param name="userId">The ID of the user for whom wallets are being retrieved</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/{user_id}/wallets")]
        [SwaggerOperation("GetWalletsUsingGET")]
        [SwaggerResponse(200, type: typeof(List<SimpleWallet>))]
        public virtual IActionResult GetWalletsUsingGET([FromRoute]int? userId)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<SimpleWallet>>(exampleJson)
            : default(List<SimpleWallet>);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Retrieve a list of wallets across the system
        /// </summary>
        
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//wallets")]
        [SwaggerOperation("GetWalletsUsingGET1")]
        [SwaggerResponse(200, type: typeof(PageSimpleWallet))]
        public virtual IActionResult GetWalletsUsingGET1([FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageSimpleWallet>(exampleJson)
            : default(PageSimpleWallet);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Retrieve wallet transactions across the system
        /// </summary>
        
        /// <param name="filterInvoice">Filter for transactions from a specific invoice</param>
        /// <param name="filterType">Filter for transactions with specified type</param>
        /// <param name="filterMaxDate">Filter for transactions from no earlier than the specified date as a unix timestamp in seconds</param>
        /// <param name="filterMinDate">Filter for transactions from no later than the specified date as a unix timestamp in seconds</param>
        /// <param name="filterSign">Filter for transactions with amount with the given sign</param>
        /// <param name="filterUserId">Filter for transactions for specific userId</param>
        /// <param name="filterUsername">Filter for transactions for specific username that start with the given string</param>
        /// <param name="filterDetails">Filter for transactions for specific details that start with the given string</param>
        /// <param name="filterCurrencyCode">Filter for transactions for specific currency code</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//wallets/transactions")]
        [SwaggerOperation("TransactionHistoryUsingGET")]
        [SwaggerResponse(200, type: typeof(PageWalletTransactionResource))]
        public virtual IActionResult TransactionHistoryUsingGET([FromQuery]int? filterInvoice, [FromQuery]string filterType, [FromQuery]long? filterMaxDate, [FromQuery]long? filterMinDate, [FromQuery]string filterSign, [FromQuery]int? filterUserId, [FromQuery]string filterUsername, [FromQuery]string filterDetails, [FromQuery]string filterCurrencyCode, [FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageWalletTransactionResource>(exampleJson)
            : default(PageWalletTransactionResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Updates the balance for a user&#39;s wallet
        /// </summary>
        
        /// <param name="userId">The ID of the user for whom wallet is being modified</param>
        /// <param name="currencyCode">Currency code of the user&#39;s wallet</param>
        /// <param name="request">The requested balance modification to be made to the user&#39;s wallet</param>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//users/{user_id}/wallets/{currency_code}/balance")]
        [SwaggerOperation("UpdateBalanceUsingPUT")]
        [SwaggerResponse(200, type: typeof(WalletTransactionResource))]
        public virtual IActionResult UpdateBalanceUsingPUT([FromRoute]int? userId, [FromRoute]string currencyCode, [FromBody]WalletAlterRequest request)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<WalletTransactionResource>(exampleJson)
            : default(WalletTransactionResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Retrieve a user&#39;s wallet transactions
        /// </summary>
        
        /// <param name="userId">The ID of the user for whom wallet transactions are being retrieved</param>
        /// <param name="currencyCode">Currency code of the user&#39;s wallet</param>
        /// <param name="filterType">Filter for transactions with specified type</param>
        /// <param name="filterMaxDate">Filter for transactions from no earlier than the specified date as a unix timestamp in seconds</param>
        /// <param name="filterMinDate">Filter for transactions from no later than the specified date as a unix timestamp in seconds</param>
        /// <param name="filterSign">Filter for transactions with amount with the given sign.  Allowable values: (&#39;positive&#39;, &#39;negative&#39;)</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//users/{user_id}/wallets/{currency_code}/transactions")]
        [SwaggerOperation("UserTransactionHistoryUsingGET")]
        [SwaggerResponse(200, type: typeof(PageWalletTransactionResource))]
        public virtual IActionResult UserTransactionHistoryUsingGET([FromRoute]int? userId, [FromRoute]string currencyCode, [FromQuery]string filterType, [FromQuery]long? filterMaxDate, [FromQuery]long? filterMinDate, [FromQuery]string filterSign, [FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageWalletTransactionResource>(exampleJson)
            : default(PageWalletTransactionResource);
            return new ObjectResult(example);
        }
    }
}
