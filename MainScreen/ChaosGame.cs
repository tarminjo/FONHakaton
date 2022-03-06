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
    public partial class ChaosGame : Form
    {
        public ChaosGame()
        {
            InitializeComponent();
        }

        


        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
            Graphics g = CreateGraphics();

            Pen p = new Pen(Color.White);

            Point a = new Point(this.Width/2, 0);
            Point b = new Point(0, this.Height-50);
            Point c = new Point(this.Width-50, this.Height-50);

            Point s = new Point(200, 200);

            Random r = new Random();

            int n;

            if(textBox1.Text=="")
            {
                n = 10000;
            }
            else
            {
                n = Int32.Parse(textBox1.Text);
            }


            for (int i = 1; i < n+1; i++)
            {
                progressBar1.Value = 10000*i/n;
                int k = r.Next(3);
                switch (k)
                {
                    case 0:
                        s.X = (s.X + a.X) / 2;
                        s.Y = (s.Y + a.Y) / 2;
                        g.DrawLine(p, s.X, s.Y, s.X + 1, s.Y + 1);
                        break;
                    case 1:
                        s.X = (s.X + b.X) / 2;
                        s.Y = (s.Y + b.Y) / 2;
                        g.DrawLine(p, s.X, s.Y, s.X + 1, s.Y + 1);
                        break;
                    case 2:
                        s.X = (s.X + c.X) / 2;
                        s.Y = (s.Y + c.Y) / 2;
                        g.DrawLine(p, s.X, s.Y, s.X + 1, s.Y + 1);
                        break;
                }
            }
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
