using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Kandydat
    {
        public string Nazwisko { get; set; }
        private int punktyMatematyka;
        private int punktyInformatyka;
        private int punktyJezykObcy;

        public int PunktyMatematyka
        {
            get { return punktyMatematyka; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException("Punkty z matematyki muszą mieć wartość między 0 a 100.");
                punktyMatematyka = value;
            }
        }

        public int PunktyInformatyka
        {
            get { return punktyInformatyka; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException("Punkty z informatyki muszą mieć wartość między 0 a 100.");
                punktyInformatyka = value;
            }
        }

        public int PunktyJezykObcy
        {
            get { return punktyJezykObcy; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException("Punkty z języka obcego muszą mieć wartość między 0 a 100.");
                punktyJezykObcy = value;
            }
        }

        public double ObliczLacznaLiczbePunktow()
        {
            return 0.6 * PunktyMatematyka + 0.5 * PunktyInformatyka + 0.2 * PunktyJezykObcy;
        }
    }
}
