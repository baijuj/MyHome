using Microsoft.AspNetCore.Mvc;
using Moq;
using MyHome.API.Controllers;
using MyHome.Domain;
using MyHome.Service;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHome.Test

{
    public class AuthControllerTests
    {
        private Mock<IAuthService> _mockAuthService;
        private AuthController _controller;

        [SetUp]
        public void Setup()
        {
            _mockAuthService = new Mock<IAuthService>();
            _controller = new AuthController(_mockAuthService.Object);
        }

        [Test]
        public async Task Login_WithValidCredentials_ShouldReturnOk()
        {
            // Arrange
            var username = "testUser";
            var password = "testPassword";
            var expectedTokenResponse = new TokenResponse
            {
                JwtToken = "validToken",
            };

            _mockAuthService.Setup(service => service.Authenticate(username, password))
                .ReturnsAsync(expectedTokenResponse);

            // Act
            var result = await _controller.Login(username, password);

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result);
            Assert.AreEqual(expectedTokenResponse, ((OkObjectResult)result).Value);
        }

        [Test]
        public async Task Login_WithInvalidCredentials_ShouldReturnUnauthorized()
        {
            // Arrange
            var username = "testUser";
            var password = "wrongPassword";

            _mockAuthService.Setup(service => service.Authenticate(username, password))
                .ReturnsAsync((TokenResponse)null);

            // Act
            var result = await _controller.Login(username, password);

            // Assert
            Assert.IsInstanceOf<UnauthorizedResult>(result);
        }
    }
}
