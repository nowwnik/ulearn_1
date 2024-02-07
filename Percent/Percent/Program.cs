using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate(Console.ReadLine()));
            Console.ReadLine();
        }

        public static string Calculate(string userInput)
        {
     
            string[] values = userInput.Split(' ');

            var initialMoney = double.Parse(values[0]);
            var yearlyPercent = double.Parse(values[1]);
            var monthsCount = double.Parse(values[2]);

            return Convert.ToString(initialMoney * Math.Pow((1 + yearlyPercent / 100 / 12), monthsCount));

        }

    }
}