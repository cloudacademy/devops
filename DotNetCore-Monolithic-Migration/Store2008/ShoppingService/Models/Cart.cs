using System;
using System.Collections.Generic;

namespace ShoppingService
{
    public class Cart
    {
        public Cart()
        {
        }

        public int Id { get; set; }
        public List<Product> Items { get; set; }
    }
}
