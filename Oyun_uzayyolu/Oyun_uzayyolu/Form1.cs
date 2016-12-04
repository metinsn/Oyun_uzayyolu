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

        int genislik, yukseklik;
        public Form1()

        {
            InitializeComponent();
            Bomb.Visible = false;
            Bomb1.Visible = false;
            Bomb2.Visible = false;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
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
                    timer1.Start();
                    Bomb.Visible = true;
                    int yer = SpaceShip.Location.X + (SpaceShip.Width);
                    int yer1 = SpaceShip.Location.Y + (SpaceShip.Height / 4);
                    Bomb.Location = new Point(yer , yer1);
                    if (SpaceShip.Location.X > Bomb.Location.x)
                    {
                        Bomb1.Visible = true;
                        Bomb1.Location = new Point(yer, yer1);
                    }


                    break;
                default:
                    break;
            }
               


             genislik = Form1.ActiveForm.Width;
             yukseklik = Form1.ActiveForm.Height;

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


        private void timer1_Tick(object sender, EventArgs e)
        {

             genislik = Form1.ActiveForm.Width;
             yukseklik = Form1.ActiveForm.Height;



            if (Bomb.Location.X < genislik)
            {
                Bomb.Left += 10;
                Bomb1.Left += 10;

            }
            else
            {
                timer1.Stop();
                Bomb.Visible = false;
                Bomb1.Visible = false;
            }
        }


    }
}
