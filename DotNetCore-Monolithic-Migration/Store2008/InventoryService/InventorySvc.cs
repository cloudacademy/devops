using System;
using System.Collections.Generic;
namespace InventoryService
{
    public class InventorySvc
    {
        public InventorySvc()
        {
        }

        public List<Product> GetProducts()
        {
            var products = new List<Product>()
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
            };

            return products;
        }

    }
}
