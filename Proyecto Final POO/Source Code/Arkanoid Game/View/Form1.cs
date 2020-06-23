using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid_Game
{
    public partial class Form1 : Form
    {
        public BlockClass[,] blocks;
        private NewScore NS;

        public Form1()
        {
            InitializeComponent();
            
            //Seteo de datos
            GameData.ySpeed = 10;
            GameData.xSpeed = 10;
            GameData.cont = 0;
            GameData.conta = 0;
            GameData.contra = 0;
            Ship.livesLeft = 5;
            GameData.score = 0;
            GameData.flag = true;
            GameData.reset = false;
            timer1.Enabled = false;
            pbHeart1.Left = 10;
            pbHeart1.Top = 655;
            pbHeart2.Left = 55;
            pbHeart2.Top = 655;
            pbHeart3.Left = 100;
            pbHeart3.Top = 655;
            pbHeart4.Left = 145; 
            pbHeart4.Top = 655; 
            pbHeart5.Left = 190; 
            pbHeart5.Top = 655;
            
            setBlock();//Seteo bloques
        }

        private void setBlock()
        {
            int bheight = 35;
            int bwidth = 75;
            
            if (GameData.cont == 0)
            {
                blocks = new BlockClass[10, 18];
                
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 18; j++)
                    {
                        blocks[i, j] = new BlockClass();
                        blocks[i, j].Height = bheight;
                        blocks[i, j].Width = bwidth;
                        blocks[i, j].Top = bheight * i;
                        blocks[i, j].Left = bwidth * j;
                        
                        #region Formar figura
                        if (i == 1 && (j == 6 || j == 12))
                        {
                            blocks[i, j].BackColor = Color.Green;
                        }

                        if (i == 1 && ((j >= 0 && j < 6) || (j > 6 && j < 12) || (j > 12 && j <= 17)))
                        {
                            blocks[i, j].BackColor = Color.Black;
                        }

                        if (i == 0)
                        {
                            blocks[i, j].BackColor = Color.Black;
                        }

                        if (i == 2 && (j == 7 || j == 11))
                        {
                            blocks[i, j].BackColor = Color.Green;
                        }

                        if (i == 2 && ((j >= 0 && j < 7) || (j > 7 && j < 11) || (j > 11 && j <= 17)))
                        {
                            blocks[i, j].BackColor = Color.Black;
                        }

                        if (i == 3 && (j > 5 && j < 13))
                        {
                            blocks[i, j].BackColor = Color.Green;
                        }

                        if (i == 3 && ((j >= 0 && j < 6) || (j > 12 && j <= 17)))
                        {
                            blocks[i, j].BackColor = Color.Black;
                        }

                        if (i == 4 && ((j >= 0 && j < 5) || (j > 13 && j <= 17)))
                        {
                            blocks[i, j].BackColor = Color.Black;
                        }

                        if (i == 4 && (j == 5 || j == 6 || j == 8 || j == 9 || j == 10 || j == 12 || j == 13))
                        {
                            blocks[i, j].BackColor = Color.Green;
                        }

                        if (i == 4 && (j == 7 || j == 11))
                        {
                            blocks[i, j].BackColor = Color.Red;
                        }

                        if (i == 5 && ((j >= 0 && j < 4) || (j > 14 && j <= 17)))
                        {
                            blocks[i, j].BackColor = Color.Black;
                        }

                        if (i == 5 && (j > 3 && j < 15))
                        {
                            blocks[i, j].BackColor = Color.Green;
                        }

                        if ((i == 6 || i == 7) && (j == 4 || j == 6 || j == 12 || j == 14))
                        {
                            blocks[i, j].BackColor = Color.Green;
                        }

                        if (i == 6 && (j == 8 || j == 10))
                        {
                            blocks[i, j].BackColor = Color.Red;
                        }

                        if (i == 6 && (j == 7 || j == 9 || j == 11))
                        {
                            blocks[i, j].BackColor = Color.Green;
                        }

                        if (i == 8 && (j == 7 || j == 8 || j == 10 || j == 11))
                        {
                            blocks[i, j].BackColor = Color.Green;
                        }

                        if ((i == 6 || i == 7) && ((j >= 0 && j < 4) || (j > 14 && j <= 17)))
                        {
                            blocks[i, j].BackColor = Color.Black;
                        }

                        if ((i == 6 || i == 7) && (j == 5 || j == 13))
                        {
                            blocks[i, j].BackColor = Color.Black;
                        }

                        if ((i == 7) && ((j > 6 && j < 12)))
                        {
                            blocks[i, j].BackColor = Color.Black;
                        }

                        if ((i == 8) && ((j >= 0 && j < 7) || (j > 11 && j <= 17)))
                        {
                            blocks[i, j].BackColor = Color.Black;
                        }

                        if ((i == 8) && j == 9)
                        {
                            blocks[i, j].BackColor = Color.Black;
                        }

                        if ((i == 9))
                        {
                            blocks[i, j].BackColor = Color.Black;
                        }
                        #endregion

                        //Asignar cantidad de golpes y puntos
                        if (blocks[i, j].BackColor == Color.Black)
                        {
                            blocks[i, j].hitsRemaining = 1;
                            blocks[i, j].points = 100;
                        }
                        else if (blocks[i, j].BackColor == Color.Green)
                        {
                            blocks[i, j].hitsRemaining = 2;
                            blocks[i, j].points = 200;
                        }
                        else if (blocks[i, j].BackColor == Color.Red)
                        {
                            blocks[i, j].hitsRemaining = 3;
                            blocks[i, j].points = 300;
                        }

                        Controls.Add(blocks[i, j]);
                    }
                }
                GameData.cont++;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (GameData.conta == 180)
            {
                GameData.score = GameData.score * Ship.livesLeft;
                timer1.Enabled = false;
                MessageBox.Show("¡FELICIDADES JUGADOR, HAS GANADO!\nPuntaje final: " + GameData.score,
                    "ARKANOIDE :v", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Close();
            }

            if (Ship.livesLeft == 4)
                Controls.Remove(pbHeart5);
            if (Ship.livesLeft == 3)
                Controls.Remove(pbHeart4);
            if (Ship.livesLeft == 2)
                Controls.Remove(pbHeart3);
            if (Ship.livesLeft == 1)
                Controls.Remove(pbHeart2);
            if (Ship.livesLeft == 0)
                Controls.Remove(pbHeart1);

            BallBounce();//Rebote de la bola
        }

        private void BallBounce()
        {
            var pbUniqueBallLocation = pbUniqueBall.Location;
            var pbShipLocation = pbShip.Location;
            
            if (pbUniqueBall.Bottom > ClientSize.Height)
            {
                Ship.livesLeft--;
                timer1.Enabled = false;
                GameData.reset = true;
                GameData.ySpeed = 10;
                GameData.xSpeed = 10;
                GameData.contra++;

                if (Ship.livesLeft < 0)
                {
                    MessageBox.Show("FIN DEL JUEGO\nPuntaje final: " + GameData.score, "ARKANOIDE :v", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    Close();
                }
                
                label3.Visible = true;
            }
            //golpe arriba
            else if (pbUniqueBall.Top <= 0)
            {
                GameData.ySpeed = -(GameData.ySpeed + 5);
            } 
            //golpe de la bola izquierda 
            else if (pbUniqueBallLocation.X <= 0)
            {
                pbUniqueBallLocation.X = 1;//Sin esto la bola queda atrapada en la orilla y desaparece
                GameData.xSpeed = -(GameData.xSpeed + 5);
            }
            //golpe de la bola  a la derecha
            else if (pbUniqueBallLocation.X + pbUniqueBall.Width >= ClientSize.Width)
            {
                GameData.xSpeed = -(GameData.xSpeed + 5);
            }

            else if (((pbUniqueBall.Bounds.IntersectsWith(pbShip.Bounds) && pbUniqueBallLocation.X >= pbShipLocation.X &&
                       pbUniqueBallLocation.X + (pbUniqueBall.Width / 2) < pbShipLocation.X + (pbShip.Width / 2)) &&
                      pbUniqueBall.Location.X < pbShipLocation.X + (pbShip.Width / 2) &&
                      pbUniqueBallLocation.Y >= (pbShipLocation.Y - pbShip.Height)))
            {
                pbUniqueBallLocation.Y = pbShipLocation.Y - pbUniqueBall.Height;//Instrucción extra para que
                                                                                //la bola no quede atrapada en la pb de la nave
                if (GameData.xSpeed < 0)
                {
                    GameData.ySpeed = -(GameData.ySpeed + 5);
                }
                if (GameData.xSpeed > 0)
                {
                    GameData.ySpeed = -(GameData.ySpeed + 5);
                    GameData.xSpeed = -(GameData.xSpeed + 5);
                }
            }
            else if (((pbUniqueBall.Bounds.IntersectsWith(pbShip.Bounds) &&
                       pbUniqueBallLocation.X + (pbUniqueBall.Width / 2) > pbShipLocation.X + (pbShip.Width / 2) &&
                       pbUniqueBallLocation.X <= pbShipLocation.X + pbShip.Width + 1) &&
                      pbUniqueBallLocation.Y >= (pbShipLocation.Y - pbShip.Height)))
            {
                pbUniqueBallLocation.Y = pbShipLocation.Y - pbUniqueBall.Height;
                
                if (GameData.xSpeed < 0)
                {
                    GameData.ySpeed = -(GameData.ySpeed + 5);
                    GameData.xSpeed = -(GameData.xSpeed + 5);
                }

                if (GameData.xSpeed > 0)
                {
                    GameData.ySpeed = -(GameData.ySpeed + 5);
                }
            }
            else if ((pbUniqueBall.Bounds.IntersectsWith(pbShip.Bounds) && pbUniqueBallLocation.X +
                      pbUniqueBall.Width >=
                      pbShipLocation.X &&
                      pbUniqueBallLocation.X +
                      pbUniqueBall.Width <=
                      pbShipLocation.X + (pbShip.Width / 2) && pbUniqueBallLocation.X < pbShipLocation.X
                ) && pbUniqueBallLocation.Y >=
                (pbShipLocation.Y - pbShip.Height))
            {
                pbUniqueBallLocation.Y = pbShipLocation.Y - pbUniqueBall.Height;
                
                if (GameData.xSpeed < 0)
                {
                    GameData.ySpeed = -(GameData.ySpeed + 5);
                }

                if (GameData.xSpeed > 0)
                {
                    GameData.ySpeed = -(GameData.ySpeed + 5);
                    GameData.xSpeed = -(GameData.xSpeed + 5);
                }
            } 
            //validacion extra
            else if ((pbUniqueBallLocation.X + (pbUniqueBall.Width / 2)) == (pbShipLocation.X + (pbShip.Width / 2)) &&
                     pbUniqueBallLocation.Y >= (pbShipLocation.Y - pbShip.Height))
            {
                pbUniqueBallLocation.Y = pbShipLocation.Y - pbUniqueBall.Height;
                GameData.ySpeed = -(GameData.ySpeed + 5);
            }
            
            pbUniqueBallLocation.Y -= GameData.ySpeed;
            pbUniqueBallLocation.X += GameData.xSpeed;

            pbUniqueBall.Location = pbUniqueBallLocation;
            int k = 30000;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    int u = 1;

                    if (j <= 15)
                    {
                        if ((pbUniqueBall.Bounds.IntersectsWith(blocks[i, j].Bounds) &&
                             pbUniqueBallLocation.X + pbUniqueBall.Width <
                             blocks[i, j + u].Location.X))
                        {
                            blocks[i, j].hitsRemaining--;
                            if (blocks[i, j].hitsRemaining <= 0)
                            {
                                switch (blocks[i, j].points)
                                {
                                    case 100: GameData.score += 100;
                                        break;
                                    case 200: GameData.score += 200;
                                        break;
                                    case 300: GameData.score += 300;
                                        break;
                                }
                                
                                blocks[i, j].Top = k;
                                blocks[i, j].Left = k;
                                Controls.Remove(blocks[i, j]); //blocks[i,j]=null;
                                GameData.conta++;
                                label1.Text = "Bloques rotos:" + GameData.conta;
                                label2.Text = "Puntaje:" + GameData.score;
                            }
                            GameData.ySpeed = -(GameData.ySpeed + 5);
                        }

                        if (pbUniqueBall.Bounds.IntersectsWith(blocks[i, j].Bounds) &&
                            (pbUniqueBall.Bounds.IntersectsWith(blocks[i, j + u].Bounds)))
                        {
                            if (pbUniqueBall.Location.X + (pbUniqueBall.Width / 2) < blocks[i, j + 1].Location.X)
                            {
                                blocks[i, j].hitsRemaining--;
                                if (blocks[i, j].hitsRemaining <= 0)
                                {
                                    switch (blocks[i, j].points)
                                    {
                                        case 100: GameData.score += 100;
                                            break;
                                        case 200: GameData.score += 200;
                                            break;
                                        case 300: GameData.score += 300;
                                            break;
                                    }
                                    
                                    blocks[i, j].Top = k;
                                    blocks[i, j].Left = k;
                                    Controls.Remove(blocks[i, j]); //blocks[i,j]=null;
                                    GameData.conta++;
                                    label1.Text = "Bloques rotos:" + GameData.conta;
                                    label2.Text = "Puntaje:" + GameData.score;
                                }
                                GameData.ySpeed = -(GameData.ySpeed + 5);
                            }

                            if (pbUniqueBall.Location.X + (pbUniqueBall.Width / 2) > blocks[i, j + 1].Location.X)
                            {
                                blocks[i, j].hitsRemaining--;
                                if (blocks[i, j].hitsRemaining <= 0)
                                {
                                    switch (blocks[i, j].points)
                                    {
                                        case 100: GameData.score += 100;
                                            break;
                                        case 200: GameData.score += 200;
                                            break;
                                        case 300: GameData.score += 300;
                                            break;
                                    }
                                    
                                    blocks[i, j].Top = k;
                                    blocks[i, j].Left = k;
                                    Controls.Remove(blocks[i, j]); //blocks[i,j]=null;
                                    GameData.conta++;
                                    label1.Text = "Bloques rotos:" + GameData.conta;
                                    label2.Text = "Puntaje:" + GameData.score;
                                }
                                GameData.ySpeed = -(GameData.ySpeed + 5);
                            }

                            if (pbUniqueBall.Location.X + (pbUniqueBall.Width / 2) == blocks[i, j + 1].Location.X)
                            {
                                blocks[i, j].hitsRemaining--;
                                if (blocks[i, j].hitsRemaining <= 0)
                                {
                                    switch (blocks[i, j].points)
                                    {
                                        case 100: GameData.score += 100;
                                            break;
                                        case 200: GameData.score += 200;
                                            break;
                                        case 300: GameData.score += 300;
                                            break;
                                    }
                                    
                                    blocks[i, j].Top = k;
                                    blocks[i, j].Left = k;
                                    Controls.Remove(blocks[i, j]); //blocks[i,j]=null;
                                    GameData.conta++;
                                    label1.Text = "Bloques rotos:" + GameData.conta;
                                    label2.Text = "Puntaje:" + GameData.score;
                                }
                                GameData.ySpeed = -(GameData.ySpeed + 5);
                            }
                        }
                    }

                    if (j == 16)
                    {
                        if ((pbUniqueBall.Bounds.IntersectsWith(blocks[i, j].Bounds) &&
                             pbUniqueBallLocation.X + pbUniqueBall.Width <
                             blocks[i, j + u].Location.X))
                        {
                            blocks[i, j].hitsRemaining--;
                            if (blocks[i, j].hitsRemaining <= 0)
                            {
                                switch (blocks[i, j].points)
                                {
                                    case 100: GameData.score += 100;
                                        break;
                                    case 200: GameData.score += 200;
                                        break;
                                    case 300: GameData.score += 300;
                                        break;
                                }
                                
                                blocks[i, j].Top = k;
                                blocks[i, j].Left = k;
                                Controls.Remove(blocks[i, j]); //blocks[i,j]=null;
                                GameData.conta++;
                                label1.Text = "Bloques rotos:" + GameData.conta;
                                label2.Text = "Puntaje:" + GameData.score;
                            }
                            GameData.ySpeed = -(GameData.ySpeed + 5);
                        }
                        
                        if (pbUniqueBall.Bounds.IntersectsWith(blocks[i, j].Bounds) &&
                            (pbUniqueBall.Bounds.IntersectsWith(blocks[i, j + u].Bounds)))
                        {
                            if (pbUniqueBall.Location.X + (pbUniqueBall.Width / 2) < blocks[i, j + 1].Location.X)
                            {
                                blocks[i, j].hitsRemaining--;
                                if (blocks[i, j].hitsRemaining <= 0)
                                {
                                    switch (blocks[i, j].points)
                                    {
                                        case 100: GameData.score += 100;
                                            break;
                                        case 200: GameData.score += 200;
                                            break;
                                        case 300: GameData.score += 300;
                                            break;
                                    }
                                    
                                    blocks[i, j].Top = k;
                                    blocks[i, j].Left = k;
                                    Controls.Remove(blocks[i, j]); //blocks[i,j]=null;
                                    GameData.conta++;
                                    label1.Text = "Bloques rotos:" + GameData.conta;
                                    label2.Text = "Puntaje:" + GameData.score;
                                }
                                GameData.ySpeed = -(GameData.ySpeed + 5);
                            }

                            if (pbUniqueBall.Location.X + (pbUniqueBall.Width / 2) > blocks[i, j + 1].Location.X)
                            {
                                blocks[i, j].hitsRemaining--;
                                if (blocks[i, j].hitsRemaining <= 0)
                                {
                                    switch (blocks[i, j].points)
                                    {
                                        case 100: GameData.score += 100;
                                            break;
                                        case 200: GameData.score += 200;
                                            break;
                                        case 300: GameData.score += 300;
                                            break;
                                    }
                                    
                                    blocks[i, j].Top = k;
                                    blocks[i, j].Left = k;
                                    Controls.Remove(blocks[i, j]); //blocks[i,j]=null;
                                    GameData.conta++;
                                    label1.Text = "Bloques rotos:" + GameData.conta;
                                    label2.Text = "Puntaje:" + GameData.score;
                                }
                                GameData.ySpeed = -(GameData.ySpeed + 5);
                            }

                            if (pbUniqueBall.Location.X + (pbUniqueBall.Width / 2) == blocks[i, j + 1].Location.X)
                            {
                                blocks[i, j].hitsRemaining--;
                                if (blocks[i, j].hitsRemaining <= 0){
                                    switch (blocks[i, j].points)
                                    {
                                        case 100: GameData.score += 100;
                                            break;
                                        case 200: GameData.score += 200;
                                            break;
                                        case 300: GameData.score += 300;
                                            break;
                                    }
                                    
                                    blocks[i, j].Top = k;
                                    blocks[i, j].Left = k;
                                    Controls.Remove(blocks[i, j]); //blocks[i,j]=null;
                                    GameData.conta++;
                                    label1.Text = "Bloques rotos:" + GameData.conta;
                                    label2.Text = "Puntaje:" + GameData.score;
                                }
                                GameData.ySpeed = -(GameData.ySpeed + 5);
                            }
                        }
                    }

                    if (j == 17)
                    {
                        if ((pbUniqueBall.Bounds.IntersectsWith(blocks[i, j].Bounds) &&
                             pbUniqueBallLocation.X >= blocks[i, j].Location.X
                            ))
                        {
                            blocks[i, j].hitsRemaining--;
                            if (blocks[i, j].hitsRemaining <= 0)
                            {
                                switch (blocks[i, j].points)
                                {
                                    case 100: GameData.score += 100;
                                        break;
                                    case 200: GameData.score += 200;
                                        break;
                                    case 300: GameData.score += 300;
                                        break;
                                }
                                
                                blocks[i, j].Top = k;
                                blocks[i, j].Left = k;
                                Controls.Remove(blocks[i, j]); //blocks[i,j]=null;
                                GameData.conta++;
                                label1.Text = "Bloques rotos:" + GameData.conta;
                                label2.Text = "Puntaje:" + GameData.score;
                            }
                            GameData.ySpeed = -(GameData.ySpeed + 5);
                        }
                    }
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            var pbShipLocation = pbShip.Location;
            var ballLocation = pbUniqueBall.Location;
            
            #region Movimiento nave
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                if (pbShipLocation.X <= 5) { }
                else
                    pbShipLocation.X -= 20;
            }
            
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                if (pbShipLocation.X + pbShip.Width > ClientSize.Width) { }
                else
                    pbShipLocation.X += 20;
            }

            pbShip.Location = pbShipLocation;
            #endregion

            if (e.KeyCode == Keys.Enter && GameData.reset)//No se puede lanzar la bola mientras no se resetee la posición
            {
                GameData.reset = false;
                GameData.flag = true;
                label3.Visible = false;

                ballLocation.Y = pbShipLocation.Y - pbUniqueBall.Height;//Sin esto la bola no regresa a la altura original
                
                SetScreen();
            }

            if (GameData.flag)//Para que la bola permanezca sobre la nave mientras se mueva antes de lanzarla
            {
                ballLocation.X = pbShipLocation.X + pbShip.Width / 2 - pbUniqueBall.Width / 2;
                pbUniqueBall.Location = ballLocation;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            SetScreen();
            
            BackColor = Color.White;
            label2.Location = new Point(Width - 200, label1.Location.Y);
            label3.Location = new Point(Width/2 - label3.Width/2 , 492);
        }
        
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !GameData.reset)//Para que la bola se lanze desde la posición de la nave
            {                                              //Sino, se lanza desde la posición donde cayó
                GameData.flag = false;
                timer1.Interval = (50);
                timer1.Start();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form window = new FrmMenu(GameData.score);
            window.Show();
        }

        private void SetScreen()//Posiciona la nave y la bola
        {
            var pbShipLocation = pbShip.Location;
            pbShipLocation.X = Width / 2 - pbShip.Width / 2;
            pbShipLocation.Y = Height - 150;
            pbShip.Location = pbShipLocation;
            var pbUniqueBallLocation = pbUniqueBall.Location;
            pbUniqueBallLocation.X = Width / 2 - pbUniqueBall.Width / 2;
            pbUniqueBallLocation.Y = pbShipLocation.Y - pbUniqueBall.Height;
            pbUniqueBall.Location = pbUniqueBallLocation;
        }
    }
}
