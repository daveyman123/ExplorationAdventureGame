﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorationGame
{
    class Items

    {
        List<Item> ItemsLst;
        public Items()
        {
            ItemsLst = new List<Item>();
        }
        
        public Items(Item Item)
        {
            ItemsLst = new List<Item>();
            ItemsLst.Add(Item);
        }

        public void addItem(Item Item)
        {
            ItemsLst.Add(Item);
        }

        public List<Item> getItems()
        {
            return ItemsLst;
        }
       
        public Item GetRandom()

        {
         
            Random randomNumber = new Random();
            int number;
            if (this.ItemsLst.Count > 0)
            {
                number = randomNumber.Next(ItemsLst.Count-1);
                Item itm = ItemsLst[number];
                return itm;

            }
            else return null;
        }
        public void RemoveItem(Item itm)
        {
            ItemsLst.Remove(itm);
        }

        public Item returnItem(string Name)
        {
            Item selectedItem = null;
            foreach (Item element in ItemsLst)
            {
                if (element.getName() == Name)
                {
                    selectedItem = element;
                }
                else
                    selectedItem = null;
            }
            return selectedItem;
        }


    }

}
