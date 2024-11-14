using System.Text;

namespace Prime_Palin_DT
{
    public class PrimeCalculator : Calculator
    {
        private string lastResult = "No prime number calculation performed yet.";

        public override void Execute()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("          Prime Number Finder Tool      ");
            Console.WriteLine("========================================");
            Console.WriteLine("Please enter numbers between 0 and 2,147,483,647.");
            Console.WriteLine("----------------------------------------");

            int n = GetNumber("Enter the first number (n):");
            int m = GetNumber("Enter the second number (m):");

            if (m <= n)
            {
                Console.WriteLine("Invalid input: m should be greater than n.");
                lastResult = "Invalid input for prime number calculation.";
                return;
            }

            StringBuilder resultBuilder = new StringBuilder();

            if (m - n < 1000)
            {
                resultBuilder.Append("Using simple method to find prime numbers:\n");
                resultBuilder.Append(FindPrimesSimple(n, m));
            }
            else
            {
                resultBuilder.Append("Using optimized method to find prime numbers:\n");
                resultBuilder.Append(FindPrimesOptimized(n, m));
            }

            lastResult = resultBuilder.ToString(); // Save the result for later display

            Console.WriteLine(lastResult);
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("Process completed. Press any key to continue.");
            Console.ReadKey();
        }

        private string FindPrimesSimple(int n, int m)
        {
            StringBuilder primes = new StringBuilder();
            for (int i = n + 1; i < m; i++)
            {
                if (IsPrimeSimple(i))
                {
                    primes.AppendLine(i.ToString());
                }
            }
            return primes.ToString();
        }

        private string FindPrimesOptimized(int n, int m)
        {
            StringBuilder primes = new StringBuilder();
            for (int i = n + 1; i < m; i++)
            {
                if (IsPrimeOptimized(i))
                {
                    primes.AppendLine(i.ToString());
                }
            }
            return primes.ToString();
        }

        private static bool IsPrimeSimple(int number)
        {
            if (number < 2) return false;
            for (int j = 2; j < number; j++)
            {
                if (number % j == 0)
                    return false;
            }
            return true;
        }

        private static bool IsPrimeOptimized(int number)
        {
            if (number < 2) return false;
            for (int j = 2; j <= Math.Sqrt(number); j++)
            {
                if (number % j == 0)
                    return false;
            }
            return true;
        }

        // Override the method to display last result
        public override void DisplayLastResult()
        {
            Console.WriteLine("Last Prime Number Calculation:");
            Console.WriteLine(lastResult);
        }
    }
}



