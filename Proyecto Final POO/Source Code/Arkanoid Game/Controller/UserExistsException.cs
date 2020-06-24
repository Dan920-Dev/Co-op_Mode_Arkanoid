using System;

namespace Arkanoid_Game
{
    public class UserExistsException : Exception
    {
        public UserExistsException(string ex) : base(ex)
        {
            
        }
    }
}