using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalsLibrary.Interfaces;

namespace AnimalsLibrary.Mammals
{
    public class Tiger : Mammal, ICat
    {
        public void ClimbTree()
        {
            Console.WriteLine("{0} is climbing tree", this.GetType());
        }

        public override void Eat()
        {
            Console.WriteLine("{0} is eating wildfowl", this.GetType());
        }
    }
}
