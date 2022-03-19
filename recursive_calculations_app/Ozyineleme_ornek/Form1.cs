using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ozyineleme_ornek
{
    public partial class Form1 : Form
    {
        public class Dugum
        {
            public int sayi;
            public Dugum sonraki;
            public Dugum onceki;
        }
        Dugum ilk = null;
        Dugum son = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void FaktoriyelBul_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(faktoriyelGiris.Text);
            int sonuc = recursiveHesapla(sayi);
            faktoriyelSonuc1.Text = Convert.ToString(sonuc);

            sonuc = iteratifHesapla(sayi);
            faktoriyelSonuc2.Text = Convert.ToString(sonuc);
        }

        public int recursiveHesapla(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * recursiveHesapla(n - 1);
            }
        }

        private int iteratifHesapla(int n)
        {
            int sonuc = 1;
            for (int i = n; i > 0; i--)
            {
                sonuc = sonuc * i;
            }
            return sonuc;
        }

        private void fibonacciHesapla_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(fibonacciGiris.Text);
            int sonuc1 = recursiveFiboHesapla(sayi);
            fibonacciSonuc1.Text = Convert.ToString(sonuc1);

            int sonuc2 = iteratifFiboHesapla(sayi);
            fibonacciSonuc2.Text = Convert.ToString(sonuc2);
        }

        private int recursiveFiboHesapla(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return recursiveFiboHesapla(n - 1) + recursiveFiboHesapla(n - 2);
            }
        }

        private int iteratifFiboHesapla(int n)
        {
            int sonuc = 1;
            int onceki = 1;
            int sonraki = 1;
            for (int i = 1; i < n; i++)
            {
                onceki = sonraki;
                sonraki = sonuc;
                sonuc = onceki + sonraki;
            }
            return sonuc;
        }

        private void toplamBul_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(toplamaGiris.Text);
            int sonuc = iteratifToplamHesapla(sayi);
            toplamaSonuc2.Text = Convert.ToString(sonuc);

            sonuc = recursiveToplamHesapla(sayi);
            toplamaSonuc1.Text = Convert.ToString(sonuc);

        }

        private int recursiveToplamHesapla(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n + recursiveToplamHesapla(n - 1);
            }
        }

        private int iteratifToplamHesapla(int sayi)
        {
            int sonuc = 0;
            for (int i = 0; i <= sayi; i++)
            {
                sonuc = sonuc + i;
            }
            return sonuc;
        }

        private void sayiEkle_Click(object sender, EventArgs e)
        {
            Dugum eleman = new Dugum();
            eleman.sayi = Convert.ToInt32(sayiGiris.Text);
            if (ilk == null)
            {
                ilk = eleman;
                son = eleman;
            }
            else
            {
                son.sonraki = eleman;
                eleman.onceki = son;
                son = eleman;
                son.sonraki = null;
            }
        }

        private void butonListele_Click(object sender, EventArgs e)
        {
            Dugum isaretci = ilk;
            listBox1.Items.Clear();
            while (isaretci != null)
            {
                listBox1.Items.Add(isaretci.sayi);
                isaretci = isaretci.sonraki;
            }
        }

        private void butonTemizle_Click(object sender, EventArgs e)
        {
            ilk = null;
            son = null;
            listBox1.Items.Clear();
        }

        private void butonSapmaHesapla_Click(object sender, EventArgs e)
        {
            double iteratifSapma = iteratifSapmaHesapla();

            Dugum isaretci = new Dugum();
            isaretci = ilk;

            double sonuc = 0.0;
            double toplam = recursiveToplamHesapla(sonuc, isaretci);
            double adet = recursiveAdetHesapla(sonuc, isaretci);
            double ortalama = toplam / adet;

            double varyans = 0.0;
            varyans = recursiveSapmaHesapla(ortalama, varyans, isaretci);
            varyans = varyans / (adet - 1);

            double recursiveSapma = Math.Sqrt(varyans);

            listBox2.Items.Clear();
            listBox2.Items.Add("Sayıların Toplamı: " + toplam);
            listBox2.Items.Add("Sayıların Adeti:  " + adet);
            listBox2.Items.Add("Sayıların Ortalaması: " + ortalama);
            listBox2.Items.Add("Sayıların Varyansı: " + varyans);
            listBox2.Items.Add("Recursive Standart Sapma: " + recursiveSapma);
            listBox2.Items.Add("İteratif Standart Sapma: " + iteratifSapma);
        }

        private double recursiveSapmaHesapla(double ort, double varyans, Dugum isaretci)
        {
            if (isaretci != null)
            {
                varyans = Math.Pow((isaretci.sayi - ort), 2);
                isaretci = isaretci.sonraki;
                return varyans + recursiveSapmaHesapla(ort, varyans, isaretci);
            }
            else
            {
                return 0;
            }
        }

        private double recursiveToplamHesapla(double sonuc, Dugum isaretci)
        {

            if (isaretci != null)
            {
                sonuc = isaretci.sayi;
                isaretci = isaretci.sonraki;
                return sonuc + recursiveToplamHesapla(sonuc, isaretci);
            }
            else
            {
                return 0;
            }
        }
        private double recursiveAdetHesapla(double sonuc, Dugum isaretci)
        {
            if (isaretci != null)
            {
                sonuc = +1;
                isaretci = isaretci.sonraki;
                return sonuc + recursiveAdetHesapla(sonuc, isaretci);
            }
            else
            {
                return 0;
            }
        }

        private double iteratifSapmaHesapla()
        {
            Dugum isaretci = new Dugum();
            isaretci = ilk;
            double toplam = 0.0;
            double adet = 0.0;
            while (isaretci != null)
            {
                toplam = toplam + isaretci.sayi;
                isaretci = isaretci.sonraki;
                adet++;
            }
            double ortalama = toplam / adet;
            double varyans = 0.0;
            isaretci = ilk;
            while (isaretci != null)
            {
                varyans += Math.Pow((isaretci.sayi - ortalama), 2);
                isaretci = isaretci.sonraki;
            }
            varyans = varyans / (adet - 1);
            double standartSapma = Math.Sqrt(varyans);
            return standartSapma;
        }

    }
}
