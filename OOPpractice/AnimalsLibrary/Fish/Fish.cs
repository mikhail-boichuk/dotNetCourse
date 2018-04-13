using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalsLibrary.Interfaces;

namespace AnimalsLibrary.Fish
{
    public abstract class Fish : Animal, IDiver
    {
        public void Dive()
        {
            Console.WriteLine("{0} is diving", this.GetType());
        }

        public override void Move()
        {
            Console.WriteLine("{0} is swimming", this.GetType());
        }
    }
}
