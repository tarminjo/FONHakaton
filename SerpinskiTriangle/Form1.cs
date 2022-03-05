using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerpinskiTriangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double AreaOfTriangle(Point[] p)
        {
            return 0.5 * (p[1].X * p[2].Y - p[2].X*p[1].Y - p[0].X*p[2].Y + p[2].X*p[0].Y + p[0].X*p[1].Y - p[1].X * p[0].Y);
        }
        private void DrawSierpinski(Graphics g, SolidBrush brush, Point[] p, int areaTreshold)
        {
            if (AreaOfTriangle(p) < areaTreshold)
            {
                return;
            }
            Point p1 = new Point((p[0].X + p[1].X) / 2, (p[0].Y + p[1].Y) / 2);
            Point p2 = new Point((p[1].X + p[2].X) / 2, (p[1].Y + p[2].Y) / 2);
            Point p3 = new Point((p[0].X + p[2].X) / 2, (p[0].Y + p[2].Y) / 2);
            Point[] newTriangle = { p1, p2, p3 };
            g.FillPolygon(brush, newTriangle);
            Point[] firstTriangle = { p[0], p1, p3 };
            Point[] secondTriangle = { p1, p[1], p2 };
            Point[] thirdTriangle = { p2, p[2], p3 };
            DrawSierpinski(g, brush, firstTriangle, areaTreshold);
            DrawSierpinski(g, brush, secondTriangle, areaTreshold);
            DrawSierpinski(g, brush, thirdTriangle, areaTreshold);
        }

        private void CallSierpinski()
        {
            Refresh();
            int areaTreshold = Convert.ToInt32(textBox1.Text);
            int width = ClientRectangle.Width;
            int height = ClientRectangle.Height;
            Graphics g = CreateGraphics();
            Point p1 = new Point(width / 2, 0);
            Point p2 = new Point(width, height);
            Point p3 = new Point(0, height);
            Point[] p = { p1, p2, p3 };
            SolidBrush brush = new SolidBrush(Color.Gray);
            g.FillPolygon(brush, p);
            brush.Color = Color.White;
            DrawSierpinski(g, brush, p, areaTreshold);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            int textBoxX = ClientRectangle.Width - textBox1.Width - 12;
            int textBoxY = 12;
            button1.Location = new Point(textBoxX + textBox1.Width/2 - button1.Width/2, 45);
            textBox1.Location = new Point(textBoxX, textBoxY);
            CallSierpinski();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CallSierpinski();
        }
    }
}
