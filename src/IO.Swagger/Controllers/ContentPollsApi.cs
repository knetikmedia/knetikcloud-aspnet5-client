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
    public class ContentPollsApiController : Controller
    { 

        /// <summary>
        /// Add your vote to a poll
        /// </summary>
        
        /// <param name="id">The poll id</param>
        /// <param name="answerKey">The answer key</param>
        /// <response code="200">OK</response>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//media/polls/{id}/response")]
        [SwaggerOperation("AnswerPoll")]
        [SwaggerResponse(200, type: typeof(PollResponseResource))]
        public virtual IActionResult AnswerPoll([FromRoute]string id, [FromBody]string answerKey)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PollResponseResource>(exampleJson)
            : default(PollResponseResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Create a new poll
        /// </summary>
        /// <remarks>Polls are blobs of text with titles, a category and assets. Formatting and display of the text is in the hands of the front end.</remarks>
        /// <param name="pollResource">The poll object</param>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//media/polls")]
        [SwaggerOperation("CreatePoll")]
        [SwaggerResponse(200, type: typeof(PollResource))]
        public virtual IActionResult CreatePoll([FromBody]PollResource pollResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PollResource>(exampleJson)
            : default(PollResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Create a poll template
        /// </summary>
        /// <remarks>Poll templates define a type of poll and the properties they have</remarks>
        /// <param name="pollTemplateResource">The poll template resource object</param>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//media/polls/templates")]
        [SwaggerOperation("CreatePollTemplate")]
        [SwaggerResponse(200, type: typeof(TemplateResource))]
        public virtual IActionResult CreatePollTemplate([FromBody]TemplateResource pollTemplateResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<TemplateResource>(exampleJson)
            : default(TemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Delete an existing poll
        /// </summary>
        
        /// <param name="id">The poll id</param>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpDelete]
        [Route("//media/polls/{id}")]
        [SwaggerOperation("DeletePoll")]
        public virtual void DeletePoll([FromRoute]string id)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete a poll template
        /// </summary>
        /// <remarks>If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects</remarks>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">The value needed to delete used templates</param>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpDelete]
        [Route("//media/polls/templates/{id}")]
        [SwaggerOperation("DeletePollTemplate")]
        public virtual void DeletePollTemplate([FromRoute]string id, [FromQuery]string cascade)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get a single poll
        /// </summary>
        
        /// <param name="id">The poll id</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//media/polls/{id}")]
        [SwaggerOperation("GetPoll")]
        [SwaggerResponse(200, type: typeof(PollResource))]
        public virtual IActionResult GetPoll([FromRoute]string id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PollResource>(exampleJson)
            : default(PollResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get poll answer
        /// </summary>
        
        /// <param name="id">The poll id</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//media/polls/{id}/response")]
        [SwaggerOperation("GetPollAnswer")]
        [SwaggerResponse(200, type: typeof(PollResponseResource))]
        public virtual IActionResult GetPollAnswer([FromRoute]string id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PollResponseResource>(exampleJson)
            : default(PollResponseResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get a single poll template
        /// </summary>
        
        /// <param name="id">The id of the template</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//media/polls/templates/{id}")]
        [SwaggerOperation("GetPollTemplate")]
        [SwaggerResponse(200, type: typeof(TemplateResource))]
        public virtual IActionResult GetPollTemplate([FromRoute]string id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<TemplateResource>(exampleJson)
            : default(TemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List and search poll templates
        /// </summary>
        
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//media/polls/templates")]
        [SwaggerOperation("GetPollTemplates")]
        [SwaggerResponse(200, type: typeof(PageResourceTemplateResource))]
        public virtual IActionResult GetPollTemplates([FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceTemplateResource>(exampleJson)
            : default(PageResourceTemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List and search polls
        /// </summary>
        /// <remarks>Get a list of polls with optional filtering. Assets will not be filled in on the resources returned. Use &#39;Get a single poll&#39; to retrieve the full resource with assets for a given item as needed.</remarks>
        /// <param name="filterCategory">Filter for polls from a specific category by id</param>
        /// <param name="filterTagset">Filter for polls with specified tags (separated by comma)</param>
        /// <param name="filterText">Filter for polls whose text contains a string</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//media/polls")]
        [SwaggerOperation("GetPolls")]
        [SwaggerResponse(200, type: typeof(PageResourcePollResource))]
        public virtual IActionResult GetPolls([FromQuery]string filterCategory, [FromQuery]string filterTagset, [FromQuery]string filterText, [FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourcePollResource>(exampleJson)
            : default(PageResourcePollResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Update an existing poll
        /// </summary>
        
        /// <param name="id">The poll id</param>
        /// <param name="pollResource">The poll object</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//media/polls/{id}")]
        [SwaggerOperation("UpdatePoll")]
        public virtual void UpdatePoll([FromRoute]string id, [FromBody]PollResource pollResource)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Update a poll template
        /// </summary>
        
        /// <param name="id">The id of the template</param>
        /// <param name="pollTemplateResource">The poll template resource object</param>
        /// <response code="201">Created</response>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//media/polls/templates/{id}")]
        [SwaggerOperation("UpdatePollTemplate")]
        public virtual void UpdatePollTemplate([FromRoute]string id, [FromBody]TemplateResource pollTemplateResource)
        { 
            throw new NotImplementedException();
        }
    }
}
