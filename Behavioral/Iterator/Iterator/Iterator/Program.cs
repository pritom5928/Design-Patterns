using Iterator.Collection_Implementations;
using Iterator.Element;
using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build a collection
            ConcreteCollection collection = new ConcreteCollection();
            collection.AddEmployee(new Employee("Pritom", 100));
            collection.AddEmployee(new Employee("Jugal", 101));
            collection.AddEmployee(new Employee("Pinke", 102));
            collection.AddEmployee(new Employee("Bijoy", 103));
            collection.AddEmployee(new Employee("Swadeshi", 104));
            collection.AddEmployee(new Employee("Niva", 105));

            // Create iterator
            Iterator.Iterator_Implementations.Iterator iterator = collection.CreateIterator();
            //looping iterator      
            Console.WriteLine("Iterating over collection:");

            for (Employee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
            {
                Console.WriteLine($"ID : {emp.ID} & Name : {emp.Name}");
            }
            Console.Read();
        }
    }
}
