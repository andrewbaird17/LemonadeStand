using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Inventory
    {
        //Member Variables (HAS A)
        public List<Lemon> lemons;
        public List<IceCube> icecubes;
        public List<Cup> cups;
        public List<SugarCube> sugarCubes;
        Recipe 
            recipe;
        public Lemon lemon;
        public SugarCube sugarcube;
        public IceCube icecube;
        public Cup cup;
        //Constructor
        public Inventory()
        {
            lemons = new List<Lemon>();
            icecubes = new List<IceCube>();
            cups = new List<Cup>();
            sugarCubes = new List<SugarCube>();
            lemon = new Lemon();
            icecube = new IceCube();
            cup = new Cup();
            sugarcube = new SugarCube();
        }
        //Member Methods (CAN DO)
        
        public void SubtractLemonsFromInventory()
        {
            for (int i = 0; i < recipe.amountOfLemons; i++)
            {
                lemons.RemoveAt(0);
            }
        }
        public void SubtractSugarCubesFromInventory()
        {
            for (int i = 0; i < recipe.amountOfSugarCubes; i++)
            {
                sugarCubes.RemoveAt(0);
            }
        }
        public void SubtractIceCubesFromInventory()
        {
            for (int i = 0; i < recipe.amountOfIceCubes; i++)
            {
                icecubes.RemoveAt(0);
            }
        }
        public bool CheckForEnoughLemons(bool enoughLemons)
        {
            if (lemons.Count() == recipe.amountOfLemons)
            {
                return enoughLemons = true;
            }
            else
            {
                return enoughLemons = false;
            }

        }
        public bool CheckForEnoughSugarCubes(bool enoughSugarCubes)
        {
            if (sugarCubes.Count() >= recipe.amountOfLemons)
            {
                return enoughSugarCubes = true;
            }
            else
            {
                return enoughSugarCubes = false;
            }
        }
        public bool CheckForEnoughIceCubes(bool enoughIceCubes)
        {
            if (icecubes.Count() >= recipe.amountOfIceCubes)
            {
                return enoughIceCubes = true;
            }
            else
            {
                return enoughIceCubes = false;
            }
        }
    }
}
