namespace Tabuleiro
{
    internal class Piece
    {
        public Position PositionPiece { get; set; }
        public Cor Color { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public BoardGaming Tabuleiro { get; protected set; }

        public Piece(BoardGaming tabuleiro, Cor color)
        {
            PositionPiece = null;
            Color = color;
            Tabuleiro = tabuleiro;
            QtdMovimentos = 0;
        }
         
    }
}
