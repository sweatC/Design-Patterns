using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorMs
{
    interface IEnumerator
    {
        bool MoveNext();
        void Reset();
        object Current { get; }
    }
}
