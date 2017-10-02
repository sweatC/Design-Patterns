using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class ConcreteHandler2 : Handler
    {
        const int HANDLER_REQUEST = 2;
        
        /// <summary>
        /// For handling chain end.
        /// </summary>
        ERROR error = new ERROR(() => { Console.WriteLine("YOUR Request in a TRASH!"); });

        public override void HandleRequest(int request)
        {
            if (request.Equals(HANDLER_REQUEST))
                Console.WriteLine("SECOND EVENT =)");
            else if (GetSuccessor != null)
                GetSuccessor.HandleRequest(request);
            else
                error();
        }
    }
}
