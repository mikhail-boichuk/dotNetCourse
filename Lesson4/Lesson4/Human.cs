using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Human
    {
        string Name { get; set; }

        public Human (string name)
        {
            Name = name;
        }

        public void Speak ()
        {
            Console.WriteLine("Hello, my name is {0}", Name);
        }

        public void Walk()
        {
            Console.WriteLine("{0} is walking", Name);
        }
    }

    class Kid : Human
    {
        public Kid(string name) : base(name)
        {
        }
    }

    class SuperKid : Kid
    {
        public SuperKid(string name) : base(name)
        {
        }
    }



}
