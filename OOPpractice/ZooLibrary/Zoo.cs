using AnimalsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZooLibrary
{
    public class Zoo
    {
        public List<Animal> PredatorsAviary { get; set; }
        public List<Animal> HerbivorousAviary { get; set; }
        public DateTime Hours { get; set; }
        public bool IsClosed { get; set; }
        public Manager ZooManager { get; set; }

        public Zoo (Manager manager)
        {
            PredatorsAviary = new List<Animal>();
            HerbivorousAviary = new List<Animal>();
            Hours = DateTime.Now;
            IsClosed = true;
            ZooManager = manager;
        }
    }
}
