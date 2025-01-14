using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num= new int[5];
            Console.Write("Enter 5 Numbers to Sort: ");
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            int temp = 0;
            Console.WriteLine("Sorted Element:");
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num.Length - 1; j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        temp = num[j + 1];
                        num[j + 1] = num[j];
                        num[j] = temp;
                    }
                }
            }
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i] + "");
            }
            Console.ReadKey();

        }
    }
}
