using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskOne
{
    public interface ILogWriter
    {
        public void LogInfo(string message);
        public void LogWarning(string message);
        public void LogError(string message);
    }
}
