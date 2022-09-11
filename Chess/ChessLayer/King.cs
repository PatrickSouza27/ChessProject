using Tabuleiro;

namespace Chess.ChessLayer
{
    internal class King : Piece
    {
        public King(BoardGaming tabuleiro, Cor color) : base(tabuleiro, color)
        {

        }
        public override string ToString()
        {
            return "K";
        }


    }
}

