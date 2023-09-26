using ASP_WEB_app_MVC_1.Models;

namespace ASP_WEB_app_MVC_1.Services.Storages
{
    public class UserStorage : IUserStorage
    {
        private static List<User> _users;

        public UserStorage()
        {
            _users = new List<User>
            {
                new User("Admin", "dmitry061093@mail.ru", "+79521758954")
            };
        }

        public User GetAdminUser()
        {
            if (_users != null)
            {
                return _users.FirstOrDefault(u => u.Name == "Admin");
            }

            return new User("Admin", "dmitry061093@mail.ru", "+79521758954");   //todo  delete this 
        }
    }
}
