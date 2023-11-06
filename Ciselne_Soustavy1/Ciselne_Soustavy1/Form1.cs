using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciselne_Soustavy1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar <'0' || e.KeyChar>'9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        public string DecToBin(int cislo)
        {
            string vysledek = string.Empty;
            while(cislo > 0)
            {
                int zbytek = cislo % 2;
                vysledek = zbytek + vysledek;
                cislo = cislo / 2;
            }
            return vysledek;
        }

        public int BinToDec(string cislo)
        {
            int vysledek = 0;
            int pocitadlo = 1;
            while(pocitadlo < cislo.Length)
            {
                int vypocet = int.Parse(cislo[cislo.Length - pocitadlo].ToString()) * Convert.ToInt32(Math.Pow(2,pocitadlo));
                pocitadlo++;
                vysledek += vypocet;
            }
            return vysledek;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vstup = textBox1.Text;
            label2.Text = BinToDec(vstup).ToString();
        }
    }
}
