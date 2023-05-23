using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using MyHome.API.Controllers;
using MyHome.Domain;
using MyHome.Service;
using MyHome.Shared.Dtos;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHome.Test
{
    public class PropertyControllerTests
    {
        private Mock<IPropertyService> _propertyServiceMock;
        private Mock<IMapper> _mapperMock;
        private Mock<ILogger<PropertyController>> _loggerMock;

        [SetUp]
        public void Setup()
        {
            _propertyServiceMock = new Mock<IPropertyService>();
            _mapperMock = new Mock<IMapper>();
            _loggerMock = new Mock<ILogger<PropertyController>>();
        }

        [Test]
        public async Task GetProperties_ReturnsOkObjectResult_WhenPropertiesExist()
        {
            // Arrange
            _propertyServiceMock.Setup(s => s.GetAllAsync(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<int>()))
                                .ReturnsAsync(new List<Property>());

            var controller = new PropertyController(_propertyServiceMock.Object, _mapperMock.Object, _loggerMock.Object);

            // Act
            var result = await controller.Get();

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result);
        }

        [Test]
        public async Task GetPropertyById_ReturnsOkObjectResult_WhenPropertyExists()
        {
            // Arrange
            _propertyServiceMock.Setup(s => s.GetByIdAsync(It.IsAny<int>()))
                                .ReturnsAsync(new Property());

            var controller = new PropertyController(_propertyServiceMock.Object, _mapperMock.Object, _loggerMock.Object);

            // Act
            var result = await controller.Get(1);

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result);
        }

        [Test]
        public async Task GetPropertyById_ReturnsNotFoundResult_WhenPropertyDoesNotExist()
        {
            // Arrange
            _propertyServiceMock.Setup(s => s.GetByIdAsync(It.IsAny<int>()))
                                .ReturnsAsync((Property)null);

            var controller = new PropertyController(_propertyServiceMock.Object, _mapperMock.Object, _loggerMock.Object);

            // Act
            var result = await controller.Get(1);

            // Assert
            Assert.IsInstanceOf<NotFoundResult>(result);
        }

        [Test]
        public async Task PostProperty_ReturnsCreatedAtActionResult_WhenPropertyIsCreated()
        {
            // Arrange
            _propertyServiceMock.Setup(s => s.CreateAsync(It.IsAny<Property>()))
                                .Callback(() => { });
            _mapperMock.Setup(m => m.Map<Property>(It.IsAny<PropertyDto>()))
                       .Returns(new Property());
            _mapperMock.Setup(m => m.Map<PropertyDto>(It.IsAny<Property>()))
                       .Returns(new PropertyDto());

            var controller = new PropertyController(_propertyServiceMock.Object, _mapperMock.Object, _loggerMock.Object);

            // Act
            var result = await controller.Post(new PropertyDto());

            // Assert
            Assert.IsInstanceOf<CreatedAtActionResult>(result);
        }

        [Test]
        public async Task PutProperty_ReturnsNoContentResult_WhenUpdateIsSuccessful()
        {
            // Arrange
            _propertyServiceMock.Setup(s => s.UpdateAsync(It.IsAny<Property>()))
                                .ReturnsAsync(true);
            _mapperMock.Setup(m => m.Map<Property>(It.IsAny<PropertyDto>()))
                       .Returns(new Property());
            var controller = new PropertyController(_propertyServiceMock.Object, _mapperMock.Object, _loggerMock.Object);

            // Act
            var result = await controller.Put(1, new PropertyDto { Id = 1 });

            // Assert
            Assert.IsInstanceOf<NoContentResult>(result);
        }

        [Test]
        public async Task PutProperty_ReturnsNotFoundObjectResult_WhenUpdateIsUnsuccessful()
        {
            // Arrange
            _propertyServiceMock.Setup(s => s.UpdateAsync(It.IsAny<Property>()))
                                .ReturnsAsync(false);
            _mapperMock.Setup(m => m.Map<Property>(It.IsAny<PropertyDto>()))
                       .Returns(new Property());

            var controller = new PropertyController(_propertyServiceMock.Object, _mapperMock.Object, _loggerMock.Object);

            // Act
            var result = await controller.Put(1, new PropertyDto { Id = 1 });

            // Assert
            Assert.IsInstanceOf<NotFoundObjectResult>(result);
        }

        [Test]
        public async Task DeleteProperty_ReturnsNoContentResult_WhenDeletionIsSuccessful()
        {
            // Arrange
            _propertyServiceMock.Setup(s => s.DeleteAsync(It.IsAny<int>()))
                                .ReturnsAsync(true);

            var controller = new PropertyController(_propertyServiceMock.Object, _mapperMock.Object, _loggerMock.Object);

            // Act
            var result = await controller.Delete(1);

            // Assert
            Assert.IsInstanceOf<NoContentResult>(result);
        }

        [Test]
        public async Task DeleteProperty_ReturnsNotFoundObjectResult_WhenDeletionIsUnsuccessful()
        {
            // Arrange
            _propertyServiceMock.Setup(s => s.DeleteAsync(It.IsAny<int>()))
                                .ReturnsAsync(false);

            var controller = new PropertyController(_propertyServiceMock.Object, _mapperMock.Object, _loggerMock.Object);

            // Act
            var result = await controller.Delete(1);

            // Assert
            Assert.IsInstanceOf<NotFoundObjectResult>(result);
        }
    }
}
