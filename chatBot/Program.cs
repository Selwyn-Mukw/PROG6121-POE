using System;
using System.Media;
namespace chatBot
    

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //call the method to play the audio file
            AudioPlayer player = new AudioPlayer();
            player.PlayAudio(@"C:\Users\mukwe\Downloads\CyberGreeting.wav");

            //We will create an ACSII inmage which will display apon launching the application
            Console.WriteLine($"  █████████               ██████            █████                  ███████████  ███                     █████   \r\n ███░░░░░███             ███░░███          ░░███                  ░░███░░░░░░█ ░░░                     ░░███    \r\n░███    ░░░   ██████    ░███ ░░░   ██████  ███████   █████ ████    ░███   █ ░  ████  ████████   █████  ███████  \r\n░░█████████  ░░░░░███  ███████    ███░░███░░░███░   ░░███ ░███     ░███████   ░░███ ░░███░░███ ███░░  ░░░███░   \r\n ░░░░░░░░███  ███████ ░░░███░    ░███████   ░███     ░███ ░███     ░███░░░█    ░███  ░███ ░░░ ░░█████   ░███    \r\n ███    ░███ ███░░███   ░███     ░███░░░    ░███ ███ ░███ ░███     ░███  ░     ░███  ░███      ░░░░███  ░███ ███\r\n░░█████████ ░░████████  █████    ░░██████   ░░█████  ░░███████     █████       █████ █████     ██████   ░░█████ \r\n ░░░░░░░░░   ░░░░░░░░  ░░░░░      ░░░░░░     ░░░░░    ░░░░░███    ░░░░░       ░░░░░ ░░░░░     ░░░░░░     ░░░░░  \r\n                                                      ███ ░███                                                  \r\n                                                     ░░██████                                                   \r\n                                                      ░░░░░░                                                    ");

            //ask user for there name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello {name} Welcome to the cyber security hub.");

            //Menu of questions the user can ask the chatbot
            string[] options = new string[]
            {
                "1. What is cyber security?",
                "2. What is phishing?",
                "3. What is malware?",
                "4. What is ransomware?",
                "5. What is a firewall?",
                "6. What is a VPN?",
                "7. how do I protect myself from cyber attacks?",
                "8. How do I create a strong password?",
                "9. What is two-factor authentication?",
                "10. How can I protect my personal data online?",
                "11. What is a social engineering attack?",
                

                }
            }
        }
    // create a class which will play an audio file when the user starts the program
    class AudioPlayer

    {
        public void PlayAudio(string filePath)
        {
            // Create audio which will be played when the user starts the program
            SoundPlayer player = new SoundPlayer(filePath);
            player.Play();
            //player.PlaySync();
        }
    }

    class user
    {
       



    }
    
}
