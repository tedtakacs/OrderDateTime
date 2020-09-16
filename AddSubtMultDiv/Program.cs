using System;

namespace AddSubtMultDiv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            string strFirst = Console.ReadLine();
            int intFirst = Convert.ToInt32(strFirst);
            Console.WriteLine("Enter Second Number");
            string strSecond = Console.ReadLine();
            int intSecond = Convert.ToInt32(strSecond);
            Console.WriteLine("Enter Third Number");
            string strThird = Console.ReadLine();
            int intThird = Convert.ToInt32(strThird);
            int intAdd = intFirst + intSecond + intThird;
            int intSubtract = intFirst - intSecond - intThird;
            int intMult = intFirst * intSecond * intThird;
            decimal intDiv = (decimal)intFirst / (decimal)intSecond / (decimal)intThird;
            Console.WriteLine("Add result is {0}", intAdd);
            Console.WriteLine("Subtract result is {0}", intSubtract);
            Console.WriteLine("Multiply result is {0}", intMult);
            Console.WriteLine("Divide result is {0}", intDiv);
        }
    }
}
