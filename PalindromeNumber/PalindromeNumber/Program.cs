using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check to whether the enterd string palindrome or not");
            Console.Write("Enter a String:");
            string name=Console.ReadLine();
            string reverse=string.Empty;

            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverse += name[i];
            }
            if (name == reverse)
            {
                Console.WriteLine($"{name} is Palindrome");
            }
            else
            {
                Console.WriteLine($"{name} is not Palindrome");
            }
            Console.ReadKey();
        }
    }
}
