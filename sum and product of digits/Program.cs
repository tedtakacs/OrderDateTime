using System;
using System.Collections.Generic;
using System.Linq;

namespace sum_and_product_of_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a multi-digit integer");
            string strInput = Console.ReadLine();
            char[] charDigits = strInput.ToCharArray();
            int product= 1;
            int sum = 0;
            foreach (char ch in charDigits)
            {
                product = product * (int)Char.GetNumericValue(ch);
                sum = sum + (int)Char.GetNumericValue(ch);
            }
            Console.WriteLine("product is {0}", product);
            Console.WriteLine("sum is {0}", sum);
        }
    }
}
