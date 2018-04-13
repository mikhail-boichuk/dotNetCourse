using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    //Polymorphysm

    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            //var unicorn = new Animal();
            var horse = new Horse();
            var dog = new Dog();

            // animals.Add(unicorn);
            animals.Add(horse);
            animals.Add(dog);

            MakeAnimalsTalk(animals);

            Console.ReadLine();
        }

        static void MakeAnimalsTalk(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                animal.Talk();
            }
        }
    }
}
