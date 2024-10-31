using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // seconds from given date
            long totalSekunder = 86399231233423;

            // defining constants
            const int sekunderPrDag = 86400; // 60 sek * 60 min * 24 timer
            const int dagePrÅr = 365;
            const int sekunderPrÅr = sekunderPrDag * dagePrÅr;

            // downcasting from the fraction to get years
            int år = (int)(totalSekunder / sekunderPrÅr);

            // finding rest of seconds in a year
            int resterendeSekunder = (int)(totalSekunder % sekunderPrÅr);

            // calculating days from other calc.
            int dage = resterendeSekunder / sekunderPrDag;

            Console.WriteLine($"År: {år}");
            Console.WriteLine($"Dage: {dage}");
            
        }
    }
}

