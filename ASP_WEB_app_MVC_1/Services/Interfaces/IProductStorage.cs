using ASP_WEB_app_MVC_1.Models;

namespace ASP_WEB_app_MVC_1.Services.Interfaces
{
    public interface IProductStorage
    {
        public List<Product> GetProductsCollection();
        public Product GetProductById(int id);
    }
}
