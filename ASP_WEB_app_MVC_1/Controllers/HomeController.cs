using ASP_WEB_app_MVC_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;

namespace ASP_WEB_app_MVC_1.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly ProductStrorage _productStrorage;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //_productStrorage = new ProductStrorage();
        }

        public string Index()
        {
            //return _productStrorage.GetProduct(1002);
            //return _productStrorage.GetAllProducts();
            //return View();
            return "HOMe INDEX";
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
    }
}