using System;
using System.Linq;

namespace SwapFirstLastChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string strInput = Console.ReadLine();
            int len = strInput.Length;
            string strNew = strInput.Substring(len - 1, 1) + strInput.Substring(1, len - 2) + strInput.Substring(0, 1);
            Console.WriteLine(strNew);
         }
    }
}
