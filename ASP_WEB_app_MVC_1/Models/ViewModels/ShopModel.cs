using ASP_WEB_app_MVC_1.Models.Storages;

namespace ASP_WEB_app_MVC_1.Models.ViewModels
{
    public class ShopModel
    {
        public ProductStorage ProductStorage { get; }

        public User User { get; }

        public ShopModel(ProductStorage productStorage, User user)
        {
            ProductStorage = productStorage;
            User = user;
        }
    }
}
