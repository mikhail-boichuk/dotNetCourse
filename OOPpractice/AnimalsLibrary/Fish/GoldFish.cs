using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLibrary.Fish
{
    public class GoldFish : Fish
    {
        public override void Eat()
        {
            Console.WriteLine("{0} is eating feed", this.GetType());
        }
    }
}
