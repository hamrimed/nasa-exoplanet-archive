using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Planet
    {
        public long Id { get; set; } = 0;
        public string PlanetName { get; set; } = null;
        public string HostName { get; set; } = null;
        public int DefaultParameterSet { get; set; } = -1;
        public int StartsNumber { get; set; } = -1;
        public int PlanetsNumber { get; set; } = -1;
        public string DiscoveryMethod { get; set; } = null;
        public int DiscoveryYear { get; set; } = -1;
        public string SolutionType { get; set; } = null;
        public string DiscoveryFacility { get; set; } = null;
        public IDictionary Details { get; set; } = new Hashtable();

        public Planet()
        {
        }

        public static PlanetBuilder Builder()
        {
            return new PlanetBuilder();
        }

        public override string ToString()
        {
            return "[" + Id + ", " + PlanetName + ", " + HostName + ", " + DefaultParameterSet + ", " +
                    StartsNumber + ", " + PlanetsNumber + ", " + DiscoveryMethod + ", " + SolutionType +
                    DiscoveryYear + ", " + DiscoveryFacility + ", ( + " + Details.Count + " other details)]";
        }


        public class PlanetBuilder
        {
            private long id;
            private string planetName;
            private string hostName;
            private int defaultParameterSet;
            private int startsNumber;
            private int planetsNumber;
            private string discoveryMethod;
            private int discoveryYear;
            private string solutionType;
            private string discoveryFacility;
            private IDictionary details = new Hashtable();
            public PlanetBuilder Id(long id)
            {
                this.id = id;
                return this;
            }

            public PlanetBuilder PlanetName(string planetName)
            {
                this.planetName = planetName;
                return this;
            }

            public PlanetBuilder HostName(string hostName)
            {
                this.hostName = hostName;
                return this;
            }

            public PlanetBuilder DefaultParameterSet(int defaultParameterSet)
            {
                this.defaultParameterSet = defaultParameterSet;
                return this;
            }

            public PlanetBuilder StartsNumber(int startsNumber)
            {
                this.startsNumber = startsNumber;
                return this;
            }

            public PlanetBuilder PlanetsNumber(int planetsNumber)
            {
                this.planetsNumber = planetsNumber;
                return this;
            }

            public PlanetBuilder DiscoveryMethod(string discoveryMethod)
            {
                this.discoveryMethod = discoveryMethod;
                return this;
            }

            public PlanetBuilder DiscoveryYear(int discoveryYear)
            {
                this.discoveryYear = discoveryYear;
                return this;
            }

            public PlanetBuilder SolutionType(string solutionType)
            {
                this.solutionType = solutionType;
                return this;
            }

            public PlanetBuilder DiscoveryFacility(string discoveryFacility)
            {
                this.discoveryFacility = discoveryFacility;
                return this;
            }

            public PlanetBuilder Details(IDictionary allDetails)
            {
                this.details = allDetails;
                return this;
            }

            public PlanetBuilder AddDetail(string detailName, string detailValue)
            {
                this.details.Add(detailName, detailValue);
                return this;
            }

            public Planet Build()
            {
                Planet planet = new Planet
                {
                    Id = id,
                    PlanetName = planetName,
                    HostName = hostName,
                    DefaultParameterSet = defaultParameterSet,
                    StartsNumber = startsNumber,
                    PlanetsNumber = planetsNumber,
                    DiscoveryMethod = discoveryMethod,
                    DiscoveryYear = discoveryYear,
                    SolutionType = solutionType,
                    DiscoveryFacility = discoveryFacility,
                    Details = details
                };
                return planet;
            }

        }
    }
}
