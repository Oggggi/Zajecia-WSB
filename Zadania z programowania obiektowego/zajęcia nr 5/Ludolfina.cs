using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    interface ILeibniz
    {
        double Ludolfina(int n);
    }
    interface IEuler
    {
        double Ludolfina(int n);
    }
    class Obliczenia : ILeibniz, IEuler
    {
        double ILeibniz.Ludolfina(int n)
        {
            double pi = 0;
            for (int i = 0; i < n; i++)
            {
                pi += Math.Pow(-1, i) / (2 * i + 1);
            }
            return pi * 4;
        }

        double IEuler.Ludolfina(int n)
        {
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / (i * i);
            }

            return Math.Sqrt(6 * sum);
        }
    }
}
