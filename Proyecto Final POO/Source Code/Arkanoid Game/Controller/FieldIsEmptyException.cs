using System;

namespace Arkanoid_Game
{
    public class FieldIsEmptyException : Exception
    {
        public FieldIsEmptyException(string ex) : base(ex)
        {
            
        }
    }
}