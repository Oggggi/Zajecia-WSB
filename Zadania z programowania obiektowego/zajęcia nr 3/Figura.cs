using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Figura
    {
        public string kolor;
        public bool wypelnienie;

        public Figura(string kolor, bool wypelnienie)
        {
            this.kolor = kolor;
            this.wypelnienie = wypelnienie;
        }

        public override string ToString()
        {
            return $"{GetType().Name} - Kolor: {kolor}, Wypełnienie: {wypelnienie}";
        }

        public static int LiczbaElementow<T>(object[] tablica)
        {
            int count = 0;
            foreach (var element in tablica)
            {
                if (element.GetType() == typeof(T))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
