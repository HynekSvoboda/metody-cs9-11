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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        void Smazani(string text)
        {
            listBox1.Items.Clear();
            string cisla = "0123456789";
            while (text.Contains("  "))
            {
                text = text.Replace("  ", " ");
            }
            foreach (char c in cisla)
            {
                if (text.Contains(c)) text = text.Replace(c.ToString(), "");
            }
            string[] slova = text.Split(' ');
            foreach (string slovo in slova)
            {
                listBox1.Items.Add(slovo);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            Smazani(text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Je dán řetězec slov, každé slovo je odděleno jednou nebo více mezerami\nNapište azavolejte metodu, která v řetězci smaže všechny číslice\nŘetězec vypište, každé slovonapište pod sebe do komponenty ListBox.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
