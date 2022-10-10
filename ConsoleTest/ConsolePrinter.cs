using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    public class ConsolePrinter<T> : IPrinter<T>
    {
        private static IPrinter<T> INSTANCE = new ConsolePrinter<T>();
        private ConsolePrinter()
        {
        }
        public void Print(ICollection<T> model)
        {
            StringBuilder text = new StringBuilder("{");
            text.Append("\n");
            foreach(T element in model)
            {
                text.Append("\t");
                text.Append(element.ToString() + ",\n");
            }
            text.Append("}");
            Console.WriteLine(text.ToString());
        }

        public static IPrinter<T> GetInstance()
        {
            return INSTANCE;
        }
    }
}
