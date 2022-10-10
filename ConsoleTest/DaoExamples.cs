using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao;
using Model;

namespace ConsoleTest
{
    public class DaoExamples : AbstractExamples
    {
        private IExoplanetsDao planetsDao = new ExoplanetDaoCsv();
        private IPrinter<Planet> printer = ConsolePrinter<Planet>.GetInstance();
        public DaoExamples()
        {
            Test01();
            Break();
            Test02();
            Break();
        }

        void Test01()
        {
            var planets = planetsDao.SelectAll();
            printer.Print(planets);
            Console.WriteLine("(Total: " + planets.Count + ")");
        }

        void Test02()
        {
            Console.WriteLine("### Select By Key Results: ");
            var planets = planetsDao.SelectByKey("pl_name", "16 Cyg B b");
            printer.Print(planets);
            
        }

        
    }
}
