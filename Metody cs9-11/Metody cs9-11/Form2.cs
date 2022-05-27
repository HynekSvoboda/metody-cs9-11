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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        bool JeAlfanum(ref int pocetmalych, ref int pocetvelkych, ref int pocetcisel, ref int pocetjiny, TextBox textBoxik)
        {
            bool alfa = false;
            string text = textBoxik.Text;
            foreach (char c in text)
            {
                if (c >= 'a' && c <= 'z')
                {
                    pocetmalych++;
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    pocetvelkych++;
                }
                else if (c >= '0' && c <= '9')
                {
                    pocetcisel++;
                }
                else
                {
                    pocetjiny++;
                }
            }
            label6.Text = pocetmalych.ToString();
            label7.Text = pocetvelkych.ToString();
            label8.Text = pocetcisel.ToString();
            label9.Text = pocetjiny.ToString();
            if (pocetjiny > 0) alfa = true;
            return alfa;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int pocetmalych = 0;
            int pocetvelkych = 0;
            int pocetcisel = 0;
            int pocetjiny = 0;
            bool alfanum=JeAlfanum(ref pocetmalych, ref pocetvelkych, ref pocetcisel, ref pocetjiny, textBox1);
            label10.Text = String.Format("{0} alfanumerický", alfanum ? "Neni":"Je");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Napište metodu JeAlfanum, která pro zadaný řetězec zjistí, zda je alfanumerický(obsahuje pouze písmena a číslice)\nKolik obsahuje malých písmen, kolik obsahujevelkých písmen a kolik obsahuje jiných znaků než alfanumerických.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
