using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2;
            int a, b, result;
            str1 = "10";
            str2 = "7";



            a = Convert.ToInt32(str1);
            b = Convert.ToInt32(str2);
            result = a + b;
            Console.WriteLine("Output = " + result);
            string str = "1.9";

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            double d = Convert.ToDouble(str, numberFormatInfo);
            Console.WriteLine("Double = " + d);
            
            //str = Console.ReadLine();
        }
    }
}
