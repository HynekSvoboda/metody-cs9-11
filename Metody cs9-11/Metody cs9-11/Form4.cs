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
            while (a != b)
            {
                if (a > b) a -= b;
                else b -= a;
            }
            return a;
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
        void Rozklad (int a, ListBox listboxik)
        {
            int pomocna = 1;
            listboxik.Items.Clear();
            int i = 2;
            while( i <= a)
            {
                if (JePrvocislo(i) == false);
                while (a % i == 0)
                {
                    listboxik.Items.Add(i);
                    a /= i;
                }
                if (i == 3) pomocna = 2;
                i += pomocna;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            int a =(int) numericUpDown1.Value;
            int b = (int)numericUpDown2.Value;
            Rozklad(a, listBox2);
            Rozklad(b, listBox1);
            label2.Text = NSD(a, b).ToString();
            label4.Text =Convert.ToString ((a * b) / NSD(a,b));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Na vstupu jsou dvě čísla, spočítejte NSD (největší společný dělitel), NSN (nejmenšíspolečný násobek)\nDo listboxů vypište rozklad na prvočísla\nNapište metodu JePrvocislo, která vrací zda číslo je prvočíslo a nejmenší dělitel\nNapište metodu Rozklad a metodu NSD.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
