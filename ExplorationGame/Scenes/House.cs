using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorationGame.Scenes
{
    class House : Scene
    {
        
        public House(Game game) : base(game)
        {

        }
        public override void Run()
        {
            Console.WriteLine("it sure is a spooky looking house especially on halloween");
            string[] op = { "Go to the door", "Leave house", "Exit" };
            string houseArt = Text_read_helper.ascii("Haunted_House");

            Options_helper myOptions = new Options_helper(houseArt, op);
            
            switch (myOptions.MenuChoice())
            {
                case 1:
                    MyGame.myDoorScene.Run();
                    return;
                case 2:
                    MyGame.myMainOptionsScene.Run();
                    return;
            }
        }
    }
}
