using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array:");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter value for index {i}:");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int largest = arr[0];
            int smallest = arr[0];

            for (int i = 1; i < size; i++)
            {
                if (arr[i] > largest)
                {
                    largest = arr[i];
                }
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                }
            }

            Console.WriteLine($"Smallest value: {smallest}, and largest value: {largest}");
            Console.ReadKey();
        }
    }
}
