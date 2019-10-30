using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace karne_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         *Program Yapımcısı: K. Mert ŞENTÜRK
         * Site: www.mertseneturk.net
         * Forum: www.kodevreni.com - mertinkotr
         * E-mail: kasim@mertsenturk.net / ksm_mrtsntrk@outlook.com
         */
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int q1;

        private void Arasinavsonucbtn_Click(object sender, EventArgs e)
        {
            Hesapla1();
            Hesapla2();
            Hesapla3();
            Hesapla4();
            Hesapla5();

        }

        public void Hesapla1()
        {
            try
            {
                double hesapla = ((Convert.ToInt32(quiz1_1.Text) * 0.1) + (Convert.ToInt32(quiz2_1.Text) * 0.1) + (Convert.ToInt32(odev1.Text) * 0.2) + (Convert.ToInt32(vize1.Text) * 0.6));
                arasin1.Text = Convert.ToInt32(hesapla).ToString();
                double ort = (Convert.ToInt32(arasin1.Text) * 0.4) + (Convert.ToInt32(final1.Text) * 0.6);
                gnot1.Text = Convert.ToInt32(ort).ToString();
                if (ort >= 0 && ort < 50)
                    hnot1.Text = "FF";
                if (ort >= 50 && ort < 60)
                    hnot1.Text = "CC";
                if (ort >= 60 && ort < 70)
                    hnot1.Text = "CB";
                if (ort >= 70 && ort < 80)
                    hnot1.Text = "BB";
                if (ort >= 80 && ort < 90)
                    hnot1.Text = "BA";
                if (ort >= 90 && ort <= 100)
                    hnot1.Text = "AA";
                if (ort > 100)
                    hnot1.Text = "Yanlış not veya notlar girdiniz.";
            }
            catch
            {

            }
            
        }
        public void Hesapla2()
        {
            try
            {
                double hesapla = ((Convert.ToInt32(quiz1_2.Text) * 0.1) + (Convert.ToInt32(quiz2_2.Text) * 0.1) + (Convert.ToInt32(odev2.Text) * 0.2) + (Convert.ToInt32(vize2.Text) * 0.6));
                arasin2.Text = Convert.ToInt32(hesapla).ToString();
                double ort = (Convert.ToInt32(arasin2.Text) * 0.4) + (Convert.ToInt32(final2.Text) * 0.6);
                gnot2.Text = Convert.ToInt32(ort).ToString();
                if (ort >= 0 && ort < 50)
                    hnot2.Text = "FF";
                if (ort >= 50 && ort < 60)
                    hnot2.Text = "CC";
                if (ort >= 60 && ort < 70)
                    hnot2.Text = "CB";
                if (ort >= 70 && ort < 80)
                    hnot2.Text = "BB";
                if (ort >= 80 && ort < 90)
                    hnot2.Text = "BA";
                if (ort >= 90 && ort <= 100)
                    hnot2.Text = "AA";
                if (ort > 100)
                    hnot2.Text = "Yanlış not veya notlar girdiniz.";
            }
            catch
            {

            }

        }
        public void Hesapla3()
        {
            try
            {
                double hesapla = ((Convert.ToInt32(quiz1_3.Text) * 0.1) + (Convert.ToInt32(quiz2_3.Text) * 0.1) + (Convert.ToInt32(odev3.Text) * 0.2) + (Convert.ToInt32(vize3.Text) * 0.6));
                arasin3.Text = Convert.ToInt32(hesapla).ToString();
                double ort = (Convert.ToInt32(arasin3.Text) * 0.4) + (Convert.ToInt32(final3.Text) * 0.6);
                gnot3.Text = Convert.ToInt32(ort).ToString();
                if (ort >= 0 && ort < 50)
                    hnot3.Text = "FF";
                if (ort >= 50 && ort < 60)
                    hnot3.Text = "CC";
                if (ort >= 60 && ort < 70)
                    hnot3.Text = "CB";
                if (ort >= 70 && ort < 80)
                    hnot3.Text = "BB";
                if (ort >= 80 && ort < 90)
                    hnot3.Text = "BA";
                if (ort >= 90 && ort <= 100)
                    hnot3.Text = "AA";
                if (ort > 100)
                    hnot3.Text = "Yanlış not veya notlar girdiniz.";
            }
            catch
            {

            }

        }
        public void Hesapla4()
        {
            try
            {
                double hesapla = ((Convert.ToInt32(quiz1_4.Text) * 0.1) + (Convert.ToInt32(quiz2_4.Text) * 0.1) + (Convert.ToInt32(odev4.Text) * 0.2) + (Convert.ToInt32(vize4.Text) * 0.6));
                arasin4.Text = Convert.ToInt32(hesapla).ToString();
                double ort = (Convert.ToInt32(arasin4.Text) * 0.4) + (Convert.ToInt32(final4.Text) * 0.6);
                gnot4.Text = Convert.ToInt32(ort).ToString();
                if (ort >= 0 && ort < 50)
                    hnot4.Text = "FF";
                if (ort >= 50 && ort < 60)
                    hnot4.Text = "CC";
                if (ort >= 60 && ort < 70)
                    hnot4.Text = "CB";
                if (ort >= 70 && ort < 80)
                    hnot4.Text = "BB";
                if (ort >= 80 && ort < 90)
                    hnot4.Text = "BA";
                if (ort >= 90 && ort <= 100)
                    hnot4.Text = "AA";
                if (ort > 100)
                    hnot4.Text = "Yanlış not veya notlar girdiniz.";
            }
            catch
            {

            }

        }
        public void Hesapla5()
        {
            try
            {
                double hesapla = ((Convert.ToInt32(quiz1_5.Text) * 0.1) + (Convert.ToInt32(quiz2_5.Text) * 0.1) + (Convert.ToInt32(odev5.Text) * 0.2) + (Convert.ToInt32(vize5.Text) * 0.6));
                arasin5.Text = Convert.ToInt32(hesapla).ToString();
                double ort = (Convert.ToInt32(arasin5.Text) * 0.4) + (Convert.ToInt32(final5.Text) * 0.6);
                gnot5.Text = Convert.ToInt32(ort).ToString();
                if (ort >= 0 && ort < 50)
                    hnot5.Text = "FF";
                if (ort >= 50 && ort < 60)
                    hnot5.Text = "CC";
                if (ort >= 60 && ort < 70)
                    hnot5.Text = "CB";
                if (ort >= 70 && ort < 80)
                    hnot5.Text = "BB";
                if (ort >= 80 && ort < 90)
                    hnot5.Text = "BA";
                if (ort >= 90 && ort <= 100)
                    hnot5.Text = "AA";
                if (ort > 100)
                    hnot5.Text = "Yanlış not veya notlar girdiniz.";
            }
            catch
            {

            }

        }
    }
}
