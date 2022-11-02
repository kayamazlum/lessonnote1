using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tekrar1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //[1] Girilen değerleri listbox'a ekler
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        //[2] Listbox'daki değerleri temizler
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        //[3] Girilen sayının küpünü alır
        private void button3_Click(object sender, EventArgs e)
        {
            int sayi, sonuc;
            sayi = Convert.ToInt16(textBox2.Text);
            sonuc = sayi * sayi * sayi;
            label1.Text = sonuc.ToString();
        }

        //[4] Girilen kişi bilgisi ve vize final notlarını listbox'a ekler
        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt16(textBox3.Text);
            sayi2 = Convert.ToInt16(textBox4.Text);
            sonuc = sayi1 + sayi2;
            MessageBox.Show("Sonuç: "+sonuc,"Başlık", MessageBoxButtons.YesNoCancel);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String ad, soyad;
            double s1, s2, sonuc;
            ad = textBox5.Text;
            soyad = textBox6.Text;
            s1 = Convert.ToDouble(textBox7.Text);
            s2 = Convert.ToDouble(textBox8.Text);
            sonuc = s1*0.4 + s2*0.6;
            listBox2.Items.Add(ad + " " + soyad + " " + sonuc.ToString());
        }
    }
}
