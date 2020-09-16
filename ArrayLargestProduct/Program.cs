using System;

namespace ArrayLargestProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] intArray = new int[size];
            var intRandom = new Random();
            int largest = 0;
            int seclargest= 0;
            int count = 0;
            while (count < size)
            {
                intArray[count] = intRandom.Next(1000);
                if (intArray[count] > largest)
                    largest = intArray[count];
                else if (intArray[count] > seclargest)
                    seclargest = intArray[count];
                count++;
            }
            Console.WriteLine("largest = " + largest);
            Console.WriteLine("seclargest = " + seclargest);
            Console.WriteLine("product = " + largest * seclargest);
            Array.ForEach(intArray, Console.WriteLine);
        }
    }
}
