using System;

namespace CyberBot_PROG_Prac1
{
    internal static class ShowMenuHelpers
    {


        public static void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\n***** CYBERSECURITY AWARENESS BOT MENU *****");
            Console.WriteLine("1. Password Safety");
            Console.WriteLine("2. Phishing");
            Console.WriteLine("3. Safe Browsing");
            Console.WriteLine("4. Exit");

            Console.ResetColor();
            CyberBot_PROG_Prac1.UI.TypeText("You can type a number OR  keyword like 'phishing'\n");
        }
    }
}