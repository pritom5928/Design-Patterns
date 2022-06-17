using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.SearchEngineMechanism
{
    public class DataIndexers
    {
        public int[] GetIndexesOfStoredData(string query)
        {
            Console.WriteLine($"{query} found at index : 1, 6, 9");

            return new[] { 1, 6, 9 };
        }
    }
}
