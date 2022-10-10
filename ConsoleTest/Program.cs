using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao;
namespace ConsoleTest
{
    public class Program
    {
        public Program()
        {
            Run();
        }
        void Run()
        {
            new DaoExamples();
            new BuisnessExamples();
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            new Program();
        }

    }
}
