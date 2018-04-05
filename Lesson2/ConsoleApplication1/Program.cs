using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        // Recursion practice 

        public static bool IsPalindrome(string str)
        {
            if (str.Length >= 2)
            {
                // If first and last chars are identical, trim string and pass it to isPalindrome()
                if (str[0] == str[str.Length-1])
                {
                    return IsPalindrome(str.Substring(1,str.Length - 2));
                }
            } else
            {
                // When 1 or 0 chars left, return true
                return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
            // Input string
            Console.WriteLine("Please enter string:");
            string str = Convert.ToString(Console.ReadLine());

            // Check if string is a palindrome
            Console.WriteLine("Is it a palindrome? - {0}", IsPalindrome(str));
            Console.ReadLine();
        }
    }
}
