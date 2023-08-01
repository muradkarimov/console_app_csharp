using System;

namespace HelloWorldApplication
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MultiplebyEvenNumbers(a));
            Console.ReadKey();
        }
        public static int MultiplebyEvenNumbers(int number)
        {
            if (number == 2)
            {
                return 1;
            }
            return (number-2)*MultiplebyEvenNumbers(number - 2);
        }
    }
}