using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{

    class MainClass
    {
        private Circus c;
        private Zoo z;

        public MainClass()
        {
            this.c = new Circus("SuperCyrk");
            this.z = new Zoo("SuperZoo");
        }

        private void ShowCircusNames()
        {
            foreach (Animal a in c.Animals)
                Console.WriteLine(a.Name);
        }

        private void wykonajPolecenie(String polecenie)
        {
            if (polecenie.Length>1)
            {
                Console.WriteLine("Nie ma takiego polecenia. Spróbuj jeszcze raz");
            }
            else
            {
                int p = (int)polecenie[0];
                switch(p)
                {
                    case 49:
                        Console.Clear();
                        Console.WriteLine("Prezentacja zwierząt cyrku " + c.Name +" :\n");
                        Console.WriteLine(c.ShowPresentation());
                        break;
                    case 50:
                        Console.Clear();
                        Console.WriteLine("Programu cyrku: " + c.Name + " :\n");
                        Console.WriteLine(c.ShowTricks());
                        break;
                    case 51:
                        Console.Clear();
                        Console.WriteLine("Dźwięki Zoo: " + z.Name + " :\n");
                        Console.WriteLine(z.Sounds());
                        break;
                    case 52:
                        Console.Clear();
                        Console.WriteLine("Imię pierwszego znalezionego futrzaka w Zoo: " + z.Name + " :\n");
                        Console.WriteLine(z.FirstWithFur().Name + "\n");
                        break;
                    case 53:
                        Console.Clear();
                        Console.WriteLine("Wszystkie imiona zwierząt w Cyrku: " + c.Name + " :\n");
                        ShowCircusNames();
                        Console.WriteLine("\n");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Nie ma takiego polecenia. Spróbuj jeszcze raz \n");
                        break;

                }
            }
        }

        public void PrintCommandList()
        {
            Console.WriteLine("Wybierz co chcesz zrobić");
            Console.WriteLine("1 - Prezentacja zwierząt cyrku: " + c.Name);
            Console.WriteLine("2 - Obejrzenie programu cyrku: " + c.Name);
            Console.WriteLine("3 - Posłuchanie dźwięków Zoo: " + z.Name);
            Console.WriteLine("4 - Wyświetla imię pierwszego znalezionego futrzaka w Zoo: " + z.Name);
            Console.WriteLine("5 - Wyświetla wszystkie imiona zwierząt w Cyrku: " + c.Name);
        }
        static void Main(string[] args)
        {
            MainClass m = new MainClass();
            while (true)
            {
                m.PrintCommandList();
                string choice = Console.ReadLine();
                m.wykonajPolecenie(choice);
            }
            Console.ReadKey();
        }
    }
}
