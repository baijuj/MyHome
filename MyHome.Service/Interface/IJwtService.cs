using MyHome.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHome.Service
{
    public  interface IJwtService
    {
        Task<TokenResponse> GenerateTokens(User user);
    }
}
