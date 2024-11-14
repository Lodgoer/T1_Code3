namespace Prime_Palin_DT
{
    public abstract class Calculator
    {
        // Virtual method for displaying the last result, to be overridden by subclasses
        public virtual void DisplayLastResult()
        {
            Console.WriteLine("No previous results to display.");
        }

        public static int GetNumber(string prompt = "Please enter a number:")
        {
            int number;
            Console.Write(prompt + " ");
            while (!int.TryParse(Console.ReadLine()?.Trim() ?? "0", out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.Write(prompt + " ");
            }
            return number;
        }

        public abstract void Execute();
    }
}

