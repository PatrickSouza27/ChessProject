namespace Tabuleiro
{
    internal class BoardGaming
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }
        private Piece[,]? Pieces { get; set; }

        public BoardGaming(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
            Pieces = new Piece[Linha, Coluna];
        }
        public Piece GetPiece(int linha, int coluna)
        {

            return Pieces[linha, coluna];
        }
        public void PiecePut(Piece x, Position pos)
        {
            Pieces[pos.Linha, pos.Coluna] = x;
            x.PositionPiece = pos;
        }
    }
}
