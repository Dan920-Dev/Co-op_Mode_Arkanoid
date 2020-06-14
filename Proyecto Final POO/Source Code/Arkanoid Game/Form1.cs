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
        public bool flag, reset;
        public PictureBox[,] blocks;

        public Form1()
        {
            InitializeComponent();
            tSpeed = 10;
            xSpeed = 10;
            flag = true;
            reset = false;
            timer1.Enabled = false;
            setBlock();
            }

        private void setBlock()
        {
            int bheight = 35;
            int bwidth = 75;

            blocks = new PictureBox[10, 18];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    blocks[i,j]=new PictureBox();
                    blocks[i, j].Height = bheight;
                    blocks[i, j].Width = bwidth;
                    blocks[i, j].Top = bheight * i;
                    blocks[i, j].Left = bwidth * j;
                    if (i == 1 && (j==6 || j== 12)           )
                    {
                        blocks[i, j].BackColor = Color.Green;
                    } 
                    if (i == 1 && ((j>=0&&j<6)||(j>6&&j<12)||(j>12&&j<=17))){
                        blocks[i, j].BackColor = Color.Black;
                    } 
                    if (i == 0)
                    {
                        blocks[i, j].BackColor = Color.Black;
                    }
                    if (i == 2&&(j==7||j==11))
                    {
                        blocks[i, j].BackColor = Color.Green;
                        
                    }
                    if (i == 2 && ((j>=0&&j<7)||(j>7&&j<11)||(j>11&&j<=17))){
                        blocks[i, j].BackColor = Color.Black;
                    } 
                    if (i == 3&&(j>5&&j<13))
                    {
                        blocks[i, j].BackColor = Color.Green;
                    }
                    if (i == 3 && ((j>=0&&j<6)||(j>12&&j<=17))){
                        blocks[i, j].BackColor = Color.Black;
                    } 
                    if (i == 4 && ((j>=0&&j<5)||(j>13&&j<=17))){
                        blocks[i, j].BackColor = Color.Black;
                    } 
                    if (i == 4 &&(j==5||j==6||j==8||j==9||j==10||j==12||j==13))
                    {
                        blocks[i, j].BackColor = Color.Green;
                    }
                    if (i == 4 &&(j==7||j==11))
                    {
                        blocks[i, j].BackColor = Color.Red;
                    }
                    if (i == 5 && ((j>=0&&j<4)||(j>14&&j<=17))){
                        blocks[i, j].BackColor = Color.Black;
                    }
                    if (i == 5 &&(j>3&&j<15))
                    {
                        blocks[i, j].BackColor = Color.Green;
                    }
                    if ((i == 6||i==7) &&(j==4||j==6||j==12||j==14))
                    {
                        blocks[i, j].BackColor = Color.Green;
                    }
                    if (i == 6 &&(j==8||j==10)){
                        blocks[i, j].BackColor = Color.Red;
                    }
                    if (i == 6 &&(j==7||j==9||j==11))
                    {
                        blocks[i, j].BackColor = Color.Green;
                    }
                    if (i == 8 &&(j==7||j==8||j==10||j==11))
                    {
                        blocks[i, j].BackColor = Color.Green;
                    }
                    if ((i == 6 || i==7)&& ((j>=0&&j<4)||(j>14&&j<=17))){
                        blocks[i, j].BackColor = Color.Black;
                    }
                    if ((i == 6 || i==7) &&(j==5||j==13))
                    {
                        blocks[i, j].BackColor = Color.Black;
                    }
                    if ((i == 7 )&& ((j>6&&j<12))){
                        blocks[i, j].BackColor = Color.Black;
                    }
                    if ((i == 8 )&& ((j>=0&&j<7)||(j>11&&j<=17))){
                        blocks[i, j].BackColor = Color.Black;
                    }
                    if ((i == 8 )&& j==9){
                        blocks[i, j].BackColor = Color.Black;
                    }

                    if ((i == 9))
                    {
                        blocks[i, j].BackColor = Color.Black;
                    }



                    this.Controls.Add(blocks[i,j]);

                }

            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var uniqueBallLocation = UniqueBall.Location;
            var pbShipLocation = pbShip.Location;
            //UniqueBall.Top += tSpeed;

            if (UniqueBall.Bottom > ClientSize.Height)
            {
                timer1.Enabled = false;
                
                reset = true;
                tSpeed = 10;
                xSpeed = 10;
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
            else if (((uniqueBallLocation.X >= pbShipLocation.X &&
                     uniqueBallLocation.X <= pbShipLocation.X + pbShip.Width) &&
                     uniqueBallLocation.Y >= (pbShipLocation.Y - pbShip.Height))||(uniqueBallLocation.X +
                     UniqueBall.Width >= pbShipLocation.X && uniqueBallLocation.X + 
                     UniqueBall.Width<= pbShipLocation.X + pbShip.Width)&& uniqueBallLocation.Y >= 
                     (pbShipLocation.Y - pbShip.Height))
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

            if (e.KeyCode == Keys.Enter && reset)
            {
                reset = false;
                flag = true;
                
                ballLocation.Y = pbShipLocation.Y - UniqueBall.Height;
                SetScreen(pbShip, UniqueBall);
            }
            
            if (flag)
            {
                ballLocation.X = pbShipLocation.X + pbShip.Width/2 - UniqueBall.Width/2;
                UniqueBall.Location = ballLocation;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            SetScreen(pbShip, UniqueBall);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !reset)
            {
                flag = false;
                timer1.Interval = (100);
                timer1.Start();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form window = new FrmMenu();
            window.Show();
        }
        
        private void SetScreen(PictureBox pbShip, PictureBox UniqueBall)
        {
            var pbShipLocation = pbShip.Location;
            pbShipLocation.X = Width / 2 - pbShip.Width / 2;
            pbShipLocation.Y = Height - 150;
            pbShip.Location = pbShipLocation;
            var uniqueBallLocation = UniqueBall.Location;
            uniqueBallLocation.X = Width / 2 - UniqueBall.Width / 2;
            uniqueBallLocation.Y = pbShipLocation.Y - UniqueBall.Height;
            UniqueBall.Location = uniqueBallLocation;
        }
    }
}