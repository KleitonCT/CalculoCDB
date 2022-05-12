using CalculoCDB.Domain.Request;
using CalculoCDB.Domain.Response;
using CalculoCDB.Services.Interfaces;
using CalculoCDB.Services.Services;
using Newtonsoft.Json;
using NUnit.Framework;

namespace CalculoCDB.Test
{
    [TestFixture]
    public class CalculoCdbServiceTest
    {
        private ICalculoCdbService _mockService;

        [OneTimeSetUp]
        public void SetUp()
        {
            _mockService = new CalculoCdbService();
        }

        [Test]
        public void CalcularCDB_ShouldCalculateCorrectly()
        {
            //Arrange
            var mockRequest = new CalculoCdbRequest { PrazoMeses = 5, ValorInvestimento = 10000M };

            //Act
            var actual = _mockService.CalcularCDB(mockRequest);

            //Assert
            var expected = new CalculoCdbResponse { ResultadoBruto = 10972.0000M, ResultadoLiquido = 8503.3000000M };
            Assert.AreEqual(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(actual));
        }

        [Test]
        public void CalcularCDB_ShouldNotCalculateCorrectly()
        {
            //Arrange
            var mockRequest = new CalculoCdbRequest { PrazoMeses = 5, ValorInvestimento = 1000M };

            //Act
            var actual = _mockService.CalcularCDB(mockRequest);

            //Assert
            var expected = new CalculoCdbResponse { ResultadoBruto = 10972.0000M, ResultadoLiquido = 8503.3000000M };
            Assert.AreNotEqual(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(actual));
        }
    }
}
