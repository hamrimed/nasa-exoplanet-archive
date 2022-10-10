using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao;
using Buisness;
using Model;
using System.Diagnostics;
using System.Collections;

namespace ConsoleTest
{
    public class BuisnessExamples : AbstractExamples
    {
        private IExoplanetsService exoplanetService;
        private IPrinter<Planet> printer = ConsolePrinter<Planet>.GetInstance();
        public BuisnessExamples()
        {
            Wiring();
            Test00();
            Break();
            Test02();
            Test03();
        }

        private void Wiring()
        {
            IExoplanetsDao dao = new ExoplanetDaoCsv();
            IExoplanetsService service = new ExoplanetsService(dao);
            exoplanetService = new ExoplanetServiceProxy(service);
        }

        void Test00()
        {
            var planet = exoplanetService.GetPlanetById(2);
            Console.WriteLine(planet);
            foreach (DictionaryEntry e in planet.Details)
            {
                Console.WriteLine(" - " + e.Key + ": " + e.Value);
            }
            Console.ReadLine();
        }

        void Test01()
        {
            var insatnce = Stopwatch.StartNew();
            var planets = exoplanetService.GetPlanets();
            insatnce.Stop();
            Console.WriteLine(">>" + planets.Count + " rows found in " + insatnce.ElapsedMilliseconds + "ms.");
        }

        void Test02()
        {
            
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Iteration: " + i);
                Test01();
            }
        }

        void Test03()
        {
            var planets = exoplanetService.GetPlanets();
            printer.Print(planets);
        }
    }
}
