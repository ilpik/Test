using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskOne
{
    public interface IMessageFormatter
    {
        string FormatMessage(string message, Enum.LogLevel logLevel);
    }
}
