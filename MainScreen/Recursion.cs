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
            int width = groupBoxArea.Location.X;
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

        private void CallSierpinski2()
        {
            int n = Convert.ToInt32(trackLvlNum.Value);
            lblIterations.Text = n.ToString();
            Refresh();

            int width = groupBoxArea.Location.X;
            int height = ClientRectangle.Height;
            Graphics g = CreateGraphics();
            Point p1 = new Point(width / 2, 0);
            Point p2 = new Point(width, height);
            Point p3 = new Point(0, height);
            Point[] p = { p1, p2, p3 };
            SolidBrush brush = new SolidBrush(Color.Gray);
            g.FillPolygon(brush, p);
            brush.Color = Color.White;
            DrawSierpinski2(g, brush, p, n);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CallSierpinski();
        }

        private void Recursion_ResizeEnd(object sender, EventArgs e)
        {
            int X = ClientRectangle.Width - groupBoxArea.Width - 12;

            radioButton1.Location = new Point(X, 12);
            label1.Location = new Point(X, radioButton1.Location.Y + radioButton1.Height);
            groupBoxArea.Location = new Point (X, label1.Location.Y + label1.Height);

            radioButton2.Location = new Point(X, groupBoxArea.Location.Y + groupBoxArea.Height + 12);
            groupBoxIterations.Location = new Point (X, radioButton2.Location.Y + radioButton2.Height);
            closeBtn.Location = new Point(X + groupBoxIterations.Width / 4, groupBoxIterations.Location.Y + groupBoxIterations.Height);

            if (radioButton1.Checked)
            {
                CallSierpinski();
            }
            else
            {
                CallSierpinski2();
            }
            
        }

        private void trackLvlNum_Scroll(object sender, EventArgs e)
        {
            CallSierpinski2();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxArea.Enabled = !groupBoxArea.Enabled;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxIterations.Enabled = !groupBoxIterations.Enabled;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
