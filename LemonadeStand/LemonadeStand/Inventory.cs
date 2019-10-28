using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {

        public List<Lemon> lemons;
        public List<IceCube> iceCubes;
        public List<Cup> cups;
        public List<SugarCube> sugarCubes;

        public Inventory()
        {
            lemons = new List<Lemon>();
            iceCubes = new List<IceCube>();
            cups = new List<Cup>();
            sugarCubes = new List<SugarCube>();
        }

        public void DisplayInventory()
        {
            Console.WriteLine("Here is your current inventory.");
            Console.WriteLine(lemons.Count);
            Console.WriteLine(iceCubes.Count);
            Console.WriteLine(cups.Count);
            Console.WriteLine(sugarCubes.Count);
            
        }

        public void MeltRemainingIce()
        {
            
        }
   
        public void AddLemons(int userInput)
        {
            for (int i = 0; i < userInput; i++)
            {
                Lemon lemon = new Lemon();
                lemons.Add(lemon);
            }
        }

        public void AddIce(int userInput)
        {
            for (int i = 0; i < userInput; i++)
            {
                IceCube ice = new IceCube();
                iceCubes.Add(ice);
            }
        }

        public void AddSugar(int userInput)
        {
            for (int i = 0; i < userInput; i++)
            {
                SugarCube sugar = new SugarCube();
                sugarCubes.Add(sugar);
            }
        }

        public void AddCups(int userInput)
        {
            for (int i = 0; i < userInput; i++)
            {
                Cup cup = new Cup();
                cups.Add(cup);
            }
        }
    }
}
