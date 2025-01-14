using System;
namespace PascalsTriangle
{
class MyClass
{
static void Main(String[] args)
{
int row = 5;
for (int i = 0; i < row; i++)
{
int num = 1;
//Console.Write("%" + (row - i) * 2 + "S", "");
for (int j = 0; j <= i; j++)
{
	Console.Write("*", num);
	num = num * (i - j) / (j + 1);
}
Console.WriteLine();
}
Console.ReadKey();
}
}

}