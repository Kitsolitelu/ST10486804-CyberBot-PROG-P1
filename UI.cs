using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CyberBot_PROG_Prac1
{
    internal class UI
    {
        public static void TypeText(string message, int delay = 20)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }

        
        public static void ShowLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("*******************************************");
            Console.WriteLine(" CYBERSECURITY AWARENESS BOT");
            Console.WriteLine("*******************************************");


            Console.WriteLine(@"    _____      _                                        _ _                                                               ____        _    
  / ____|    | |                                      (_) |             /\                                              |  _ \      | |   
 | |    _   _| |__   ___ _ __ ___  ___  ___ _   _ _ __ _| |_ _   _     /  \__      ____ _ _ __ ___ _ __   ___  ___ ___  | |_) | ___ | |_  
 | |   | | | | '_ \ / _ \ '__/ __|/ _ \/ __| | | | '__| | __| | | |   / /\ \ \ /\ / / _` | '__/ _ \ '_ \ / _ \/ __/ __| |  _ < / _ \| __| 
 | |___| |_| | |_) |  __/ |  \__ \  __/ (__| |_| | |  | | |_| |_| |  / ____ \ V  V / (_| | | |  __/ | | |  __/\__ \__ \ | |_) | (_) | |_  
  \_____\__, |_.__/ \___|_|  |___/\___|\___|\__,_|_|  |_|\__|\__, | /_/    \_\_/\_/ \__,_|_|  \___|_| |_|\___||___/___/ |____/ \___/ \__| 
         __/ |                                                __/ |                                                                       
        |___/                                                |___/                                                                        
        ");

            Console.ResetColor();
        }
    }
}

