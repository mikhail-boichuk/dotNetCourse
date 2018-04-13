using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public abstract class Animal
    {
        public string Name {get; set; }
        public string Breed { get; set; }
        // abstarct funtion
        public abstract void Talk();
        // virtual function
        public virtual void Walk()
        {
            // Walk on 4 legs
        }

        public virtual void Eat()
        {
            // Eat food
        }
    }
}
