using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
        
            const int limit = 10000;
            bool isPrime;
            int biggestPrime = -1;

            for (int i = 2; i < limit; i++)
            {
                
                isPrime = true;

                for (int y = 2; y < i; y++)
                {
                    if (i % y == 0)
                    {
                    isPrime = false;
                    break;
                    }
                }
            
            if (isPrime)
            {
                biggestPrime = i;
            }
            }
            
            Console.WriteLine(biggestPrime);
             
        }
    }
}

