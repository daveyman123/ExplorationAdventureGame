using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorationGame.Scenes
{
    class BowlingAlley : Scene
    {
        Items BA_Items;
        
        public BowlingAlley(Game game) : base(game)
        {
            Item Lint = new Item("some lint", "someone forgot to clean these shoes");


            Item Sock = new Item("a sock", "it smells funny");
            Item Token = new Item("Arcade token", "it says its worth one credit");

            //instantiate bowling alley items and add items
            BA_Items = new Items();
            BA_Items.addItem(Lint);
            BA_Items.addItem(Sock);
            BA_Items.addItem(Token);
            


        }
        public override void Run()
        {
            
            
          
            
            Console.WriteLine("The sound of pins being struck and people chattering around the alley can be heard in the distance");
            //your options are
            string[] op = { "to rent some bowling shoes (this step feels vaguely important)", "Bowl", "Leave Alley", "Exit Game" };
            string Art = Text_read_helper.ascii("BowlingAlley");

            Options_helper myOptions = new Options_helper(Art, op);

            Item randomItem;


            switch (myOptions.MenuChoice())
            {
                case 1:
                    // flavor text
                    Console.WriteLine("The worker looks at you funny and hands you a fresh pair of bowling shoes");
                    //get a random item from the list just created above
                    randomItem = BA_Items.GetRandom();

                    // check if there are any random items to get
                    if (randomItem != null)
                    {
                        // get the name and desc of a new item and print it out
                        Console.WriteLine("You find " + randomItem.getName() + "(" + randomItem.getDescription() + ") inside one of the shoes");


                        // remove the item from the BA items list of items available
                        BA_Items.RemoveItem(randomItem);
                        // add the item to the players inventory
                        MyGame.myInv.invAdd(randomItem);
                    }

                    //ReRun the scene to get options again
                    MyGame.myBowlingAlleyScene.Run();
                    
                    
                    return;
                case 2:
                    Random generate = new Random();
                    int scorez = generate.Next(33, 300);
                    string score = string.Format("you bowl a {0}", scorez);
                    Console.WriteLine(score);
                    if (scorez > 200)
                    {
                        Console.WriteLine("thats a great score");
                    }
                    else
                    {
                        Console.WriteLine("you can do better than that. Maybe you need some new shoes? Try again!");
                    }
                    MyGame.myBowlingAlleyScene.Run();
                    return;


                case 3:
                    //inventory system needs lots of work
                    Item Token = new Item("Arcade token", "it says its worth one credit");
                    BA_Items.addItem(Token);
                    MyGame.myMainOptionsScene.Run();
                    return;
                case 4:
                    ConsoleUtils.QuitConsole();
                    return;

            }
        }
    }
}
