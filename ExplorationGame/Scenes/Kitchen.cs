using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace ExplorationGame.Scenes
{
    class Kitchen : Scene
    {
        SoundPlayer spookyPlayer;
        public Kitchen(Game game) : base(game)
        {

            

        }

        public override void Run()
        {
            Console.WriteLine("a spooky kitchen that doesnt seem like its been used in a while");
         
            string prompt = Text_read_helper.ascii("Haunted_House");
           
            Item knife = new Item("Knife", "A sharp kitchen knife");
            Items KitchenItems = new Items(knife);
      
                Console.WriteLine("You enter the kitchen and find an assortment of knives on the counter");
                String[] opt = { "pick up a knife", "leave the knife where it's at", "leave kithen", "exit game" };

                Options_helper kitchenMenu = new Options_helper(prompt,opt);
                switch (kitchenMenu.MenuChoice())
                {
                    case 1:
                        if (!MyGame.myInv.Contains("Knife"))

                        {
                        MyGame.getSP().SoundLocation = "Audio/knife-pick-up.wav";
                        MyGame.getSP().Load();
                        MyGame.getSP().Play();
                            MyGame.myInv.invAdd(KitchenItems.returnItem("Knife"));
                        }
                        else
                        {
                            Console.WriteLine("You already picked up the knife");
                        }
                        MyGame.myKitchenScene.Run();
                        return;
                    case 2:
                        if (MyGame.myInv.returnItem("Knife") != null)
                        {
                        MyGame.getSP().SoundLocation = "Audio/knife-drop.wav";
                        MyGame.getSP().Load();
                        MyGame.getSP().Play();
                        MyGame.myInv.RemoveItem(MyGame.myInv.returnItem("Knife"));
                        }
                        Console.WriteLine("You leave the knife");
                        MyGame.myKitchenScene.Run();
                        return;
                    case 3:
                            
                        MyGame.myInHouseScene.Run();
                        return;
                    case 4:
                        ConsoleUtils.QuitConsole();
                        return;
        
            }
            

        }

    }
}
