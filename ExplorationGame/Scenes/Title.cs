using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ExplorationGame.Scenes
{
    class Title : Scene
    {
        public Title(Game game) : base(game)
        {
          
        }
        public override void Run()
        {
            
            WriteLine("TItle scene is running!");
            Console.WriteLine("Adventure Game");
            Console.WriteLine(Text_read_helper.ascii("Art/title.txt"));
            Console.WriteLine("The goal of the game is to eradicate the ghosts from the spooky haunted house");
            Console.WriteLine("press enter to continue");
            ConsoleUtils.WaitForKeyPress();

            
        }

    }
}
