using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Stars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //random number prep made
        public static Random randNum = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            StarField(100);
        }

        public void StarField(int starNum)
        {

            //counter made
            int counter = 0;

            Graphics g = this.CreateGraphics();

            //brush made
            SolidBrush starBrush = new SolidBrush(Color.Black);

            while (counter < starNum)
            {
                //random numbers for colours made
                int r = randNum.Next(1, 254);
                int gr = randNum.Next(1, 254);
                int b = randNum.Next(1, 254);

                //random numbers for coords made
                int x = randNum.Next(1, 300);
                int y = randNum.Next(1, 300);

                //colour of brush called
                starBrush.Color = Color.FromArgb(r, gr, b);

                //fills elipse
                g.FillEllipse(starBrush, x, y, 10, 10);

                //counter changed
                counter = counter + 1;

                Thread.Sleep(15);
            }
        }
    }
}
