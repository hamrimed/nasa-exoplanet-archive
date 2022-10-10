using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Buisness
{
    public interface IExoplanetsService
    {
        Planet GetPlanetById(long id);
        ICollection<Planet> GetPlanets();
        ICollection<Planet> GetPlanetsByName(string name);
    }
}
