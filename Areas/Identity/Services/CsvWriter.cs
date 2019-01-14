using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.Areas.Identity.Services
{
    public interface ICsvWriter
    {
        string Write(List<string> columns, List<List<string>> rows);

    }
    public class CsvWriter : ICsvWriter
    {

        public string Write(List<string> columns, List<List<string>> rows)
        {
            string output = string.Empty;
            output = string.Join(',', columns);
            foreach (var row in rows)
            {
                output += string.Join(',', row);
            }
            return output;
        }
    }
}
