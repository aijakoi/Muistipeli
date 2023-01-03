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
using System.Runtime.Serialization;
using Newtonsoft.Json;
using testi2.Model;

namespace testi2
{
    public partial class frmMuistipeli : Form
    {
        // alustetaan tarvittavat muuttujat
        int aikaajaljella = 0;
        int valitut = 0;
        int nayttoaika = -1;
        int taso = 5;
        int jaljella = 0;
        bool vuoro1 = true;
        bool vuoro2 = false;
        int loydetty1;
        int loydetty2;
        int[,] kuvat = new int[5, 6];
        int[,] nayttokuvat = new int[5, 6];
        int[,] valittuna = new int[2, 2];
        int[,] vaikeustaso = new int[,] { { 3, 2 }, { 2, 4 }, { 3, 4 }, { 4, 4 }, { 5, 4 }, { 5, 6 } };
        Kuvaboksit[,] kuvaboksi = new Kuvaboksit[5, 6];
        Random rnd = new Random();
        public List<Tiedot> tiedot = new List<Tiedot>();
        string file = @"c:\\temp\tilastot.json";
        Tiedot t1 = new Tiedot();
        Tiedot t2 = new Tiedot();
        System.Media.SoundPlayer sp1 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer sp2 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer sp3 = new System.Media.SoundPlayer();


        public frmMuistipeli()
        {
            InitializeComponent();

            frmTilastot frm = new frmTilastot(this); // luodaan kutsu toiseen formiin

            tiedot = DeserializeJSON();

            if (tiedot == null)
            {
                tiedot = new List<Tiedot>();
            }
        }
        public void SerializeJSON(List<Tiedot> input)
        {
            string json = JsonConvert.SerializeObject(input);
            System.IO.File.WriteAllText(file, json);
        }

        public List<Tiedot> DeserializeJSON() // muunnetaan Tiedot-listan sisältö json-muotoon
        {
            if (File.Exists(file))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        string json = sr.ReadToEnd();
                        return JsonConvert.DeserializeObject<List<Tiedot>>(json);
                        sr.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        private void btnTilastot_Click(object sender, EventArgs e) // tilastot aukeavat uuteen formiin
        {
            frmTilastot frm = new frmTilastot(this);
            frm.Show();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // luodaan automaattisesti alkuun vaikein taso kaksiulotteisena taulukkona
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    kuvaboksi[i, j] = new Kuvaboksit(i, j);
                    kuvaboksi[i, j].Location = new System.Drawing.Point(10 + j * 110, 125 + i * 110);
                    kuvaboksi[i, j].Size = new System.Drawing.Size(100, 100);
                    kuvaboksi[i, j].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    kuvaboksi[i, j].Click += new System.EventHandler(kuvaboksi_Click);
                    this.Controls.Add(kuvaboksi[i, j]);
                }
            }

            sekoitaKuvat();
            sp1.SoundLocation = "voitto.wav";
            sp2.SoundLocation = "kylla.wav";
            sp3.SoundLocation = "ei.wav";
            btnOikea.Enabled = false; // vaikeustasoa ei voi nostaa
            naytaKuvat();
        }
        private void kuvaboksi_Click(object sender, EventArgs e)
        {
            Kuvaboksit kb = (Kuvaboksit)sender;
            // pelaajan 1 vuoro
            if (vuoro1 == true)
            {

                if ((nayttoaika == -1) && ((kb.y < vaikeustaso[taso, 0]) && (kb.x < vaikeustaso[taso, 1]))) // jos väärää paria on klikattu ja odotusaika loppuu
                {
                    if (nayttokuvat[kb.y, kb.x] == 0) // sallitaan kuvien klikkaaminen
                    { // tallennetaan klikatun kuvan paikka ja näytetään kuva, merkataan kuva avatuksi
                        valittuna[valitut, 0] = kb.y;
                        valittuna[valitut, 1] = kb.x;
                        kuvaboksi[kb.y, kb.x].Image = imageList1.Images[kuvat[kb.y, kb.x]];
                        nayttokuvat[kb.y, kb.x] = kuvat[kb.y, kb.x];
                        valitut++;
                    }
                    if (valitut == 2)
                    {

                        if (kuvat[valittuna[0, 0], valittuna[0, 1]] == kuvat[valittuna[1, 0], valittuna[1, 1]]) // jos löytyy pari
                        {
                            jaljella--;
                            loydetty1++;
                            sp2.Play();
                            lblLoydetty1.Text = "Löydetty: " + loydetty1;
                        }
                        else // jos paria ei löydy, niin vaihdetaan vuoroa
                        {
                            sp3.Play();
                            nayttoaika = 10;
                            vuoro1 = false;
                            vuoro2 = true;
                            lblVuoro.Text = "Vuoro: " + tbPelaaja2.Text;
                        }
                        valitut = 0;
                    }
                }
            }
            // pelaajan 2 vuoro
            if (vuoro2 == true)
            {

                if ((nayttoaika == -1) && ((kb.y < vaikeustaso[taso, 0]) && (kb.x < vaikeustaso[taso, 1]))) // jos väärää paria on klikattu ja odotusaika loppuu
                {
                    if (nayttokuvat[kb.y, kb.x] == 0) // sallitaan kuvien klikkaaminen
                    { // tallennetaan klikatun kuvan paikka ja näytetään kuva, merkataan kuva avatuksi
                        valittuna[valitut, 0] = kb.y;
                        valittuna[valitut, 1] = kb.x;
                        kuvaboksi[kb.y, kb.x].Image = imageList1.Images[kuvat[kb.y, kb.x]];
                        nayttokuvat[kb.y, kb.x] = kuvat[kb.y, kb.x];
                        valitut++;
                    }
                    if (valitut == 2)
                    {

                        if (kuvat[valittuna[0, 0], valittuna[0, 1]] == kuvat[valittuna[1, 0], valittuna[1, 1]]) // jos löytyy pari
                        {
                            jaljella--;
                            loydetty2++;
                            sp2.Play();
                            lblLoydetty2.Text = "Löydetty: " + loydetty2;
                        }
                        else // jos paria ei löydy, niin vaihdetaan vuoroa
                        {
                            sp3.Play();
                            nayttoaika = 10;
                            vuoro1 = true;
                            vuoro2 = false;
                            lblVuoro.Text = "Vuoro: " + tbPelaaja1.Text;
                        }
                        valitut = 0;
                    }
                }
            }
            if (jaljella == 0) // peli päättyy
            {
                lahetaTilastot();
            }
        }

        private void btnVasen_Click(object sender, EventArgs e)
        { // jos ollaan alimmalla tasolla, niin napin painaminen vasemmalle ei ole sallittu
            btnOikea.Enabled = true;
            taso--;
            if (taso < 1)
                btnVasen.Enabled = false;

            sekoitaKuvat();
            naytaKuvat();
            aikaajaljella = 0;
            loydetty1 = 0;
            loydetty2 = 0;
        }

        private void btnOikea_Click(object sender, EventArgs e)
        { // jos ollaan korkeimmalla tasolla, niin napin painaminen oikealle ei ole sallittu
            btnVasen.Enabled = true;
            taso++;
            if (taso > 6)

                btnOikea.Enabled = false;

            sekoitaKuvat();
            naytaKuvat();
            aikaajaljella = 0;
            loydetty1 = 0;
            loydetty2 = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        { // pelikello näyttää kauanko on pelattu
            int min;
            int sek;

            if (jaljella > 0)

                aikaajaljella++;


            min = aikaajaljella / 600;
            sek = (aikaajaljella - min * 600) / 10;
            lblAika.Text = "Aika: " + min + ":" + sek.ToString("00");


            if (nayttoaika >= 0) // jos väärän parin näyttöaikaa on jäljellä, niin vähennetään aikaa
                nayttoaika--;

            if (nayttoaika == 0) // kun väärää paria on näytetty riittävästi, niin piilotetaan kuvat
            {
                kuvaboksi[valittuna[0, 0], valittuna[0, 1]].Image = imageList1.Images[0];
                nayttokuvat[valittuna[0, 0], valittuna[0, 1]] = 0;
                kuvaboksi[valittuna[1, 0], valittuna[1, 1]].Image = imageList1.Images[0];
                nayttokuvat[valittuna[1, 0], valittuna[1, 1]] = 0;
            }
        }
        private void naytaKuvat()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if ((i < vaikeustaso[taso, 0]) && (j < vaikeustaso[taso, 1])) // jos kuva on pelialueella, niin näytetään kuva tai suljettu luukku
                        kuvaboksi[i, j].Image = imageList1.Images[nayttokuvat[i, j]];
                    else // muutoin ei näytetä mitään
                        kuvaboksi[i, j].Image = null;
                }
            }
            lblTaso.Text = "Taso: " + (taso + 1);
        }
        private void sekoitaKuvat()
        {
            jaljella = vaikeustaso[taso, 0] * vaikeustaso[taso, 1] / 2; // merkitään kuinka monta paria on jäljellä

            for (int i = 0; i < vaikeustaso[taso, 0]; i++)
            {
                for (int j = 0; j < vaikeustaso[taso, 1]; j++)
                {
                    kuvat[i, j] = (i * 6 + j) / 2 + 1; // aluksi laitetaan peräkkäisiin pictureboxeihin parit
                    nayttokuvat[i, j] = 0;
                }
            }
            for (int i = 0; i < 100; i++) // sekoitetaan pelialueen kuvat kunnolla sekaisin
            {
                int temp;
                int x1;
                int x2;
                int y1;
                int y2;

                y1 = rnd.Next(0, vaikeustaso[taso, 0]);
                x1 = rnd.Next(0, vaikeustaso[taso, 1]);
                y2 = rnd.Next(0, vaikeustaso[taso, 0]);
                x2 = rnd.Next(0, vaikeustaso[taso, 1]);

                temp = kuvat[y1, x1];
                kuvat[y1, x1] = kuvat[y2, x2];
                kuvat[y2, x2] = temp;
            }
        }

        private void btnAloita_Click(object sender, EventArgs e)
        { // pelaajien nimet eivät saa olla tyhjiä
            if (string.IsNullOrWhiteSpace(tbPelaaja1.Text) || string.IsNullOrWhiteSpace(tbPelaaja2.Text))
            {
                MessageBox.Show("Kirjoita nimi", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sp3.Play();
            }
            else
            {
                MessageBox.Show(tbPelaaja1.Text + " aloittaa", "Peli alkaa", MessageBoxButtons.OK);
                timer1.Enabled = true;
            }

        }

        private void lopetaPeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult lopeta = MessageBox.Show("Haluatko varmasti lopettaa pelin?", "Lopeta?", MessageBoxButtons.OKCancel);

            if (lopeta == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        public void lahetaTilastot()
        {
            // jos pelaaja 1 voittaa, hänelle merkitään 1 voitto
            if (loydetty1 > loydetty2)
            {
                MessageBox.Show(tbPelaaja1.Text + " voittaa", "Hurraa!");
                sp1.Play();

                t1.Nimi = tbPelaaja1.Text;
                t1.Voitto = 1;
                t1.Tappio = 0;

                t2.Nimi = tbPelaaja2.Text;
                t2.Voitto = 0;
                t2.Tappio = 1;

            } // jos pelaaja 2 voittaa, hänelle merkitään 1 voitto
            else if (loydetty2 > loydetty1)
            {
                MessageBox.Show(tbPelaaja2.Text + " voittaa", "Hurraa!");
                sp1.Play();

                t1.Nimi = tbPelaaja1.Text;
                t1.Voitto = 0;
                t1.Tappio = 1;

                t2.Nimi = tbPelaaja2.Text;
                t2.Voitto = 1;
                t2.Tappio = 0;
            }
            else // tasapelejä ei merkitä mihinkään
            {
                MessageBox.Show("Tasapeli");
            }

            if (tiedot.Exists(x => x.Nimi == t1.Nimi)) // jos pelaajan 1 nimi on jo tilastoissa, niin lisätään voitto/tappiotilastoa yhdellä
            {
                var etsi1 = tiedot.Single(s => s.Nimi == t1.Nimi);

                if (tiedot.Contains(etsi1))
                {
                    t1.Voitto += etsi1.Voitto;
                    t1.Tappio += etsi1.Tappio;
                    //var poistettava = tiedot.Single(r => r.Nimi == t1.Nimi);
                    //tiedot.Remove(poistettava);
                }
            }

            if (tiedot.Exists(x => x.Nimi == t2.Nimi)) // jos pelaajan 2 nimi on jo tilastoissa, niin lisätään voitto/tappiotilastoa yhdellä
            {
                var etsi2 = tiedot.Single(s => s.Nimi == t2.Nimi);

                if (tiedot.Contains(etsi2))
                {
                    t2.Voitto += etsi2.Voitto;
                    t2.Tappio += etsi2.Tappio;
                    //var poistettava = tiedot.Single(r => r.Nimi == t2.Nimi);
                    //tiedot.Remove(poistettava);
                }
            }
            tiedot.Add(t1);
            tiedot.Add(t2);

            SerializeJSON(tiedot);

            DialogResult jatka = new DialogResult();

            jatka = MessageBox.Show("Haluatteko pelata uudelleen?", "Jatka?", MessageBoxButtons.YesNo);

            if (jatka == DialogResult.Yes) // jos pelaajat haluavat pelata uudelleen, niin alustetaan muuttujat lähtötilanteeseen
            {
                timer1.Enabled = false;
                sekoitaKuvat();
                naytaKuvat();
                aikaajaljella = 0;

                loydetty1 = 0;
                loydetty2 = 0;

                lblLoydetty1.Text = "Löydetty: " + loydetty1;
                lblLoydetty2.Text = "Löydetty: " + loydetty2;
            }
        }

    }
    public class Kuvaboksit : PictureBox
    {
        public int x;
        public int y;

        public Kuvaboksit(int i, int j)
        {
            y = i;
            x = j;
        }
    }
}
