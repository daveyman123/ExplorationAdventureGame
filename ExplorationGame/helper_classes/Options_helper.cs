using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;

namespace ExplorationGame
{
    class Options_helper
    {
        String[] opt = new String[] { "Go to the Haunted House", "Bowling Alley", "Library", "Arcade", "Exit Game" };
        string prompt = "";

        public Options_helper(string prompt)
        {
            this.prompt = prompt;
        }
        public Options_helper(string[] opt)
        {
            this.opt = opt;
        }
        public Options_helper(string prompt, String[] opt)
        {
            this.opt = opt;
            this.prompt = prompt;
        }

        public int MenuChoice()
        {
           
            string output = "";
            output += "\n " + prompt + "\n";
            int Choice = 0;
            output += "Your options are: ";
            int counter = 1;
            for (int i = 0; i < opt.Length - 1; i++)
            {

                output += counter + ") " + opt[i] + " or ";
                counter = counter + 1;

            }

            output += opt.Length + ") " + opt[opt.Length - 1] + "\nType a number corresponding to your choice \n";
            Console.WriteLine(output);
            var x = Console.ReadLine();

            Console.Clear();
            int.TryParse(x, out Choice);

            var isNumeric = (!string.IsNullOrEmpty(x) && x.All(Char.IsDigit));
            


            while (!isNumeric || Choice > opt.Length || Choice <= 0)
            {
                Console.WriteLine(output);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("you must enter a digit between 1-" + opt.Length);
                Console.ForegroundColor = ConsoleColor.White;
                x = Console.ReadLine();


                int.TryParse(x, out Choice);

                isNumeric = !string.IsNullOrEmpty(x) && x.All(Char.IsDigit);

                
            }
            Console.Clear();
            return Choice;
        }
    }
}
