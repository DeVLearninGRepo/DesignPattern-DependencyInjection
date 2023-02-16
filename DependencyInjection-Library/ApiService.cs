using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DependencyInjection.Library.Entities;

namespace DependencyInjection.Library
{
    public class ApiService : IApiService
    {
        private ILogger _logger;

        private List<Customer> _customers;

        public ApiService(ILogger logger)
        {
            _logger = logger;
            _customers = new List<Customer>();

            Init();
        }

        private void Init()
        {
            _logger.LogInfo("Entered method " + typeof(ApiService) + "." + nameof(Init));

            XDocument xDoc = XDocument.Load("Data/data.xml");
            XElement xRoot = xDoc.Root;

            _customers = (from c in xRoot.Descendants("customer")
                          select new Customer
                          {
                              Id = Convert.ToInt32(c.Attribute("id").Value),
                              Name = c.Attribute("name").Value,
                              Surname = c.Attribute("surname").Value
                          }).ToList();
        }

        public Customer GetCustomer(int id)
        {
            _logger.LogInfo("Entered method " + typeof(ApiService) + "." + nameof(GetCustomer));

            return _customers.FirstOrDefault(x => x.Id == id);
        }
    }
}
