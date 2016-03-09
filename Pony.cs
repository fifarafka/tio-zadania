using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Pony : Animal
    {
        public bool IsMagic { get; set; }

        public Pony()
        {
            Name = "pony";
            HaveFur = true;
            IsMagic = true;
        }

        public Pony(string name)
        {
            Name = name;
        }

        public override string Sound()
        {
            return "Ihahaha";
        }

        public override string Trick()
        {
            return "Can talk";
        }

        public override int CountLegs()
        {
            return 4;
        }
    }
}
