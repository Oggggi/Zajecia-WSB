using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Length
    {
        int m, cm;
        public Length(int m, int cm)
        {
            this.m = m;
            this.cm = cm;
        }
        public static Length operator +(Length L1, Length L2)
        {
            int metry = L1.m + L2.m;
            int centymetry = L1.cm + L2.cm;

            if (centymetry >= 100)
            {
                metry += centymetry / 100;
                centymetry %= 100;
            }

            return new Length(metry, centymetry);
        }
        public static Length operator *(int mnoznik, Length len)
        {
            int wszystkieCm = (len.m * 100 + len.cm) * mnoznik;

            int metry = wszystkieCm / 100;
            int centymetry = wszystkieCm % 100;

            return new Length(metry, centymetry);
        }
        public string GetLength()
        {
            return $"Length : {m} metrow {cm} centymetrow";
        }
    }
}
