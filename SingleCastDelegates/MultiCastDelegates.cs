using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleCastDelegates
{
    internal class MultiCastDelegates
    {
        public delegate void DelOp(int x, int y);

        public static void ImplementationDelegates()
        {
            DelOp obj = Operation.Addition;
            obj += Operation.Square;
            obj(6, 15);
            obj(6, 15);

        }
        public class Operation
        {
            public static void Addition(int x, int y)
            {
                Console.WriteLine("Addition of two Number" + (x + y));
            }
            public static void Square(int x, int y)
            {
                Console.WriteLine("Sqaure  of two Number" + Math.Pow(x, y));
            }
        }
    }
}
