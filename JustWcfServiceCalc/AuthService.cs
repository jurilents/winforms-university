using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace JustWcfServiceCalc
{
    public class AuthService : IAuthService
    {
        private readonly MySecretDatabase _database = MySecretDatabase.Instance;


        public UserContract Authenticate(string login, string password)
        {
            var user = _database.GetUserByLogin(login);

            if (user == null)
            {
                return null;
            }

            if (!SecurePasswordHasher.Verify(password, user.PasswordHash))
            {
                return null;
            }

            // Here we are sure that user is valid and we can authorize him
            user.Token = Guid.NewGuid().ToString().ToUpper();

            return new UserContract
            {
                Name = user.Name,
                Token = user.Token,
            };
        }
    }
}
