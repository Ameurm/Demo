using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjections
{
    class Program
    {
        static void Main(string[] args)
        {
            //var processor = new GizmoProcessor();
            //processor.Process();
            var processor = new GizmoProcessor(new TextLogger());
        }
    }
}
