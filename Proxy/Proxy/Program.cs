using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject real = new RealSubject();
            Subject p = new Proxy(real as RealSubject);
            Subject proxy = new Proxy((p as Proxy).Subject as RealSubject);

            proxy.Request();
        }
    }
}
