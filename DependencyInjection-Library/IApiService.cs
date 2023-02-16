 using DependencyInjection.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Library
{
    public interface IApiService
    {
        Customer GetCustomer(int id);
    }
}
