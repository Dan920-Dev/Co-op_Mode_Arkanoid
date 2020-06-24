using System;

namespace Arkanoid_Game
{
    public class GetDataException : Exception
    {
        public GetDataException(string ex) : base(ex)
        {
        }
    }
}