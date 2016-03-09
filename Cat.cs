using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Cat : Animal
    {
        public string Color { get; set; }

        public Cat()
        {
            Name = "cat";
            HaveFur = true;
            Color = "black";
        }

        public Cat(string name)
        {
            this.Name = name;
        }

        public override string Sound()
        {
            return "Miauuuu";
        }

        public override string Trick()
        {
            return "Can dance ballet";
        }

        public override int CountLegs()
        {
            return 4;
        }
    }
}
