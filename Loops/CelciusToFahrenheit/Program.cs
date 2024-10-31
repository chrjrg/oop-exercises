using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int tempc = -5; // start temp
            double tempf;

            for (int i = 0; i <= 45; i++) // running 46 times, from -5 to 40
            {
                tempf = 32 + tempc * 1.8; // defining farenheit based on celcius
                Console.WriteLine("The temputure in celcius " + tempc + " is equal to " + Math.Floor(tempf * 10) / 10 + " in fahrenheit."); // Math.Floor(tempf * 10) / 10 is only for rounding to one decimenl. Just "tempf" doesn't print well..
                tempc++; // incrementing for next iteration.
            }
            
        }
    }
}
