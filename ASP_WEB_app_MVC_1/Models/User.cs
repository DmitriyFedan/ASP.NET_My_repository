namespace ASP_WEB_app_MVC_1.Models
{
    public class User
    {
        private static int _uniqueId = 1000;
        public int Id { get; }
        public string Name { get; }
        public string Email { get; }
        public string Phone { get; }
        public Basket Basket { get; }


        public User (string name, string email, string phone)
        {
            Id = _uniqueId;
            Name = name;
            Email = email;
            Phone = phone;
            Basket = new Basket(Id);

            _uniqueId += 1;     
        }
    }
}
