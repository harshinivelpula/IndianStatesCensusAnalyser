using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyser
{
    public class CSVStateCode
    {
        public void ReadStateCodeData(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<StateCodeData>().ToList();
                foreach (var data in records)
                {
                    Console.WriteLine(data.SrNo+" " +data.StateName+" "+data.TIN+" "+data.StateCode+" ");
                }
            }
        }
    }
}
