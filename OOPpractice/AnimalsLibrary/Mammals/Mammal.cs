using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLibrary.Mammals
{
    public abstract class Mammal : Animal
    {
        public override void Move()
        {
            Console.WriteLine("{0} is walking", this.GetType());
        }
    }
}
