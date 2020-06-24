using System;

namespace Arkanoid_Game
{
    public class ScoreisEmptyException : Exception
    {
        public ScoreisEmptyException(string ex) : base(ex)
        {
            
        }
    }
}