using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatBot
{
    // TopicService class: Handles displaying information about cybersecurity topics
    class TopicService
    {
        // Private field to hold an instance of the DisplayService
        private readonly DisplayService _displayService;

        // Constructor: Initializes the TopicService with its dependency (DisplayService)
        public TopicService()
        {
            _displayService = new DisplayService();
        }

        // PhishingInfo method: Displays information about phishing emails
        public void PhishingInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Phishing Emails");
            string[] tips = {
                "Phishing emails are fake messages that try to trick you into giving away personal information.",
                "Safety Tips:",
                "- Don’t click on suspicious links.",
                "- Check the sender’s email address.",
                "- Never share personal information via email."
            };
            _displayService.DisplayTipsWithBox(tips, ConsoleColor.Green);
        }

        // PasswordInfo method: Displays information about safe password practices
        public void PasswordInfo()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Safe Password Practices");
            string[] tips = {
                "Using strong, unique passwords helps protect your accounts.",
                "Safety Tips:",
                "- Use a mix of uppercase, lowercase, numbers, and symbols.",
                "- Avoid using the same password on multiple websites.",
                "- Change your passwords regularly."
            };
            _displayService.DisplayTipsWithBox(tips, ConsoleColor.Blue);
        }

        // SuspiciousLinksInfo method: Displays information about recognizing suspicious links
        public void SuspiciousLinksInfo()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Recognising Suspicious Links");
            string[] tips = {
                "Cybercriminals often use links to infect your device or steal your information.",
                "Safety Tips:",
                "- Hover over links to check the real URL.",
                "- Don’t click links from unknown or unexpected sources.",
                "- Be cautious with shortened URLs like bit.ly or tinyurl."
            };
            _displayService.DisplayTipsWithBox(tips, ConsoleColor.Magenta);
        }
    }
}
