using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ArmstrongNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int rem;
            Console.WriteLine("Check to Whether the Enterd Number is Armstrong or not");
            Console.Write("Enter Your Number:");
            int val=Convert.ToInt32(Console.ReadLine());
            // check for armstrong
            for (int i = val; i > 0; i = i / 10)
            {
                rem = i % 10;
                sum = sum + rem * rem * rem;
            }
            if (sum == val)
            {
                Console.Write("Armstrong Number");
            }
            else
            {
                Console.Write("Not an Armstrong Number");
            }
            Console.ReadLine();
        }
    }
}