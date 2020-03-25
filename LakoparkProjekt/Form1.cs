using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace LakoparkProjekt
{
    public partial class Form1 : Form
    {
        Happyliving happyliving = new Happyliving("lakoparkok.txt");
        int aktivlakopark;
        int maxutca = 0;
        int maxhaz = 0;
        int oldalméret;
        PictureBox[,] hazak;

        public Form1()
        {
            InitializeComponent();
        }

        private void Lakoparkok_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < happyliving.Lakoparkok.Count(); i++)
            {
                if (maxutca < happyliving.Lakoparkok[i].UtcakSzama)
                {
                    maxutca = happyliving.Lakoparkok[i].UtcakSzama;
                }
                if (maxhaz < happyliving.Lakoparkok[i].MaxHazSzam)
                {
                    maxhaz = happyliving.Lakoparkok[i].MaxHazSzam;
                }
            }
            oldalméret =  (int)Math.Min(Math.Floor((double)(panelLakoPark.Height / maxutca)), Math.Floor((double)(panelLakoPark.Width / maxhaz)));
 
            hazak = new PictureBox[maxutca,maxhaz];
            for (int ix = 0; ix < maxutca; ix++)
            {
                for (int iy = 0; iy < maxhaz; iy++)
                {
                    hazak[ix, iy] = new PictureBox();
                    hazak[ix, iy].Location =  new System.Drawing.Point(iy * oldalméret, ix * oldalméret);
                    hazak[ix, iy].Size =  new System.Drawing.Size(oldalméret-2, oldalméret-2);
                    hazak[ix, iy].SizeMode = PictureBoxSizeMode.StretchImage;
                    hazak[ix, iy].Tag = ix.ToString() + ";" + iy.ToString();
                    hazak[ix, iy].Click += this.PictureClick;
                    panelLakoPark.Controls.Add(hazak[ix, iy]);
                }
            }
            aktivlakopark = 0;
            LakoparkKitesz();
        }

        private void PictureClick(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            string[] picture = pictureBox.Tag.ToString().Split(';');
            if (happyliving.Lakoparkok[aktivlakopark].Hazak[int.Parse(picture[0]),  int.Parse(picture[1])] == 3)
            {
                happyliving.Lakoparkok[aktivlakopark].Hazak[int.Parse(picture[0]),  int.Parse(picture[1])] = 0;
            } else {
                happyliving.Lakoparkok[aktivlakopark].Hazak[int.Parse(picture[0]),  int.Parse(picture[1])]++;
            }
            LakoparkKitesz();
        }
        private void LakoparkKitesz()
        {
            string kepnev;

            buttonLeft.Visible = (aktivlakopark > 0);
            buttonRight.Visible = (aktivlakopark < happyliving.Lakoparkok.Count()-1);
            pictireBoxNev.Image = Image.FromFile(@"..\..\..\Kepek\"+  happyliving.Lakoparkok[aktivlakopark].Nev + ".jpg");
            this.Text = happyliving.Lakoparkok[aktivlakopark].Nev+" lakópark";
            for (int i = 0; i < maxutca; i++)
            {
                for (int j = 0; j < maxhaz; j++)
                {
                    if (happyliving.Lakoparkok[aktivlakopark].UtcakSzama > i && 
                        happyliving.Lakoparkok[aktivlakopark].MaxHazSzam > j)
                    {
                        switch (happyliving.Lakoparkok[aktivlakopark].Hazak[i, j])
                        {
                            case 0:
                                kepnev = "kereszt";
                                break;
                            default:
                                kepnev =  "Haz" +  happyliving.Lakoparkok[aktivlakopark].Hazak[i, j].ToString();
                                break;
                        }
                        kepnev = @"..\..\..\Kepek\"+kepnev+".jpg";
                        hazak[i, j].Image = Image.FromFile(kepnev);
                        hazak[i, j].Visible = true;
                    } else
                    {
                        hazak[i, j].Visible = false;
                    }
                }
            }
        }
        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (aktivlakopark < happyliving.Lakoparkok.Count() - 1)
            {
                aktivlakopark++;
                LakoparkKitesz();
            }
        }
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (aktivlakopark > 0)
            {
                aktivlakopark--;
                LakoparkKitesz();
            }
        }
        private void buttonMentes_Click(object sender, EventArgs e)
        { 
            try {
                string sourceFile = "lakoparkok.txt";
                string destFile = "lakoparkok_"+DateTime.Now.ToString("yyyyMMdd_HHmm")+".txt";
                System.IO.File.Copy(sourceFile, destFile, true);
                if (File.Exists(destFile))
                {
                    File.Delete(sourceFile);

                    using (StreamWriter sw = File.CreateText(sourceFile))
                    {
                        for (int i = 0; i < happyliving.Lakoparkok.Count; i++)
                        {
                            sw.WriteLine(happyliving.Lakoparkok[i].Nev);
                            sw.WriteLine(happyliving.Lakoparkok[i].UtcakSzama+";"+happyliving.Lakoparkok[i].MaxHazSzam);
                            for (int ix = 0; ix < happyliving.Lakoparkok[i].UtcakSzama; ix++)
                            {
                                for (int iy = 0; iy < happyliving.Lakoparkok[i].MaxHazSzam; iy++)
                                {
                                    if (happyliving.Lakoparkok[i].Hazak[ix,iy] > 0)
                                    {
                                        sw.WriteLine((ix+1).ToString() + ";" +  (iy+1).ToString() + ";" +  happyliving.Lakoparkok[i].Hazak[ix, iy].ToString());                                       
                                    }
                                }
                            }
                            sw.WriteLine("");
                        }
                    }
                    if (File.Exists(sourceFile))
                    {
                        MessageBox.Show("Sikeres mentés!",   "",  MessageBoxButtons.OK,  MessageBoxIcon.Information);
                    }
                    else
                    {
                        System.IO.File.Copy(destFile, sourceFile, true);
                        MessageBox.Show("A mentés nem sikerült!",  "Hiba",  MessageBoxButtons.OK,  MessageBoxIcon.Error);
                    }
                } else
                {
                    MessageBox.Show("Nem sikerült a biztonsági filet létrehozni, a mentés megszakítva!", "Hiba", MessageBoxButtons.OK,  MessageBoxIcon.Error);
                }                                   
            } catch (IOException ex)
            {
                MessageBox.Show("Hiba lépett fel a mentés során!",  ex.Message ,  MessageBoxButtons.OK,  MessageBoxIcon.Error);
            }
        }

        private void buttonStatisztika_Click(object sender, EventArgs e)
        {
            ArrayList statisztikak = new ArrayList();
            ArrayList top = new ArrayList();
            int first;

            happyliving.statisztika();

            statisztikak.Add( "Az első lakópark, ahol teljesen beépitett utca van: ");
            first = happyliving.elsoTeliUtca();
            if (first > -1)
            {
                statisztikak.Add( happyliving.Lakoparkok[first].Nev + " (" + happyliving.Lakoparkok[first].elsoTeliUtcca + ". utca)");
            }
            else
            {
                statisztikak.Add( "Egyik lakóparkban sincs teljesen beépített utca.");
            }
            statisztikak.Add(" ");

            statisztikak.Add("Arányaiban legjobban beépített lakópark(ok):");
            top = happyliving.legjobbLakoParkBeEpites();
            for (int i = 0; i < top.Count; i++)
            {
                statisztikak.Add( "  " + happyliving.Lakoparkok[(Int32)top[i]].Nev + " (" + happyliving.Lakoparkok[(Int32)top[i]].BeEpitettLakoPark + "%)");
            }
            statisztikak.Add(" ");

            statisztikak.Add( "HappyLiving cég eddigi bevétele a lakóparkokból:");
            for (int i = 0; i < happyliving.Lakoparkok.Count; i++)
            {
                statisztikak.Add( "  " +happyliving.Lakoparkok[i].Nev +  " (" + String.Format("{0,-14:C0}", (int)happyliving.Lakoparkok[i].lakoParkBevetel)+")");
            }
            try
            {
                string destFile = "statisztika_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".txt";

                using (StreamWriter sw = File.CreateText(destFile))
                {
                    for (int i = 0; i < statisztikak.Count; i++)
                    {
                        sw.WriteLine(statisztikak[i]);
                    }
                }

            }
            catch (IOException ex)
            {
                MessageBox.Show("Hiba lépett fel a statisztika  mentése során!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            statisztikaMegjelenit(statisztikak);
          
        }
        private void statisztikaMegjelenit(ArrayList stat) { 
            StatForm statform = new StatForm(stat);
            statform.ShowDialog(this);
        }
    }
}
