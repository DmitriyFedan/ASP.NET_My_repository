using ASP_WEB_app_MVC_1.Models.ViewModels;
using ASP_WEB_app_MVC_1.Models.Storages;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace ASP_WEB_app_MVC_1.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly ProductStorage _productStrorage;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _productStrorage = ProductStorage.GetStorage();
        }

        public IActionResult Index()
        {
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
    }
}