using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uidesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel5.Height = button1.Height;
            panel5.Top = button1.Top;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel5.Height = button1.Height;
            panel5.Top = button1.Top;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel5.Height = button2.Height;
            panel5.Top = button2.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel5.Height = button3.Height;
            panel5.Top = button3.Top;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel5.Height = button4.Height;
            panel5.Top = button4.Top;
        }
    }
}
