using ASP_WEB_app_MVC_1.Models;

namespace ASP_WEB_app_MVC_1.Services.Storages
{
    public class BasketStorageService : IBasketStorage
    {
        private List<Basket> _allBaskets;

        public BasketStorageService()
        {
            _allBaskets = new List<Basket>();
        }

        public Basket TryGetBasketById(int userId)
        {
            var result = _allBaskets.FirstOrDefault(b => b.BasketID == userId);

            if (result == null)  // TODO //dirty realization. Temporary. redezign this
            {
                result = new Basket(userId);
                _allBaskets.Add(result);
            }

            return result;
        }
    }
}