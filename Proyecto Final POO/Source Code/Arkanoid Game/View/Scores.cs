using System;
using System.Windows.Forms;

namespace Arkanoid_Game
{
    public partial class Scores : UserControl
    {
        public delegate void EventScoresUserControl(object sender, EventArgs e);

        public event EventScoresUserControl ScoresButtonCLick;

        public Scores()
        {
            InitializeComponent();
        }
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (ScoresButtonCLick != null)
                ScoresButtonCLick(this, e);
        }

        private void Scores_Load(object sender, EventArgs e)
        {
            BestPlayersAndScores();
        }

        private void BestPlayersAndScores()
        {
            var listPlayer = ScoreDAO.GetBestPlayers();
            var listScore = ScoreDAO.GetBestScores();

            for (int i = 0; i < listPlayer.Count; i++)
            {
                lblBestP.Text += $"{i + 1} " + listPlayer[i] + "\n";
                lblScores.Text += $"{i + 1}" + listScore[i] + "\n";
            }
        }
    }
}