using System;
using System.Windows.Forms;

namespace Arkanoid_Game
{
    public partial class Menu : UserControl
    {
        public delegate void EventMenuUserControl (object sender, EventArgs e);
        public event EventMenuUserControl MenuButtonCLick;
        
        public Menu()
        {
            InitializeComponent();
        }


        private void btnScores_Click(object sender, EventArgs e)
        {
            if (MenuButtonCLick != null)
                MenuButtonCLick(this, e);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (MenuButtonCLick != null)
                MenuButtonCLick(this, e);
        }
    }
}