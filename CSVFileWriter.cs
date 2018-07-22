using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ACMEBusiness
{
    public class CSVFileWriter
    {
        public void WriteEmployee<T>(IEnumerable<T> employees, string path)
        {
            var logFile = System.IO.File.Create(path);
            Type itemType = typeof(T);
            var props = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance);            

            using (var writer = new StreamWriter(logFile))
            {
                writer.WriteLine(string.Join(", ", props.Select(p => p.Name)));

                foreach (var item in employees)
                {
                    writer.WriteLine(string.Join(", ", props.Select(p => p.GetValue(item, null))));
                }
            }
        }
    }
}
