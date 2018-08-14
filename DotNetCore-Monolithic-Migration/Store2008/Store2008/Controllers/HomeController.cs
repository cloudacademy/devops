using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using ShoppingService;
using AccountService;
using InventoryService;

using Store2008.Models;

namespace Store2008.Controllers
{
    public class HomeController : Controller
    {
        private static AccountSvc AccountServices = new AccountSvc();
        private static InventorySvc InventoryServices = new InventorySvc();
        private static ShoppingSvc ShoppingServices = new ShoppingSvc();

        public ActionResult Index()
        {
            var commercemodel = new CommerceModel()
            {
                User = AccountServices.GetConsumerById(1),
                Products = InventoryServices.GetProducts(),
                Cart = ShoppingServices.GetCart(30)
            };

            return View(commercemodel);
        }

        public ActionResult About()
        {
            var commercemodel = new CommerceModel()
            {
                User = AccountServices.GetConsumerById(1),
                Products = InventoryServices.GetProducts()
            };

            return View(commercemodel);
        }
    }
}
