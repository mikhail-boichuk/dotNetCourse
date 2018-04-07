using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttractionsPark
{
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
            // Input kids list
            List<Kid> kids = RegisterKids(kidsCount);
            
            //// Test pool of kids for fast debug
            //List<Kid> kids = new List<Kid>();
            //kids.Add(new Kid("Joe", Gender.male, -12, 145, -45, 100));
            //kids.Add(new Kid("Mary", Gender.female, 8, 125, 30, 90));
            //kids.Add(new Kid("Peter", Gender.male, 10, 125, 30, 20));
            
            // Initialize attraction manager
            AttractionManager am = new AttractionManager(day);
            
            while (am.GetCashBox() < 200)
            {
                // Counter for kids that spent all money
                int kidsWithNoMoney = 0;
                // Let each kid ride on attraction
                foreach (Kid k in kids)
                {
                    LetKidTryHisLuck(am, k);
                    if (k.GetCash() < 10) kidsWithNoMoney++;
                }
                // If all kids are out of money - close park
                if (kidsWithNoMoney == kids.Count)
                {
                    Console.WriteLine("Kids spent all of their money...");
                    break;
                }
            }

            ClosePark(kids);
            Console.WriteLine("Money earned: {0}", am.GetCashBox());

            // Few tests to be sure that interfaces of classes are working correctly
            //// Test Kid class
            //Kid joe = new Kid("Joe", Gender.male, -12, 145, -45, -85);
            //joe.RideAttraction(Attractions.Batman, 20);
            //joe.RideAttraction(Attractions.Pony, 10);
            //joe.Cry();
            //Console.WriteLine("name: {0}\nheight: {1}\nmoney left: {2}\nsatisfaction: {3}\n\n",
            //    joe.GetName(), joe.GetHeight(), joe.GetCash(), joe.GetSatisfationLevel());

            //// Test AttractionManager class
            //AttractionManager am = new AttractionManager();
            //am.TakeFee(joe, Attractions.Batman);
            //Console.WriteLine("Cash in cashbox {0}", am.GetCashBox());
            //am.TakeFee(joe, Attractions.Pony);
            //Console.WriteLine("Cash in cashbox {0}", am.GetCashBox());

            Console.ReadLine();
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

        static void LetKidTryHisLuck (AttractionManager manager, Kid kid)
        {
            var attractionsCount = Enum.GetNames(typeof(Attractions)).Length;
            // Kid will try to go to all attractions
            for (int i = 0; i < attractionsCount; i++)
            {
                manager.TakeFee(kid, (Attractions)i);
            }

        }

        // Close park
        static void ClosePark (List<Kid> kidsInThePark)
        {
            Console.WriteLine("--- The park is closed! ---");
            foreach (Kid kid in kidsInThePark)
            {
                Console.WriteLine("{0} is {1}% happy, money left: {2}USD", kid.GetName(), kid.GetSatisfationLevel(), kid.GetCash());
            }
        }

        // Read input and create kid
        static Kid ReadKidData()
        {
            int age, height, weight, cash;

            Console.WriteLine("---- Adding new kid ----");
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
                Console.WriteLine("{0} : Incorrect input format\n {1} \n\n!!!--- Will set all kid's params to -1 ---!!!\n", e.GetType().Name, e.StackTrace);
                age = height = weight = cash = -1;
            }

            return new Kid(name, gender, age, height, weight, cash);
        }
    }
}
