using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cislo = Convert.ToInt32(textBox1.Text);
            int cislo2 = Convert.ToInt32(textBox2.Text);
            label1.Text = Convert.ToString(cislo + cislo2);
            label2.Text = Convert.ToString(cislo * cislo2);
        }
    }
}
