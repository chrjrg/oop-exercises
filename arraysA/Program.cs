using System;

namespace ArraysAndStructs
{
class Program
 {

struct Person
  {
public string name;
public int age; 
  } ;

    static void Main(string[] args)
  {


/*

Skriv et program, der finder det største tal i et array af typen int[], 
og udskriverindeks for dette tal. Find selv på noget passende indhold til dette array

*/


int [] array = [13,9,2,11,3,7,4,69,5,42]; // defining array

int largest = array[0]; // assuming largest (not largest, just assuming a int)
        
        foreach (int num in array) // Iterate through the array
        {
            if (num > largest) // if num larger than assumed value, then..
            {
                largest = num;
        
            }
        }

Console.WriteLine(largest) ;

  Console.WriteLine(" ") ;

/*

Ekempel på 2 dimitionel array

*/

int [,] sodukuBoard = new int [3,3]
{
{1,3,9},
{2,7,4},
{6,5,8}
};

Console.WriteLine(sodukuBoard[0,0] + " " + sodukuBoard[0,1] + " " + sodukuBoard[0,2]) ;
Console.WriteLine(sodukuBoard[1,0] + " " + sodukuBoard[1,1] + " " + sodukuBoard[1,2]) ;
Console.WriteLine(sodukuBoard[2,0] + " " + sodukuBoard[2,1] + " " + sodukuBoard[2,2]) ;

  Console.WriteLine(" ") ;

/*
Skriv et program, hvori

1. En variabel initialiseres til at være et array der indeholder 
antallet af dage i hver af de 12 måneder i et normalt år. 
Det første element vil da indeholdeantallet af dage i Januar.

•Hvad skal typen af denne variabel være?
int

2. En anden variabel initialiseres til at være 
et array der indeholder antalletaf dage i hver af de 12 måneder i et skudår.

•Hvad skal typen af denne variabel være?
int

3. Gennemløb årene 2000 til 2020:

(a) Brug en ny variabel kaldet pointer til at pege på dét 
af de to arraysder er korrekt for det aktuelle år.

•Hvad skal typen af denne variabel være?
•Hvor meget data bliver der kopieret her?
•Hint:Vi kan i denne opgave tillade os at forsimple skudårsre-glerne til 
at det er skudår hvis 4 går op i årstallet.

(b) For hvert år udskrives indholdet af det array sompointerpeger på
*/

int [] arrayYearDays = [31,28,31,30,31,30,31,31,30,31,30,31]; 

int [] arrayLeapYearDays = [31,29,31,30,31,30,31,31,30,31,30,31]; // defining arrays..

int[] pointer; // defning variable "pointer" as array = complex datatype

for (int i = 2000 ; i <= 2020 ; i++) { // looping through all iterations from 2000 to 2020

if (i%4==0) {                         // if leap year
  pointer = arrayLeapYearDays ;       // redefining pointer as leap year array
  Console.Write(i + " = ") ;       
  
  foreach (int num in pointer)        // looping through array
        {
            Console.Write(num + " "); // printing all ints in array in one single line
        }
  Console.WriteLine(" ");             // breaking line for next iteration of for loop
 } 

else {                                // same as above
  pointer = arrayYearDays ;
  Console.Write(i + " = ") ;
  
  foreach (int num in pointer)      
        {
            Console.Write(num + " ");
        }

  Console.WriteLine(" ") ;
 }
} 


Person person1 ;
person1.name = "John" ;
person1.age = 1 ;

Console.WriteLine(person1.name) ;


   
  }
 }
}


