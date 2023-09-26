using ASP_WEB_app_MVC_1.Services.Interfaces;
using System.Text;

namespace ASP_WEB_app_MVC_1.Models.Storages
{
    public class ProductStorageService : IProductStorage
    {
        public List<Product> Products { get; }

        public ProductStorageService()
        {
            Products = new List<Product>();

            for (var count = 0; count <= 10; count++)
            {
                Products.Add(new Product());
            }
        }


        // Todo  remove this method (newer used)
        public string GetAllProducts()
        {
            StringBuilder sb = new StringBuilder();

            Products.ForEach(p => sb.Append(p.ToString()));

            return sb.ToString();
        }

        public List<Product> GetProductsCollection()
        {
            return Products;
        }

        public Product GetProductById(int id)
        {
            return Products.FirstOrDefault(p => p.Id.Equals(id));
        }
    }
}
