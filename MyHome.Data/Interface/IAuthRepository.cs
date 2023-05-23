using MyHome.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHome.Data
{
    public interface IAuthRepository
    {
        Task<User> Authenticate(string userName, string password);
        Task<bool> SaveRefreshToken(User user, string refreshToken);
        Task<User> GetUserByUsername(string username);
    }
}
