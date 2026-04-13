using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CyberBot_PROG_Prac1
{
    internal class ChatBot
    {
        private string userName;

        public void Start()
        {
            
            UI.ShowLogo();
            Voice.PlayAudio();
            userName = GetUserInput.GetUsername();




            RunMenu();
        }


       
    

        void RunMenu()
        {
            string input;

            UI.TypeText("\nHow are you. What can I help you with?");
        

            while (true)
            {
                ShowMenuHelpers.ShowMenu();

                input = Console.ReadLine().ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    UI.TypeText("Please enter a valid option.");
                    continue;
                }

                if (input == "1" || input.Contains("password"))
                {
                    NavigateTo(PasswordSafety);
                }
                else if (input == "2" || input.Contains("phishing"))
                {
                    NavigateTo(Phishing);
                }
                else if (input == "3" || input.Contains("safe"))
                {
                    NavigateTo(SafeBrowsing);
                }
                else if (input == "4" || input == "exit")
                {
                    ExitApp();
                    break;
                }
                else
                {
                    UI.TypeText("I didnt catch that. Could you please rephase?");
                }
            }
        }

      
        void NavigateTo(Action page)
        {
            Console.Clear();
            page();
            ReturnToMenu();
        }

        void ReturnToMenu()
        {
            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }


        void PasswordSafety()
        {
            UI.TypeText("Password Safety");
            UI.TypeText("In order to keep yor data protected from unauthorized users, you must " +
                "use strong passwords with symbols, numbers, and letters.");
            UI.TypeText("Example: @KI32We$$");
            UI.TypeText("Avoid using your perosnal information such as your first name or birthdate.");
        }

        void Phishing()
        {
            UI.TypeText("Phishing");
            UI.TypeText("Phishing is when someeone pretends to be another person or from a company you trust so that they " +
                "can trick you into giving up your private information .");
            UI.TypeText("Signs of Phishing - Ask you to verify information via a link..");
            UI.TypeText("Don't click links in unexpected messages.");
           
        }

        void SafeBrowsing()
        {
            UI.TypeText("Safe Browsing");
            UI.TypeText("Safe browsing is the set of practices you use to reduce risk while you are on the internet.");
            UI.TypeText("The s in HTTPS and padlock icon in your address bar mean the connection is encrypted .");
            UI.TypeText(" Use an ad blocker and pop up blocker to stop malvertising and drive-by downloads.");
        }

        void ExitApp()
        {
            Console.Clear();
            UI.TypeText($"Goodbye {userName}!Thanks for visiting this site and remember to stay safe online!");
            Thread.Sleep(1000);
        }
    }
}

