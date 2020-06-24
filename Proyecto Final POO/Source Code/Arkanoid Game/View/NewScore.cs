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
            try
            {
                richTextBox1.Text = richTextBox1.Text.Trim();
                if (richTextBox1.Text.Equals(""))
                {
                    throw new FieldIsEmptyException("Error: Campo vacio, registre su nickname");
                }

                if (lblScore.Text.Equals(""))
                {
                    throw new ScoreisEmptyException("Error: No se han registrado puntajes");
                }
                else
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
            catch (FieldIsEmptyException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ScoreisEmptyException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}