using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleCastDelegates
{
    internal class MultiCastDelegates
    {
        public delegate void DeployOperation(int x, int y);

        public static void ImplementationDelegates()
        {
            DeployOperation obj = Operation.Addition;
            obj += Operation.Square;
            obj += Operation.Subtraction;
            obj += Operation.MultiPlication;

            //obj(6, 15);
            obj(20, 15);
            //obj(50, 15);
            obj(120, 15);

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
            public static void Subtraction(int x, int y)
            {
                Console.WriteLine("Subtraction  of two Number" + (x-y));
            }
            public static void MultiPlication(int x, int y)
            {
                Console.WriteLine("Multiplication of the   of two Number" + (x * y));
            }
        }
    }
}
