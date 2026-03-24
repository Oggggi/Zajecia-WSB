using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    static class Math2
    {
        public static int NWD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static int NWW(int a, int b)
        {
            return ((a * b)/NWD(a, b));
        }
    }
}
