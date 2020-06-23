using System;
using System.Windows.Forms;

namespace Arkanoid_Game
{
    public partial class FrmMenu : Form
    {
        private Menu mainMenu;
        private Scores topScores;
        private NewScore NS;

        private int MyScore;
        public FrmMenu(int Score)
        {
            InitializeComponent();
            MyScore = Score;
            WindowState = FormWindowState.Maximized;
            mainMenu = new Menu();
            topScores = new Scores();
            NS = new NewScore(MyScore);
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
        
        private void NewScoreUsButtonClick(object sender, EventArgs e)
        {
            NS.Hide();
            mainMenu.Show();
        }

        private void StartGame(object sender, EventArgs e)
        {
            Form window = new Form1();
            window.Show();
            Hide();
        }
        
        private void ExitGame(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterScore()
        {
            mainMenu.Hide();
            topScores.Hide();
            NS.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            #region Configurando User Controls
            mainMenu.Dock = DockStyle.Fill;
            mainMenu.Width = ClientSize.Width;
            mainMenu.Height = ClientSize.Height;
            
            topScores.Dock = DockStyle.Fill;
            topScores.Width = ClientSize.Width;
            topScores.Height = ClientSize.Height;
            
            NS.Dock = DockStyle.Fill;
            NS.Width = ClientSize.Width;
            NS.Height = ClientSize.Height;

            Controls.Add(mainMenu);
            Controls.Add(topScores);
            Controls.Add(NS);
            #endregion

            //Agregando Events
            mainMenu.MenuButtonCLick += StartGame;
            mainMenu.ShowScoresClick += OnClickToMenuUS;
            mainMenu.ExitGameClick += ExitGame;
            topScores.ScoresButtonCLick += OnClickToScoresUS;
            NS.NSButtonCLick += NewScoreUsButtonClick;
            
            if (MyScore > 0)
                RegisterScore();
        }
    }
}