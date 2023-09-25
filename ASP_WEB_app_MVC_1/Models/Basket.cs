using System.Reflection.Metadata.Ecma335;

namespace ASP_WEB_app_MVC_1.Models
{
    public class Basket
    {
        public int BasketID { get; }

        public List<Product> Products { get; }

        public decimal BasketTotalPrice => Products.Sum(p => p.SummaryCost);

        public Basket(int basketID)
        {
            BasketID = basketID;
            Products = new List<Product>();
        }

        public decimal GetTotalCost(int basketID)
        {
            return 0;
        }


        public bool TryAddProduct(Product product, int amount) 
        {
            if (product == null)
            {
                return false;
            }

            else
            {
               foreach(Product p in Products) 
               {
                    if(p.Id == product.Id) 
                    {
                        p.AddAmount(amount);

                        return true;
                    }
               }
                
                Products.Add(product);
                product.AddAmount(amount);

                return true;
            }
        }

       
    }
}
