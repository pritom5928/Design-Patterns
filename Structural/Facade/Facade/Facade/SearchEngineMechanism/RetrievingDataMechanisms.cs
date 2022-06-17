using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.SearchEngineMechanism
{
    public class RetrievingDataMechanisms
    {
        public void GetData(int[] indexes)
        {
            Console.WriteLine("Downloading data with indexes : ");
            foreach (var index in indexes)
            {
                Console.Write(index + ", ");
            }
            Console.WriteLine();
        }
    }
}
