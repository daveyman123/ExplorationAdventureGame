using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorationGame.Scenes
{
    class InHouse : Scene
    {
        
        public InHouse(Game game) : base(game)
        {

        }
        public override void Run()
        {
            Console.WriteLine("it smells musty in here");
            string[] op = { "Go to the kitchen", "living room(Beware: there is a ghost in there!)", "Leave house", "Exit Game" };
            string houseArt = Text_read_helper.ascii("Haunted_House");

            Options_helper myOptions = new Options_helper(houseArt, op);
           
            
            switch (myOptions.MenuChoice())
            {
                case 1:
                    MyGame.myKitchenScene.Run();
                    return;
                case 2:
                    MyGame.myLivingRoomScene.Run();
                    return;
                case 3:
                    // try to leave house
                    Console.WriteLine("You are trapped in here");
                    MyGame.myInHouseScene.Run();
                    return;
                case 4:
                    ConsoleUtils.QuitConsole();
                    return;
            }
        }
    }
}
