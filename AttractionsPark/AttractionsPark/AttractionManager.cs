using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttractionsPark
{
    public enum Attractions { Batman, Swan, Pony };
    class AttractionManager
    {
        // Class fields
        private int _cashbox;
        private Days _day;

        // Class Contructor
        public AttractionManager (Days day)
        {
            _cashbox = 0;
            _day = day;
        }

        // Class interfaces -------------------------------------------------------
        public void TakeFee(Kid kid, Attractions attraction)
        {
            // Get list of attractions where kid can go today
            List<Attractions> availableAttractions = MatchAttractions(kid.GetHeight(), kid.GetGender());

            int cost = 0;
            switch (attraction)
            {
                case Attractions.Batman:
                    cost = AttractionSettings.GetBatmanPrice();
                    break;
                case Attractions.Swan:
                    cost = AttractionSettings.GetSwanPrice();
                    break;
                case Attractions.Pony:
                    cost = AttractionSettings.GetPonyPrice();
                    break;
            }
            // Check if kid can go to attraction
            if (availableAttractions.Contains(attraction) && kid.GetCash() >= cost)
            {
                kid.RideAttraction(attraction, cost);
                _cashbox += cost;
            } else
            {
                Console.WriteLine("{0} cannot go to {1}", kid.GetName(), attraction);
                kid.Cry();
            }
        }
        // ------------------------------------------------------------------------

        //Getters -----------------------------------------------------------------
        public int GetCashBox()
        {
            return _cashbox;
        }
        //-------------------------------------------------------------------------

        // Auxillary private methods ----------------------------------------------
        // Aquire attrations available today
        private List<Attractions> GetAvailableAttr()
        {
            List<Attractions> avalaibleAttractions = new List<Attractions>();

            if (_day != Days.Sunday)
            {
                avalaibleAttractions.Add(Attractions.Pony);
            }
            if (_day == Days.Monday || _day == Days.Wednesday || _day == Days.Friday)
            {
                avalaibleAttractions.Add(Attractions.Batman);
            }
            if (_day == Days.Tuesday || _day == Days.Wednesday || _day == Days.Thursday)
            {
                avalaibleAttractions.Add(Attractions.Swan);
            }

            return avalaibleAttractions;
        }

        // Match available attractions with kid's parameters
        private List<Attractions> MatchAttractions(int height, Gender gender)
        {
            List<Attractions> matchedAttractions = new List<Attractions>();
            foreach (Attractions attr in GetAvailableAttr())
            {
                switch (attr)
                {
                    case Attractions.Batman:
                        if (attr == Attractions.Batman && gender == Gender.male && height > 150)
                            matchedAttractions.Add(attr);
                        break;
                    case Attractions.Swan:
                        if ((gender == Gender.male && height < 140) || (gender == Gender.female && height > 120 && height < 140))
                            matchedAttractions.Add(attr);
                        break;
                    case Attractions.Pony:
                        matchedAttractions.Add(attr);
                        break;
                }
            }
            return matchedAttractions;
        }
        //-------------------------------------------------------------------------
    }
}
