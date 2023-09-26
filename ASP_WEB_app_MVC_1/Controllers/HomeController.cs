using ASP_WEB_app_MVC_1.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ASP_WEB_app_MVC_1.Services.Interfaces;

namespace ASP_WEB_app_MVC_1.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly IProductStorage _productStrorage;

        public HomeController(ILogger<HomeController> logger, IProductStorage productStorage)
        {
            _logger = logger;
            _productStrorage = productStorage;
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