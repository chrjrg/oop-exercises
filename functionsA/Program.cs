using System;

class Program{
   public static void Main(string[] args) {

      float[] temp = [21.5F,23.7F,19.6F,22.5F,25.3F,21.7F,18.9F] ;
      
      int x = 12312;
      int y = 1235;
      
      // Console.WriteLine(Solutions.diff(temp));
      Console.WriteLine("[{0}]", string.Join(", ", (Solutions.diff(temp))));   
      Console.WriteLine(Solutions.add(x,y));
      Console.WriteLine(Solutions.minus(x,y));
      Console.WriteLine(Solutions.times(Solutions.add(x,y),Solutions.minus(x,y)));
      
      int indeholder = 0;

      int cifre = 1000000000;
      int checkEfter = 5;

      for (int i = 0;i<cifre;i++) {
         if (i.ToString().Contains(checkEfter.ToString())){
             indeholder++;
         } else
              continue;
         }

         Console.WriteLine(indeholder);

   }
}
 
/*

11.9  Daglige DifferencerEmneKreativitetSkriv et program, der givet 7 dagstemperaturer 
udregner og udskriver temper-aturdifferencen mellem alle to på hinanden følgende dage 
(dvs. Tirsdag-Mandag,Onsdag-Tirsdag . . . Søndag-Lørdag).Dagstemperaturerne kunne være:

Skriv en metode, der lægger to heltal sammen. Skriv derudover enmainmetodeder 
viser hvordan denne metode skal bruges.

class Solutions 
*/

class Solutions {
   public static float[] diff (float[] array) {
      float[] result = new float[array.Length-1]; 

      for (int i = 0 ; i<result.Length ; i++) {
         result[i] = array[i+1] - array[i];
      }
      return result;
      }


   public static int add(int num1, int num2) {
      int result = num1 + num2;

      return result;
      }

   public static int minus(int num1, int num2) {
      int result = num1 - num2;

      return result;
      }


   public static int times(int num1, int num2) {
      int result = num1 * num2;

      return result;
      }


}
  


 

