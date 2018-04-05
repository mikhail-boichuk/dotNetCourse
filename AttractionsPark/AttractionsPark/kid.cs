using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttractionsPark
{
    enum Gender { male, female };

    class Kid
    {
        // Class fields
        private string _name;
        private Gender _gender;
        private int _age, _height, _weight, _cash;
        private int _satisfactionLevel = 0;
        
        // Class constants
        private const int MAX_AGE = 18;
        private const int MAX_HEIGHT = 180;
        private const int MAX_WEIGHT = 100;
        private const int MAX_CASH = 1000;
        private const int MAX_SATISFACTION_LEVEL = 100;

        // Class constructor
        public Kid (string name, Gender gendrer, int age, int height, int weight, int cash)
        {
            _name = name;
            _gender = gendrer;
            _age = NormalizeIfIncorrect(age, MAX_AGE);
            _height = NormalizeIfIncorrect(height, MAX_HEIGHT);
            _weight = NormalizeIfIncorrect(weight, MAX_WEIGHT);
            _cash = NormalizeIfIncorrect(cash, MAX_CASH);
        }

        // Normalization function for inputs
        private int NormalizeIfIncorrect(int val, int threshold)
        {
            if (val <= 0 && val >= threshold)
            {
                return threshold / 2;
            }
            return val;
        }

        // Getters
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

        public int GetSatisfationLEvel()
        {
            return _satisfactionLevel;
        }
    }
}
