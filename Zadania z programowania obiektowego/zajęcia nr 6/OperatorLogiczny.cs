using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class OperatorLogiczny
    {
        public bool wartosc { get; set; }

        public OperatorLogiczny(bool wartosc)
        {
            this.wartosc = wartosc;
        }

        public static bool operator &(OperatorLogiczny a, OperatorLogiczny b)
        {
            if (!a.wartosc && !b.wartosc)
            {
                return true;
            }
            return a.wartosc && b.wartosc;
        }
    }
}
