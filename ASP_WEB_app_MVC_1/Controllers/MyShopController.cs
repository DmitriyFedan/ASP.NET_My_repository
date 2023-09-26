using ASP_WEB_app_MVC_1.Models;
using ASP_WEB_app_MVC_1.Models.Storages;
using ASP_WEB_app_MVC_1.Models.ViewModels;
using ASP_WEB_app_MVC_1.Services.Interfaces;
using ASP_WEB_app_MVC_1.Services.Storages;
using Microsoft.AspNetCore.Mvc;

namespace ASP_WEB_app_MVC_1.Controllers
{
    public class MyShopController : Controller
    {
        private readonly IProductStorage _productStrorage;

        private readonly User _user;

        private readonly ShopModel _shopModel;

        private readonly IUserStorage _userStorage;


        public MyShopController(IProductStorage productStorage, IUserStorage userStorage)
        {
            _productStrorage = productStorage;

            //TODO hardcoded user
            //implement user registration and authorization and their transfer to the controller
            _userStorage = userStorage;

            _user = _userStorage.GetAdminUser();

            _shopModel = new ShopModel(_productStrorage, _user);
        }

        public IActionResult AllProducts()
        {   
            return View(_shopModel);
        }

        public IActionResult CurrentProduct(int first)
        {
            Product model = _productStrorage.GetProductById(first);
            
            return View(model);
        }
    }
}
