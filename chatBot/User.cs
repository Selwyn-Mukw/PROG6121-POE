using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace chatBot
{
    //create a class which will have two methods a welcomemessage and menu of questions method which the user can ask the chatbot
    public class User
    {
        public void welcomeMessage()
        {
            /*ask user for there name
             * The colour will also be modified to make the user experience more enjoyable and to make the text more visible on the console
             * Also add a 5 second delay in line 22 to make the user experience more enjoyable and to give the user time to read the ASCII image before being prompted to enter their name
             * Also add a 2 second delay in the responsiveness of the app in line 23
             */
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Black;
            Thread.Sleep(5000);
            Console.Write("Please Enter your name: ");
            string name = Console.ReadLine();
            Thread.Sleep(2000);

            Console.WriteLine($"\nHello {name} Welcome to the cyber security hub.\nI will be helping you remain safe online .Below are some topics which can help you learn more about Cyber Security");

        }

        // Create a class which will contain the menu of questions the user can ask the chatbot
        public void DisplayMenu()
        {
            //if what the user selects )number is 1-10 is true then the code below in the condition will execute while if its false it will execute line 100
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("\n======================================================");
                Console.WriteLine("\n1. What is cyber security?");
                Console.WriteLine("\n2. What is phishing?");
                Console.WriteLine("\n3. What is malware?");
                Console.WriteLine("\n4. What is ransomware?");
                Console.WriteLine("\n5. What is a firewall?");
                Console.WriteLine("\n6. What is a VPN?");
                Console.WriteLine("\n7. how do I protect myself from cyber attacks?");
                Console.WriteLine("\n8. How do I create a strong password?");
                Console.WriteLine("\n9. What is two-factor authentication?");
                Console.WriteLine("\n10. How can I protect my personal data online?");
                Console.WriteLine("\n======================================================");
                Thread.Sleep(1000);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("\n*********************************************************************************************");
                Console.Write("Please choose a number on the menu to ask Ori the chatbot a question: or press '0' to exit: ");
                Console.WriteLine("\n*********************************************************************************************");
                string choice = Console.ReadLine();
                Thread.Sleep(1000);

                //This will execute should the user press 0 to exit the program
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.BackgroundColor = ConsoleColor.Black;
                if (choice == "0")
                {
                    Console.WriteLine("\nThank you for using the cyber security hub. Stay safe online!");
                    return;
                }

                // Create a switch statement which will display the definition of each number listed in the menu should the user select a number between 1-10
                switch (choice)
                {

                    case "1":
                        Console.WriteLine("\n1.Cyber security is the practice of protecting computers, networks, and data from unauthorized access, use, disclosure, disruption, modification, or destruction.");
                        break;
                    case "2":
                        Console.WriteLine("\n2.Phishing is a type of cyber attack that uses email or other forms of communication to trick people into providing sensitive information, such as passwords or credit card numbers.");
                        break;
                    case "3":
                        Console.WriteLine("\n3.Malware is a type of software that is designed to harm or exploit any programmable device, service, or network. It can take many forms, including viruses, worms, trojans, ransomware, and spyware.");
                        break;
                    case "4":
                        Console.WriteLine("\n4.Ransomware is a type of malware that encrypts a victim's files and demands payment in exchange for the decryption key.");
                        break;
                    case "5":
                        Console.WriteLine("\n5.A firewall is a network security system that monitors and controls incoming and outgoing network traffic based on predetermined security rules.");
                        break;
                    case "6":
                        Console.WriteLine("\n6.A VPN (Virtual Private Network) is a technology that creates a secure and encrypted connection over a less secure network, such as the internet. It allows users to protect their online privacy and access restricted content.");
                        break;
                    case "7":
                        Console.WriteLine("\n7.To protect yourself from cyber attacks, you should use strong passwords, keep your software up to date, be cautious when clicking on links or downloading attachments, and use a reputable antivirus program.");
                        break;
                    case "8":
                        Console.WriteLine("\n8.To create a strong password, you should use a combination of upper and lower case letters, numbers,and special characters. Avoid using common words or phrases, and make sure your password is at least 12 characters long.");
                        break;
                    case "9":
                        Console.WriteLine("\n9.Two-factor authentication (2FA) is an extra layer of security that requires not only a password but also something else that only the user has access to, such as a fingerprint or a one-time code sent to their phone.");
                        break;
                    case "10":
                        Console.WriteLine("\n10.To protect your personal data online, you should be cautious about what information you share on social media and other websites. Use privacy settings to control who can see your information, and be wary of phishing scams that try to steal your personal data.");
                        break;

                    //This Line of code will execute should a user input a number <10 .so should you say 11 then it will print the statement below, exception handling
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine("\nInvalid choice.We currently dont have that option.");
                        Thread.Sleep(1000);
                        break;

                }

            }
        }
    }
}

