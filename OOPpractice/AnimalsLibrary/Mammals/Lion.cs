using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalsLibrary.Interfaces;

namespace AnimalsLibrary.Mammals
{
    public class Lion : Mammal, ICat
    {
        public void ClimbTree()
        {
            Console.WriteLine("{0} is diving", this.GetType());
        }

        public override void Eat()
        {
            Console.WriteLine("{0} is eating wildfowl", this.GetType());
        }
    }
}
