using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zegar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            PictureBox.Paint += PictureBox1_Paint;
            Timer.Tick += Timer1_Tick;
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {

        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            PictureBox.Invalidate(); 
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            DateTime now = DateTime.Now;
            Graphics g = e.Graphics;

            int centerX = PictureBox.Width / 2;
            int centerY = PictureBox.Height / 2;
            int radius = Math.Min(centerX, centerY) - 10;

            using (Pen circlePen = new Pen(Color.Black, 7))
            {
                g.DrawEllipse(circlePen, centerX - radius, centerY - radius, radius * 2, radius * 2);
            }

            double secAngle = now.Second * 6;
            double minAngle = now.Minute * 6 + now.Second * 0.1;
            double hourAngle = (now.Hour % 12) * 30 + now.Minute * 0.5;


            using (Pen hourPen = new Pen(Color.Black, 4))
            using (Pen minutePen = new Pen(Color.Red, 4))
            using (Pen secondPen = new Pen(Color.Blue, 4))
            {
                DrawHand(g, centerX, centerY, hourAngle, radius * 0.5f, hourPen); 
                DrawHand(g, centerX, centerY, minAngle, radius * 0.7f, minutePen); 
                DrawHand(g, centerX, centerY, secAngle, radius * 0.9f, secondPen); 
            }
        }

        private void DrawHand(Graphics g, int cx, int cy, double angleDeg, float length, Pen pen)
        {
            double angleRad = (Math.PI / 180) * (angleDeg - 90); 
            float x = cx + (float)(length * Math.Cos(angleRad));
            float y = cy + (float)(length * Math.Sin(angleRad));
            g.DrawLine(pen, cx, cy, x, y);
        }
    }
}
