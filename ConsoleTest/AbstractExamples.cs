using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    public abstract class AbstractExamples
    {
        public void Break()
        {
            Console.WriteLine("################################################################");
            Console.WriteLine("> To continue press any key..");
            Console.ReadLine();
        }
    }
}
