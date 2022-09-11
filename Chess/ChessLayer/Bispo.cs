using Tabuleiro;

namespace Chess.ChessLayer
{
    internal class Bispo : Piece
    {
        public Bispo(BoardGaming tabuleiro, Cor color) : base(tabuleiro, color)
        {

        }
        public override string ToString()
        {
            return "B";
        }
    }
}
