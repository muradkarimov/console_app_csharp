using System;

namespace VariableDefinition
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Enter a number:");
double a = Convert.ToDouble(Console.ReadLine());
if (a > 0)
{
    Console.WriteLine("The number {0} is positive", a);
}
else if (a < 0)
{
    Console.WriteLine("The number {0} is negative", a);
}
else
{
    Console.WriteLine("The number {0} is neither positive nor negative", a);
}

            Console.ReadLine();
        }
    }
}