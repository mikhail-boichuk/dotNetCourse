using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalsLibrary.Interfaces;

namespace AnimalsLibrary.Mammals
{
    public class Lion : Mammal, ICat, IPredator
    {
        public void ClimbTree()
        {
            Console.WriteLine("{0} is diving", this.GetType());
        }

        public override void Eat()
        {
            Console.WriteLine("{0} is eating wildfowl", this.GetType());
        }

        public void NotSeatWithHerbivorous()
        {
            Console.WriteLine("{0} is a predator and cannot sit with herbivorous", this.GetType());
        }
    }
}
