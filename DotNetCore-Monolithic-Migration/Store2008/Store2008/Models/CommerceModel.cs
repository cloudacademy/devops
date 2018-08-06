using System;
using System.Collections.Generic;
using InventoryService;
using AccountService;

namespace Store2008.Models
{
    public class CommerceModel
    {
        public Consumer User { get; set; }
        public List<Product> Products { get; set; }
    }
}
