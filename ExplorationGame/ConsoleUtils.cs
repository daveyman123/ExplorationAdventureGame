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

        public static void WriteOptions()
        {
            Console.WriteLine("1) Haunted House 2) Bowling Alley 3) Library 4) Arcade 5) Exit");
        }
    }
}
