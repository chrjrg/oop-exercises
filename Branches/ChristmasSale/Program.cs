using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // if secondsfromny > 28512000 we are in december.
            int secondsfromny = 28512001;
            float price = 599.95F;

            // if variable is > seconds * minutes * hours * days * months, i.e a value of seconds that passes into december (which is our definition of "christmas")
            if (secondsfromny > 60 * 60 * 24 * 30 * 11)
            {
                price = price * 0.7F; // 30% off
            }

            Console.WriteLine(price);
            
        }
    }
}

