using Iterator.Collection_Implementations;
using Iterator.Element;
using Iterator.Iterator_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Iterator_Implementations
{
    public class Iterator<T> : AbstractIterator<T>
    {
        private ConcreteCollection<T> collection;
        private int current = 0;
        private int step = 1;

        // Constructor
        public Iterator(ConcreteCollection<T> collection)
        {
            this.collection = collection;
        }

        // Gets first item
        public T First()
        {
            current = 0;
            return collection.Get(current);
        }

        // Gets next item
        public T Next()
        {
            current += step;
            if (!IsCompleted)
            {
                return collection.Get(current);
            }
            else
            {
                return default(T);
            }
        }

        // Check whether iteration is complete
        public bool IsCompleted
        {
            get { return current >= collection.Count; }
        }
    }
}
