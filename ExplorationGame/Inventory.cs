﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
namespace ExplorationGame
{
    class Inventory
    {
        //Items list the player has
        List<Item> Inv = new List<Item>();
       
  
        public Inventory()
        {

        }


    
    public void invAdd(Item item)
    {
        if (!Inv.Contains(item))
        {

                Console.ForegroundColor
            = ConsoleColor.Green;
                Inv.Add(item);
            Console.WriteLine(item.getName() + " was added to your inventory", Console.ForegroundColor);
                Console.ForegroundColor
= ConsoleColor.White;
            }
    }

    public List<Item> invGet()
        {
            return Inv;
        }

        public bool Contains(string Name)
        {
            bool hasItem = false;
            foreach (Item element in Inv) 
            {
                if (element.getName() == Name)
                {
                    hasItem = true;
                }
                
            }
            return hasItem;
        }

        public void RemoveItem(Item itm)
        {
            if (Contains(itm.getName()))
            {
                Inv.Remove(itm);
                Console.WriteLine(itm.getName() + " was removed from your person");
            }
            else
            {
                
            }
        }
        public void RemoveAll()
        {
            this.Inv.Clear();
        }
        public Item returnItem(string Name)
        {
            Item selectedItem = null;
            foreach (Item element in Inv)
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
