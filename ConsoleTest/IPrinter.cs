using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    public interface IPrinter<T>
    {
        void Print(ICollection<T> model);
    }
}
