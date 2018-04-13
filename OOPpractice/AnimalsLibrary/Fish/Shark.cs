using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLibrary.Fish
{
    public class Shark : Fish
    {
        public override void Eat()
        {
            Console.WriteLine("{0} is eating other fishes", this.GetType());
        }
    }
}
