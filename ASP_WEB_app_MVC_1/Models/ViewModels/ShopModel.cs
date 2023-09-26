using ASP_WEB_app_MVC_1.Services.Interfaces;


namespace ASP_WEB_app_MVC_1.Models.ViewModels
{
    public class ShopModel
    {
        public IProductStorage ProductStorage { get; }

        public User User { get; }

        public ShopModel(IProductStorage productStorage, User user)
        {
            ProductStorage = productStorage;
            User = user;
        }
    }
}
