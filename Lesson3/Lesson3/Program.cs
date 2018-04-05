using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Robot verder = new Robot("Verder", "plastic");
            Robot terminator = new Robot("T-1000", "liquid metal");

            verder.Walk();
            terminator.Talk();

            Console.ReadLine();
            */

            CofeeMachine coffeeDominator = new CofeeMachine(60, 70, 30);

            coffeeDominator.PrepareCofee(1);
            Console.ReadLine();
        }
    }
}
