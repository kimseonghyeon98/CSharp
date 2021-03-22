using System;
namespace A015_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("첫번째 숫자를 입력하세요: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("두번째 숫자를 입력하세요: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            short value = short.MaxValue; // Int16.MaxValue 
            Console.WriteLine("\n2진수, 8진수, 10진수, 16진수로 출력하기");
            int baseNum = 2;
            string s = Convert.ToString(value, baseNum); // value를 string으로 변환(2진수로) 
            int i = Convert.ToInt32(s, baseNum);  // string으로 변환된 값을 2진수로 읽어서 int로 다시 변환
            Console.WriteLine("i = {0}, {1,2}진수 = {2,16}", i, baseNum, s);
            baseNum = 8;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1,2}진수 = {2,16}", i, baseNum, s);
            baseNum = 10;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1,2}진수 = {2,16}", i, baseNum, s);
            baseNum = 16;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1,2}진수 = {2,16}", i, baseNum, s);
            Console.WriteLine(@"abc\nabc");
            Console.WriteLine("123\n123");
            string a = "\\\u0066\n";
            Console.WriteLine(a);
            string b = "C:\\Windows\\";
            Console.WriteLine(b);
        }
    }
}