using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Elephant : Animal
    {
        public Elephant()
        {
            Name = "elephant";
            HaveFur = false;
        }

        public Elephant(string name)
        {
            Name = name;
        }

        public override string Sound()
        {
            return "Łiii";
        }

        public override string Trick()
        {
            return "standing on two legs";
        }

        public override int CountLegs()
        {
            return 4;
        }
    }
}
