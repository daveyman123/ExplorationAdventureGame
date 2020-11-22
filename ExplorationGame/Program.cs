using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using ExplorationGame.Scenes;
using static System.Console;
namespace ExplorationGame
{





    class Program
{
    static void Main(String[] args)
    {
        try
            {
                WindowWidth = 130;
                WindowHeight = 35;
            }
        catch
            {
                Console.WriteLine("Cannot create a big enough console window");
                Console.WriteLine("Try adjusting your font/console settings and restarting.");
                Console.WriteLine("You can continue playing, just be aware that some art might not render properly!");
                Console.ReadLine();
            }
        Game myGame = new Game();
        myGame.Start();
    }
}
}