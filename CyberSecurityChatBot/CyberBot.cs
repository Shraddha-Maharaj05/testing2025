using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatBot
{
    // CyberBot class: Orchestrates the cybersecurity awareness chat
    class CyberBot
    {
        // Private fields to hold instances of the helper services
        private readonly GreetingService _greetingService; // Handles welcome sound
        private readonly QuestionService _questionService; // Handles predefined questions
        private readonly TopicService _topicService; // Handles cybersecurity topics
        private readonly DisplayService _displayService; // Handles console display

        // Constructor: Initializes the CyberBot with its dependencies (services)
        public CyberBot()
        {
            // Create instances of the helper services
            _greetingService = new GreetingService();
            _questionService = new QuestionService();
            _topicService = new TopicService();
            _displayService = new DisplayService();
        }

        // StartChat method: Manages the main chat flow
        public void StartChat()
        {
            _greetingService.PlayWelcomeSound(); // Play the welcome sound using the GreetingService

            _displayService.DisplayAsciiArt(); // Display the ASCII art using the DisplayService

            // Get the user's name from the console
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            // Display the welcome message using the DisplayService
            _displayService.DisplayWelcomeMessage(userName);

            // Ask predefined questions using the QuestionService
            _questionService.AskPredefinedQuestions(userName);

            // Main loop to keep the chat going until the user chooses to exit
            bool keepGoing = true;
            while (keepGoing)
            {
                _displayService.DisplayMenu();

                // Get the user's choice from the console
                Console.Write("\nEnter your choice (1-4): ");
                string choice = Console.ReadLine();
                Console.Clear();

                // Process the user's choice
                switch (choice)
                {
                    case "1":
                        // Display information about phishing emails using the TopicService
                        _topicService.PhishingInfo();
                        break;
                    case "2":
                        // Display information about safe password practices using the TopicService
                        _topicService.PasswordInfo();
                        break;
                    case "3":
                        // Display information about suspicious links using the TopicService
                        _topicService.SuspiciousLinksInfo();
                        break;
                    case "4":
                        // Display the goodbye message using the DisplayService and exit the loop
                        _displayService.DisplayGoodbyeMessage(userName);
                        keepGoing = false;
                        break;
                    default:
                        // Display an invalid choice message using the DisplayService
                        _displayService.DisplayInvalidChoiceMessage();
                        break;
                }
            }
        }
    
}
}
