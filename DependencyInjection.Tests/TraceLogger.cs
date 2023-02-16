using DependencyInjection.Library;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Tests
{
    public class TraceLogger : ILogger
    {
        public void LogError(string error)
        {
            Trace.TraceError(error);
        }

        public void LogError(Exception exception)
        {
            LogError(exception.Message);
        }

        public void LogInfo(string info)
        {
            Trace.TraceInformation(info);
        }
    }
}
