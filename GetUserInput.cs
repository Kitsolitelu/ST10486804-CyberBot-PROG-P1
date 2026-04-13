using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberBot_PROG_Prac1
{
    internal class GetUserInput
    {
        
         public static string GetUsername()
        {
            UI.TypeText("What is your name?");
            string name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                UI.TypeText("Please enter a valid name:");
                name = Console.ReadLine();
            }

            return name;
        }
    }
}
