using System.Collections.Generic;

namespace JustWcfServiceCalc
{
    internal class User
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public string Token { get; set; }
    }

    internal class MySecretDatabase
    {
        private List<User> _users = new List<User>
        {
            new User 
            {
                Name = "Antony",
                Login = "admin",
                PasswordHash = SecurePasswordHasher.Hash("admin")
            },
        };

        public User GetUserByLogin(string login)
        {
            return _users.Find(x => x.Login == login);
        }
    }
}
