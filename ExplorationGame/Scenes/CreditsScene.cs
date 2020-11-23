using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Media;
using System.IO;
namespace ExplorationGame.Scenes

{
    class CreditsScene : Scene
    {

        SoundPlayer sp;
        public CreditsScene(Game game) : base(game)
        {
            sp = MyGame.getSP();
        }
        public override void Run()
        {
            // credits sound
            sp = MyGame.getSP();
            
            sp.SoundLocation = "Audio/Fun_House.wav";
            sp.Load();
            sp.Play();
            string ghostArt;
            if (MyGame.getGD() == true) 
            {
                ghostArt = "GhostDefeated";
                
            }
            else
            {
                ghostArt = "Ghost";
            }
            Console.WriteLine(
            "\n" +
            "Thank you for playing:" +
            "\n" +
            "This game was created by David Graff and finished on 11/22/2020" +
            "\n" +
            "the tutorials found on this youtube channel helped out heavily:" +
            "\n" +
            "https://www.youtube.com/channel/UC_x9TgYAIFHj1ulXjNgZMpQ" +
            "\n" +
            "https://ascii.co.uk/art/ghost was used for a lot of the art" +
            "https://freesound.org/ for some of the audio" +
            "\n");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(
            "Would you like to play the game again?" +
            "\n\n")
            ;
            Console.ForegroundColor = ConsoleColor.White;
            //ending the game could be done better in game.cs
            MyGame.myInv.RemoveAll();

           
            string[] options = { "Yes", "No, Exit Game" };
            string art = Text_read_helper.ascii(ghostArt);
            Options_helper myOptions = new Options_helper(art, options);
            





            int choice = myOptions.MenuChoice();

            switch (choice)
            {
                case 1:
                    MyGame.myMainOptionsScene.Run();
                    return;
                case 2:
                    ConsoleUtils.QuitConsole();
                    return;

            }
            
        }

  
    }
}
