using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorationGame.Scenes
{
    class Library : Scene
    {
        
        public Library(Game game) : base(game)
        {

        }
        public override void Run()
        {
            Console.WriteLine("lots of books here");
            string[] op = { "Browse the books","Lookup a book on the computer", "Leave Library", "Exit Game" };
        
            string Art = Text_read_helper.ascii("Library");

            Options_helper myOptions = new Options_helper(Art, op);

            Item Key = new Item("Key", "A skeleton key");

            Items LibraryItems = new Items(Key);
            
            switch (myOptions.MenuChoice())
            {
                case 1:
                  

                    Console.WriteLine("You find some spooky books but nothing of interest");
                    MyGame.myLibraryScene.Run();
                    
                    
                    return;
                case 2:
                    Console.WriteLine(Text_read_helper.ascii("LibraryComp"));
                    Console.WriteLine("type the name of the book: ");
                    string DVCBook = Console.ReadLine();
                    if (DVCBook.ToLower().Contains("davinci"))
                    {
                        Console.WriteLine("You get the ISBN and find the book... inside you find the pages have been cut out specifically to hold a key");
                        Console.WriteLine("You found a skeleton key");
                        MyGame.myInv.invAdd(LibraryItems.returnItem("Key"));
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("a search for {0} turns up nothing of interest, perhaps someone at the arcade knows more about eradicating ghosts", DVCBook);
                    }
                 

                    MyGame.myLibraryScene.Run();
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
