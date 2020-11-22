using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ExplorationGame
{
    class ConsoleUtils
    {
        public ConsoleUtils()
        {

        }

        public static void WaitForKeyPress()
        {
            ReadLine();
        }

        public static void QuitConsole()
        {
            Console.WriteLine("you are about to exit the game");
            Console.WriteLine("press any key to continue...");
            Console.ReadLine();
            Environment.Exit(0);
        }

  

    }
}
