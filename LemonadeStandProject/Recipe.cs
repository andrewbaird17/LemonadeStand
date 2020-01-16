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
        int amountOfLemons;
        int amountOfSugarCubes;
        int amountOfIceCubes;
        double pricePerCup;
        //Constructor
        public Recipe()
        {
            int amountOfLemons = 4;
            int amountOfSugarCubes = 4;
            int amountOfIceCubes = 5;
            double pricePerCup = 0.25;
        }
        //Member Methods (CAN DO)
        public void ChangeAmountOfLemonsInRecipe()
        {
            Console.WriteLine("Enter new amount of lemons for your recipe!");
            String userInput = Console.ReadLine();
            Int32.TryParse(userInput, out amountOfLemons);          
        }
        public void ChangeAmountOfSugarCubes()
        {
            Console.WriteLine("Enter new amount of sugar cubes for your recipe!");
            String userInput = Console.ReadLine();
            Int32.TryParse(userInput, out amountOfSugarCubes);
        }
        public void ChangeAmountOfIceCubes()
        {
            Console.WriteLine("Enter new amount of ice cubes for your recipe!");
            String userInput = Console.ReadLine();
            Int32.TryParse(userInput, out amountOfIceCubes);
        }
        public void ChangePriceOfCup()
        {
            Console.WriteLine("Enter new amount of lemons for your recipe!");
            String userInput = Console.ReadLine();
            double.TryParse(userInput, out pricePerCup);
        }
    }
}
