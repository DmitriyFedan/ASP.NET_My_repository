using ASP_WEB_app_MVC_1.Models;
using ASP_WEB_app_MVC_1.Models.Storages;
using ASP_WEB_app_MVC_1.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace ASP_WEB_app_MVC_1.Controllers
{
    public class MyShopController : Controller
    {
        private readonly ProductStorage _productStrorage;

        private readonly User _user;

        private readonly ShopModel _shopModel;

        private readonly UserStorage _userStorage;


        public MyShopController()
        {
            _productStrorage = ProductStorage.GetStorage();

            //TODO hardcoded user
            //implement user registration and authorization and their transfer to the controller
            _userStorage = UserStorage.GetUserStorage();

            _user = _userStorage.GetAdminUser();

            _shopModel = new ShopModel(_productStrorage, _user);
        }

        public IActionResult AllProducts()
        {   
            return View(_shopModel);
        }

        public IActionResult CurrentProduct(int first)
        {
            Product model = _productStrorage.GetProduct(first);
            
            return View(model);
        }
    }
}
