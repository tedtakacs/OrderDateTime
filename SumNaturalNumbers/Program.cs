using System;
using System.Collections.Generic;
using System.Linq;

namespace SumNaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var intList = new List<int>();
            string strInput = "";
            var strList = new List<string>();
            bool validInput;
            int sumInput;
            do
            {
                validInput = true;
                Console.WriteLine("Input min natural number and numbers to sum");
                strInput = Console.ReadLine();
                strList = strInput.Split(' ').ToList();
                try
                {
                    foreach (var item in strList) { intList.Add(int.Parse(item));}
                    sumInput = intList.AsQueryable().Sum();
                    Console.WriteLine("Sum = {0}", sumInput);
                }
                catch (Exception)
                {
                    validInput = false;
                    Console.WriteLine("Error in input string");
                }
            } 
            while (validInput == false);
        }
    }
}
