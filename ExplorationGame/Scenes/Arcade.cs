using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
namespace ExplorationGame.Scenes
{
    class Arcade : Scene
    {
        
        public Arcade(Game game) : base(game)
        {

        }
        public override void Run()
        {

            Console.WriteLine("clattering and ringing of various arcade machines permiates through the dark room");
            string[] op = { "talk to the locals", "insert token and use the fortune teller", "leave Arcade", "Exit Game" };
            string Art = Text_read_helper.ascii("Arcade");

            Options_helper myOptions = new Options_helper(Art, op);
            
            switch (myOptions.MenuChoice())
            {
                case 1:
                  

                    Console.WriteLine("The locals dont have much to say, but they agree something needs to be done about the haunted house");
                    MyGame.myArcadeScene.Run();
                    
                    
                    return;
                case 2:

                    if (MyGame.myInv.Contains("Arcade token"))
                    {
                       

                        Console.WriteLine("the fortune says something ominous about 'The Davinci Code' (a book)");
                        MyGame.myInv.RemoveItem(MyGame.myInv.returnItem("Arcade token"));
                    }
                    else
                    {
                        Console.WriteLine("you dont have a token");
                    }

                    
                  
                    MyGame.myArcadeScene.Run();
                    return;
                case 3:
                    MyGame.myMainOptionsScene.Run();
                    return;
                case 4:
                    ConsoleUtils.QuitConsole();
                    return;

            }
        }
    }
}
