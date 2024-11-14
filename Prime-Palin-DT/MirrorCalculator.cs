using System.Text;

namespace Prime_Palin_DT
{
    public class MirrorCalculator : Calculator
    {
        private string lastResult = "No mirror number calculation performed yet.";

        public override void Execute()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("      Mirror Number Finder Tool        ");
            Console.WriteLine("========================================");
            Console.WriteLine("Please enter numbers between 0 and 2,147,483,647.");
            Console.WriteLine("----------------------------------------");

            int n = GetNumber("Enter the first number (n):");
            int m = GetNumber("Enter the second number (m):");

            if (n > m)
            {
                (n, m) = (m, n); // Swap values using a tuple
            }

            StringBuilder resultBuilder = new StringBuilder();
            resultBuilder.Append($"Mirror numbers between {n} and {m} are:\n");

            bool foundMirror = false;
            for (int num = n; num <= m; num++)
            {
                if (IsMirrorNumber(num))
                {
                    resultBuilder.AppendLine(num.ToString());
                    foundMirror = true;
                }
            }

            if (!foundMirror)
            {
                resultBuilder.AppendLine("No mirror numbers found in the given range.");
            }

            lastResult = resultBuilder.ToString(); // Save the result for later display
            Console.WriteLine(lastResult);

            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("Process completed. Press any key to continue.");
            Console.ReadKey();
        }

        private static bool IsMirrorNumber(int number)
        {
            if (number >= 0 && number < 10)
            {
                return false;
            }

            int reversed = 0;
            int temp = number;

            while (temp > 0)
            {
                int digit = temp % 10;
                reversed = reversed * 10 + digit;
                temp /= 10;
            }

            return number == reversed;
        }

        public override void DisplayLastResult()
        {
            Console.WriteLine("Last Mirror Number Calculation:");
            Console.WriteLine(lastResult);
        }
    }
}

