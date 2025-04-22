using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatBot
{
    // QuestionService class: Handles asking and answering predefined questions
    class QuestionService
    {
        // AskPredefinedQuestions method: Asks the user predefined questions and provides answers
        public void AskPredefinedQuestions(string userName)
        {
            // Display the available questions to the user
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nBefore we begin, {userName}, you can ask me one of the following questions:");
            Console.WriteLine("- How are you?");
            Console.WriteLine("- Why is cybersecurity important?");
            Console.WriteLine("- How do you know all this stuff?");
            Console.WriteLine("Or just press Enter to skip.\n");
            Console.ResetColor();

            Console.Write("Ask me a question: ");
            string question = Console.ReadLine().Trim().ToLower();

            // Provide an answer based on the user's question
            switch (question)
            {
                case "how are you?":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("I'm well thanks!");
                    Console.ResetColor();
                    break;
                case "why is cybersecurity important?":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Cybersecurity helps protect our data and privacy. It is an important topic in today's world.");
                    Console.ResetColor();
                    break;
                case "how do you know all this stuff?":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("I gather information through a combination of methods, including pre-programmed rules, training data, and access to external data sources");
                    Console.ResetColor();
                    break;
                case "":
                    Console.WriteLine("No problem, let's jump right in!\n");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Hmm... I only know how to answer those three questions for now. Sorry :(");
                    Console.ResetColor();
                    break;
            }

            Console.WriteLine();
        }
    }
}
