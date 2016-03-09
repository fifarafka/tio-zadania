using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Ant : Animal
    {
        public bool IsQuenn { get; set; }

        public Ant()
        {
            Name = "ant";
            HaveFur = false;
            IsQuenn = false;
        }

        public Ant(string name)
        {
            Name = name;
        }

        public override string Sound()
        {
            return "Bzz";
        }

        public override string Trick()
        {
            return "Jugglery";
        }

        public override int CountLegs()
        {
            return 6;
        }
    }
}
