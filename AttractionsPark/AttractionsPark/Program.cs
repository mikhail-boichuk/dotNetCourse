using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttractionsPark
{
    public enum Attractions { Batman, Swan, Pony };
    public enum Days { Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };

    class Program
    {
        static void Main(string[] args)
        {
            // Input day
            Console.WriteLine("Please enter day of week:");
            Days day = (Days)Convert.ToInt32(Console.ReadLine());
            // Input kids count
            Console.WriteLine("Please enter kids count:");
            int kidsCount = Convert.ToInt32(Console.ReadLine());
            // Input all kids
            List<Kid> kids = RegisterKids(kidsCount);

        }


        // Create list of kids
        static List<Kid> RegisterKids(int kidsCount)
        {
            List<Kid> kids = new List<Kid>();
            for (int i = 0; i < kidsCount; i++)
            {
                kids.Add(ReadKidData());
            }
            return kids;
        }

        public void LetKidTryHisLuck (Kid kid, Days day)
        {
            List<Attractions> availableAttractions = MatchAttractions(kid.GetHeight(), kid.GetGender(), day);

            foreach (Attractions attraction in availableAttractions)
            {

            }

        }

        public void ClosePark ()
        {

        }

        // Auxillary private methods ----------------------------------------
        // Read input and create kid
        private static Kid ReadKidData()
        {
            int age, height, weight, cash;

            Console.WriteLine("Please enter kid's name:");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please enter gender:");
            Gender gender = Gender.male;
            if (Convert.ToString(Console.ReadLine()) == "female")
            {
                gender = Gender.female;
            }

            try
            {
                Console.WriteLine("Please enter kid's age:");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter kid's height:");
                height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter kid's weight:");
                weight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter kid's cash:");
                cash = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("{0} : Incorrect input format\n {1} \n\n!!!--- Will set incorrect params to -1 ---!!!", e.GetType().Name, e.StackTrace);
                age = height = weight = cash = -1;
            }

            return new Kid(name, gender, age, height, weight, cash);
        }

        // Aquire attrations available today
        private static List<Attractions> GetAvailableAttr(Days day)
        {
            List<Attractions> avalaibleAttractions = new List<Attractions>();

            if (day != Days.Sunday)
            {
                avalaibleAttractions.Add(Attractions.Pony);
            }
            if (day == Days.Monday || day == Days.Wednesday || day == Days.Friday)
            {
                avalaibleAttractions.Add(Attractions.Batman);
            }
            if (day == Days.Tuesday || day == Days.Wednesday || day == Days.Thursday)
            {
                avalaibleAttractions.Add(Attractions.Swan);
            }

            return avalaibleAttractions;
        }

        // Match available attractions with kid's parameters
        public static List<Attractions> MatchAttractions(int height, Gender gender, Days day)
        {
            List<Attractions> matchedAttractions = new List<Attractions>();
            foreach (Attractions attr in GetAvailableAttr(day))
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

        // -------------------------------------------------------------
    }
}
