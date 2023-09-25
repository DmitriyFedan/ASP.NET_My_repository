using System.Reflection.Metadata.Ecma335;

namespace ASP_WEB_app_MVC_1.Models.Storages
{
    public class BasketStorage
    {
        private static BasketStorage _singletone;

        private List<Basket> _allBaskets;


        private BasketStorage()
        {
            _allBaskets = new List<Basket>();

        }
       
        public static BasketStorage GetBasketStorage()
        {
            if (_singletone == null)
            {
                _singletone = new BasketStorage();
            }

            return _singletone;
        }

        public Basket TryGetBasketById(int userId)
        {
            var result = _allBaskets.FirstOrDefault(b => b.BasketID == userId);

            if (result == null) 
            {
                result = new Basket(userId);
                _allBaskets.Add(result);
            }

            return result;
        }
    }
}