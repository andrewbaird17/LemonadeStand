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
        Recipe recipe;
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
        

    }
}
