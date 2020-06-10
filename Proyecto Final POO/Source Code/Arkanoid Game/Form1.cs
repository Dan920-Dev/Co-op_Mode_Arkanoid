using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arkanoid_Game
{
    public partial class Form1 : Form
    {
        public int tSpeed, xSpeed;
        public bool flag;

        public Form1()
        {
            InitializeComponent();
            tSpeed = 10;
            xSpeed = 10;
            flag = true;
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var uniqueBallLocation = UniqueBall.Location;
            var pbShipLocation = pbShip.Location;
            Form form1 = new Form1();
            //UniqueBall.Top += tSpeed;

            if (UniqueBall.Bottom > ClientSize.Height)
            {
                timer1.Enabled = false;
                flag = true;
                //tSpeed = -(tSpeed + 5);
                SetGame.SetScreen(form1, pbShip, UniqueBall);
                
            }
            else if (UniqueBall.Top <= 0)
            {
                tSpeed = -(tSpeed + 5);
            }

            else if (uniqueBallLocation.X <= 0)
            {
                xSpeed = -(xSpeed + 5);
            }
            else if (uniqueBallLocation.X  + UniqueBall.Width >= ClientSize.Width)
            {
                xSpeed = -(xSpeed + 5);
            }
            else if ((uniqueBallLocation.X > pbShipLocation.X &&
                     uniqueBallLocation.X < pbShipLocation.X + pbShip.Width) &&
                     uniqueBallLocation.Y >= (pbShipLocation.Y - pbShip.Height))
            {
                tSpeed = -(tSpeed + 5);
            }
            
            uniqueBallLocation.Y -= tSpeed;
            uniqueBallLocation.X += xSpeed;

            UniqueBall.Location = uniqueBallLocation;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            var pbShipLocation = pbShip.Location;
            var ballLocation = UniqueBall.Location;
            if (e.KeyCode == Keys.Left)
            {
                if (pbShipLocation.X <= 5) {}
                else
                    pbShipLocation.X -= 10;
            }
            else if (e.KeyCode == Keys.A)
            {
                if (pbShipLocation.X <= 5) {}
                else 
                    pbShipLocation.X -= 10;
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (pbShipLocation.X + pbShip.Width > ClientSize.Width) {}
                    
                else 
                    pbShipLocation.X += 10;
            }
            else if (e.KeyCode == Keys.D)
            {
                if (pbShipLocation.X + pbShip.Width > ClientSize.Width){}
                else 
                    pbShipLocation.X += 10;
            }
            
            pbShip.Location = pbShipLocation;

            if (flag)
            {
                ballLocation.X = pbShipLocation.X + pbShip.Width/2 - UniqueBall.Width/2;
                UniqueBall.Location = ballLocation;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            SetGame.SetScreen(form1, pbShip, UniqueBall);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                flag = false;
                timer1.Interval = (100);
                timer1.Start();
            }
        }
    }
}