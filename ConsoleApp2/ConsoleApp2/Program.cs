using System;
namespace ConsoleApp2
{
    class Class234
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.Write("Enter your first num= ");
            String s1 = Console.Readline();
            x = int.parse(s1);
            Console.Write("Enter your second num= ");
            String s2 = Console.Readline();
            y = int.parse(s2);
            z = x + y;
            Console.WriteLine("Sum of {0} & {1} is {2}", x, y, z);
        }
    }
}

