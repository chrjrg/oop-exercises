using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int [] arrayYearDays = [31,28,31,30,31,30,31,31,30,31,30,31]; 

            int [] arrayLeapYearDays = [31,29,31,30,31,30,31,31,30,31,30,31]; // defining arrays..

            int[] pointer; // defning variable "pointer" as array = complex datatype

            for (int i = 2000 ; i <= 2020 ; i++) 
            {                                       // looping through all iterations from 2000 to 2020

            if (i%4==0) 
            {                         // if leap year
                pointer = arrayLeapYearDays ;       // redefining pointer as leap year array
                Console.Write(i + " = ") ;       
  
                foreach (int num in pointer)        // looping through array
                {
                    Console.Write(num + ", ");       // printing all ints in array in one single line
                }

                Console.WriteLine(" ");             // breaking line for next iteration of for loop
            } 

            else 
            {                                      // same as above
                pointer = arrayYearDays ;
                Console.Write(i + " = ") ;
  
                foreach (int num in pointer)      
                {   
                    Console.Write(num + ", ");
                }

                Console.WriteLine(" ") ;
            }      
            } 
            
        }
    }
}
