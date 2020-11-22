using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExplorationGame.Scenes;
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

        }

        public void Start()
        {

            
            myMainOptionsScene.Run();



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



       
 
    }
}
