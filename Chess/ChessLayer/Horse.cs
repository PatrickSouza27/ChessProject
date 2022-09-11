using Tabuleiro;

namespace Chess.ChessLayer
{
    internal class Horse : Piece
    {
        public Horse(BoardGaming tabuleiro, Cor color) : base(tabuleiro, color)
        {

        }
        public override string ToString()
        {
            return "C";
        }
    }
}
