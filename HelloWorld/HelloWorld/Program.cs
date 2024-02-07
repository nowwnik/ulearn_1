using System;


namespace Lectures
{
    class Program
    {
        static void Main()
        {
            // Console.WriteLine("Hello, world!");

            //Console.WriteLine("The first step!");

            //double num1 = +5.5e-2;
            //float num2 = 7.8f;
            //int num3 = 0;
            //long num4 = 2000000000000L;
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            //Console.WriteLine(num3);
            //Console.WriteLine(num4);

            double pi = Math.PI;
            long tenThousand = 10000L;
            double tenThousandPi = pi * tenThousand;
            int roundedTenThousandPi = (int)Math.Round(tenThousandPi);
            int integerPartOfTenThousandPi = (int)tenThousandPi;
            Console.WriteLine(integerPartOfTenThousandPi);
            Console.WriteLine(roundedTenThousandPi);
        }
    }

}