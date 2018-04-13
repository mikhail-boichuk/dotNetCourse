using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLibrary.Reptiles
{
    public class Lizard : Reptile
    {
        public override void Eat()
        {
            Console.WriteLine("{0} is eating insects", this.GetType());
        }
    }
}
