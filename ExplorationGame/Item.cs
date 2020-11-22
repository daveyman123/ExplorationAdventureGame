using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorationGame
{
    class Item
    {
        string Name;
        string Description;
        public Item(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
        }

        public string getName()
        {
            return this.Name;
        }

        public string getDescription()
        {
            return this.Description;
        }

    }
}
