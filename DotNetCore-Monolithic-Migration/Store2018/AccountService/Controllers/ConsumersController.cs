using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AccountService.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AccountService.Controllers
{
    [Route("api/[controller]")]
    public class ConsumersController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value100", "value200" };
        }

        // GET api/values/5
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Consumer> Get(int id)
        {
            var consumer = new Consumer()
            {
                Firstname = "Jeremy",
                Surname = "Cook",
                Age = 20
            };

            return consumer;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
