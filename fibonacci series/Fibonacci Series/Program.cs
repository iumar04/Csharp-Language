using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1;
            Console.Write("Enter the Range of Fibonacci Series:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fibonacci Series:" + n1 + "," + n2);
            for (int i = 2; i < n; i++)
            {
                int n3 = n1 + n2;
                Console.Write("," + n3);
                n1 = n2; n2 = n3;
            }
            Console.ReadKey();
        }
    }
}
