using System;

namespace VariableDefinition
{
    class Program
    {
        static void Main(string[] args)
        {
            //Convert from int to double
            int a = 5;
            double a1 = a;
            Console.WriteLine("Convert from int to double: {0} - {1}", a, a1);

            //Convert from float to int
            float b = 10.43F;
            int b1 = (int)b;
            Console.WriteLine("Convert from  float to int: {0} - {1}", b, b1);


            //Convert from string to int
            string name = "3";
            int name1 = int.Parse(name);
            Console.WriteLine("Conver from string to int {0} - {1}", name, name1);


            //Convert from bool to string
            bool c = false;
            string c1 = Convert.ToString(c);
            Console.WriteLine("Conver from bool to string {0} - {1}", c, c1);


            //Convert from double to string
            double d = 200.23;
            string d1 = Convert.ToString(d);
            Console.WriteLine("Conver from double to string {0} - {1}", d, d1);


            Console.ReadLine();
        }
    }
}