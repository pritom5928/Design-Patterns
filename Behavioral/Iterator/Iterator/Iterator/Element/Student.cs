using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Element
{
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(int rollNo, string name, int age)
        {
            RollNo = rollNo;
            Name = name;
            Age = age;
        }
    }
}
