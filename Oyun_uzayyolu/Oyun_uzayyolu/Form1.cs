using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oyun_uzayyolu
{
    public partial class Form1 : Form
    {

        int genislik,yukseklik;
        public Form1()
        {
            InitializeComponent();
            Bomb.Visible = false;
            Bomb1.Visible = false;
            Bomb2.Visible = false;
            fire.Visible = false;
            fire1.Visible = false;
            fire2.Visible = false;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            genislik = Form1.ActiveForm.Width;
            yukseklik = Form1.ActiveForm.Height;

            switch (e.KeyCode)
            {
                case Keys.Left:
                    SpaceShip.Left -= 10;

                    break;
                case Keys.Right:
                    SpaceShip.Left += 10;

                    break;
                case Keys.Up:
                    SpaceShip.Top -= 10;

                    break;
                case Keys.Down:
                    SpaceShip.Top += 10;

                    break;
                case Keys.Space:

                    int yer = SpaceShip.Location.X + (SpaceShip.Width) + (Bomb.Width);
                    int yer1 = SpaceShip.Location.Y + (SpaceShip.Height / 3);

                    if (Bomb.Location.X <= yer )
                    {
                        timer1.Start();
                        Bomb.Visible = true; 
                    }

                    if (Bomb.Location.X > yer)
                    {
                        timer2.Start();
                        Bomb1.Visible = true;
                    }

                    if (Bomb1.Location.X > yer)
                    {

                        timer3.Start();
                        Bomb2.Visible = true;
                    }


                    break;
            }
           
            if (SpaceShip.Location.X > genislik - SpaceShip.Width)
            {
                MessageBox.Show("Sınır Aşıldı");
                SpaceShip.Location = new Point(0, 0);
            }

            if (SpaceShip.Location.Y > yukseklik - SpaceShip.Height)
            {
                MessageBox.Show("Sınır Aşıldı");
                SpaceShip.Location = new Point(0, 0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Bomb.Location.X < genislik)
            {
                Bomb.Left += 10;
            }
            else
            {
                timer1.Stop();
                Bomb.Visible = false;
                int byer = SpaceShip.Location.X + (SpaceShip.Width);
                int byer1 = SpaceShip.Location.Y + (SpaceShip.Height / 3);
                Bomb.Location = new Point(byer, byer1);
            }
        }


        private void timer2_Tick(object sender, EventArgs e)
        {

            if (Bomb1.Location.X < genislik)
            {
                Bomb1.Left += 10;
            }
            else
            {
                timer2.Stop();
                Bomb1.Visible = false;
                int byer = SpaceShip.Location.X + (SpaceShip.Width);
                int byer1 = SpaceShip.Location.Y + (SpaceShip.Height / 3);
                Bomb1.Location = new Point(byer, byer1);
            }

        }


        private void timer3_Tick(object sender, EventArgs e)
        {

            if (Bomb2.Location.X < genislik)
            {
                Bomb2.Left += 10;
            }
            else
            {
                timer3.Stop();
                Bomb2.Visible = false;
                int byer = SpaceShip.Location.X + (SpaceShip.Width);
                int byer1 = SpaceShip.Location.Y + (SpaceShip.Height / 3);
                Bomb2.Location = new Point(byer, byer1);
            }
        }
    }
}
