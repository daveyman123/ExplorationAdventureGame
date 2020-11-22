using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorationGame.Scenes
{
    class Door : Scene
    {
        
        public Door(Game game) : base(game)
        {

        }
        public override void Run()
        {
            Console.WriteLine("its a big door with a lock");
            string[] op = { "try to enter door", "leave", "Exit Game" };
            string Art = Text_read_helper.ascii("lock");

            Options_helper myOptions = new Options_helper(Art, op);
            
            switch (myOptions.MenuChoice())
            {
                case 1:
                    if (MyGame.myInv.Contains("Key"))
                    {

                        Console.WriteLine("You enter the Haunted House wearily. The door makes a loud creek as you enter");
                        MyGame.myInHouseScene.Run();
                    }
                    else
                    {
                        Console.WriteLine("The door is locked");
                        MyGame.myDoorScene.Run();
                    }
                    break;
                case 2:
                    MyGame.myMainOptionsScene.Run();
                    return;
                case 3:
                    ConsoleUtils.QuitConsole();
                    return;

            }
        }
    }
}
