using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LakoparkProjekt
{
    class Happyliving
    {
        /*private List<Lakopark> lakoparkok;*/

        private List<Lakopark> lakoparkok ;

        internal List<Lakopark> Lakoparkok { get => lakoparkok; }

        public Happyliving(string filenev)
        {
            lakoparkok = new List<Lakopark>();
            string[] lakas;

            StreamReader file = new StreamReader(filenev);
            while (! file.EndOfStream)
            {
                string nev = file.ReadLine();
                if (nev.Length > 0)
                {
                    string[] sor = file.ReadLine().Split(';');
                    int utcaSzam = int.Parse(sor[0]);
                    int maxhazSzam  = int.Parse(sor[1]);
                    int[,] info = new int[utcaSzam,maxhazSzam];
                    for (int i= 0; i < utcaSzam; i++)
                    {
                        for (int j = 0; j < maxhazSzam; j++)
                        {
                            info[i, j] = 0;
                        }
                    }               
                    do
                    {
                        lakas = file.ReadLine().Split(';');  
                        if (lakas[0] != "") {
                            info[ int.Parse(lakas[0]) - 1 , int.Parse(lakas[1]) - 1] = 
                              int.Parse(lakas[2]);
                        }

                    } while (lakas[0] != "");

                    Lakopark lakoPark = new Lakopark(nev, utcaSzam, maxhazSzam, info);
                    lakoparkok.Add(lakoPark);
                }
            }
            file.Close();
        }

        public void statisztika()
        {
            int hazakSzama;
            Boolean teljes;
            int negyzetMeter = 0;
            int osszeg;
            double percent;

            for (int i = 0; i < lakoparkok.Count; i++)
            {
                hazakSzama = 0;
                osszeg = 0;
                lakoparkok[i].elsoTeliUtcca = 0;
                lakoparkok[i].BeEpitettLakoPark = 0;
                for (int ix = 0; ix < lakoparkok[i].UtcakSzama; ix++)
                {
                    teljes = true;
                    for (int iy = 0; iy < lakoparkok[i].MaxHazSzam; iy++)
                    {
                        if (lakoparkok[i].Hazak[ix,iy] > 0)
                        {
                            hazakSzama++;
                            switch (lakoparkok[i].Hazak[ix,iy])
                            {
                                case 1:
                                    negyzetMeter = 80;
                                    break;
                                case 2:
                                    negyzetMeter = 80 + 70;
                                    break;
                                case 3:
                                    negyzetMeter = 80 + 70 + 50;
                                    break;
                            }
                            osszeg += negyzetMeter * 300000;
                        }
                        else
                        {
                            teljes = false;
                        }
                    }
                    if (teljes && lakoparkok[i].elsoTeliUtcca == 0)
                    {
                        lakoparkok[i].elsoTeliUtcca = ix+1;
                    }
                }
                percent =
                    (hazakSzama * 100) / (lakoparkok[i].UtcakSzama * lakoparkok[i].MaxHazSzam);
                lakoparkok[i].BeEpitettLakoPark = percent;
                lakoparkok[i].lakoParkBevetel = osszeg;
            }
        }
        public int elsoTeliUtca()
        {
            int elso = -1;
            int i = 0;
            while (i < lakoparkok.Count && elso == -1)
            {
                if (lakoparkok[i].elsoTeliUtcca > 0)
                {
                    elso = i;
                }
                i++;
            }
            return elso;
        }
        public ArrayList legjobbLakoParkBeEpites()
        {
            ArrayList legjobb = new ArrayList();

            for (int i = 0; i < lakoparkok.Count; i++)
            {
                if (legjobb.Count == 0)
                {
                    legjobb.Add(i);
                }
                else
                {
                    if (lakoparkok[i].BeEpitettLakoPark == lakoparkok[(Int32)legjobb[0]].BeEpitettLakoPark)
                    {
                        legjobb.Add(i);
                    }
                    else if (lakoparkok[i].BeEpitettLakoPark > lakoparkok[(Int32)legjobb[0]].BeEpitettLakoPark)
                    {
                        legjobb.Clear();
                        legjobb.Add(i);
                    }
                }
            }
            return legjobb;
        }

    }
}
