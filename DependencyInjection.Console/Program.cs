using DependencyInjection.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Console
{
    class Program
    {
        private static ILogger _logger;

        static void Main(string[] args)
        {
            Dependency.Configure();

            _logger = Dependency.Container.GetInstance<ILogger>();

            var calculatorInstance = Dependency.Container.GetInstance<Calculator>();

            calculatorInstance.SumInt(1, 2);
            calculatorInstance.SumInt(201, 2);

            System.Console.ReadKey();


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

            System.Console.ReadKey();
        }
    }
}
