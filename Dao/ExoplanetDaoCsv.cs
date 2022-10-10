using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class ExoplanetDaoCsv : IExoplanetsDao
    {
        public CsvParser Parser { get; set; } = new CsvParser();

        public ExoplanetDaoCsv()
        {
        }

        public ExoplanetDaoCsv(string source)
        {
            Parser = new CsvParser(source);
        }
        public ICollection<Planet> SelectAll()
        {
            ICollection<Planet> planets = new List<Planet>();
            ICollection<string[]> rows = Parser.Rows();
            for (int i = 1; i < rows.Count; i++)
            {
                planets.Add(PlanetMapper.WithDetails(rows.ElementAt(i), rows.ElementAt(0)));
            }
            return planets;
        }

        public ICollection<Planet> SelectByKey(string key, object value)
        {
            var rows = Parser.Rows();
            int keyIndex = -1;
            if(rows != null)
            {
                ICollection<Planet> planets = new List<Planet>();
                string[] cols = rows.ElementAt(0);
                for(int i = 0; i<cols.Length; i++)
                {
                    if (cols[i] == key)
                    {
                        keyIndex = i;
                        break;
                    }
                }
                if (keyIndex != -1)
                {
                    for(int i = 1; i<rows.Count; i++)
                    {
                        string[] row = rows.ElementAt(i);
                        if (row[keyIndex] == (string)value)
                        {
                            planets.Add(PlanetMapper.WithoutDetails(row));
                        }
                    }
                    return planets;
                }
            }
            return null;
        }
    }
}
