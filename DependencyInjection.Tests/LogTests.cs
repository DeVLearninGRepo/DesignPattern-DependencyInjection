using System;
using System.Diagnostics;
using DependencyInjection.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DependencyInjection.Tests
{
    [TestClass]
    public class UnitTest
    {
        private ILogger _logger;

        [TestInitialize]
        public void Initialize()
        {
            Dependency.Configure();

            _logger = Dependency.Container.GetInstance<ILogger>();
        }


        [TestMethod]
        public void TestCalculator()
        {
            var calculatorInstance = Dependency.Container.GetInstance<Calculator>();

            calculatorInstance.SumInt(1, 2);
            calculatorInstance.SumInt(201, 2);
        }

        [TestMethod]
        public void TestApi()
        {

            var apiServiceInstance = Dependency.Container.GetInstance<IApiService>();

            var customer = apiServiceInstance.GetCustomer(2);


            if (customer != null)
            {
                _logger.LogInfo($"  - found customer {customer.Id} - {customer.Name} {customer.Surname}");
            }
            else
            {
                _logger.LogError($"  - customer not found");
            }
        }
    }
}
