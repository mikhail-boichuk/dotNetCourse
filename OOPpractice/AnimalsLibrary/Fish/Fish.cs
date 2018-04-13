using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLibrary.Fish
{
    public abstract class Fish : Animal
    {
        public override void Move()
        {
            Console.WriteLine("{0} is swimming", this.GetType());
        }
    }
}
