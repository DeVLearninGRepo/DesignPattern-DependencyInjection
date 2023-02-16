using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Library
{
    public class Calculator
    {
        private ILogger _logger;

        public Calculator(ILogger logger)
        {
            _logger = logger;
        }

        public int SumInt(int a, int b)
        {
            _logger.LogInfo("Entered method " + typeof(Calculator) + "." + nameof(SumInt));

            if (a > 200)
            {
                _logger.LogError("A is greater than 200");
            }

            return a + b;
        }
    }
}
