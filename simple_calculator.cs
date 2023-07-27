using System;

namespace VariableDefinition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter operator:");
            string b =  Console.ReadLine();
            Console.WriteLine("Enter second number:");
            double c = Convert.ToDouble(Console.ReadLine());
switch (b)
{
    case "+":
        Console.WriteLine("Result:{0}", a+c);
        break;
    case "-":
        Console.WriteLine("Result:{0}", a-c);
        break;
    case "*":
        Console.WriteLine("Result:{0}", a*c);
        break;
    case "/":
        Console.WriteLine("Result:{0}", a/c);
        break;
    case "^":
        Console.WriteLine("Result:{0}", Math.Pow(a,c));
        break;
    default:
        Console.WriteLine("Invalid input.");
        break;
}
Console.ReadLine();
        }
    }
}