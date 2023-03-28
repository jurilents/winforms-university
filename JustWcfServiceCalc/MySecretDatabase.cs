using System.Collections.Generic;
using System.Linq;

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
        public static MySecretDatabase Instance = new MySecretDatabase();

        private List<User> _users = new List<User>
        {
            new User 
            {
                Name = "Antony",
                Login = "admin",
                PasswordHash = SecurePasswordHasher.Hash("admin")
            },
            new User
            {
                Name = "Yurii (MIT-41)",
                Login = "juri",
                PasswordHash = SecurePasswordHasher.Hash("1234")
            },
        };

        public User GetUserByLogin(string login)
        {
            return _users.Find(x => x.Login == login);
        }

        public bool CheckToken(string token)
        {
            return !string.IsNullOrEmpty(token) 
                && _users.Any(x => x.Token == token);
        }
    }
}
