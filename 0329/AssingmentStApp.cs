using System;

namespace AssingmentStApp
{
    class Program
    {
        static void Main(string[] args)
        {
            short s; int i;
            float f; double d;
            s = 526;
            d = f = i = s;
            Console.WriteLine("s = " + s + " i = " + i); 
            Console.WriteLine("f = " + f + " d = " + d);
        }
    }
}