using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int [] array = [13,70,2,11,3,7,4,69,5,42]; // defining array

            int largest = array[0]; // assuming int (not largest, just assuming a int)
        
            foreach (int num in array) // Iterate through the array
            {
            if (num > largest) // if num larger than assumed value, then..
                {
                largest = num;
                }
            }   
            
            Console.WriteLine(largest);

        }
    }
}

