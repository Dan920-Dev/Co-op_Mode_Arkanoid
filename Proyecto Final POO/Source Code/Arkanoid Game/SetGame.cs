using System.Windows.Forms;

namespace Arkanoid_Game
{
    public static class SetGame
    {
        public static void SetScreen(Form f, PictureBox pbShip, PictureBox UniqueBall)
        {
            var pbShipLocation = pbShip.Location;
            pbShipLocation.X = f.ClientSize.Width / 2 - pbShip.Width / 2;
            pbShipLocation.Y = f.ClientSize.Height - 100;
            pbShip.Location = pbShipLocation;
            var uniqueBallLocation = UniqueBall.Location;
            uniqueBallLocation.X = f.ClientSize.Width / 2 - UniqueBall.Width / 2;
            uniqueBallLocation.Y = pbShipLocation.Y - UniqueBall.Height;
            UniqueBall.Location = uniqueBallLocation;
        }
    }
}