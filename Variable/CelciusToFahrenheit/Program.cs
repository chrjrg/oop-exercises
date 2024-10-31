using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int tempc = 69;
            float tempf;

            tempf = 32 + tempc * 1.8F;

            Console.WriteLine("The temp " + tempc + " in celcius is " + tempf + " in fahrenheit.");
            
        }
    }
}

