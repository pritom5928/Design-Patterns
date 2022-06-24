using Iterator.Collection_Interface;
using Iterator.Element;
using System.Collections.Generic;


namespace Iterator.Collection_Implementations
{
    public class ConcreteCollection : AbstractCollection
    {
        private List<Employee> listEmployees = new List<Employee>();
        //Create Iterator
        public Iterator.Iterator_Implementations.Iterator CreateIterator()
        {
            return new Iterator.Iterator_Implementations.Iterator(this);
        }
        // Gets item count
        public int Count
        {
            get { return listEmployees.Count; }
        }
        //Add items to the collection
        public void AddEmployee(Employee employee)
        {
            listEmployees.Add(employee);
        }
        //Get item from collection
        public Employee GetEmployee(int IndexPosition)
        {
            return listEmployees[IndexPosition];
        }

    }
}
