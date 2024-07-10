using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205HW2_Part4
{
    using System;

    namespace CSC205HW2_Part4
    {
        public class SquareRootApproximation
        {
            public static double SquareRoot(double a)
            {
                double x0 = 2; // Initial guess for the square root
                double x1;     // Variable to hold the improved estimate

                // Iterate until the difference between consecutive estimates is less than 0.0001
                do
                {
                    // Calculate the new estimate using the formula x1 = (x0 + a/x0) / 2
                    x1 = (x0 + a / x0) / 2;

                    // Check if the difference between x1 and x0 is within the tolerance (0.0001)
                    if (Math.Abs(x1 - x0) < 0.0001)
                    {
                        break; // If the difference is small enough, exit the loop
                    }

                    // Update x0 to x1 for the next iteration
                    x0 = x1;
                }
                while (true); // Loop indefinitely until break condition is met

                // Return the final estimated square root
                return x1;
            }

            public static void Main(string[] args)
            {
                double number = 9;
                double sqrt = SquareRoot(number);
                Console.WriteLine($"Square root of {number} is approximately: {sqrt}");

                // Example with another number
                double anotherNumber = 25;
                double sqrtAnother = SquareRoot(anotherNumber);
                Console.WriteLine($"Square root of {anotherNumber} is approximately: {sqrtAnother}");

                // Example with a larger number
                double largeNumber = 123456;
                double sqrtLarge = SquareRoot(largeNumber);
                Console.WriteLine($"Square root of {largeNumber} is approximately: {sqrtLarge}");
            }
        }
    }
}
