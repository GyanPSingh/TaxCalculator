using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text;
namespace ACMEBusiness
{
    public class CSVFileReader
    {
       
        public List<Employee> readFromFile(String fileName)
        {
            try
            {
                List<Employee> values = File.ReadAllLines(fileName)
                                                         .Skip(1)
                                                         .Select(v => Employee.FromCsv(v))
                                                         .ToList();
                return values;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}