﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Media;
namespace ExplorationGame.Scenes
{
    class Title : Scene
    {

        SoundPlayer sp;
        public Title(Game game) : base(game)
        {
            
        }
        public override void Run()
        {
            sp = MyGame.getSP();
            sp.SoundLocation = "Audio/Fun_House.wav";
            sp.Load();
            sp.Play();
            string titleCredit = Text_read_helper.ascii("title") +
            "\n" +
            "The goal of the game is to eradicate the ghosts from the spooky haunted house" +
            "\n" +
            "Would you like to play?" +
            "\n"
            ;

            string[] options = { "Play", "Quit", "Credits"};
            Options_helper myOptions = new Options_helper(titleCredit, options);
           
           
            
            

            int choice = myOptions.MenuChoice();

            switch (choice)
            {
                case 1:
                    MyGame.myMainOptionsScene.Run();
                    return;
                case 2:
                    ConsoleUtils.QuitConsole();
                    return;
                case 3:
                    MyGame.myCreditsScene.Run();
                    return;
                    

            }
            
        }

  
    }
}
