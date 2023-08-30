using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ASP_WEB_app_MVC_1.Models
{
    public class ProductStrorage
    {
        private static ProductStrorage instance;

        public List<Product> Products { get; set; }

        private ProductStrorage()
        {
            Products = new List<Product>();

            for(var count=0; count <=10 ; count++)
            {
                Products.Add(new Product());
            }
        }

        public static ProductStrorage GetStorage()
        {
            if (instance == null)
            {
                instance = new ProductStrorage();
            }

            return instance;
        }

        public string GetAllProducts()
        {
            StringBuilder sb = new StringBuilder();
            
            Products.ForEach(p => sb.Append(p.ToString()));

            return sb.ToString();
        }

        public string GetProduct(int id)
        {
            foreach (var product in Products)
            {
                if (product.Id == id)
                {
                    return product.ToString();
                }

                return "Product not defined";
            }

            return Products.FirstOrDefault(p => p.Id.Equals(id)).ToString();
        }
    }
}
