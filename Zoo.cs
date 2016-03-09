using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Zoo
    {
        public List<Animal> Animals { get; set; }
        public string Name { get; set; }

        public Zoo(string name)
        {
            Animals = new List<Animal>();
            this.Name = name;

            Animals.Add(new Ant("Kili"));
            Animals.Add(new Ant("Fili"));
            Animals.Add(new Pony("Dori"));
            Animals.Add(new Pony("Nori"));
            Animals.Add(new Cat("Ori"));
            Animals.Add(new Cat("Bifur"));
            Animals.Add(new Cat("Bombur"));


        }

        public string Sounds()
        {
            string sounds = "";
            foreach (Animal a in Animals)
            {
                sounds = sounds + a.Sound() + "\n";
            }
            return sounds;
        }

        public Animal FirstWithFur()
        {
            Animal a;
            a = Animals.FirstOrDefault(animal => animal.HaveFur = true);
            return a;
        }
    }
}
