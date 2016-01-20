using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus5
{
    class Opiskelija
    {
        public string Nimi { get; set; }
        public int Ika { get; set; }
        public string Koulu { get; set; }
        public int Ahdistus { get; set; }
        public int Opintopisteet { get; set; }


        public void opiskele()
        {
            Opintopisteet += 1;
            Ahdistus += 2;
        }

        public void lepaile()
        {
            Ahdistus -= 2;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija opiskelija1 = new Opiskelija();
            opiskelija1.Nimi = "Tero";
            opiskelija1.Ika = 22;
            opiskelija1.Koulu = "Elaman kova koulu";
            opiskelija1.Ahdistus = 2;

            Opiskelija opiskelija2 = new Opiskelija();
            opiskelija2.Nimi = "Mari";
            opiskelija2.Ika = 19;
            opiskelija2.Koulu = "Kristillinen opisto";
            opiskelija2.Ahdistus = 5;

            Opiskelija opiskelija3 = new Opiskelija();
            opiskelija3.Nimi = "Heikki";
            opiskelija3.Ika = 18;
            opiskelija3.Koulu = "Autokoulu";
            opiskelija3.Ahdistus = 1;

            Opiskelija opiskelija4 = new Opiskelija();
            opiskelija1.Nimi = "Arska";
            opiskelija1.Ika = 40;
            opiskelija1.Koulu = "Yrittajaopisto";
            opiskelija1.Ahdistus = 10;

            string[] opiskelijat = {opiskelija1.Nimi, }
        }
    }
}
