using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Circus : ICircus
    {
        public List<Animal> Animals { get; set; }
        public string Name { get; set; }

        public Circus()
        {
            Animals = new List<Animal>();
        }

        public Circus(String name)
        {
            Animals = new List<Animal>();
            this.Name = name;

            Animals.Add(new Ant("Kasia"));
            Animals.Add(new Ant("Basia"));
            Animals.Add(new Pony("Asia"));
            Animals.Add(new Pony("Zosia"));
            Animals.Add(new Cat("Wiesia"));
            Animals.Add(new Cat("Wisia"));
            Animals.Add(new Giraffe("Wacia"));
            Animals.Add(new Giraffe("Jola"));
            Animals.Add(new Elephant("Ola"));
            Animals.Add(new Elephant("Pola"));
        }


        public string ShowPresentation()
        {
            string names = "";
            foreach (Animal a in Animals)
            {
                names = names + a.Name + "\n";
            }
            return names;
        }

        public string AnimalsIntroduction()
        {
            string sounds = "";
            foreach (Animal a in Animals )
            {
                sounds = sounds + a.Sound()+"\n";
            }
            return sounds;
        }

        public string ShowTricks()
        {
            string tricks = "";
            foreach (Animal a in Animals)
            {
                tricks = tricks + a.Trick()+"\n";
            }
            return tricks;
        }

        public int Patter(int howMuch)
        {
            int patter = 0;
            foreach (Animal a in Animals)
            {
                patter = patter + a.CountLegs()*howMuch;
            }
            return patter;
        }

    }
}
