using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Data;
namespace Dao
{
    public class CsvParser
    {
        public string Source { get; set; } = @"C:\Users\simof\Documents\open-source\nasa-exoplanet-archive\NasaExoplanetArchive\Dao\Resources\Data\PS.csv";
        public char CommentToken { get; set; } = '#';
        public char Delimiter { get; set; } = ',';

        public CsvParser()
        {
        }

        public CsvParser(String source)
        {
            Source = source;
        }

        public ICollection<string[]> Rows()
        {
            ICollection<string[]> rows = new List<string[]>();
            StreamReader streamReader = new StreamReader(Source);
            while(!streamReader.EndOfStream)
            {
                String row = streamReader.ReadLine();
                if (!row.StartsWith(CommentToken.ToString()))
                {
                    rows.Add(row.Split(Delimiter));
                }
            }
            streamReader.Close();
            return rows;
        }
    }
}
