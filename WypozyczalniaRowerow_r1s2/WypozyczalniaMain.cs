using System;
using System.Collections.Generic;
using System.Text;

namespace WypozyczalniaRowerow
{
    public class WypozyczalniaMain
    {
        private List<Rower> rowery;
        private List<Wypozyczenie> historia;

        public WypozyczalniaMain()
        {
            rowery = new List<Rower>();
            historia = new List<Wypozyczenie>();
        }
        private bool CzyMoznaWypozyczyc(IWypozyczalny element)
        {
            return element.CzyDostepny();
        }

        private void ZmienStatus(IWypozyczalny element, bool wypozycz)
        {
            if (wypozycz)
                element.Wypozycz();
            else
                element.Zwroc();
        }

        // Dodanie roweru
        public void DodajRower(Rower rower)
        {
            rowery.Add(rower);
        }

        // Usunięcie roweru
        public bool UsunRower(int id)
        {
            Rower rower = ZnajdzRower(id);

            if (rower == null)
                return false;

            if (!rower.CzyDostepny())
                return false;

            rowery.Remove(rower);
            return true;
        }

        // Wyszukanie roweru po ID
        public Rower ZnajdzRower(int id)
        {
            return rowery.FirstOrDefault(r => r.Id == id);
        }

        // Wyświetlenie wszystkich rowerów
        public List<Rower> PobierzRowery()
        {
            return rowery;
        }

        // Wyświetlenie tylko dostępnych
        public List<Rower> PobierzDostepneRowery()
        {
            return rowery
                .Where(r => r.CzyDostepny())
                .ToList();
        }
        public bool WypozyczRower(Wypozyczenie wypozyczenie)
        {
            if (!CzyMoznaWypozyczyc(wypozyczenie.Rower))
                return false;

            ZmienStatus(wypozyczenie.Rower, true);

            historia.Add(wypozyczenie);

            return true;
        }

        public bool ZwrocRower(int id)
        {
            Rower rower = ZnajdzRower(id);

            if (rower == null)
                return false;

            if (rower.CzyDostepny())
                return false;

            ZmienStatus(rower, false);

            return true;
        }

        public List<Wypozyczenie> PobierzHistorie()
        {
            return historia;
        }

        public decimal ObliczPrzychod()
        {
            return historia.Sum(w => w.ObliczKoszt());
        }
    }
}