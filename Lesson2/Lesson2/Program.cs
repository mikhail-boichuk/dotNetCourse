using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
    enum Attractions { Batman, Swan, Pony };
    enum Gender { male, female };

    class Program
    {
        //aquire attrations available today
        public static List<int> GetAvailableAttr(Days day)
        {
            List<int> avalaibleAttractions = new List<int>();
            
            if (day == Days.Sunday)
            {
                avalaibleAttractions.Add((int)Attractions.Pony);
            }
            if (day == Days.Monday || day == Days.Wednesday || day == Days.Friday)
            {
                avalaibleAttractions.Add((int)Attractions.Batman);
            }
            if (day == Days.Tuesday || day == Days.Wednesday || day == Days.Thursday)
            {
                avalaibleAttractions.Add((int)Attractions.Swan);
            }

            return avalaibleAttractions;
        }

        //match available attractions with kid's parameters
        public static List<int> MatchAttractions(int height, Gender gender, Days day)
        {
            List<int> matchedAttractions = new List<int>();
            foreach (int attr in GetAvailableAttr(day))
            {
                if (attr == (int)Attractions.Batman && gender == Gender.male && height > 150)
                {
                    matchedAttractions.Add(attr);
                } else if (attr == (int)Attractions.Swan && ((gender == Gender.male && height < 140) || (gender == Gender.female && height > 120 && height < 140)))
                {
                    matchedAttractions.Add(attr);
                } else if (attr == (int)Attractions.Pony)
                {
                    matchedAttractions.Add(attr);
                }
            }
            return matchedAttractions;
        }

        //print list of matched attractions and kids name
        public static void PrintMatchedAttrations (String name, List<int> matchedAttractions)
        {
            Console.WriteLine("{0} can go to:", name);
            if (matchedAttractions.Count > 0)
            {
                foreach (int attr in matchedAttractions)
                {
                    Console.WriteLine((Attractions)attr);
                }
            } else
            {
                Console.WriteLine("None");
            }
        }

        static void Main(string[] args)
        {
            // get data from commandline
            Console.WriteLine("Please enter kids name:");
            String name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please enter kids height:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter day of week:");
            Days day = (Days)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter gender:");
            Gender gender = Gender.male; 
            if (Convert.ToString(Console.ReadLine()) == "female")
            {
                gender = Gender.female;
            }

            //print where kid can go today
            PrintMatchedAttrations(name, MatchAttractions(height, gender, day));
            Console.ReadLine();
        }
    }
}
