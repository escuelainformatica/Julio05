using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web.repo
{
    // api/Ejemplo/
    [RoutePrefix("api/Ejemplo")]
    public class EjemploController : ApiController
    {
        [Route("Listar")]
        [HttpGet]
        public IEnumerable<string> Listar()
        {
            return new string[] { "value1 desde listar", "value2 desde listar" };
        }
        
        [Route("Lista2r")]
        [HttpGet]
        public IEnumerable<string> Listar2()
        {
            return new string[] { "value1 desde listar2", "value2 desde listar2" };
        }
        [Route("Lista3/{id}")]
        [HttpGet]
        public IEnumerable<string> Listar3(string id)
        {
            return new string[] { "value1 desde listar3 "+id, "value2 desde listar3" };
        }

        // GET api/<controller>

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}