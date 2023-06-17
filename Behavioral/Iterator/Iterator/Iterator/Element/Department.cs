using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Element
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Department(string name, int id)
        {
            Name = name;
            ID = id;
        }
    }
}
