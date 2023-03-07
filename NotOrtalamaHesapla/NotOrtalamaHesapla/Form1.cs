using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotOrtalamaHesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sayi3;
            double sonuc;
            sayi1 = Convert.ToInt32(textBox3.Text);
            sayi2 = Convert.ToInt32(textBox4.Text);
            sayi3 = Convert.ToInt32(textBox5.Text);
            sonuc = (sayi1 + sayi2 + sayi3) / 3;
            listBox1.Items.Add(textBox1.Text + " " + textBox2.Text + " adlı öğrencinin not ortalaması: " + sonuc );
        }
    }
}
