using System;
namespace Tabuleiro
{
    internal class BoardGamingException : Exception
    {
        public BoardGamingException(string msg): base(msg)
        {

        }
    }
}
