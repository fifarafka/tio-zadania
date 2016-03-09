using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Animal
    {
        public string Name { get; set; }
   
        public float Weight{ get; set;}

        public bool HaveFur { get; set; }

        public virtual string Sound()
        {
            return "Sound undefined";
        }

        public virtual string Trick()
        {
            return "Trick undefined";
        }

        public virtual int CountLegs()
        {
            Console.WriteLine("Legs undefined");
            return 0;
        }
    }
}
