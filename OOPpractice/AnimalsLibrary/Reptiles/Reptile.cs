using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalsLibrary.Interfaces;

namespace AnimalsLibrary.Reptiles
{
    public abstract class Reptile : Animal, IDiver
    {
        public void Dive()
        {
            Console.WriteLine("{0} is diving", this.GetType());
        }

        public override void Move()
        {
            Console.WriteLine("{0} is crawling", this.GetType());
        }
    }
}
