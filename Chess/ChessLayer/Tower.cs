using System.Drawing;
using Tabuleiro;

namespace Chess.ChessLayer
{
    internal class Tower : Piece
    {
        public Tower(BoardGaming tabuleiro, Cor color) : base(tabuleiro, color)
        {

        }
        public override string ToString()
        {
            return "T";
        }
    }
}
