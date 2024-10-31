using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int dice = 8;

            // declaring a bool which is determent by whether or not a value is even and is greater than or equal to 3.
            bool result = (dice % 2 == 0) && (dice >= 3);

            Console.WriteLine(result);
            
        }
    }
}
