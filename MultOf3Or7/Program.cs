using System;

namespace MultOf3Or7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isDivisible;
            string prompt;
            do
            {
                isDivisible = GetValue(out prompt);
            }
            while (isDivisible == false);
            Console.WriteLine(prompt);
        }
        public static bool GetValue(out string prompt)
        {
            prompt = "Enter an integer";
            Console.WriteLine(prompt);
            string strNumber = Console.ReadLine();
            decimal number = Convert.ToDecimal(strNumber);
            bool isDivisible = CheckValue(number, out prompt);
            return isDivisible;
        }
        public static bool CheckValue(decimal number, out string prompt)
        {
            if (number % 3 == 0)
            {
                prompt = "divisible by 3";
                return true;
            }
            else if (number % 7 == 0) 
            {
                prompt = "divisible by 7";
                return true;
            }
            else 
            {
                prompt = "not divisible";
                return false;
            }
        }
    }
}
