using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void AgeDetector()
        {
            String cont;

            while (true)
            {
                Console.WriteLine("Please enter preson age:");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age <= 0 || age > 100)
                {
                    Console.WriteLine("invalid");
                }
                else if (age >= 1 && age < 18)
                {
                    Console.WriteLine("kid");
                }
                else if (age >= 18 && age < 60)
                {
                    Console.WriteLine("adult");
                }
                else if (age >= 60 && age <= 100)
                {
                    Console.WriteLine("old man");
                }

                Console.WriteLine("wanna try again?(y/n)");
                cont = Convert.ToString(Console.ReadLine());

                if (cont != "y")
                {
                    break;
                }
            }
        }

        public static void Numbers()
        {
            int count = 0, posCount = 0, negCount = 0, totalSum = 0;
            float avg;
            // My implementation below
            /*
            while (true)
            {   
                Console.WriteLine("please enter number");
                var num = Convert.ToInt32(Console.ReadLine());
                
                if (num == 0)
                {
                    if (count == 0)
                    {
                        Console.WriteLine("no numbers were entered");
                        break;
                    }
                    avg = (float)totalSum / count;
                    Console.WriteLine("Count: {0}\nPositive {1}\nNegative: {2}\nAverage: {3}", count, posCount, negCount, avg);
                    break;
                }
                else
                {
                    count++;
                    totalSum += num;
                    if (num > 0)
                    {
                        posCount++;
                    }
                    else
                    {
                        negCount++;
                    }
                }
            }
            */
            
            //More appropriate implementation with divison by section

            //input cycle
            while (true)
            {
                Console.WriteLine("please enter number");
                var num = Convert.ToInt32(Console.ReadLine());

                //Update counters 
                if (num > 0)
                {
                    posCount++;
                } else if (num < 0)
                {
                    negCount++;
                } else
                {
                    break;
                }
                count++;
                totalSum += num;
            }

            //Calculations and output
            if (count != 0)
            {
                avg = (float)totalSum / count;
                Console.WriteLine("Count: {0}\nPositive {1}\nNegative: {2}\nAverage: {3}", count, posCount, negCount, avg);
            } else
            {
                Console.WriteLine("no numbers were entered");
            }

            Console.ReadLine();
        }

        //in case of 'out' value MUST be modified
        static void OutTest(out int val)
        {
            val = 10;
        }

        //in case of 'ref' value CAN be modified
        static void RefTest(ref int val)
        {
            val = 8;
        }

        static void Main(string[] args)
        {
            //AgeDetector();
            Numbers();

            //test of 'ref' and 'out' keywords
            //both passes reference to object into function, so function can modify object
            int val = 25;
            RefTest(ref val);
            OutTest(out val);
        }
    }
}
