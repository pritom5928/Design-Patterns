using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Iterator_Implementations;

namespace Iterator.Collection_Interface
{
    public interface AbstractCollection<T> 
    {
        Iterator.Iterator_Implementations.Iterator<T> CreateIterator();
    }
}
