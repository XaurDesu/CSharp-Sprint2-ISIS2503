using CSharp_Sprint2.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Serialization;
using System.Web.Http;
using FromBodyAttribute = Microsoft.AspNetCore.Mvc.FromBodyAttribute;
using HttpDeleteAttribute = Microsoft.AspNetCore.Mvc.HttpDeleteAttribute;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CSharp_Sprint2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        // GET: api/<DocumentController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DocumentController>/5
        [HttpGet("{Id}")]
        [HttpGet("{Name}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DocumentController>
        [HttpPost]
        public DocumentModel Post(DocumentModel model)
        {
            return model;
        }


        // PUT api/<DocumentController>/5
        /// <summary>
        /// Adds a value to a database.
        /// eventually this should connect to a Database, 
        /// relational or otherwise
        /// </summary>
        /// <param name="id"></param>
        [Microsoft.AspNetCore.Mvc.HttpPut("{Id,Name,Date,value,documentType,idDocument,currentState}")]
        public IHttpActionResult Put(DocumentModel model)
        {
            if (!ModelState.IsValid)
                return (IHttpActionResult)BadRequest("Invalid data.");

            return (IHttpActionResult)Ok();
        }

        // DELETE api/<DocumentController>/5
        /// <summary>
        /// Deletes the value from a database, 
        /// eventually this should connect to a Database, 
        /// relational or otherwise
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{Id,Name,Date,value,documentType,idDocument,currentState}")]
        public IHttpActionResult Delete(DocumentModel model)
        {
            if (!ModelState.IsValid)
                return (IHttpActionResult)BadRequest("Invalid data.");

            return (IHttpActionResult)Ok();
        }
    }
}
