using System;

namespace Arkanoid_Game
{
    public class finishGameException : Exception
    {
        public finishGameException(string ex) : base(ex)
        {
            
        }
    }
}