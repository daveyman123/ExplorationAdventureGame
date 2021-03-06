﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExplorationGame.Scenes;
using System.Media;
namespace ExplorationGame 
{
    class Game
    {

        //inventory
        public Inventory myInv;


        //title scene
        public Title myTitleScene;
        public House myHouseScene;
        public Door myDoorScene;
        public InHouse myInHouseScene;
        public Kitchen myKitchenScene;

        //main nav
        public MainOptions myMainOptionsScene;

        //BowlingAlleyScene
        public BowlingAlley myBowlingAlleyScene;
        //ArcadeScene
        public Arcade myArcadeScene;
        //LibraryScene
        public Library myLibraryScene;
        //LivingRoomScene
        public LivingRoom myLivingRoomScene;

        //Credits Scene
        public CreditsScene myCreditsScene;

        //ghost defeated field
        protected bool ghostDefeated;

        //make a soundplayer
        SoundPlayer spookyPlayer;

        //play again field
        public static bool playAgain = true;
        public Game()
        {
            //instantiate the inventory
            myInv = new Inventory();

            //instantiate the scenes
            myTitleScene = new Title(this);
            myMainOptionsScene = new MainOptions(this);
            myHouseScene = new House(this);
            myDoorScene = new Door(this);
            myInHouseScene = new InHouse(this);
            myKitchenScene = new Kitchen(this);
            myArcadeScene = new Arcade(this);
            myBowlingAlleyScene = new BowlingAlley(this);
            myLibraryScene = new Library(this);
            myLivingRoomScene = new LivingRoom(this);
            myCreditsScene = new CreditsScene(this);

            //goal of game to defeat the ghost
            ghostDefeated = false;

            //instantiate soundplayer
            spookyPlayer = new SoundPlayer();

            //instantiate play again field
            playAgain = true;



        }

        public void Start()
        {
           
            
            myTitleScene.Run();
            
        }

        public void End()
        {
            myCreditsScene.Run();
            
            
        }

       

        //get whether ghost is defeated
        public bool getGD()
        {
            return ghostDefeated;
        }

        //set whether ghost is defeated
        public void setGD(bool gd)
        {
            this.ghostDefeated = gd;
        }

        //access the soundplayer
        public SoundPlayer getSP()
        {
            return this.spookyPlayer;
        }

        //set whether to play again
        public static void setplayAgain(bool pa)
        {
            playAgain = pa;
        }


       //get whether to play again, this is static so we can access and change it outside instantiated classes
       public static bool getPlayAgain()
        {
            return playAgain;
        }
 
    }
}
