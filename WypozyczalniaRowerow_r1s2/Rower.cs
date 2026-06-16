using System;
using System.Collections.Generic;
using System.Text;

namespace WypozyczalniaRowerow
{
    public class Rower : IWypozyczalny
    {
        private static int kolejneId = 1;

        public int Id { get; }

        public TypRower Typ { get; set; }

        public string Marka { get; set; }

        public string Model { get; set; }

        public decimal CenaZaGodzine { get; set; }

        public decimal CenaZaDobe { get; set; }

        private bool dostepny;

        public Rower(
            TypRower typ,
            string marka,
            string model,
            decimal cenaZaGodzine,
            decimal cenaZaDobe)
        {
            Id = kolejneId++;

            Typ = typ;
            Marka = marka;
            Model = model;

            CenaZaGodzine = cenaZaGodzine;
            CenaZaDobe = cenaZaDobe;

            dostepny = true;
        }

        public void Wypozycz()
        {
            dostepny = false;
        }

        public void Zwroc()
        {
            dostepny = true;
        }

        public bool CzyDostepny()
        {
            return dostepny;
        }

        public override string ToString()
        {
            return $"ID: {Id} | {Typ} | {Marka} {Model} | " +
                   $"{CenaZaGodzine:C}/h | {CenaZaDobe:C}/d | " +
                   $"{(CzyDostepny() ? "Dostępny" : "Wypożyczony")}";
        }
    }
}
