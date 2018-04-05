using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Robot
    {
        string _name { get; }
        string _material { get; }
        int _bateryLevel = 100;

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
