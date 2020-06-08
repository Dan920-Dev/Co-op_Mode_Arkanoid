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
        public int tSpeed;

        public Form1()
        {
            InitializeComponent();
            tSpeed = 5;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UniqueBall.Top += tSpeed;

            if(UniqueBall.Bottom > this.ClientSize.Height)
            {
                tSpeed = -tSpeed;
            }
            if(UniqueBall.Top < 0)
            {
                tSpeed = -tSpeed;
            }
        }
    }
}