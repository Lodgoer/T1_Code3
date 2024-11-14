namespace Prime_Palin_DT
{
    public class SmartCalc
    {
        private static PrimeCalculator primeCalculator = new PrimeCalculator();
        private static MirrorCalculator mirrorCalculator = new MirrorCalculator();
        private static DecisionTreeCalculator decisionTreeCalculator = new DecisionTreeCalculator();

        public static void ShowMenu()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Choose a calculation:");
                Console.WriteLine("1. Prime Number Check");
                Console.WriteLine("2. Mirror Number Check");
                Console.WriteLine("3. Decision Tree");
                Console.WriteLine("4. Last Results");
                Console.WriteLine("0. Exit");

                string choice = Console.ReadLine() ?? "";
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        primeCalculator.Execute();
                        break;
                    case "2":
                        mirrorCalculator.Execute();
                        break;
                    case "3":
                        decisionTreeCalculator.Execute();
                        break;
                    case "4":
                        DisplayLastResults();
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("\nPress Enter to return to the main menu...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        private static void DisplayLastResults()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("           Last Calculations            ");
            Console.WriteLine("========================================");

            primeCalculator.DisplayLastResult();
            mirrorCalculator.DisplayLastResult();
            decisionTreeCalculator.DisplayLastResult();

            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("End of last calculations. Press any key to continue.");
            Console.ReadKey();
        }
    }
}

