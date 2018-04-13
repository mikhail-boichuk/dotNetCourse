using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLibrary.Reptiles
{
    public abstract class Reptile : Animal
    {
        public override void Move()
        {
            Console.WriteLine("{0} is crawling", this.GetType());
        }
    }
}
