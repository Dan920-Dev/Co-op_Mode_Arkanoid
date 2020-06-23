using System;
using System.Windows.Forms;

namespace Arkanoid_Game
{
    public partial class NewScore : UserControl
    {
        public delegate void EventNSUserControl (object sender, EventArgs e);
        public event EventNSUserControl NSButtonCLick;

        private int MyScore;
        public NewScore(int Score)
        {
            InitializeComponent();
            MyScore = Score;
            lblScore.Text = MyScore.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NSButtonCLick != null)
            {
                ConnectionDB.ExecuteNonQuery($"INSERT INTO PLAYERS(nameplayer, score) VALUES(" +
                                             $"'{richTextBox1.Text}'," +
                                             $"{Convert.ToInt32(lblScore.Text)})");
                NSButtonCLick(this, e);
            }
        }
    }
}