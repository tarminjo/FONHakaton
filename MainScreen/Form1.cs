using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Recursion r = new Recursion();
            r.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ChaosGame c = new ChaosGame();
            c.Show();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            //54; 155; 205
            button1.BackColor = Color.FromArgb(40, 130, 180);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(54, 155, 205);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(40, 130, 180);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(54, 155, 205);
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(40, 130, 180);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(54, 155, 205);
        }


    }
}
