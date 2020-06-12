using System;
using System.Windows.Forms;

namespace Arkanoid_Game
{
    public partial class Menu : UserControl
    {
        public delegate void EventMenuUserControl (object sender, EventArgs e);
        public event EventMenuUserControl MenuButtonCLick;
        public event EventMenuUserControl ShowScoresClick;
        public event EventMenuUserControl ExitGameClick;
        
        public Menu()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (MenuButtonCLick != null)
                MenuButtonCLick(this, e);
        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            if (ShowScoresClick != null)
                ShowScoresClick(this, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (ExitGameClick != null)
                ExitGameClick(this, e);
        }
    }
}