using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    public class KlasaBazowa<TId, TExperience>
    {
        public TId ID { get; set; }
        public TExperience experience;

        public string Nickname { get; set; }
        public static int nextID = 1;

        public KlasaBazowa(TId id, TExperience exp)
        {
            ID = id;
            experience = exp;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {ID}, Experience: {experience}, Nickname: {Nickname}");
        }
    }

    class KlasaPochodna1 : KlasaBazowa<int, string>
    {
        public KlasaPochodna1(string nickname) : base(nextID, "No experience")
        {
            Nickname = nickname;
            nextID++;
        }
    }

    class KlasaPochodna2 : KlasaBazowa<Guid, bool>
    {
        public KlasaPochodna2(string nickname) : base(Guid.NewGuid(), false)
        {
            Nickname = nickname;
        }
    }
}

