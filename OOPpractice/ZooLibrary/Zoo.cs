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
        public DateTime Time { get; set; }
        public bool IsClosed { get; set; }

        public Zoo ()
        {
            PredatorsAviary = new List<Animal>();
            HerbivorousAviary = new List<Animal>();
            //Time = DateTime.Now();
            IsClosed = true;
        }
    }
}
