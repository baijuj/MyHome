using MyHome.Data;
using MyHome.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHome.Service
{
    public class AuthService:IAuthService
    {
        private readonly IAuthRepository _authRepository;
        private readonly IJwtService _jwtService;
        public AuthService(IAuthRepository authRepository, IJwtService jwtService)
        {
            _authRepository = authRepository;
            _jwtService = jwtService;
        }
        public async Task<TokenResponse> Authenticate(string username, string password)
        {
            var user = await _authRepository.Authenticate(username, password);

            if (user == null)
            {

                throw new Exception("Invalid username or password.");
            }

            var tokenResponse = await _jwtService.GenerateTokens(user);

            return tokenResponse;
        }

        public Task<User> GetUserByUsername(string username)
        {
            return _authRepository.GetUserByUsername(username);
        }

        public Task<bool> SaveRefreshToken(User user, string refreshToken)
        {
            return _authRepository.SaveRefreshToken(user, refreshToken);
        }
    }
}
