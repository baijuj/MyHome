using MyHome.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHome.Service
{
    public interface IAuthService
    {
        Task<TokenResponse> Authenticate(string username, string password);
        Task<bool> SaveRefreshToken(User user, string refreshToken);
        Task<User> GetUserByUsername(string username);
    }
}
