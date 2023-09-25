namespace ASP_WEB_app_MVC_1.Models.Storages
{
    public class UserStorage
    {
        private static UserStorage _singletone;

        private static List<User> _users;

        private UserStorage()
        {
            _users = new List<User>
            {
                new User("Admin", "dmitry061093@mail.ru", "+79521758954")
            };
        }

        public static UserStorage GetUserStorage()
        {
            if (_singletone == null)
            {
                _singletone = new UserStorage();
            }

            return _singletone;
        }

        public User GetAdminUser()
        {
            if( _users != null)
            {
                return _users.FirstOrDefault(u => u.Name == "Admin");
            }

            return new User("Admin", "dmitry061093@mail.ru", "+79521758954");   //todo  delete this 
        }
    }
}
