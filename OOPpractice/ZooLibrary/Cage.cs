using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalsLibrary;


namespace ZooLibrary
{
    public class Cage<T> where T : Animal
    {
        private List<T> _animalsList;

        public Cage()
        {
            _animalsList = new List<T>();
        }
        
        public void Add(T item)
        {
            _animalsList.Add(item);
        }
        
        public List<T> GetAnimalsList()
        {
           return _animalsList;
        }  
    }
}
