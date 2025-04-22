using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatBot
{
    // DisplayService class: Handles all console output formatting
    class DisplayService
    {
        // DisplayAsciiArt method: Displays the ASCII art banner
        public void DisplayAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
  ______   ______  _____ ____  ____  _____ ____ _   _ ____  ___ _______   __        .----.
 / ___\ \ / / __ )| ____|  _ \/ ___|| ____/ ___| | | |  _ \|_ _|_   _\ \ / /       / .--. \
| |    \ V /|  _ \|  _| | |_) \___ \|  _|| |   | | | | |_) || |  | |  \ V /       | |    | |
| |___  | | | |_) | |___|  _ < ___) | |__| |___| |_| |  _ < | |  | |   | |        | |____| |
 \____| |_| |____/|_____|_| \_\____/|_____\____|\___/|_| \_\___| |_|_ _|_|_       |  ____  |
   / \ \      / / \  |  _ \| ____| \ | | ____/ ___/ ___|  | __ ) / _ \_   _|      | |    | |
  / _ \ \ /\ / / _ \ | |_) |  _| |  \| |  _| \___ \___ \  |  _ \| | | || |        | | -- | |
 / ___ \ V  V / ___ \|  _ <| |___| |\  | |___ ___) |__) | | |_) | |_| || |        | |____| |
/_/   \_\_/\_/_/   \_\_| \_\_____|_| \_|_____|____/____/  |____/ \___/ |_|        |________|                                                                  
                                      
");
            Console.ResetColor();
        }

        // DisplayWelcomeMessage method: Displays the welcome message to the user
        public void DisplayWelcomeMessage(string userName)
        {
            string welcomeMessage = $" Hello, {userName}! I'm your Cybersecurity Awareness bot.";
            string learnMessage = " What should we learn about today?";

            int boxWidth = Math.Max(welcomeMessage.Length, learnMessage.Length) + 4;
            string border = new string('═', boxWidth);

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"╔{border}╗");
            Console.WriteLine($"║ {welcomeMessage.PadRight(boxWidth - 2)} ║");
            Console.WriteLine($"║ {learnMessage.PadRight(boxWidth - 2)} ║");
            Console.WriteLine($"╚{border}╝");
            Console.ResetColor();
            Console.WriteLine();
        }

        // DisplayMenu method: Displays the main menu options
        public void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine("Please enter a number to select the topic that you would like to learn about:");
            Console.WriteLine("[1]Phishing Emails");
            Console.WriteLine("[2]Safe Password Practices");
            Console.WriteLine("[3]Recognising Suspicious Links");
            Console.WriteLine("[4]Exit");
            Console.WriteLine("══════════════════════════════════════════");
            Console.ResetColor();
        }

        // DisplayGoodbyeMessage method: Displays the goodbye message to the user
        public void DisplayGoodbyeMessage(string userName)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Thank you for chatting, {userName}! Come Back Soon! :)");
            Console.ResetColor();
        }

        // DisplayInvalidChoiceMessage method: Displays an error message for invalid menu choices
        public void DisplayInvalidChoiceMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("XXX Invalid choice. Please select a valid option (1-4).\n");
            Console.ResetColor();
        }

        // DisplayTipsWithBox method: Displays a list of tips within a box
        public void DisplayTipsWithBox(string[] lines, ConsoleColor borderColor)
        {
            // Calculate the maximum width of the lines
            int width = 0;
            foreach (string line in lines)
                if (line.Length > width) width = line.Length;

            // Add padding to the width
            width += 4; // padding
            string border = new string('═', width);

            // Display the box with the tips
            Console.ForegroundColor = borderColor;
            Console.WriteLine($"╔{border}╗");
            foreach (string line in lines)
            {
                Console.WriteLine($"║ {line.PadRight(width - 2)} ║");
            }
            Console.WriteLine($"╚{border}╝\n");
            Console.ResetColor();
        }
    }
}
