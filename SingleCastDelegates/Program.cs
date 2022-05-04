using System;
using SingleCastDelegates;
using static SingleCastDelegates.SingleCastDelegate;

class Program
{
    public static void Main(String[] args)
    {
        Operation obj = new Operation(Addition);
        Console.WriteLine("Asdditin of the two  number is:-> " + obj(51, 10));
    }
}