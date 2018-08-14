using System;
using System.Collections.Generic;
using InventoryService;
using AccountService;
using ShoppingService;

namespace Store2008.Models
{
    public class CommerceModel
    {
        public Consumer User { get; set; }
        public List<InventoryService.Product> Products { get; set; }
        public Cart Cart { get; set; }
    }
}
