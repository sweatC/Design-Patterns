<<<<<<< HEAD
﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorMs
{
    class Enumerable : IEnumerable
    {
        ArrayList items = new ArrayList();

        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }

        public int Count
        {
            get { return items.Count; }
        }

        public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
        }
    }
}
=======
﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorMs
{
    class Enumerable : IEnumerable
    {
        ArrayList items = new ArrayList();

        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }

        public int Count
        {
            get { return items.Count; }
        }

        public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
        }
    }
}
>>>>>>> dbcb8d1db99d2bde4cee380e98094da4bc2d70b7
