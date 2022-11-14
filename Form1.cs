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
        
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.Blue);
            //g.DrawEllipse(Pens.Green, 200, 200, 200, 200);
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            g.Clear(this.BackColor);
        }
    }
}
