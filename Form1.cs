using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        int a;
        int b;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32( textBox1.Text);
            b = Convert.ToInt32( textBox2.Text);
            int kq = a + b;
            textBox3.Text = kq.ToString();
        }
    }
}
