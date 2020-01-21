﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Store
    {
        //Member Variables (HAS A)       
        Inventory storeInventory;
        public Player player;
        public int numberOfItems;
        public double saleCost;
        //Constructor
        public Store()
        {
            storeInventory = new Inventory();
        }
        //Member Methods (CAN DO)

        public double SellLemons(Player player)
        {
            NumberItemsToPurchase();
            saleCost = storeInventory.lemon.purchasePrice * numberOfItems;
            AddLemonsToInventory(numberOfItems, player);
            return saleCost;
        }
        public void AddLemonsToInventory(int numberOfItems, Player player)
        {
            for (int i = 0; i < numberOfItems; i++)
            {
                player.inventory.lemons.Add(new Lemon());
            }
        }
        public double SellSugar(Player player)
        {
            NumberItemsToPurchase();
            saleCost = storeInventory.sugarcube.purchasePrice * numberOfItems;
            AddSugarToInventory(numberOfItems, player);
            return saleCost;
        }
        public void AddSugarToInventory(int numberOfItems, Player player)
        {
            for (int i = 0; i < numberOfItems; i++)
            {
                player.inventory.sugarCubes.Add(new SugarCube());
            }
        }
        public double SellIce(Player player)
        {
            NumberItemsToPurchase();
            saleCost = storeInventory.icecube.purchasePrice * numberOfItems;
            AddIceToInventory(numberOfItems, player);
            return saleCost;
        }
        public void AddIceToInventory(int numberOfItems, Player player)
        {
            for (int i = 0; i < numberOfItems; i++)
            {
                player.inventory.icecubes.Add(new IceCube());
            }
        }
        public double SellCups(Player player)
        {
            NumberItemsToPurchase();
            saleCost = storeInventory.cup.purchasePrice * numberOfItems;
            AddCupToInventory(numberOfItems, player);
            return saleCost;
        }
        public void AddCupToInventory(int numberOfItems, Player player)
        {
            for (int i = 0; i < numberOfItems; i++)
            {
                player.inventory.cups.Add(new Cup());
            }
        }
        public void NumberItemsToPurchase()
        {
            Console.WriteLine("How many items do you want?");
            Int32.TryParse(Console.ReadLine(), out numberOfItems);
        }
    }
}
