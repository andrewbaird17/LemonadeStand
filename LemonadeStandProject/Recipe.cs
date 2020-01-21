using System;
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
            amountOfLemons = UserInterface.GetUserInteger("Enter new amount of lemons for your recipe!");
        }
        public void ChangeAmountOfSugarCubes()
        {
            amountOfSugarCubes = UserInterface.GetUserInteger("Enter new amount of sugar cubes for your recipe!");
        }
        public void ChangeAmountOfIceCubes()
        {
            amountOfIceCubes = UserInterface.GetUserInteger("Enter new amount of sugar cubes for your recipe!");
        }
        public void ChangePriceOfCup()
        {
            Console.WriteLine("Enter the new price of your glass of lemonade!");
            double.TryParse(Console.ReadLine(), out pricePerCup);
        }
    }
}
