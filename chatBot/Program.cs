using System;
using System.Media;
namespace chatBot
    

{
    internal class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\mukwe\Downloads\CyberGreeting.wav");
            player.Load();
            player.PlaySync();
            //Console.WriteLine("Welcome to the Cyber security Hub my Name is Ori and I will teach you how to be safe online ");
        }
    }
}
