using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ASP_WEB_app_MVC_1.Models.Storages
{
    public class ProductStorage
    {
        private static ProductStorage instance;

        public List<Product> Products { get; set; }

        private ProductStorage()
        {
            Products = new List<Product>();

            for (var count = 0; count <= 10; count++)
            {
                Products.Add(new Product());
            }
        }

        public static ProductStorage GetStorage()
        {
            if (instance == null)
            {
                instance = new ProductStorage();
            }

            return instance;
        }

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

        public Product GetProduct(int id)
        {
            return Products.FirstOrDefault(p => p.Id.Equals(id));
        }
    }
}
