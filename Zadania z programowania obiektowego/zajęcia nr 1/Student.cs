using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_Punkt
{
    internal class Student
    {
        private string imie;
        private int wiek;
        private string szkola;

        public Student(string imie, int wiek, string szkola)
        {
            this.imie = imie;
            this.wiek = wiek;
            this.szkola = szkola;
        }

        public void ZmienSzkole(string nowaSzkola)
        {
            szkola = nowaSzkola;
        }

        public void DaneStudenta()
        {
            Console.WriteLine($"Imię: {imie}, Wiek: {wiek}, Szkoła: {szkola}");
        }
    }
}
