using System.Windows.Forms;

namespace Arkanoid_Game
{
    public class BlockClass : PictureBox
    {
        public int hitsRemaining { get; set; }
        public int points { get; set; }
        
        public BlockClass() : base() {}
    }
}