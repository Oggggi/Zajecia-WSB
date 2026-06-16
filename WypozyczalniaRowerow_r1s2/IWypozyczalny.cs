using System;
using System.Collections.Generic;
using System.Text;

namespace WypozyczalniaRowerow
{
    public interface IWypozyczalny
    {
        void Wypozycz();

        void Zwroc();

        bool CzyDostepny();
    }
}
