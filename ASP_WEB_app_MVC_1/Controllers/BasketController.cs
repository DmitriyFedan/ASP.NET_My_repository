using ASP_WEB_app_MVC_1.Models;
using ASP_WEB_app_MVC_1.Models.Storages;
using Microsoft.AspNetCore.Mvc;

namespace ASP_WEB_app_MVC_1.Controllers
{
    public class BasketController : Controller
    {
        private BasketStorage _basketStorage;

        private ProductStorage _productStorage;

        private UserStorage _userStorage;

        public BasketController() 
        {
            _basketStorage = BasketStorage.GetBasketStorage();
            _productStorage = ProductStorage.GetStorage();
            _userStorage = UserStorage.GetUserStorage();
        }

        public IActionResult UserBasket()
        {
            Basket model = _basketStorage.TryGetBasketById(_userStorage.GetAdminUser().Id);

            return View(model);
        }

        public IActionResult AddProduct(int first)
        {
            var userBasket = _basketStorage.TryGetBasketById(_userStorage.GetAdminUser().Id);  // TODO  hardcoded user id 

            var product = _productStorage.GetProduct(first);
            userBasket.TryAddProduct(product, 1);  // TODO  hardcoded amount 

            return RedirectToAction("AllProducts", "MyShop");

        }
    }
}
