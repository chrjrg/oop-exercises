using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // using switch

            int monthNumber = 4;
            int daysInMonth;

            switch (monthNumber)
            {
            case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                daysInMonth = 31;
                break;
            case 4: case 6: case 9: case 11:
                daysInMonth = 30;
                break;
            case 2:
                daysInMonth = 28; // Assuming it’s not a leap year
                break;
            default:
                Console.WriteLine("Invalid");
                return;
            }

            Console.WriteLine($"The number of days in month {monthNumber} is: {daysInMonth}");
        }
            
        }
    }

