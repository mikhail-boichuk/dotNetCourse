using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLibrary.Mammals
{
    public class Horse : Mammal
    {
        public override void Eat()
        {
            Console.WriteLine("{0} is eating grass", this.GetType());
        }
    }
}
