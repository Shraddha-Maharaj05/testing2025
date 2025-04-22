using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatBot
{
    // GreetingService class: Handles playing the welcome sound
    class GreetingService
    {
        // PlayWelcomeSound method: Plays the welcome sound from a file
        public void PlayWelcomeSound()
        {
            try
            {
                // Create a SoundPlayer object and play the sound
                SoundPlayer player = new SoundPlayer("welcome.wav");
                player.Play();
            }
            catch
            {
                // Handle the exception if the sound file is not found
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" Voice greeting not found. Add 'welcome.wav' to your project folder.");
                Console.ResetColor();
            }
        }
    }
}

//Reference for voice message:
/*AI Voice Generator & Text to Speech (no date) ElevenLabs. Available at: https://elevenlabs.io/app/speech-synthesis/text-to-speech (Accessed: 13 April 2025).*/
