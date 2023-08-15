using Apcef.Domain.Abstractions.Repository.General;
using Apcef.Domain.Arguments.Request;

namespace Apcef.Infrastructure.Repositories.General
{
    public class AuthRepository : IAuthRepository
    {
        private List<Login> logins = new List<Login>()
        {
            new Login
            {
                Username = "admin",
                Password = "abc123"
            },
            new Login
            {
                Username = "apcef_user",
                Password = "dnCwvW72MK"
            }
        };


        public Guid? GenerateAccessToken(Login login, CancellationToken cancellationToken)
        {
            if(!ValidateUser(login))
            {
                return null;
            }

            var generatedToken = Guid.NewGuid();
            TokensRepository.tokens.Add(generatedToken);

            return generatedToken;
        }

        private bool ValidateUser(Login login)
        {
            foreach(var _login in logins)
            {
                if(_login.Username == login.Username && _login.Password == login.Password)
                {
                    return true;
                }
            }
            return false;
        }


    }
}
