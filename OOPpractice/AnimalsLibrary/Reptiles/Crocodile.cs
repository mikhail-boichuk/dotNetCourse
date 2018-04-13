using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalsLibrary.Interfaces;

namespace AnimalsLibrary.Reptiles
{
    public class Crocodile : Reptile, IPredator
    {
        public override void Eat()
        {
            Console.WriteLine("{0} is eating fish ant meat", this.GetType());
        }

        public void NotSeatWithHerbivorous()
        {
            Console.WriteLine("{0} is a predator and cannot sit with herbivorous", this.GetType());
        }
    }
}
