using System;
using System.Collections.Generic;
using System.Text;

namespace chatBot
{
    //create a class which will display a menu of questions the user can ask the chatbot
    public class User
    {
        public void welcomeMessage()
        {
            //ask user for there name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello {name} Welcome to the cyber security hub.");
        }
        public void DisplayMenu()
        {
            Console.WriteLine("1. What is cyber security?");
            Console.WriteLine("2. What is phishing?");
            Console.WriteLine("3. What is malware?");
            Console.WriteLine("4. What is ransomware?");
            Console.WriteLine("5. What is a firewall?");
            Console.WriteLine("6. What is a VPN?");
            Console.WriteLine("7. how do I protect myself from cyber attacks?");
            Console.WriteLine("8. How do I create a strong password?");
            Console.WriteLine("9. What is two-factor authentication?");
            Console.WriteLine("10. How can I protect my personal data online?");
            Console.WriteLine("11. What is a social engineering attack?");
        }
    }
}
