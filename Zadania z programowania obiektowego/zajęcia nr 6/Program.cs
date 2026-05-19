using ConsoleApp6;
using System;
using System.Text;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //zadanie 1 (Operator &)
            OperatorLogiczny x1 = new OperatorLogiczny (true);
            OperatorLogiczny x2 = new OperatorLogiczny (true);
            OperatorLogiczny x3 = new OperatorLogiczny (false);
            OperatorLogiczny x4 = new OperatorLogiczny (false);

            Console.WriteLine(x1 & x2);
            Console.WriteLine(x3 & x4);
            Console.WriteLine(x1 & x3);
            Console.WriteLine(x4 & x2);

            //zadanie 2 (Kula)
            Kula kulka1 = new Kula(3);
            Kula kulka2 = new Kula(2.5);
            Kula kulka3 = new Kula(1.8);
            Kula kulaSuma;

            kulaSuma = kulka1 - kulka2 + kulka3;
            Console.WriteLine($"Objętość i promień kulki 1: {kulka1.Objetosc()}, {kulka1.PromienKuli}");
            Console.WriteLine($"Objętość i promień kulki 2: {kulka2.Objetosc()}, {kulka2.PromienKuli}");
            Console.WriteLine($"Objętość i promień kulki 3: {kulka3.Objetosc()}, {kulka3.PromienKuli}");
            Console.WriteLine($"Objętość i promień kuli wynikowej: {kulaSuma.Objetosc()}, {kulaSuma.PromienKuli}");

            //zadanie 3 (Długość)
            Length Len1 = new Length(4, 80);
            Length Len2 = new Length(2, 90);
            Length Len3 = new Length(3, 20);
            Length Len4 = Len1 + Len2 + Len3;
            Length Len5 = 3 * Len2;
            Console.WriteLine(Len1.GetLength());
            Console.WriteLine(Len2.GetLength());
            Console.WriteLine(Len3.GetLength());
            Console.WriteLine("Suma: " + Len4.GetLength());
            Console.WriteLine("Iloczyn: " + Len5.GetLength());

            //zadanie 4 (Trójkąt)
            Trojkat Rownoboczny = new Trojkat(8, 8, 8);
            Trojkat Rownoramienny = new Trojkat(10, 10, 4);
            Trojkat Roznoboczny = new Trojkat(7, 8, 9);
            
            Console.WriteLine(Rownoboczny > Rownoramienny);
            Console.WriteLine(Rownoboczny > Roznoboczny);
            Console.WriteLine(Rownoramienny > Roznoboczny);
        }
    }
}