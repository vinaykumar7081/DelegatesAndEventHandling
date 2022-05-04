using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleCastDelegates
{
    public delegate void EventHandler(string s);
    public class EventHandeling
    {
        public class Operation
        {
            public event EventHandler abc;
            public void Action(string a)
            {
                if (abc != null)
                {
                    abc(a);
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine("Event is Not Register");
                }
            }
        }
        public static void CatchEvent(string s)
        {
            Console.WriteLine("Method Calling");
        }
        public static void ImplementEvent()
        {
            Operation operation = new Operation();
            operation.Action("Event Calling");
            Console.WriteLine();
            operation.abc += new EventHandler(CatchEvent);
            operation.Action("Event Called");
        }
    }
}
