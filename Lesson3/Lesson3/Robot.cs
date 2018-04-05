using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Robot
    {
        public string _name { get; }
        public string _material { get; }
        private int _bateryLevel = 100;

        public Robot(string name, string material)
        {
           _name = name;
           _material = material;
        }

        public void Walk()
        {
            Console.WriteLine("{0} is walking", _name);
            _bateryLevel--;
            Console.WriteLine("Battery level is: {0}%", _bateryLevel);
        }

        public void Talk()
        {
            Console.WriteLine("{0} says: Kill all humans!", _name);
            _bateryLevel -= 2;
            Console.WriteLine("Battery level is: {0}%", _bateryLevel);
        }
    }
}
