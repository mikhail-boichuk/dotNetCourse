using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalsLibrary;
using AnimalsLibrary.Interfaces;
using AnimalsLibrary.Fish;
using AnimalsLibrary.Mammals;
using AnimalsLibrary.Reptiles;
using ZooLibrary;

namespace OOPpractice
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static List<Animal> GetAnimalsList()
        {
            List<Animal> animals = new List<Animal>();

            // Add fishes
            animals.Add(new GoldFish());
            animals.Add(new Shark());
            // Add mammals
            animals.Add(new Horse());
            animals.Add(new Lion());
            animals.Add(new Tiger());
            // Add Reptiles
            animals.Add(new Crocodile());
            animals.Add(new Frog());
            animals.Add(new Lizard());
            
            return animals;
        }

    }
}
