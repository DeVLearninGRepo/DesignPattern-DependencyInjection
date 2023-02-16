using DependencyInjection.Library;
using DependencyInjection.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Tests
{
    public class ApiServiceMock : IApiService
    {
        public Customer GetCustomer(int id)
        {
            return new Customer { Id = id, Name = "NameMock", Surname = "SurnameMock" };
        }
    }
}
