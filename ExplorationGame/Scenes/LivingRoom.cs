using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorationGame.Scenes
{
    class LivingRoom : Scene
    {
        public LivingRoom(Game game) : base (game)
        {

        }
        public override void Run() {
            Console.WriteLine("You Enter the Living room and a ghost appears behind you!\n");
            string[] options = { "make a call ghost busters or", "try to FIGHT the ghost?", "Exit Game" };
            string art = Text_read_helper.ascii("ghost");
            Options_helper helper = new Options_helper(art, options);
            int Choice = helper.MenuChoice();
            switch (Choice)
            {
                case 1:
                    Console.WriteLine("You call ghost busters and save the day");
                    MyGame.setGD(true);
                    MyGame.myCreditsScene.Run();
                    
                    return;
                case 2:
                    if (MyGame.myInv.Contains("Knife"))
                    {
                        Console.WriteLine("you fight off the ghost with a knife and save the day\nSuccess!\n");
                        Console.WriteLine("type enter to continue....");

                        Console.ReadLine();
                        MyGame.setGD(true);
                        MyGame.myCreditsScene.Run();
                        
                    }
                    else
                     Console.WriteLine("you die\n" +
                         "Would have been nice to have a kitchen knife.\n");
                  
                     Console.WriteLine("type enter to continue....\n");
                     
                    Console.ReadLine();

                    MyGame.myCreditsScene.Run();
                    return;
                case 3:
                    ConsoleUtils.QuitConsole();
                    return;
               
            }
        }
            
            
    }
}
