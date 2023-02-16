using DependencyInjection.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Console
{
    public static class Dependency
    {
        public static SimpleInjector.Container Container = new SimpleInjector.Container();

        public static void Configure()
        {
            Container.Register<ILogger, ConsoleLogger>(SimpleInjector.Lifestyle.Transient);
            Container.Register<IApiService, ApiService>(SimpleInjector.Lifestyle.Transient);

            Container.Register<Calculator>(SimpleInjector.Lifestyle.Transient);
        }
    }
}
