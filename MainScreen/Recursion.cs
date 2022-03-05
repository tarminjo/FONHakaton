using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MainScreen
{
    public partial class Recursion : Form
    {
        public Recursion()
        {
            InitializeComponent();
        }
        private double AreaOfTriangle(Point[] p)
        {
            return 0.5 * (p[1].X * p[2].Y - p[2].X * p[1].Y - p[0].X * p[2].Y + p[2].X * p[0].Y + p[0].X * p[1].Y - p[1].X * p[0].Y);
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
        private void DrawSierpinski2(Graphics g, SolidBrush brush, Point[] p, int n)
        {
            if (n == 0)
                return;

            Point p1 = new Point((p[0].X + p[1].X) / 2, (p[0].Y + p[1].Y) / 2);
            Point p2 = new Point((p[1].X + p[2].X) / 2, (p[1].Y + p[2].Y) / 2);
            Point p3 = new Point((p[0].X + p[2].X) / 2, (p[0].Y + p[2].Y) / 2);
            Point[] newTriangle = { p1, p2, p3 };
            g.FillPolygon(brush, newTriangle);
            Point[] firstTriangle = { p[0], p1, p3 };
            Point[] secondTriangle = { p1, p[1], p2 };
            Point[] thirdTriangle = { p2, p[2], p3 };
            int new_n = n - 1;
            DrawSierpinski2(g, brush, firstTriangle, new_n);
            DrawSierpinski2(g, brush, secondTriangle, new_n);
            DrawSierpinski2(g, brush, thirdTriangle, new_n);
        }
        private void CallSierpinski()
        {
            Refresh();
            int areaTreshold = 100;  // default vrednost
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                int i;
                bool result = int.TryParse(textBox1.Text, out i);
                if (!result || Convert.ToInt32(textBox1.Text) <= 0) textBox1.Text = "100";
                areaTreshold = Convert.ToInt32(textBox1.Text);
            }
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
        private void button1_Click(object sender, EventArgs e)
        {
            CallSierpinski();
        }

        private void Recursion_ResizeEnd(object sender, EventArgs e)
        {
            int textBoxX = ClientRectangle.Width - textBox1.Width - 12;
            int textBoxY = 12;
            int btnX = textBoxX + textBox1.Width / 2 - button1.Width / 2;
            int btnY = 45;
            int trackX = btnX + button1.Width / 2 - trackLvlNum.Width / 2 - 45;
            int trackY = 90;
            button1.Location = new Point(btnX, btnY);
            textBox1.Location = new Point(textBoxX, textBoxY);
            trackLvlNum.Location = new Point(trackX, trackY);
            CallSierpinski();
        }

        private void trackLvlNum_Scroll(object sender, EventArgs e)
        {
            Refresh();
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

            int n = Convert.ToInt32(trackLvlNum.Value);
            DrawSierpinski2(g, brush, p, n);
        }
    }
}
