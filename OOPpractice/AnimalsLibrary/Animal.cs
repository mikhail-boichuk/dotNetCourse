using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLibrary
{
    public abstract class Animal
    {
        public string Name { get; private set; }

        public abstract void Eat();

        public abstract void Move();

        public void Intorduce()
        {
            Console.WriteLine("Hello, my name is {0}", Name);
        }
    }
}
