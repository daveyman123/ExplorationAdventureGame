using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorationGame.Scenes
{
    class Scene
    {
        //Player
        // titlescene
        // navigation

        protected Game MyGame;
        protected Inventory Inventory;
        public Scene(Game game)
        {
            MyGame = game;
        }

        virtual public void Run()
        {
            // Runs the actual scene logic
            // Override in child classes
        }

        
    }
}
