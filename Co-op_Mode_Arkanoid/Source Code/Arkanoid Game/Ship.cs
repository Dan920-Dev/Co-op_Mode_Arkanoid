using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid_Game
{
    public class Ship
    {
        private PictureBox pb;
        private int sX, sY;

        public Ship(int unX, int unY)
        {
            //pb = new PictureBox();
           /* pb.Size = new Size(114, 28);
            pb.Location = new Point(unX/2, unY/2);
            pb.BackgroundImage = Properties.Resources.NaveArkanoid;
            pb.BackgroundImageLayout = ImageLayout.Stretch;*/

           var pb = new PictureBox
           {
               Name = "pib",
               Size = new Size(114, 28),
               Location = new Point(496, 418),
               BackgroundImage = Properties.Resources.NaveArkanoid,
           };
        }
    }
}