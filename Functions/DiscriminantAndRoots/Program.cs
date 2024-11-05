using System;

namespace MyNamespace
{
    public class QEsolver
    {
        double d; // Variable to store the discriminant

        // Method to calculate and return the discriminant of a quadratic equation
        public double Discriminant(double a, double b, double c)
        {
            d = (b * b) - (4 * a * c); // Calculating discriminant using the formula: b^2 - 4ac
            return d;
        }

        // Method to calculate the roots of the quadratic equation using the discriminant
        public (double? root1, double? root2) CalculateRoots(double a, double b, double c)
        {
            double discriminant = Discriminant(a, b, c); // Use the Discriminant method to calculate d
    
            if (discriminant > 0)
            {
                // Two real roots if discriminant is positive
                double root1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                return (root1, root2); // Return both roots as a tuple
            }
            else if (discriminant == 0)
            {
                // One real root if discriminant is zero
                double root = -b / (2 * a);
                return (root, null); // Return one root, second value is null
            }
            else
            {
                // No real roots if discriminant is negative
                return (null, null); // Both values are null
            }
        }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {   
            // Define coefficients for the quadratic equation
            var (a, b, c) = (2, 2, -4); 

            // Create an instance of QEsolver
            QEsolver solveTest1 = new QEsolver();
            
            // Calculate and print the discriminant
            double discriminant = solveTest1.Discriminant(a, b, c);
            Console.WriteLine($"Discriminant: {discriminant}");

            // Calculate the roots using a new QEsolver instance
            QEsolver solveTest2 = new QEsolver();
            var (root1, root2) = solveTest2.CalculateRoots(a, b, c);

            // Check if roots are real and print them
            if (root1.HasValue && root2.HasValue)
            {
                // Both roots are real
                Console.WriteLine($"Root 1: {root1.Value}, Root 2: {root2.Value}");
            }
            else if (root1.HasValue)
            {
                // Only one real root
                Console.WriteLine($"Root: {root1.Value}");
            }
            else
            {
                // No real roots
                Console.WriteLine("The equation has no real roots.");
            }
        }
    }
}
        