using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjections
{
    public interface ILogger
    {
        void WriteLogMessage(string Message);
    }
}
