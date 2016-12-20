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
    public class CategoriesApiController : Controller
    { 

        /// <summary>
        /// Create a new category
        /// </summary>
        
        /// <param name="category">The category to create</param>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//categories")]
        [SwaggerOperation("CreateCategoryUsingPOST")]
        [SwaggerResponse(200, type: typeof(CategoryResource))]
        public virtual IActionResult CreateCategoryUsingPOST([FromBody]CategoryResource category)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CategoryResource>(exampleJson)
            : default(CategoryResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Create a category template
        /// </summary>
        /// <remarks>Templates define a type of category and the properties they have</remarks>
        /// <param name="template">The template to create</param>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//categories/templates")]
        [SwaggerOperation("CreateTemplateUsingPOST2")]
        [SwaggerResponse(200, type: typeof(TemplateResource))]
        public virtual IActionResult CreateTemplateUsingPOST2([FromBody]TemplateResource template)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<TemplateResource>(exampleJson)
            : default(TemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Delete an existing category
        /// </summary>
        
        /// <param name="id">The id of the category to be deleted</param>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpDelete]
        [Route("//categories/{id}")]
        [SwaggerOperation("DeleteCategoryUsingDELETE")]
        public virtual void DeleteCategoryUsingDELETE([FromRoute]string id)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete a category template
        /// </summary>
        /// <remarks>If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects</remarks>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">The value needed to delete used templates</param>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpDelete]
        [Route("//categories/templates/{id}")]
        [SwaggerOperation("DeleteTemplateUsingDELETE1")]
        public virtual void DeleteTemplateUsingDELETE1([FromRoute]string id, [FromQuery]string cascade)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// List and search category templates
        /// </summary>
        
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//categories/templates")]
        [SwaggerOperation("GetArticleTemplatesUsingGET1")]
        [SwaggerResponse(200, type: typeof(PageResourceTemplateResource))]
        public virtual IActionResult GetArticleTemplatesUsingGET1([FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceTemplateResource>(exampleJson)
            : default(PageResourceTemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List and search categories with optional filters
        /// </summary>
        
        /// <param name="filterSearch">Filter for categories whose names begin with provided string</param>
        /// <param name="filterActive">Filter for categories that are specifically active or inactive</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//categories")]
        [SwaggerOperation("GetCategoriesUsingGET1")]
        [SwaggerResponse(200, type: typeof(PageResourceCategoryResource))]
        public virtual IActionResult GetCategoriesUsingGET1([FromQuery]string filterSearch, [FromQuery]bool? filterActive, [FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceCategoryResource>(exampleJson)
            : default(PageResourceCategoryResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get a single category
        /// </summary>
        
        /// <param name="id">The id of the category to retrieve</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//categories/{id}")]
        [SwaggerOperation("GetCategoryUsingGET1")]
        [SwaggerResponse(200, type: typeof(CategoryResource))]
        public virtual IActionResult GetCategoryUsingGET1([FromRoute]string id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CategoryResource>(exampleJson)
            : default(CategoryResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List all trivia tags in the system
        /// </summary>
        
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//tags")]
        [SwaggerOperation("GetTagsUsingGET")]
        [SwaggerResponse(200, type: typeof(PageResourcestring))]
        public virtual IActionResult GetTagsUsingGET([FromQuery]int? size, [FromQuery]int? page)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourcestring>(exampleJson)
            : default(PageResourcestring);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get a single category template
        /// </summary>
        
        /// <param name="id">The id of the template</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//categories/templates/{id}")]
        [SwaggerOperation("GetTemplateUsingGET1")]
        [SwaggerResponse(200, type: typeof(TemplateResource))]
        public virtual IActionResult GetTemplateUsingGET1([FromRoute]string id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<TemplateResource>(exampleJson)
            : default(TemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Update an existing category
        /// </summary>
        
        /// <param name="id">The id of the category</param>
        /// <param name="category">The category to update</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//categories/{id}")]
        [SwaggerOperation("UpdateCategoryUsingPUT1")]
        public virtual void UpdateCategoryUsingPUT1([FromRoute]string id, [FromBody]CategoryResource category)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Update a category template
        /// </summary>
        
        /// <param name="id">The id of the template</param>
        /// <param name="template">The updated template information</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//categories/templates/{id}")]
        [SwaggerOperation("UpdateTemplateUsingPUT2")]
        public virtual void UpdateTemplateUsingPUT2([FromRoute]string id, [FromBody]TemplateResource template)
        { 
            throw new NotImplementedException();
        }
    }
}
