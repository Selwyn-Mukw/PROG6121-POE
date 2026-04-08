using System;
using System.Media;
namespace chatBot
    

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create audio which will be played when the user starts the program
            SoundPlayer player = new SoundPlayer(@"C:\Users\mukwe\Downloads\CyberGreeting.wav");
            player.Play();
            player.PlaySync();
            
        }
    }
}
