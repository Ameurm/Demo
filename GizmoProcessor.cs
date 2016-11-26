using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjections
{
    class GizmoProcessor
    {
        //public void Process()
        //{
        //    // do something
        // //   var logger = new TextLogger();
        //   // logger.WriteLogMessage("Something happened");
        //}

        //Constructor Injection 
        private readonly ILogger _logger;
        public GizmoProcessor(ILogger logger)
        {
            _logger = logger;
        }

        public void Process()
        {
            // do something
            _logger.WriteLogMessage("Something happened");
        }


    }
    public class TextLogger : ILogger
    {
        public void WriteLogMessage(string Message)
        {
        }
    }

}
