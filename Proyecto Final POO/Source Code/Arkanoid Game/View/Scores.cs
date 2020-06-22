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
    }
}