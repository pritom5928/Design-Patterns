using Iterator.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Iterator_Interface
{
    public interface AbstractIterator<T>
    {
        T First();
        T Next();
        bool IsCompleted { get; }
    }
}
