using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
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
                // we exclude one codition check, but in case of invalid input, programm will go thru all conditions anyway
                /* else
                {
                    Console.WriteLine("invalid");
                }
                */

                Console.WriteLine("wanna input again(y/n)?");
                cont = Convert.ToString(Console.ReadLine());

                if (cont == "y")
                {
                    continue;
                } else
                {
                    break;
                }
            }

        }
    }
}
