using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float pi = 3.14159F;
            int radius1 = 1;
            int radius2 = 3;
            int radius3 = 5;

            float areal1 = pi * (radius1 * radius1);
            float areal2 = pi * (radius2 * radius2);
            float areal3 = pi * (radius3 * radius3);
            
            Console.WriteLine("Areal of radius " + radius1 + " is: " + areal1);
            Console.WriteLine("Areal of radius " + radius2 + " is: " + areal2);   
            Console.WriteLine("Areal of radius " + radius3 + " is: " + areal3);
            
        }
    }
}
