using System;

namespace Backend02
{
    class HelloWorld
    {
        static void Main(string[] args)
        {

            Console.WriteLine(CalcuateAverage());
            
            Console.ReadKey();
        }


        //Calculate average of three numbers
        static double CalcuateAverage()
        {
            Console.Write("Enter the score for subject 1:");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the score for subject 2:");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the score for subject 3:");
            double c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Average value of these 3 numbers:");
            return (a + b + c) / 3;
        }


        
    }

    
}
