using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            List<string> karakterler = new List<string>();
            karakterler.Add("Mazhar");
            karakterler.Add("Ruhser");
            karakterler.Add("Ruhser");
            karakterler.Add("Müfit");
            karakterler.Add("Reyhan");
            karakterler.Add("Firdevs");

            karakterler.Remove("Müfit");

            foreach (string kisi in karakterler)
            {
                listBox1.Items.Add(kisi);
            }

        }

        private void btnListele1_Click(object sender, EventArgs e)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(45);
            sayilar.Add(74);
            sayilar.Add(25);
            sayilar.Add(33);
            sayilar.Add(22);
            sayilar.Add(15);
            sayilar.Add(14);
            foreach (int s in sayilar)
            {
                if (s % 5 == 0)
                {
                    listBox2.Items.Add(s);
                }
            }

            if(sayilar.Contains(74))
            {
                MessageBox.Show("74 sayısı listede var");
            }
            else
            {
                MessageBox.Show("74 sayısı listede yok");
            }

        }

        private void btnListele2_Click(object sender, EventArgs e)
        {
            List<Kisiler> kisi = new List<Kisiler>();

            kisi.Add(new Kisiler
            {
                ADI = "Abdullah",
                SOYADI = "Haktan",
                MESLEK = "Bilgisayar mühendisi"
            });

            foreach(var k in kisi) // veya Kisiler k in kisi
            {
                listBox3.Items.Add(k.ADI + " " + k.SOYADI + " - \n \n " + k.MESLEK);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnListele4_Click(object sender, EventArgs e)
        {
            List<Araba> araba = new List<Araba>();

            araba.Add(new Araba
            {
                MARKA = "MERCEDES",
                MODEL = "C200",
                YIL = 2020,
                FIYAT = 1200000
            });

            foreach(Araba a in araba)
            {
                listBox4.Items.Add(a.MARKA + " - " + a.MODEL + " - " + a.YIL + " - " + a.FIYAT);
            }
        }
    }
}