﻿using Iterator.Collection_Implementations;
using Iterator.Element;
using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build a collection
            ConcreteCollection<Employee> empCollection = new ConcreteCollection<Employee>();
            empCollection.AddElement(new Employee("Pritom", 100));
            empCollection.AddElement(new Employee("Jugal", 101));
            empCollection.AddElement(new Employee("Pinke", 102));
            empCollection.AddElement(new Employee("Bijoy", 103));
            empCollection.AddElement(new Employee("Swadeshi", 104));
            empCollection.AddElement(new Employee("Niva", 105));

            // Create iterator
            Iterator.Iterator_Implementations.Iterator<Employee> iterator = empCollection.CreateIterator();

            //looping iterator      
            Console.WriteLine("Iterating over employee collection:");
            for (Employee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
            {
                Console.WriteLine($"ID : {emp.ID} & Name : {emp.Name}");
            }
            Console.WriteLine();


            ConcreteCollection<Student> stuCollection = new ConcreteCollection<Student>();
            stuCollection.AddElement(new Student(1, "Messi", 15));
            stuCollection.AddElement(new Student(2, "Ronaldo", 16));
            stuCollection.AddElement(new Student(3, "Zidan", 17));

            Iterator.Iterator_Implementations.Iterator<Student> stuIterator = stuCollection.CreateIterator();

            //looping iterator      
            Console.WriteLine("Iterating over Student collection:");
            for (Student stu = stuIterator.First(); !stuIterator.IsCompleted; stu = stuIterator.Next())
            {
                Console.WriteLine($"ID : {stu.RollNo} & Name : {stu.Name} is - {stu.Age} years old");
            }
            Console.WriteLine();


            ConcreteCollection<Department> deptCollection = new ConcreteCollection<Department>();
            deptCollection.AddElement(new Department("CSE", 1001));
            deptCollection.AddElement(new Department("BBA", 1002));

            // Create iterator
            Iterator.Iterator_Implementations.Iterator<Department> deptIterator = deptCollection.CreateIterator();

            //looping iterator      
            Console.WriteLine("Iterating over employee collection:");
            for (Department dept = deptIterator.First(); !deptIterator.IsCompleted; dept = deptIterator.Next())
            {
                Console.WriteLine($"ID : {dept.ID} & Name : {dept.Name}");
            }
            Console.WriteLine();

            Console.Read();
        }
    }
}
