using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Dao
{
    public class PlanetMapper
    {
        private PlanetMapper()
        {
        }
        public static Planet WithoutDetails(string[] row)
        {
            return Planet.Builder()
                .PlanetName(row[0])
                .HostName(row[1])
                .DefaultParameterSet(ToInt(row[2]))
                .StartsNumber(ToInt(row[3]))
                .PlanetsNumber(ToInt(row[4]))
                .DiscoveryMethod(row[5])
                .DiscoveryYear(ToInt(row[6]))
                .DiscoveryFacility(row[7])
                .SolutionType(row[8])
                .Build();

        }

        public static Planet WithDetails(string[] row, string[] cols)
        {
            Planet planet = WithoutDetails(row);
            for(int i = 0; i<cols.Length-9; i++)
            {
                planet.Details.Add(cols[i], row[i]);
            }
            return planet;
        }

        private static long ToLong(string str, long defaultValue = -1)
        {
            long value = 0;
            return long.TryParse(str, out value)? value : defaultValue;
        }

        private static int ToInt(string str, int defaultValue = -1)
        {
            int value = 0;
            return int.TryParse(str, out value) ? value : defaultValue;
        }
    }
}
