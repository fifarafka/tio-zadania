using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Giraffe : Animal
    {
        public Giraffe()
        {
            Name = "giraffe";
            HaveFur = false;
        }

        public Giraffe(string name)
        {
            Name = name;
        }

        public override string Sound()
        {
            return "Eeeeee";
        }

        public override string Trick()
        {
            return "Iceskating";
        }

        public override int CountLegs()
        {
            return 4;
        }
    }
}
