using System;

namespace Backend02
{
    class HelloWorld
    {
        static void Main(string[] args)
        {

          
            Console.WriteLine(ConvertDegree());
            
            
            Console.ReadKey();
        }


    
        //Convert From Celsius to Fahrenheit
        static double ConvertDegree()
        {
            Console.Write("Enter your temperature in C:");
            int a = Convert.ToInt32((Console.ReadLine()));
            Console.Write("Your temperature in F:");
            return  (a * 9 / 5) + 32; 
        }
    }

    
}
