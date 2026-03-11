using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_Punkt
{
    class Punkt
    {
        private int x;
        private int y;
        private int xp, yp;

        public Punkt(int wsp_x, int wsp_y)
        {
            x = wsp_x;
            y = wsp_y;
        }

        public void Wyswietl()
        {
            Console.WriteLine("x= " + x + " y= " + y);
        }

        public void Przesun(int dod_x, int dod_y)
        {
            xp = dod_x;
            yp = dod_y;
            x = x + dod_x;
            y = y + dod_y;
        }

        public void Cofnij_Przesun()
        {
            x = x - xp;
            y = y - yp;
        }
    }
}
