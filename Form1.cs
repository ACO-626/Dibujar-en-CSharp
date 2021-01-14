using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dibujar_en_CSharp
{
    public partial class Form1 : Form
    {

        Graphics papel;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pluma;


        public Form1()
        {
            InitializeComponent();
            papel = pictureBox1.CreateGraphics();
            pluma = new Pen(Color.Black,5);

        }

      
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(moving=true && x!=-1 && y!=-1)
            {
                papel.DrawLine(pluma, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pluma.Color = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pluma.Color = Color.Black;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pluma.Color = Color.Blue;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pluma.Color = Color.Pink;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pluma.Color = Color.LightBlue;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pluma.Color = Color.Orange;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pluma.Color = Color.Yellow;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pluma.Color = Color.GreenYellow;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pluma.Color = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pluma.Color = Color.White;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
            pluma.Width = trackBar1.Value;
        }
    }
}
