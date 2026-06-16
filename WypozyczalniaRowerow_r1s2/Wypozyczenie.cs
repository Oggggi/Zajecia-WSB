using System;
using System.Collections.Generic;
using System.Text;

namespace WypozyczalniaRowerow
{
    public abstract class Wypozyczenie
    {
        public Klient Klient { get; set; }

        public Rower Rower { get; set; }

        public DateTime DataWypozyczenia { get; set; }

        public abstract string Rodzaj { get; }

        protected Wypozyczenie(Klient klient, Rower rower)
        {
            Klient = klient;
            Rower = rower;
            DataWypozyczenia = DateTime.Now;
        }

        // Każdy rodzaj wypożyczenia będzie liczył koszt inaczej
        public abstract decimal ObliczKoszt();

        public override string ToString()
        {
            return
                $"Data: {DataWypozyczenia:g}\n" +
                $"Klient: {Klient}\n" +
                $"Rower: {Rower.Marka} {Rower.Model}";
        }
    }
    public class WypozyczenieGodzinowe : Wypozyczenie
    {
        public int LiczbaGodzin { get; set; }
        public override string Rodzaj => "Godzinowe";

        public WypozyczenieGodzinowe(
            Klient klient,
            Rower rower,
            int liczbaGodzin)
            : base(klient, rower)
        {
            LiczbaGodzin = liczbaGodzin;
        }

        public override decimal ObliczKoszt()
        {
            return LiczbaGodzin * Rower.CenaZaGodzine;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"\nRodzaj: Godzinowe" +
                   $"\nCzas: {LiczbaGodzin} h" +
                   $"\nKoszt: {ObliczKoszt():C}";
        }
    }
    public class WypozyczenieDobowe : Wypozyczenie
    {
        public int LiczbaDni { get; set; }
        public override string Rodzaj => "Dobowe";

        public WypozyczenieDobowe(
            Klient klient,
            Rower rower,
            int liczbaDni)
            : base(klient, rower)
        {
            LiczbaDni = liczbaDni;
        }

        public override decimal ObliczKoszt()
        {
            return LiczbaDni * Rower.CenaZaDobe;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"\nRodzaj: Dobowe" +
                   $"\nCzas: {LiczbaDni} dni" +
                   $"\nKoszt: {ObliczKoszt():C}";
        }
    }
}
