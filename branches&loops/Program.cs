using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {


/*

Skriv et program, hvori1. Værdien af et terningeslag er gemt i en variabel ved navndice.
•Hvilken type giver det mening at erklære variablen som?
int da vi har heltal og den bruger mindst memory

•Vælg selv en specifik værdi.
3

Opret en boolsk variabel og tildel den en værdi der repræsenterer hvorvidt værdien fra variablen dice er lige og større end 3.3. 


Udskriv den værdien af denne boolske variabel



*/

int dice = 6 ; // defining variable as int and x

bool tjek ; // defining our book

if (dice%2==0 && dice >= 3) { // if dice is even and >= 3 then we define bool as..

    tjek = true ;
    Console.WriteLine(tjek) ;

} else { // else..

	tjek = false ;
	Console.WriteLine(tjek) ;
}

/*

9.3  Juleudsalg

1. 
En variabel oprettes (erklæres) og initialiseres til værdien 21816000. 
Dettetal repræsenterer et antal sekunder siden nytår (alle måneder antages atvære 30 dage lange).

2. 
En anden variabel indeholder en pris på 599,95 dkr.

3. Der skal gives et 30% rabat hvis det er Jul.  Find selv på en fornuftigdefinition af hvornår det er Jul.

4. Udregn den gældende pris (eventuelt rabat medregnet) og gem denne i envariabel.

5. Udskriv denne variabel.6. Sørg for at teste den logik I har skrevet ved at prøve at tildele den førstevariable forskellige andre værdier. Hvilke værdier vil være fornuftige atteste?19


*/


int sec = 300000000; // defining the given second in a year as an int

float price = 599.95F ; // defining price as a float (because its not whole)


if (sec >= 31104000/(12/11)) { // if the given second is in the last 12th of the year (december)

	float disPrice = (price * 70) / 100 ; // calc discount price
    Console.WriteLine(disPrice) ; // writing in console

} else { // if the condition is not forfilled....
	Console.WriteLine(price) ;
}


/*

Undervisningskalenderen fortæller os at der (blandt andet) er følgende ferier:
•Efterårsferie Oktober
•Juleferie December
•Påskeferie April
•Sommerferie Juli + August

Skriv et program, hvori
1. Et månedsnummer gives via en variabel.
2. Afhængigt af indholdet af denne variabel udskrives en feries navn (hvisder er ferie i måneden) eller “Hårdt arbejde” (hvis der ikke er

*/















        }
    }
}















