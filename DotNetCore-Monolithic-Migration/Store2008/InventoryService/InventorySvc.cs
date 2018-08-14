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
            //stub
            //method would actually make SQL READ all from database

            var products = new List<Product>(){
                new Product()
                    {
                        Id = 1,
                        Description = "",
                        Sku = "abc12300",
                        Name = "Toy1",
                        DiscountPrice = 20.99m,
                        RegularPrice = 29.99m,
                        Quantity = 100
                    },
                    new Product()
                    {
                        Id = 2,
                        Description = "",
                        Sku = "xyz123",
                        Name = "Toy2",
                        DiscountPrice = 20.99m,
                        RegularPrice = 29.99m,
                        Quantity = 100
                    }
            };

            return products;
        }

        public Product GetProduct(int id)
        {
            //stub
            //method would actually make SQL READ from database
            //with WHERE clause on id

            var product = new Product()
            {
                Id = id,
                Description = "",
                Sku = "xyz123",
                Name = "Toy2",
                DiscountPrice = 20.99m,
                RegularPrice = 29.99m,
                Quantity = 100
            };

            return product;
        }

        public Product SaveProduct(Product product)
        {
            //stub
            //method would actually make SQL INSERT into database
            var saved_product = new Product()
            {
                Id = 100,
                Description = product.Description,
                Sku = product.Sku,
                Name = product.Name,
                DiscountPrice = product.DiscountPrice,
                RegularPrice = product.RegularPrice,
                Quantity = product.Quantity
            };

            return saved_product;
        }

        public Product UpdateProduct(int id, Product product)
        {
            //stub
            //method would actually make SQL UPDATE into database
            var updated_product = new Product()
            {
                Id = id,
                Description = product.Description,
                Sku = product.Sku,
                Name = product.Name,
                DiscountPrice = product.DiscountPrice,
                RegularPrice = product.RegularPrice,
                Quantity = product.Quantity
            };

            return updated_product;
        }

        public void DeleteProduct(int id)
        {
            //stub
            //method would actually make SQL DELETE in database
        }
    }
}
