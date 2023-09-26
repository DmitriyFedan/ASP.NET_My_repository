using ASP_WEB_app_MVC_1.Models;
using ASP_WEB_app_MVC_1.Services.Interfaces;
using ASP_WEB_app_MVC_1.Services.Storages;
using Microsoft.AspNetCore.Mvc;

namespace ASP_WEB_app_MVC_1.Controllers
{
    public class BasketController : Controller
    {
        private IBasketStorage _basketStorage;

        private IProductStorage _productStorage;

        private IUserStorage _userStorage;

        public BasketController(IProductStorage productStorage,
                                IBasketStorage basketStorage,
                                IUserStorage userStorage) 
        {
            _basketStorage = basketStorage;
            _productStorage = productStorage;
            _userStorage = userStorage;
        }

        public IActionResult UserBasket()
        {
            Basket model = _basketStorage.TryGetBasketById(_userStorage.GetAdminUser().Id);

            return View(model);
        }

        public IActionResult AddProduct(int first)
        {
            var userBasket = _basketStorage.TryGetBasketById(_userStorage.GetAdminUser().Id);  // TODO  hardcoded user id 

            var product = _productStorage.GetProductById(first);
            userBasket.TryAddProduct(product, 1);  // TODO  hardcoded amount 

            return RedirectToAction("AllProducts", "MyShop");

        }
    }
}
