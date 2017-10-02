using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class ConcreteHandler1 : Handler
    {
        const int HANDLER_REQUEST = 1;

        public override void HandleRequest(int request)
        {
            if (request.Equals(HANDLER_REQUEST))
                Console.WriteLine("FIRST EVENT!!!!!!!!");
            else if (GetSuccessor != null)
                GetSuccessor.HandleRequest(request);
        }
    }
}
