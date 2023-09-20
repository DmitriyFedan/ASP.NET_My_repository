using ASP_WEB_app_MVC_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace ASP_WEB_app_MVC_1.Controllers
{
    public class ProductController : Controller
    {
        
        private readonly ProductStorage _productStorage;


        public ProductController()
        {
          
            _productStorage = ProductStorage.GetStorage();
        }
        public string Index(int first)
        {
            if (first == null)
            {
                return "Id null error";
            }

            return _productStorage.GetProduct(first).ToString();

        }
    }
}
