using System;

namespace Reverse_words_in_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a stream of words");
            string strInput = Console.ReadLine();
            args = strInput.Split(' ');
            string strReverse = "";
            for (int i=args.Length-1; i>=0; i--)
            {
                strReverse = strReverse + ' ' + args[i];
            }
            Console.WriteLine(strReverse);
        }
    }
}
