using Iterator.Collection_Interface;
using Iterator.Element;
using System.Collections.Generic;


namespace Iterator.Collection_Implementations
{
    public class ConcreteCollection<T> : AbstractCollection<T>
    {
        private List<T> objects = new List<T>();

        //Create Iterator
        public Iterator.Iterator_Implementations.Iterator<T> CreateIterator()
        {
            return new Iterator.Iterator_Implementations.Iterator<T>(this);
        }

        // Gets item count
        public int Count
        {
            get { return objects.Count; }
        }

        //Add items to the collection
        public void AddElement(T element)
        {
            objects.Add(element);
        }

        //Get item from collection
        public T Get(int IndexPosition)
        {
            return objects[IndexPosition];
        }

    }
}
