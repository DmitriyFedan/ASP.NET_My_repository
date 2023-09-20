using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ASP_WEB_app_MVC_1.Models
{
    public class Product
    {
        static int uniqueId = 1000;
        private int _id;
        private string _name;
        private decimal _cost;
        private string _description;

        public string Name  => _name;

        public decimal Cost => _cost;

        public string Description => _description;

        public int Id 
        {
            get => _id;
        }

        public Product()
        {
            _id = uniqueId;
            _name = "Product " + uniqueId.ToString();
            _cost = new Random().Next(100, 1000);
            _description = $"Description bla bla bla {uniqueId}";
            uniqueId++;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine();
            sb.Append(_id.ToString());
            sb.AppendLine();
            sb.Append(_name);
            sb.AppendLine();
            sb.Append(_cost.ToString());
            sb.AppendLine();
            sb.Append(_description);
            sb.AppendLine();
            

            return sb.ToString();
        }
    }
}
