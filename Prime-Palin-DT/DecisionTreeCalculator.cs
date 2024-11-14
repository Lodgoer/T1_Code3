using System.Text;

namespace Prime_Palin_DT
{
    public class DecisionTreeCalculator : Calculator
    {
        private string lastResult = "No decision tree calculation performed yet.";

        public override void Execute()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("           Easy Outfit Advisor          ");
            Console.WriteLine("========================================");
            Console.WriteLine("Get outfit suggestions based on the weather conditions.");
            Console.WriteLine("----------------------------------------");

            lastResult = StartDecisionTree();
            Console.WriteLine(lastResult);

            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("Process completed. Press any key to continue.");
            Console.ReadKey();
        }

        private string StartDecisionTree()
        {
            string responseSequence = "";
            bool complete = false;
            StringBuilder resultBuilder = new StringBuilder();

            while (!complete)
            {
                switch (responseSequence)
                {
                    case "":
                        responseSequence += PromptUser("Is it cold outside? (Yes/No)");
                        break;

                    case "yes":
                        responseSequence += PromptUser("Is it snowing or expected to snow? (Yes/No)");
                        break;

                    case "yesyes":
                        resultBuilder.AppendLine("Suggestion: Wear a thick winter coat, scarf, gloves, snow boots, and a warm hat. Stay warm like a cozy marshmallow!");
                        complete = true;
                        break;

                    case "yesno":
                        responseSequence += PromptUser("Is it windy? (Yes/No)");
                        break;

                    case "yesnoyes":
                        resultBuilder.AppendLine("Suggestion: Wear a warm coat, scarf, and a windproof jacket. You don’t want to be blown around like a kite!");
                        complete = true;
                        break;

                    case "yesnono":
                        responseSequence += PromptUser("Do you plan to stay out after sunset? (Yes/No)");
                        break;

                    case "yesnonoyes":
                        resultBuilder.AppendLine("Suggestion: Wear a warm coat, sweater, and gloves. Add a hat to keep your ears warm!");
                        complete = true;
                        break;

                    case "yesnonono":
                        resultBuilder.AppendLine("Suggestion: Wear a warm coat and a sweater. Layers are like friends – the more, the better.");
                        complete = true;
                        break;

                    case "no":
                        responseSequence += PromptUser("Is it hot outside? (Yes/No)");
                        break;

                    case "noyes":
                        responseSequence += PromptUser("Is there high humidity? (Yes/No)");
                        break;

                    case "noyesyes":
                        resultBuilder.AppendLine("Suggestion: Wear light clothes that don’t stick to your skin. You don’t want to feel like a wet towel.");
                        complete = true;
                        break;

                    case "noyesno":
                        responseSequence += PromptUser("Is there a lot of sun? (Yes/No)");
                        break;

                    case "noyesnoyes":
                        resultBuilder.AppendLine("Suggestion: Wear a hat, sunglasses, and light clothes. Don’t forget sunscreen – you’re not a roast chicken!");
                        complete = true;
                        break;

                    case "noyesnono":
                        resultBuilder.AppendLine("Suggestion: Wear light and comfy clothes. Stay cool, don’t sweat it!");
                        complete = true;
                        break;

                    case "nono":
                        responseSequence += PromptUser("Is it rainy or expected to rain? (Yes/No)");
                        break;

                    case "nonoyes":
                        resultBuilder.AppendLine("Suggestion: Wear a raincoat, waterproof shoes, and carry an umbrella. Don’t end up looking like a wet cat!");
                        complete = true;
                        break;

                    case "nonono":
                        responseSequence += PromptUser("Is it a mild day or is there a slight breeze? (Yes/No)");
                        break;

                    case "nononoyes":
                        resultBuilder.AppendLine("Suggestion: Wear a light jacket or a sweater. Perfect for feeling comfy!");
                        complete = true;
                        break;

                    case "nononono":
                        resultBuilder.AppendLine("Suggestion: Regular, comfy clothes will do. Enjoy the nice weather!");
                        complete = true;
                        break;

                    default:
                        resultBuilder.AppendLine("No more suggestions available.");
                        complete = true;
                        break;
                }
            }

            return resultBuilder.ToString();
        }

        private static string PromptUser(string question)
        {
            Console.WriteLine(question);
            string answer;
            do
            {
                answer = Console.ReadLine()?.Trim().ToLower() ?? ""; // Handles potential null input
                if (answer != "yes" && answer != "no")
                {
                    Console.WriteLine("Invalid response. Please type 'Yes' or 'No'.");
                }
            } while (answer != "yes" && answer != "no");

            return answer;
        }

        public override void DisplayLastResult()
        {
            Console.WriteLine("Last Decision Tree Calculation:");
            Console.WriteLine(lastResult);
        }
    }
}

