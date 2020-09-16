using System;
using System.Diagnostics;

namespace FizzBuzzConditional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Min Range");
            int minRange = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Max Range");
            int maxRange = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("First Divisor");
            int firstDivisor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Divisor");
            int secondDivisor = Convert.ToInt32(Console.ReadLine());
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = minRange; i <= maxRange; i++)
            {
                string strOutput = string.Empty;
                if (i % firstDivisor == 0) strOutput += "Fizz";
                if (i % secondDivisor == 0) strOutput += "Buzz";
                Console.WriteLine("{0}", strOutput.Length > 0 ? strOutput : i.ToString());
            }
            timer.Stop();
            Console.WriteLine("Elapsed:{0}milliseconds", timer.Elapsed.TotalMilliseconds);
        }
    }
}
