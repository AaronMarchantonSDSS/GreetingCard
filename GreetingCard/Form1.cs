using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GreetingCard
{
    public partial class Form1 : Form
    {
        SolidBrush greenBrush = new SolidBrush(Color.Green);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush purpleBrush = new SolidBrush(Color.MediumPurple);
        SolidBrush grayBrush = new SolidBrush(Color.Gray);
        SolidBrush blueBrush = new SolidBrush(Color.LightBlue);
        Pen blackPen = new Pen(Color.Black, 3);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Constant();
            MClosed();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i <=10)
            {
                i++;

                Constant();
                MClosed();

                Thread.Sleep(220);
                Refresh();

                Constant();
                MOpen();

                Thread.Sleep(220);
                Refresh();
            }

            Constant();
            MClosed();
        }

        public void MOpen()
        {
            Graphics g = this.CreateGraphics();

            g.FillRectangle(purpleBrush, 160, 132, 104, 30); //Dinosaur Mouth Open
            g.DrawLine(blackPen, 160, 132, 160, 162);
            g.DrawLine(blackPen, 160, 162, 265, 162);
            g.FillRectangle(blueBrush, 158, 102, 106, 30);

            g.FillRectangle(grayBrush, 170, 102, 10, 12);
            g.FillRectangle(grayBrush, 190, 102, 10, 12);
            g.FillRectangle(grayBrush, 210, 102, 10, 12);
            g.FillRectangle(grayBrush, 230, 102, 10, 12);
            g.FillRectangle(grayBrush, 250, 102, 10, 12);

            g.FillRectangle(grayBrush, 170, 120, 10, 12);
            g.FillRectangle(grayBrush, 190, 120, 10, 12);
            g.FillRectangle(grayBrush, 210, 120, 10, 12);
            g.FillRectangle(grayBrush, 230, 120, 10, 12);
            g.FillRectangle(grayBrush, 250, 120, 10, 12);
        }

        public void MClosed()
        {
            Graphics g = this.CreateGraphics();

            g.FillRectangle(grayBrush, 170, 102, 12, 15); //Dinosaur Mouth Closed
            g.FillRectangle(purpleBrush, 160, 102, 104, 30);
            g.DrawLine(blackPen, 160, 102, 160, 132);
            g.DrawLine(blackPen, 160, 102, 166, 102);
            g.DrawLine(blackPen, 160, 132, 265, 132);
        }

        public void Constant()
        {
            Graphics g = this.CreateGraphics();

            g.Clear(Color.LightBlue);

            g.FillEllipse(greenBrush, -100, 450, 670, 450); //Grass
            g.FillEllipse(greenBrush, 200, 430, 650, 430);

            g.FillEllipse(whiteBrush, 270, 70, 100, 100); //Clouds
            g.FillEllipse(whiteBrush, 320, 100, 80, 80);
            g.FillEllipse(whiteBrush, 330, 50, 110, 110);
            g.FillEllipse(whiteBrush, 380, 80, 90, 90);
            g.FillEllipse(whiteBrush, 400, 50, 70, 70);
            g.FillEllipse(whiteBrush, 440, 70, 70, 70);

            g.FillEllipse(whiteBrush, 20, 240, 80, 80);
            g.FillEllipse(whiteBrush, 70, 280, 50, 50);
            g.FillEllipse(whiteBrush, 80, 230, 70, 70);
            g.FillEllipse(whiteBrush, 80, 250, 130, 70);

            g.FillEllipse(redBrush, 450, 450, 15, 15); //Flowers
            g.FillEllipse(redBrush, 250, 490, 12, 12);
            g.FillEllipse(redBrush, 160, 520, 14, 14);
            g.FillEllipse(redBrush, 480, 520, 11, 11);
            g.FillEllipse(redBrush, 360, 545, 12, 12);
            g.FillEllipse(redBrush, 75, 500, 15, 15);

            g.FillEllipse(purpleBrush, 225, 450, 60, 30); //Dinosaur
            g.FillEllipse(purpleBrush, 310, 470, 60, 30);
            g.DrawEllipse(blackPen, 225, 450, 60, 30);
            g.DrawEllipse(blackPen, 310, 470, 60, 30);
            g.FillRectangle(purpleBrush, 339, 363, 30, 120);
            g.FillRectangle(purpleBrush, 254, 343, 30, 120);
            g.DrawRectangle(blackPen, 339, 363, 30, 120);
            g.DrawRectangle(blackPen, 254, 343, 30, 120);
            g.FillRectangle(purpleBrush, 337, 473, 30, 19);
            g.FillRectangle(purpleBrush, 252, 452, 30, 19);
            g.FillEllipse(purpleBrush, 220, 200, 200, 180);
            g.DrawEllipse(blackPen, 220, 200, 200, 180);
            g.FillRectangle(purpleBrush, 265, 100, 50, 118);
            g.DrawRectangle(blackPen, 265, 100, 50, 118);
            g.FillRectangle(purpleBrush, 267, 202, 50, 20);
            g.FillEllipse(purpleBrush, 150, 10, 190, 120);
            g.DrawEllipse(blackPen, 150, 10, 190, 120);
            g.FillEllipse(whiteBrush, 210, 35, 25, 25);
            g.DrawEllipse(blackPen, 210, 35, 25, 25);
            g.FillEllipse(blackBrush, 216, 40, 8, 8);
            g.FillRectangle(blueBrush, 160, 102, 104, 30);
        }
    }
}