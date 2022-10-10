using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao;
namespace Buisness
{
    public class ExoplanetsService : IExoplanetsService
    {
        public IExoplanetsDao ExoplanetsDao { get; set; }

        public ExoplanetsService() : this(new ExoplanetDaoCsv())
        {
        }
        public ExoplanetsService(IExoplanetsDao exoplanetsDao)
        {
            ExoplanetsDao = exoplanetsDao;
        }

        public Planet GetPlanetById(long id)
        {
            ICollection<Planet> planets = GetPlanets();
            foreach(Planet planet in planets)
            {
                if (planet.Id == id) return planet; 
            }
            return null;
        }
        public ICollection<Planet> GetPlanets()
        {
            return ExoplanetsDao.SelectAll();
        }

        public ICollection<Planet> GetPlanetsByName(string name)
        {
            return ExoplanetsDao.SelectByKey("pl_name", name);
        }
    }
}
