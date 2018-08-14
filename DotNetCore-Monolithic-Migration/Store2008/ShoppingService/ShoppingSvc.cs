using System;
using System.Collections.Generic;

namespace ShoppingService
{
    public class ShoppingSvc
    {
        public ShoppingSvc()
        {
        }

        public IEnumerable<int> GetCartIds()
        {
            //stub
            //method would actually make SQL READ all from database

            return new int[] { 100, 101, 102, 103, 200, 201, 600 };
        }

        public Cart GetCart(int id)
        {
            //stub
            //method would actually make SQL READ all from database

            var cart = new Cart()
            {
                Id = id,
                Items = new List<Product>()
                {
                    new Product()
                    {
                        Id = 33,
                        Description = "",
                        Sku = "abc123",
                        Name = "Laptop",
                        DiscountPrice = 20.99m,
                        RegularPrice = 29.99m,
                        Quantity = 82
                    },
                    new Product()
                    {
                        Id = 14,
                        Description = "",
                        Sku = "xyz1238",
                        Name = "iPhone",
                        DiscountPrice = 20.99m,
                        RegularPrice = 29.99m,
                        Quantity = 67
                    },
                    new Product()
                    {
                        Id = 20,
                        Description = "",
                        Sku = "xyz1239",
                        Name = "Jacket",
                        DiscountPrice = 20.99m,
                        RegularPrice = 29.99m,
                        Quantity = 405
                    }
                }
            };

            return cart;
        }

        public Cart SaveCart(Cart cart)
        {
            //stub
            //method would actually make SQL INSERT into database

            var saved_cart = new Cart()
            {
                Id = 100,
                Items = cart.Items
            };

            return saved_cart;
        }

        public Cart UpdateCart(int id, Cart cart)
        {
            //stub
            //method would actually make SQL UPDATE into database

            var updated_cart = new Cart()
            {
                Id = id,
                Items = cart.Items
            };

            return updated_cart;
        }

        public void DeleteCart(int id)
        {
            //stub
            //method would actually make SQL DELETE into database
        }
    }
}
