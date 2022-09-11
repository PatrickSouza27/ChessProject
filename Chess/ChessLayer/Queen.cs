using Tabuleiro;

namespace Chess.ChessLayer
{
    internal class Queen : Piece
    {
        public Queen(BoardGaming tabuleiro, Cor color) : base(tabuleiro, color)
        {

        }
        public override string ToString()
        {
            return "Q";
        }
    }
}
