using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadanie_Punkt
{
    class Program
    {
        static void Main(string[] args)
        {
            //zadanie 1 "Punkt"
            Console.WriteLine("Zadanie 1.\n");
            Punkt p1 = new Punkt(2,3);
            p1.Wyswietl();
            p1.Przesun(1, 2);
            p1.Wyswietl();
            p1.Cofnij_Przesun();
            p1.Wyswietl();

            //zadanie 2 "Trójkąt"
            Console.WriteLine("\nZadanie 2.\n");
            Trojkat trojkat = new Trojkat();
            trojkat.Bok = 3;
            double pole = trojkat.ObliczPole();
            Console.WriteLine("Wysokość trójkąta wynosi: " + trojkat.Wysokosc);
            Console.WriteLine("Bok trójkąta wynosi: " + trojkat.Bok);
            Console.WriteLine("Pole trójkąta wynosi: " + pole);

            //zadanie 3 "Prostokąt"
            Console.WriteLine("\nZadanie 3.\n");
            Prostokat[] prost = new Prostokat[5];
            prost[0] = new Prostokat(3, 3);
            prost[1] = new Prostokat(3, 2);
            prost[2] = new Prostokat(4, 3);
            prost[3] = new Prostokat(4, 5);
            prost[4] = new Prostokat(2, 4);

            foreach (Prostokat x in prost)
            {
                x.Prezentuj();
            }
            Console.WriteLine("Powierzchnia największego prostokąta = " + Prostokat.NajwiekszaPowierzchnia(prost));

            //zadanie 4 "Student"
            Console.WriteLine("\nZadanie 4.\n");
            Student student = new Student("Jan", 20, "SP21");
            student.DaneStudenta();
            student.ZmienSzkole("SP14");
            student.DaneStudenta();
        }
    }
}
