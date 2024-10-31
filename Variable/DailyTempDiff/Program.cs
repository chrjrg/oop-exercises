using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // first i declare and define 7 varables representing days and holding temputures.
            float monday = 21.5F;
            float tuesday = 23.7F;
            float wednesday = 19.6F;
            float thursday = 22.5F;
            float friday = 25.3F;
            float saturday = 21.7F;
            float sunday = 18.9F;

            // then i do the calculations and print them
            float mtDiff = monday - tuesday;
            float twDiff = tuesday - wednesday;
            float wtDiff = wednesday - thursday;
            float tfDiff = thursday - friday;
            float fsDiff = friday - saturday;
            float ssDiff = saturday - sunday;
            float smDiff = sunday - monday;

            // then printing difference.
            Console.WriteLine(mtDiff);
            Console.WriteLine(twDiff);
            Console.WriteLine(wtDiff);
            Console.WriteLine(tfDiff);
            Console.WriteLine(fsDiff);
            Console.WriteLine(ssDiff);
            Console.WriteLine(smDiff);

        }
    }
}


