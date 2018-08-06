using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InventoryService.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InventoryService.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        // GET: api/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            var products = new List<Product>(){
                new Product()
                    {
                        Description = "",
                        Id = 1,
                        Sku = "abc12300",
                        Name = "Toy1",
                        DiscountPrice = 20.99m,
                        RegularPrice = 29.99m,
                        Quantity = 100
                    },
                    new Product()
                    {
                        Description = "",
                        Id = 2,
                        Sku = "xyz123",
                        Name = "Toy2",
                        DiscountPrice = 20.99m,
                        RegularPrice = 29.99m,
                        Quantity = 100
                    }
            };

            return products;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
