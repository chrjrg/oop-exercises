using System;
using System.Net.NetworkInformation;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double pi = 3.14159;
            double result;

            double[] radiusArr = { 1, 3, 5 };

            foreach (double radius in radiusArr)  
            {
                result = pi * (radius * radius);
                Console.WriteLine($"The areal of the circle, with the radius of {radius} is {result}");
            }
            
        }
    }
}
