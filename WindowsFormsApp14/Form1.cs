using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Point> points = new List<Point> {};
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            points.Add(new Point(e.X, e.Y));
            dataGridView1.Rows.Add(e.X, e.Y);
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(pictureBox1.Image);
            for (int i = 0; i < points.Count; i++)
            {
                graph.DrawEllipse(Pens.Black, points[i].X-2, points[i].Y-2, 4, 4);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(pictureBox1.Image);
            for (int i = 0; i < points.Count; i++)
            {
                graph.DrawLines(Pens.Black,points.ToArray());
                graph.DrawEllipse(Pens.Black, points[i].X - 2, points[i].Y - 2, 4, 4);
                graph.DrawLine(Pens.Black, points[0], points[points.Count-1]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            points.Clear();
            dataGridView1.Rows.Clear();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }
    }
}
