using ASP_WEB_app_MVC_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace ASP_WEB_app_MVC_1.Controllers
{
    public class ProductController : Controller
    {
        
        private readonly ProductStrorage _productStrorage;


        public ProductController()
        {
            
            _productStrorage = new ProductStrorage();
        }
        public string Index(int first)
        {
            if (first == null)
            {
                return "Id null error";
            }

            return _productStrorage.GetProduct(first);

        }
    }
}
