using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Library
{
    public interface ILogger
    {
        void LogInfo(string info);
        void LogError(string error);
        void LogError(Exception exception);
    }
}
