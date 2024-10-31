using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int radius = 1;
            float pi = 3.14159F; 
            float areal;

            for (int i = 0; i < 3; i++)
            {
                areal = pi * (radius * radius);
                Console.WriteLine("The areal of the circle with radius " + radius + " is " + areal);
                radius = radius + 2;
            }
            
        }
    }
}

