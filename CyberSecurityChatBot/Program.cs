using System;
using System.Media;
using System.Threading;

namespace CyberSecurityChatBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the CyberBot class
            CyberBot bot = new CyberBot();
            // Start the chat session
            bot.StartChat();
        }
    }
}

