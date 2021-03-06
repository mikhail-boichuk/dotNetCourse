﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    //Lesson 2. Topics:
    //  - Functions
    //  - Arrays
    //  - Lists
    //  - Exceptions handeling

    enum Days { Monday = 1 , Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
    enum Attractions { Batman, Swan, Pony };
    enum Gender { male, female };

    class Program
    {
        // Aquire attrations available today
        public static List<Attractions> GetAvailableAttr(Days day)
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
                //------------- Implementation with switch -------------
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
                /*
                //------------- Implementation with else if -----------
                if (attr == Attractions.Batman && gender == Gender.male && height > 150)
                {
                    matchedAttractions.Add(attr);
                } else if (attr == Attractions.Swan && ((gender == Gender.male && height < 140) || (gender == Gender.female && height > 120 && height < 140)))
                {
                    matchedAttractions.Add(attr);
                } else if (attr == Attractions.Pony)
                {
                    matchedAttractions.Add(attr);
                }
                //-----------------------------------------------------
                */
            }
            return matchedAttractions;
        }

        // Print list of matched attractions and kids name
        public static void PrintMatchedAttrations (String name, List<Attractions> matchedAttractions)
        {
            Console.WriteLine("{0} can go to:", name);
            if (matchedAttractions.Count > 0)
            {
                foreach (Attractions attr in matchedAttractions)
                {
                    Console.WriteLine(attr);
                }
            } else
            {
                Console.WriteLine("None");
            }
        }

        // Get data for all kids
        static void FillIputData(int[] heights, Gender[] genders,string[] names)
        {
            // Get input from commandline
            for (int i = 0; i < names.Length; i++)
            {
                // Handle incorrect input
                try
                {
                    Console.WriteLine("Please enter kids name:");
                    names[i] = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Please enter kids height:");
                    heights[i] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter gender:");
                    genders[i] = Gender.male;
                    if (Convert.ToString(Console.ReadLine()) == "female")
                    {
                        genders[i] = Gender.female;
                    }
                }
                catch (FormatException e)
                {
                    // We can analyze exception details and decide whether we what/can handle it or throw exception 
                    Console.WriteLine("{0} : Incorrect input format\n {1} \n\nWill set height to 0", e.GetType().Name, e.StackTrace);
                    heights[i] = 0;
                }
            }
        }

        static void Main(string[] args)
        {
            // Input day
            Console.WriteLine("Please enter day of week:");
            Days day = (Days)Convert.ToInt32(Console.ReadLine());
            // Input kids count
            Console.WriteLine("Please enter kids count:");
            int kidsCount = Convert.ToInt32(Console.ReadLine());
            // Allocate memory for arrays
            int[] heights = new int[kidsCount];
            Gender[] genders = new Gender[kidsCount];
            string[] names = new string[kidsCount];

            // Fill arrays with kids data
            FillIputData(heights, genders, names);
            
            for (int i = 0; i < kidsCount; i++)
            {
                // Print where kid can go today
                PrintMatchedAttrations(names[i], MatchAttractions(heights[i], genders[i], day));
            }
            
            Console.ReadLine();
        }
    }
}
