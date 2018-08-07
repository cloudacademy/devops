using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Store2018.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace Store2018.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();

            var user = new Consumer();
            HttpResponseMessage res1 = await client.GetAsync("http://localhost:5001/api/consumers/5");
            if (res1.IsSuccessStatusCode)
            {
                var result = res1.Content.ReadAsStringAsync().Result;
                user = JsonConvert.DeserializeObject<Consumer>(result);
            }
                
            var products = new List<Product>();
            HttpResponseMessage res2 = await client.GetAsync("http://localhost:5002/api/products");
            if(res2.IsSuccessStatusCode){
                var result = res2.Content.ReadAsStringAsync().Result;
                products = JsonConvert.DeserializeObject<List<Product>>(result);
            }

            var commerce = new Commerce()
            {
                User = user,
                Products = products
            };

            return View(commerce);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult ReactTest(){
            return View();
        }
    }
}
