using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Events
{
    class Program
    {

        public delegate void ShoutHandler(Sergant s, EventArgs e);

        public class Sergant
        {
            public string Name { get; private set;}
            public event ShoutHandler Shout;

            public Sergant (string name)
            {
                Name = name;
            }

            public void StartGivingOrders()
            {
                while (true)
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("Sergant {0} is shouting", Name);
                    if (Shout != null)
                    {
                        Shout(this, null);
                    } else
                    {
                        Console.WriteLine("Nobody is listening to Sergant {0}", Name);
                        break;
                    }
                        
                }
            }

        }

        public class Soldier
        {
           private int _patience;

            public string Name { get; private set; }

            public Soldier (string name, int patience)
            {
                Name = name;
                _patience = patience;
            }

            public void Subscribe(Sergant s)
            {
                s.Shout += Obey;
            }

            private void Obey (Sergant s, EventArgs e )
            {
                if (_patience >= 0)
                {
                    Console.WriteLine("{0} says to Sergant {1}: Yes, sir!", Name, s.Name);
                    _patience--;
                } else
                {
                    Console.WriteLine("{0} says: Fuck you, Sergant {1}, I'm tired!", Name, s.Name);
                    s.Shout -= Obey;
                }
            }

        }

        static void Main(string[] args)
        {
            Sergant bilko = new Sergant("Bilko");

            Soldier john = new Soldier("John", 4);
            Soldier peter = new Soldier("Peter", 6);
            Soldier jerry = new Soldier("Jerry", 8);

            john.Subscribe(bilko);
            peter.Subscribe(bilko);
            jerry.Subscribe(bilko);

            bilko.StartGivingOrders();

            Console.ReadLine(); 
        }
    }
}
