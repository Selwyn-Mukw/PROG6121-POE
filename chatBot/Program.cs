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
            User welcomeMessage = new User();
            welcomeMessage.welcomeMessage();

           

            //Menu of questions the user can ask the chatbot
            User menu = new User();
            menu.DisplayMenu();

        }

     }
 

}
