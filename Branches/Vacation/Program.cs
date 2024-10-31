using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int month = 4;


                // using if statement
            if (month == 10)
            {
                Console.WriteLine("Efterårsferie");
            } else if (month == 12)  {
                Console.WriteLine("Juleferie");
            } else if (month == 4)  {
                Console.WriteLine("Påskeferie");
            } else if (month == 7 || month == 8)  {
                Console.WriteLine("Sommerferie");
            } else {
                Console.WriteLine("Ikke ferie.... :(");
            }
            
                // using switch 
                // defining method which takes month as parameter
            static string GetHoliday(int month)
            {
            // Determine the holiday based on the month number
             switch (month)
            {
            case 10:
                return "Efterårsferie";
            case 12:
                return "Juleferie";
            case 4:
                return "Påskeferie";
            case 7:
            case 8:
                return "Sommerferie";
            default:
                return "Ikke ferie.... :(";
            }
            }

            string result = GetHoliday(month);
            Console.WriteLine(result);

        }
    }
}

