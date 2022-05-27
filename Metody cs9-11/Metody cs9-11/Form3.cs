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
           foreach(char s in text)
            {
                 if(s>='0'&&s<='9')
                   
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            while(text=="  ")
            {
                text = text.Replace("  ", " ");
            }
            string[] slova = text.Split(' ');
            Smazani(text);
        }
    }
}
