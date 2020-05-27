using BusinessLayer.Interface;
using Microsoft.AspNetCore.Mvc;
using Moq;
using QuantityMeasurementAPI.Controllers;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace QuantityMeasurementAPI.Test.Controller
{
    public class QuantityControllerTest
    {
        private readonly Mock<IQuantityMeasurementBL> mockBL;
        private readonly QuantityController controller;

        public QuantityControllerTest()
        {
            mockBL = new Mock<IQuantityMeasurementBL>();
            controller = new QuantityController(mockBL.Object);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            //Act
            var okResult = controller.GetAllConversions();

            //Assert
            Assert.IsType<OkObjectResult>(okResult);
        }
    }

}
