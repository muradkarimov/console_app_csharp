using System;

namespace VariableDefinition
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 24;
            int y = 13;
            int z = (x + y) / 2 + y++ + ++y + 2 * (x -- *4);  
                 //37/2     + 13(14) + 15  + 2*(24(23)*4) =  18+ 13 + 15 + 192= 238
            int w = z++ + (w = y) - --w; 
                // 238(239) + (15) - 14 =  239;
                //x=23 y=15 w=239 z=239
            Console.WriteLine("{0} {1} {2} {3}", x,y,w,z);

            Console.ReadLine();
        }
    }
}