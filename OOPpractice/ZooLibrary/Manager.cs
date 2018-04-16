using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalsLibrary;
using AnimalsLibrary.Interfaces;

namespace ZooLibrary
{
    public class Manager
    {
        public string Name { get; private set; }

        public Manager(string name)
        {
            Name = name;          
        }

        public void AddAnimalsToZoo(List<Animal> animals, Zoo zoo)
        {
            foreach (Animal animal in animals)
            {
                if (animal is IPredator)
                {
                    zoo.PredatorsAviary.Add(animal);
                } else
                {
                    zoo.HerbivorousAviary.Add(animal);
                }
            }
        }

        public void CloseZoo(Zoo zoo)
        {
            zoo.IsClosed = true;
        }

        public void OpenZoo(Zoo zoo)
        {
            zoo.IsClosed = false;
        }
    }
}
