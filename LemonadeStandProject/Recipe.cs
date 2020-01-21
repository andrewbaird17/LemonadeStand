﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Recipe
    {
        //Member Variables (HAS A)
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;
        //Constructor
        public Recipe()
        {
            amountOfLemons = 4;
            amountOfSugarCubes = 4;
            amountOfIceCubes = 5;
            pricePerCup = 0.25;
        }
        //Member Methods (CAN DO)
        public void ChangeAmountOfLemonsInRecipe()
        {
            Console.WriteLine("Enter new amount of lemons for your recipe!");
            Int32.TryParse(Console.ReadLine(), out amountOfLemons);          
        }
        public void ChangeAmountOfSugarCubes()
        {
            Console.WriteLine("Enter new amount of sugar cubes for your recipe!");
            Int32.TryParse(Console.ReadLine(), out amountOfSugarCubes);
        }
        public void ChangeAmountOfIceCubes()
        { 
            Console.WriteLine("Enter new amount of ice cubes for your recipe!");
            Int32.TryParse(Console.ReadLine(), out amountOfIceCubes);
        }
        public void ChangePriceOfCup()
        {
            Console.WriteLine("Enter the new price of your glass of lemonade!");
            double.TryParse(Console.ReadLine(), out pricePerCup);
        }
    }
}
