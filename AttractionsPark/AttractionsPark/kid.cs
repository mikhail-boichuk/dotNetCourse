using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AttractionsPark
{
    public enum Gender { male, female };

    class Kid
    {
        // Class fields
        private string _name;
        private Gender _gender;
        private int _age, _height, _weight, _cash;
        private int _satisfactionLevel = 0;
        
        // Class constants
        private const int MAX_AGE = 18; // years
        private const int MAX_HEIGHT = 180; // Centimeters
        private const int MAX_WEIGHT = 100; // Kilos
        private const int MAX_CASH = 100; // USD
        private const int MAX_SATISFACTION_LEVEL = 100; // Percents

        // Class constructor
        public Kid (string name, Gender gendrer, int age, int height, int weight, int cash)
        {
            _name = name;
            _gender = Gender.male;
            if (gendrer == Gender.female)
            {
                _gender = gendrer;
            } else
            {
                _gender = Gender.male;
            }
            _age = NormalizeIfOutOfRange(age, MAX_AGE);
            _height = NormalizeIfOutOfRange(height, MAX_HEIGHT);
            _weight = NormalizeIfOutOfRange(weight, MAX_WEIGHT);
            _cash = NormalizeIfOutOfRange(cash, MAX_CASH);
        }

        // Class interfaces --------------------------------------------------
        public void RideAttraction (int cost)
        {
            Console.WriteLine("{0} is riding on attraction");
            _cash -= cost;
            if (_satisfactionLevel <= MAX_SATISFACTION_LEVEL)
            {
                _satisfactionLevel += cost;
            } else
            {
                Console.WriteLine("{0} is totally happy", _name);
            }
        }

        public void Cry ()
        {
            if ( _height <= MAX_HEIGHT)
            {
                for (int i = 1; i <= 3; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("{0} is crying...{1} sec", _name, i);
                }
                _height += 2;
            } else
            {
                Console.WriteLine("{0} is too big to cry", _name);
            }
        }
        //-------------------------------------------------------------------------

        // Normalization function for inputs --------------------------------------
        private int NormalizeIfOutOfRange(int val, int threshold)
        {
            if (val <= 0 && val >= threshold)
            {
                Console.WriteLine("info: one of kid's parameters is out of range - nomalizing {0} => {1}", val, threshold/2);
                return threshold / 2;
            }
            return val;
        }
        //-------------------------------------------------------------------------

        // Getters ----------------------------------------------------------------
        public string GetName()
        {
            return _name;
        }

        public Gender GetGender()
        {
            return _gender;
        }

        public int GetHeight()
        {
            return _height;
        }

        public int GetWeight()
        {
            return _weight;
        }

        public int GetAge()
        {
            return _age;
        }

        public int GetCash()
        {
            return _cash;
        }

        public int GetSatisfationLevel()
        {
            return _satisfactionLevel;
        }
        //-----------------------------------------------------------------------
    }
}
