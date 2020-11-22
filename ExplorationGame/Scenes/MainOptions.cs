using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ExplorationGame.Scenes
{
    class MainOptions : Scene
    {
        
        
        public MainOptions(Game game) : base(game)
        {
            
        }
        public override void Run()
        {
            string titleCredit = Text_read_helper.ascii("Main");
        
            

           
            Options_helper myOptions = new Options_helper(titleCredit);
           
           
            
            

            int choice = myOptions.MenuChoice();

            switch (choice)
            {
                case 1:
                    MyGame.myHouseScene.Run();
                    return;
                case 2:
                    //bowling alley
                    MyGame.myBowlingAlleyScene.Run();
                    return;
                case 3:
                    //run library
                    MyGame.myLibraryScene.Run();
                    return;
                case 4:
                    MyGame.myArcadeScene.Run();
                    // run arcade
                    return;
                case 5:
                    //exit
                    ConsoleUtils.QuitConsole();
                    return;
               

            }
            
        }

  
    }
}
