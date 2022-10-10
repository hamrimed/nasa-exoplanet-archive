using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Buisness
{
    public class ExoplanetServiceProxy : IExoplanetsService
    {
        private IExoplanetsService exoplanetsService;
        private IDictionary<long, Planet> repository = null;
      
        public ExoplanetServiceProxy() : this(new ExoplanetsService())
        {
        }
        public ExoplanetServiceProxy(IExoplanetsService exoplanetsService)
        {
            this.exoplanetsService = exoplanetsService;
        }

        private ICollection<Planet> Load()
        {
            this.repository = new Dictionary<long, Planet>();
            ICollection<Planet> planets = exoplanetsService.GetPlanets();
            foreach (Planet planet in planets)
            {
                repository.Add(repository.Count, planet);
            }
            return planets;
        }

        public Planet GetPlanetById(long id)
        {
            if (repository == null) Load();
            repository.TryGetValue(id, out Planet planet);
            return planet;
        }
        
        public ICollection<Planet> GetPlanets()
        {
            if(repository == null)
            {
                return Load();
            }
            else
            {
                return repository.Values;
            }
        }

        public ICollection<Planet> GetPlanetsByName(string name)
        {
            ICollection<Planet> planets = null;
            if(repository != null)
            {
                planets = new List<Planet>();
                foreach(Planet p in repository.Values)
                {
                    if (p.PlanetName == name) planets.Add(p);
                }
                return planets;
            }
            
            return exoplanetsService.GetPlanetsByName(name);
        }
    }
}
