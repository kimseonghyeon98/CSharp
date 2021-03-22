using System;
namespace A019_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.MaxValue, y = 0;
            checked
            {
                try
                {
                    y = x + 10;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("int.MaxVlaue + 10 = {0}", y); Console.Read();
            checked
            {
                try
                {
                    Console.WriteLine(y = x + 10);
                    Console.WriteLine(y = x - 1);
                    Console.WriteLine(y = x * 2);
                    Console.WriteLine(y = x / 2);
                    Console.WriteLine(y = x % 2);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("OverflowExcetion 발생 ");
                }
            }
            int value = 780000000;
            checked
            {
                try
                {
                    // Square the original value. 
                    int square = value * value;
                    Console.WriteLine("{0} ^ 2 = {1}", value, square);
                }
                catch (OverflowException)
                {
                    double square = Math.Pow(value, 2);
                    Console.WriteLine("Exception: {0} > {1:E}.",
                    square, Int32.MaxValue);
                }
            }
        }
    }
}