using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace testSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input sequence of space-separated integers");
            string userInput = Console.ReadLine();
            List<string> strList = userInput.Split(' ').ToList();
            List<int> intList = new List<int>();
            bool invalidSeries = false;
            try
            {
                foreach (var item in strList) { intList.Add(int.Parse(item)); }
            }
            catch (Exception e)
            {
                Console.WriteLine("You have entered the integer list incorrectly");
                Console.WriteLine(e);
            }
            for (int i=0; i<intList.Count-2; i++)
            {
                int firstDiff = intList[i + 1] - intList[i];
                int secondDiff = intList[i + 2] - intList[i + 1];
                if (firstDiff == secondDiff)
                {
                    continue;
                }
                else
                {
                    invalidSeries = true;
                    Console.WriteLine("Not a valid series");
                    break;
                }
            }
            if (invalidSeries == false) { Console.WriteLine("Valid Series"); }
        }
    }
}
