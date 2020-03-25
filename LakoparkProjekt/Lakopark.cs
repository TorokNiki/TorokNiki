using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakoparkProjekt
{
    class Lakopark
    {
        private int[,] hazak;
        private int maxHazSzam;
        private string nev;
        private int utcakSzama;
        private int elsoTeliUtca;
        private double beEpitettLakoPark;
        private int bevetel;

        public Lakopark(string nev, int utcakSzama, int maxHazSzam, int[,] hazak)
        {
            this.nev = nev;
            this.utcakSzama = utcakSzama;
            this.maxHazSzam = maxHazSzam;
            this.hazak = hazak;
        }

        public int[,] Hazak
        {
            get
            {
                return hazak;
            }
         
        }

        public int MaxHazSzam
        {
            get
            {
                return maxHazSzam;
            }

        }

        public string Nev
        {
            get
            {
                return nev;
            }
        }
        
        public int UtcakSzama
        {
            get
            {
                return utcakSzama;
            }

        }

        public int elsoTeliUtcca
        {
            get { return elsoTeliUtca; }
            set { elsoTeliUtca = value; }
        }

        public double BeEpitettLakoPark
        {
            get { return beEpitettLakoPark; }
            set { beEpitettLakoPark = value; }
        }

        public int lakoParkBevetel
        {
            get { return bevetel; }
            set { bevetel = value; }
        }


    }
}
