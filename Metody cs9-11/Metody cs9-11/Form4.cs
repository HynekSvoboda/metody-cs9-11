using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody_cs9_11
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        int NSD(int a, int b)
        {
            if (a < b)
            {
                int h = a;
                a = b;
                b = h;
            }

            int nsd = 1;
            for (int i = 2; i <= b; i++)
            {
                if (b % i == 0 && a % i == 0)
                    nsd = i;
            }
            return nsd;
        }
        int NSN(int a, int b)
        {
            if (a < b)
            {
                int h = a;
                a = b;
                b = h;
            }

            for (int i = 2; i <= b; i++)
            {
                int p = b * i;
                if (p % a == 0)
                    return p;
            }
            return b * a;
        }
        private bool JePrvocislo(int cislo)
        {
            bool prvocislo = true;
            if (cislo == 2) prvocislo = true;
            else
            {
                if (cislo == 1 || cislo % 2 == 0) prvocislo = false;
                else for (int delitel = 3; delitel <= Math.Sqrt(cislo) && prvocislo; ++delitel)
                    {
                        if (cislo % delitel == 0) return false;
                    }
            }
            return prvocislo;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a =(int) numericUpDown1.Value;
            int b = (int)numericUpDown2.Value;
            label2.Text = NSD(a, b).ToString();
            label4.Text = NSN(a, b).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Na vstupu jsou dvě čísla, spočítejte NSD (největší společný dělitel), NSN (nejmenšíspolečný násobek)\nDo listboxů vypište rozklad na prvočísla\nNapište metodu JePrvocislo, která vrací zda číslo je prvočíslo a nejmenší dělitel\nNapište metodu Rozklad a metodu NSD.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
