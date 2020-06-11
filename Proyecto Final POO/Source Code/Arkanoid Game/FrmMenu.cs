using System;
using System.Windows.Forms;

namespace Arkanoid_Game
{
    public partial class FrmMenu : Form
    {
        private Menu mainMenu;
        private Scores topScores;
        public FrmMenu()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            mainMenu = new Menu();
            topScores = new Scores();
        }
        
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            mainMenu.Dock = DockStyle.Fill;
            mainMenu.Width = ClientSize.Width;
            mainMenu.Height = ClientSize.Height;
            
            topScores.Dock = DockStyle.Fill;
            topScores.Width = ClientSize.Width;
            topScores.Height = ClientSize.Height;
            
            Controls.Add(mainMenu);
            Controls.Add(topScores);

            mainMenu.MenuButtonCLick += StartGame;
            mainMenu.MenuButtonCLick += OnClickToMenuUS;
            topScores.ScoresButtonCLick += OnClickToScoresUS;
        }

        private void OnClickToMenuUS(object sender, EventArgs e)
        {
            mainMenu.Hide();
            topScores.Show();
        }

        private void OnClickToScoresUS(object sender, EventArgs e)
        {
            topScores.Hide();
            mainMenu.Show();
        }

        private void StartGame(object sender, EventArgs e)
        {
            Form window = new Form1();
            window.Show();
            this.Hide();
        }
    }
}