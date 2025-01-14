using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
internal class Program
{
static void Main(string[] args)
{
    int Num1, Num2, result;
    char option;
    Console.Write("Enter the First Number : ");
    Num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the Second Number : ");
    Num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(">> Main Menu <<");
    Console.WriteLine("Addition (+)");
    Console.WriteLine("Subtraction (-)");
    Console.WriteLine("Multiplication (x)");
    Console.WriteLine("Division (/)");
    Console.Write("Enter the Operation you want to perform : ");
    option = Convert.ToChar(Console.ReadLine());
    switch (option)
    {
        case '+':
            result = Num1 + Num2;
            Console.WriteLine("The result of Addition is : {0}", result);
            break;
        case '-':
            result = Num1 - Num2;
            Console.WriteLine("The result of Subtraction is : {0}", result);
            break;
        case 'x':
            result = Num1 * Num2;
            Console.WriteLine("The result of Multiplication is : {0}", result);
            break;
        case '/':
            result = Num1 / Num2;
            Console.WriteLine("The result of Division is : {0}", result);
            break;
        default:
            Console.WriteLine("Invalid Option");
            break;
    }
    Console.ReadLine();
}
}
}
