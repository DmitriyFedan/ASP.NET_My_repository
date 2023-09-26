using ASP_WEB_app_MVC_1.Models;

namespace ASP_WEB_app_MVC_1.Services.Storages
{
    public interface IBasketStorage
    {
        Basket TryGetBasketById(int userId);

    }
}