using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Library
{
    public interface ITraceLogger
    {
        void LogInfo(string info);
    }

    public class TraceLogger : ITraceLogger
    {
        public void LogInfo(string info)
        {
            Trace.TraceInformation(info);
        }
    }


    //public class TraceLogger
    //{
    //    public void LogInfo(string info)
    //    {
    //        Trace.TraceInformation(info);
    //    }
    //}

    public class ApiService
    {
        public ApiService()
        {

        }

        public void Register(ITraceLogger logger)
        {
            
        }
    }


    //public class ApiService
    //{
    //    private TraceLogger _logger;

    //    public ApiService(TraceLogger logger)
    //    {
    //        _logger = logger;
    //    }
    //}

    public class ApiService
    {
        private ITraceLogger _logger;

        public ApiService(ITraceLogger logger)
        {
            _logger = logger;
        }
    }
}
