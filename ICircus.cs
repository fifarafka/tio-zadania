using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    interface ICircus
    {
        string ShowPresentation();
        string AnimalsIntroduction();
        string ShowTricks();
        int Patter(int howMuch);
    }
}
