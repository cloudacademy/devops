using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingService.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoppingService.Controllers
{
    [Route("api/[controller]")]
    public class CartController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET cart/values/5
        [HttpGet("{id}")]
        public ActionResult<Cart> Get(int id)
        {
            var cart = new Cart()
            {
                Id = id,
                Items = new List<Product>()
                {
                    new Product()
                    {
                        Description = "",
                        Id = 1,
                        Sku = "abc123",
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
                }
            };

            return cart;
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
