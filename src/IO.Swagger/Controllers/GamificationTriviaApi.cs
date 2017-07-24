/*
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://knetikcloud.com.
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
    public class GamificationTriviaApiController : Controller
    { 

        /// <summary>
        /// Add an answer to a question
        /// </summary>
        
        /// <param name="questionId">The id of the question</param>
        /// <param name="answer">The new answer</param>
        /// <response code="201">Created</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//trivia/questions/{question_id}/answers")]
        [SwaggerOperation("AddQuestionAnswers")]
        [SwaggerResponse(200, type: typeof(AnswerResource))]
        public virtual IActionResult AddQuestionAnswers([FromRoute]string questionId, [FromBody]AnswerResource answer)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<AnswerResource>(exampleJson)
            : default(AnswerResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Add a tag to a question
        /// </summary>
        
        /// <param name="id">The id of the question</param>
        /// <param name="tag">The new tag</param>
        /// <response code="201">Created</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//trivia/questions/{id}/tags")]
        [SwaggerOperation("AddQuestionTag")]
        public virtual void AddQuestionTag([FromRoute]string id, [FromBody]string tag)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Add a tag to a batch of questions
        /// </summary>
        /// <remarks>All questions that dont&#39;t have the tag and match filters will have it added. The returned number is the number of questions updated.</remarks>
        /// <param name="tag">The tag to add</param>
        /// <param name="filterSearch">Filter for documents whose question, answers or tags contains provided string</param>
        /// <param name="filterIdset">Filter for documents whose id is in the comma separated list provided</param>
        /// <param name="filterCategory">Filter for questions with specified category, by id</param>
        /// <param name="filterTag">Filter for questions with specified tag</param>
        /// <param name="filterTagset">Filter for questions with specified tags (separated by comma)</param>
        /// <param name="filterType">Filter for questions with specified type</param>
        /// <param name="filterPublished">Filter for questions currenctly published or not</param>
        /// <param name="filterImportId">Filter for questions from a specific import job</param>
        /// <response code="200">The number of records updated</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//trivia/questions/tags")]
        [SwaggerOperation("AddTagToQuestionsBatch")]
        [SwaggerResponse(200, type: typeof(int?))]
        public virtual IActionResult AddTagToQuestionsBatch([FromBody]string tag, [FromQuery]string filterSearch, [FromQuery]string filterIdset, [FromQuery]string filterCategory, [FromQuery]string filterTag, [FromQuery]string filterTagset, [FromQuery]string filterType, [FromQuery]bool? filterPublished, [FromQuery]long? filterImportId)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<int?>(exampleJson)
            : default(int?);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Create an import job
        /// </summary>
        /// <remarks>Set up a job to import a set of trivia questions from a cvs file at a remote url. the file will be validated asynchronously but will not be processed until started manually with the process endpoint.</remarks>
        /// <param name="request">The new import job</param>
        /// <response code="201">Created</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//trivia/import")]
        [SwaggerOperation("CreateImportJob")]
        [SwaggerResponse(200, type: typeof(ImportJobResource))]
        public virtual IActionResult CreateImportJob([FromBody]ImportJobResource request)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ImportJobResource>(exampleJson)
            : default(ImportJobResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Create a question
        /// </summary>
        
        /// <param name="question">The new question</param>
        /// <response code="201">Created</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//trivia/questions")]
        [SwaggerOperation("CreateQuestion")]
        [SwaggerResponse(200, type: typeof(QuestionResource))]
        public virtual IActionResult CreateQuestion([FromBody]QuestionResource question)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<QuestionResource>(exampleJson)
            : default(QuestionResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Create a question template
        /// </summary>
        /// <remarks>Question templates define a type of question and the properties they have</remarks>
        /// <param name="questionTemplateResource">The question template resource object</param>
        /// <response code="201">Created</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//trivia/questions/templates")]
        [SwaggerOperation("CreateQuestionTemplate")]
        [SwaggerResponse(200, type: typeof(QuestionTemplateResource))]
        public virtual IActionResult CreateQuestionTemplate([FromBody]QuestionTemplateResource questionTemplateResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<QuestionTemplateResource>(exampleJson)
            : default(QuestionTemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Delete an import job
        /// </summary>
        /// <remarks>Also deletes all questions that were imported by it</remarks>
        /// <param name="id">The id of the job</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpDelete]
        [Route("//trivia/import/{id}")]
        [SwaggerOperation("DeleteImportJob")]
        public virtual void DeleteImportJob([FromRoute]long? id)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete a question
        /// </summary>
        
        /// <param name="id">The id of the question</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpDelete]
        [Route("//trivia/questions/{id}")]
        [SwaggerOperation("DeleteQuestion")]
        public virtual void DeleteQuestion([FromRoute]string id)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Remove an answer from a question
        /// </summary>
        
        /// <param name="questionId">The id of the question</param>
        /// <param name="id">The id of the answer</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpDelete]
        [Route("//trivia/questions/{question_id}/answers/{id}")]
        [SwaggerOperation("DeleteQuestionAnswers")]
        public virtual void DeleteQuestionAnswers([FromRoute]string questionId, [FromRoute]string id)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete a question template
        /// </summary>
        /// <remarks>If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects</remarks>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">The value needed to delete used templates</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpDelete]
        [Route("//trivia/questions/templates/{id}")]
        [SwaggerOperation("DeleteQuestionTemplate")]
        public virtual void DeleteQuestionTemplate([FromRoute]string id, [FromQuery]string cascade)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get an import job
        /// </summary>
        
        /// <param name="id">The id of the job</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//trivia/import/{id}")]
        [SwaggerOperation("GetImportJob")]
        [SwaggerResponse(200, type: typeof(ImportJobResource))]
        public virtual IActionResult GetImportJob([FromRoute]long? id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ImportJobResource>(exampleJson)
            : default(ImportJobResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get a list of import job
        /// </summary>
        
        /// <param name="filterVendor">Filter for jobs by vendor id</param>
        /// <param name="filterCategory">Filter for jobs by category id</param>
        /// <param name="filterName">Filter for jobs which name *STARTS* with the given string</param>
        /// <param name="filterStatus">Filter for jobs that are in a specific set of statuses (comma separated)</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//trivia/import")]
        [SwaggerOperation("GetImportJobs")]
        [SwaggerResponse(200, type: typeof(PageResourceImportJobResource))]
        public virtual IActionResult GetImportJobs([FromQuery]string filterVendor, [FromQuery]string filterCategory, [FromQuery]string filterName, [FromQuery]string filterStatus, [FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceImportJobResource>(exampleJson)
            : default(PageResourceImportJobResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get a single question
        /// </summary>
        
        /// <param name="id">The id of the question</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//trivia/questions/{id}")]
        [SwaggerOperation("GetQuestion")]
        [SwaggerResponse(200, type: typeof(QuestionResource))]
        public virtual IActionResult GetQuestion([FromRoute]string id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<QuestionResource>(exampleJson)
            : default(QuestionResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get an answer for a question
        /// </summary>
        
        /// <param name="questionId">The id of the question</param>
        /// <param name="id">The id of the answer</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//trivia/questions/{question_id}/answers/{id}")]
        [SwaggerOperation("GetQuestionAnswer")]
        [SwaggerResponse(200, type: typeof(AnswerResource))]
        public virtual IActionResult GetQuestionAnswer([FromRoute]string questionId, [FromRoute]string id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<AnswerResource>(exampleJson)
            : default(AnswerResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List the answers available for a question
        /// </summary>
        
        /// <param name="questionId">The id of the question</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//trivia/questions/{question_id}/answers")]
        [SwaggerOperation("GetQuestionAnswers")]
        [SwaggerResponse(200, type: typeof(List<AnswerResource>))]
        public virtual IActionResult GetQuestionAnswers([FromRoute]string questionId)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<AnswerResource>>(exampleJson)
            : default(List<AnswerResource>);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List question deltas in ascending order of updated date
        /// </summary>
        /// <remarks>The &#39;since&#39; parameter is important to avoid getting a full list of all questions. Implementors should make sure they pass the updated date of the last resource loaded, not the date of the last request, in order to avoid gaps</remarks>
        /// <param name="since">Timestamp in seconds</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//trivia/questions/delta")]
        [SwaggerOperation("GetQuestionDeltas")]
        [SwaggerResponse(200, type: typeof(List<DeltaResource>))]
        public virtual IActionResult GetQuestionDeltas([FromQuery]long? since)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<DeltaResource>>(exampleJson)
            : default(List<DeltaResource>);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List the tags for a question
        /// </summary>
        
        /// <param name="id">The id of the question</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//trivia/questions/{id}/tags")]
        [SwaggerOperation("GetQuestionTags")]
        [SwaggerResponse(200, type: typeof(List<string>))]
        public virtual IActionResult GetQuestionTags([FromRoute]string id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<string>>(exampleJson)
            : default(List<string>);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Get a single question template
        /// </summary>
        
        /// <param name="id">The id of the template</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//trivia/questions/templates/{id}")]
        [SwaggerOperation("GetQuestionTemplate")]
        [SwaggerResponse(200, type: typeof(QuestionTemplateResource))]
        public virtual IActionResult GetQuestionTemplate([FromRoute]string id)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<QuestionTemplateResource>(exampleJson)
            : default(QuestionTemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List and search question templates
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
        [Route("//trivia/questions/templates")]
        [SwaggerOperation("GetQuestionTemplates")]
        [SwaggerResponse(200, type: typeof(PageResourceQuestionTemplateResource))]
        public virtual IActionResult GetQuestionTemplates([FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceQuestionTemplateResource>(exampleJson)
            : default(PageResourceQuestionTemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List and search questions
        /// </summary>
        
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <param name="filterSearch">Filter for documents whose question, answers or tags contains provided string</param>
        /// <param name="filterIdset">Filter for documents whose id is in the comma separated list provided</param>
        /// <param name="filterCategory">Filter for questions with specified category, by id</param>
        /// <param name="filterTagset">Filter for questions with specified tags (separated by comma)</param>
        /// <param name="filterTag">Filter for questions with specified tag</param>
        /// <param name="filterType">Filter for questions with specified type.  Allowable values: (&#39;TEXT&#39;, &#39;IMAGE&#39;, &#39;VIDEO&#39;, &#39;AUDIO&#39;)</param>
        /// <param name="filterPublished">Filter for questions currenctly published or not</param>
        /// <param name="filterImportId">Filter for questions from a specific import job</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//trivia/questions")]
        [SwaggerOperation("GetQuestions")]
        [SwaggerResponse(200, type: typeof(PageResourceQuestionResource))]
        public virtual IActionResult GetQuestions([FromQuery]int? size, [FromQuery]int? page, [FromQuery]string order, [FromQuery]string filterSearch, [FromQuery]string filterIdset, [FromQuery]string filterCategory, [FromQuery]string filterTagset, [FromQuery]string filterTag, [FromQuery]string filterType, [FromQuery]bool? filterPublished, [FromQuery]long? filterImportId)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PageResourceQuestionResource>(exampleJson)
            : default(PageResourceQuestionResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Count questions based on filters
        /// </summary>
        /// <remarks>This is also provided by the list endpoint so you don&#39;t need to call this for pagination purposes</remarks>
        /// <param name="filterSearch">Filter for documents whose question, answers or tags contains provided string</param>
        /// <param name="filterIdset">Filter for documents whose id is in the comma separated list provided</param>
        /// <param name="filterCategory">Filter for questions with specified category, by id</param>
        /// <param name="filterTag">Filter for questions with specified tag</param>
        /// <param name="filterTagset">Filter for questions with specified tags (separated by comma)</param>
        /// <param name="filterType">Filter for questions with specified type.  Allowable values: (&#39;TEXT&#39;, &#39;IMAGE&#39;, &#39;VIDEO&#39;, &#39;AUDIO&#39;)</param>
        /// <param name="filterPublished">Filter for questions currenctly published or not</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//trivia/questions/count")]
        [SwaggerOperation("GetQuestionsCount")]
        [SwaggerResponse(200, type: typeof(long?))]
        public virtual IActionResult GetQuestionsCount([FromQuery]string filterSearch, [FromQuery]string filterIdset, [FromQuery]string filterCategory, [FromQuery]string filterTag, [FromQuery]string filterTagset, [FromQuery]string filterType, [FromQuery]bool? filterPublished)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<long?>(exampleJson)
            : default(long?);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Start processing an import job
        /// </summary>
        /// <remarks>Will process the CSV file and add new questions asynchronously. The status of the job must be &#39;VALID&#39;.</remarks>
        /// <param name="id">The id of the job</param>
        /// <param name="publishNow">Whether the new questions should be published live immediately</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("//trivia/import/{id}/process")]
        [SwaggerOperation("ProcessImportJob")]
        [SwaggerResponse(200, type: typeof(ImportJobResource))]
        public virtual IActionResult ProcessImportJob([FromRoute]long? id, [FromQuery]bool? publishNow)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ImportJobResource>(exampleJson)
            : default(ImportJobResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Remove a tag from a question
        /// </summary>
        
        /// <param name="id">The id of the question</param>
        /// <param name="tag">The tag to remove</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpDelete]
        [Route("//trivia/questions/{id}/tags/{tag}")]
        [SwaggerOperation("RemoveQuestionTag")]
        public virtual void RemoveQuestionTag([FromRoute]string id, [FromRoute]string tag)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Remove a tag from a batch of questions
        /// </summary>
        /// <remarks>ll questions that have the tag and match filters will have it removed. The returned number is the number of questions updated.</remarks>
        /// <param name="tag">The tag to remove</param>
        /// <param name="filterSearch">Filter for documents whose question, answers or tags contains provided string</param>
        /// <param name="filterIdset">Filter for documents whose id is in the comma separated list provided</param>
        /// <param name="filterCategory">Filter for questions with specified category, by id</param>
        /// <param name="filterTag">Filter for questions with specified tag</param>
        /// <param name="filterTagset">Filter for questions with specified tags (separated by comma)</param>
        /// <param name="filterType">Filter for questions with specified type.  Allowable values: (&#39;TEXT&#39;, &#39;IMAGE&#39;, &#39;VIDEO&#39;, &#39;AUDIO&#39;)</param>
        /// <param name="filterPublished">Filter for questions currenctly published or not</param>
        /// <param name="filterImportId">Filter for questions from a specific import job</param>
        /// <response code="200">The number of records updated</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpDelete]
        [Route("//trivia/questions/tags/{tag}")]
        [SwaggerOperation("RemoveTagToQuestionsBatch")]
        [SwaggerResponse(200, type: typeof(int?))]
        public virtual IActionResult RemoveTagToQuestionsBatch([FromRoute]string tag, [FromQuery]string filterSearch, [FromQuery]string filterIdset, [FromQuery]string filterCategory, [FromQuery]string filterTag, [FromQuery]string filterTagset, [FromQuery]string filterType, [FromQuery]bool? filterPublished, [FromQuery]long? filterImportId)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<int?>(exampleJson)
            : default(int?);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List and search tags by the beginning of the string
        /// </summary>
        /// <remarks>For performance reasons, search &amp; category filters are mutually exclusive. If category is specified, search filter will be ignored in order to do fast matches for typeahead.</remarks>
        /// <param name="filterSearch">Filter for tags starting with the given text</param>
        /// <param name="filterCategory">Filter for tags on questions from a specific category</param>
        /// <param name="filterImportId">Filter for tags on questions from a specific import job</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("//trivia/tags")]
        [SwaggerOperation("SearchQuestionTags")]
        [SwaggerResponse(200, type: typeof(Collectionstring))]
        public virtual IActionResult SearchQuestionTags([FromQuery]string filterSearch, [FromQuery]string filterCategory, [FromQuery]long? filterImportId)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Collectionstring>(exampleJson)
            : default(Collectionstring);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Update an import job
        /// </summary>
        /// <remarks>Changes should be made before process is started for there to be any effect.</remarks>
        /// <param name="id">The id of the job</param>
        /// <param name="request">The updated job</param>
        /// <response code="201">Created</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//trivia/import/{id}")]
        [SwaggerOperation("UpdateImportJob")]
        [SwaggerResponse(200, type: typeof(ImportJobResource))]
        public virtual IActionResult UpdateImportJob([FromRoute]long? id, [FromBody]ImportJobResource request)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ImportJobResource>(exampleJson)
            : default(ImportJobResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Update a question
        /// </summary>
        
        /// <param name="id">The id of the question</param>
        /// <param name="question">The updated question</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//trivia/questions/{id}")]
        [SwaggerOperation("UpdateQuestion")]
        [SwaggerResponse(200, type: typeof(QuestionResource))]
        public virtual IActionResult UpdateQuestion([FromRoute]string id, [FromBody]QuestionResource question)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<QuestionResource>(exampleJson)
            : default(QuestionResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Update an answer for a question
        /// </summary>
        
        /// <param name="questionId">The id of the question</param>
        /// <param name="id">The id of the answer</param>
        /// <param name="answer">The updated answer</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//trivia/questions/{question_id}/answers/{id}")]
        [SwaggerOperation("UpdateQuestionAnswer")]
        public virtual void UpdateQuestionAnswer([FromRoute]string questionId, [FromRoute]string id, [FromBody]AnswerResource answer)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Update a question template
        /// </summary>
        
        /// <param name="id">The id of the template</param>
        /// <param name="questionTemplateResource">The question template resource object</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//trivia/questions/templates/{id}")]
        [SwaggerOperation("UpdateQuestionTemplate")]
        [SwaggerResponse(200, type: typeof(QuestionTemplateResource))]
        public virtual IActionResult UpdateQuestionTemplate([FromRoute]string id, [FromBody]QuestionTemplateResource questionTemplateResource)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<QuestionTemplateResource>(exampleJson)
            : default(QuestionTemplateResource);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Bulk update questions
        /// </summary>
        /// <remarks>Will update all questions that match filters used (or all questions in system if no filters used). Body should match a question resource with only those properties you wish to set. Null values will be ignored. Returned number is how many were updated.</remarks>
        /// <param name="question">New values for a set of question fields</param>
        /// <param name="filterSearch">Filter for documents whose question, answers or tags contains provided string</param>
        /// <param name="filterIdset">Filter for documents whose id is in the comma separated list provided</param>
        /// <param name="filterCategory">Filter for questions with specified category, by id</param>
        /// <param name="filterTagset">Filter for questions with specified tags (separated by comma)</param>
        /// <param name="filterType">Filter for questions with specified type.  Allowable values: (&#39;TEXT&#39;, &#39;IMAGE&#39;, &#39;VIDEO&#39;, &#39;AUDIO&#39;)</param>
        /// <param name="filterPublished">Filter for questions currenctly published or not</param>
        /// <param name="filterImportId">Filter for questions from a specific import job</param>
        /// <response code="200">The number of records updated</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("//trivia/questions")]
        [SwaggerOperation("UpdateQuestionsInBulk")]
        [SwaggerResponse(200, type: typeof(int?))]
        public virtual IActionResult UpdateQuestionsInBulk([FromBody]QuestionResource question, [FromQuery]string filterSearch, [FromQuery]string filterIdset, [FromQuery]string filterCategory, [FromQuery]string filterTagset, [FromQuery]string filterType, [FromQuery]bool? filterPublished, [FromQuery]long? filterImportId)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<int?>(exampleJson)
            : default(int?);
            return new ObjectResult(example);
        }
    }
}
