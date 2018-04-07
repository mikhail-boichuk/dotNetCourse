using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttractionsPark
{

    class AttractionManager
    {
        // Class fields
        private int _cashbox;

        //Class constants
        private const int MAX_CASH = 200; // USD
        private const int BATMAN_COST = 20; // USD
        private const int SWAN_COST = 10; // USD
        private const int PONY_COST = 10; // USD

        public AttractionManager ()
        {
            _cashbox = 0;
        }

        // Class interfaces -------------------------------------------------------
        public void TakeFee(Kid kid, Attractions attraction)
        {
            int cost = 0;
            // check for money and then ride or cry
            switch (attraction)
            {
                case Attractions.Batman:
                    cost = BATMAN_COST;
                    break;
                case Attractions.Swan:
                    cost = SWAN_COST;
                    break;
                case Attractions.Pony:
                    cost = PONY_COST;
                    break;
            }

            if (kid.GetCash() >= cost)
            {
                kid.RideAttraction(cost);
                _cashbox += cost;
            } else
            {
                Console.WriteLine("{0} have not enough money for {1}", kid.GetName(), attraction);
                kid.Cry();
            }
        }
        // ------------------------------------------------------------------------
    }
}
