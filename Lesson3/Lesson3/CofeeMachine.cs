using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson3
{
    public enum CoffeType { Espresso = 1, Americano };
    class CofeeMachine
    {
        private int _waterLevel;
        private int _waterTemperature;
        private int _coffeLevel;
        private const int MAX_LEVEL = 100;


        public CofeeMachine ()
        {
            _waterLevel = MAX_LEVEL;
            _waterTemperature = 20;
        }

        public CofeeMachine(int waterLevel, int waterTemperature, int coffeLevel)
        {
            _waterLevel = waterLevel;
            _waterTemperature = waterTemperature;
            _coffeLevel = coffeLevel;
        }

        public void HeatWater(int temperature)
        {
            if ( (temperature - _waterTemperature) > 0)
            {
                Console.WriteLine("Water temperature is {0} degree", _waterTemperature);
                for (int i = 0; i < 90 - _waterTemperature; i++ )
                {
                    _waterTemperature++;
                    Console.WriteLine("Heating... {0} degree", _waterTemperature);
                    Thread.Sleep(500);
                }
                Console.WriteLine("Heating DONE");
            } else
            {
                Console.WriteLine("Water temperature is OK");
            }
        }

        public void FillTank ()
        {
            Console.WriteLine("Tank is {0} % filled", _waterLevel);
            for (int i = 0; i < MAX_LEVEL - _waterLevel; i++)
            {
                _waterLevel++;
                Console.WriteLine("Filling... {0} %", _waterTemperature);
                Thread.Sleep(250);
            }
        }

        public void AddCoffeBeans()
        {
            for (int i = 0; i < MAX_LEVEL - _coffeLevel; i++)
            {
                _coffeLevel++;
                Console.WriteLine("Filling coffee... {0} %", _coffeLevel);
                Thread.Sleep(250);
            }
        }

        public void PrepareCofee(CoffeType coffeType)
        {
            if (_waterLevel <= 10)
            {
                Console.WriteLine("Water level is LOW please fill the tank");
                FillTank();
            }

            if (_coffeLevel <= 10)
            {
                Console.WriteLine("Coffee level is LOW please fill the tank");
                AddCoffeBeans();
            }

            switch (coffeType)
            {
                case CoffeType.Americano:
                    HeatWater(95);
                    _waterLevel -= 5;
                    _waterTemperature -= 5;
                    break;
                case CoffeType.Espresso:
                    HeatWater(90);
                    _waterLevel -= 10;
                    _waterTemperature -= 5;
                    break;
            }
            _coffeLevel -= 10;
            Console.WriteLine("Your {0} is ready! Bon apetit", coffeType);
        }
    }
}
