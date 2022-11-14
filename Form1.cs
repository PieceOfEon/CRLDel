using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRLDel
{
    public partial class Form1 : Form
    {
        Point p;
     
   
        
        Graphics g;
        private PointF[] curvePoints;

        public Form1()
        {
            InitializeComponent();
        }
        public void DrawPolygonPointF(PaintEventArgs e)
        {

            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create points that define polygon.
            PointF point1 = new PointF(50.0F, 50.0F);
            PointF point2 = new PointF(100.0F, 25.0F);
            PointF point3 = new PointF(200.0F, 5.0F);
            PointF point4 = new PointF(250.0F, 50.0F);
            PointF point5 = new PointF(300.0F, 100.0F);
            PointF point6 = new PointF(350.0F, 200.0F);
            PointF point7 = new PointF(250.0F, 250.0F);
            PointF[] curvePoints =
                     {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5,
                 point6,
                 point7
             };

            // Draw polygon curve to screen.
            e.Graphics.DrawPolygon(blackPen, curvePoints);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
          
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.DrawEllipse(Pens.Red, p.X, p.Y, 100, 100);
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            p = e.Location;

            button1.Click += Circle;

            button2.Click += Rectangle;

            button3.Click += Line;

            button4.Click += Ugolnik;
           
        }
        private void Circle(object sender, EventArgs e)
        {
            g.DrawEllipse(Pens.Red, p.X, p.Y, 100, 100);
        }
        private void Rectangle(object sender, EventArgs e)
        {
            g.DrawRectangle(Pens.Red, p.X, p.Y, 100, 100);
        }
        private void Line(object sender, EventArgs e)
        {
            g.DrawLine(Pens.Red, p.X, p.Y, 100, 100);
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void Ugolnik(object sender, EventArgs e)
        {

            g.DrawPolygon(Pens.Red, curvePoints);

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            g.Clear(this.BackColor);
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            PointF point1 = new PointF(50, 75);
            PointF point2 = new PointF(100, 25);
            PointF point3 = new PointF(200, 50);
            PointF point4 = new PointF(250, 100);
            PointF point5 = new PointF(300, 125);
            PointF point6 = new PointF(350, 200);
            PointF point7 = new PointF(250, 350);
            PointF point8 = new PointF(325, 200);
            PointF[] curvePoints =
                     {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5,
                 point6,
                 point7,
                 point8
                 
             };

            // Draw polygon curve to screen.
            g.DrawPolygon(Pens.Red, curvePoints);
            //g.DrawEllipse(Pens.Green, 200, 200, 200, 200);
        }
    }
}
