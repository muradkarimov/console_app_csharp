using System;

namespace VariableDefinition
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 3;
            int b = 5;
            int c = 7;
            int d = 2;
            int e = 4;
            int result = a++ + --b * c - e-- + ++d / a + b-- * c / e;
            //3(4) + 4 * 7 - 4(3) + 3 / 4 + 4(3) * 7/ 3 = 36
            //a=4 b=3 c=7 d=3 e=3
            Console.WriteLine("Initial values:");
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.WriteLine($"c: {c}");
            Console.WriteLine($"d: {d}");
            Console.WriteLine($"e: {e}");

            Console.WriteLine("\nExpression Result:");
            Console.WriteLine($"result: a++ + --b * c - e-- + ++d / a + b-- * c / e: {result}");



            


            Console.ReadLine();
        }
    }
}