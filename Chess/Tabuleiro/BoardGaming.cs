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
        public Piece GetPosition(Position pos)
        {
            return Pieces[pos.Linha, pos.Coluna];
        }
        public void PiecePut(Piece x, Position pos)
        {
            if (AlreadyUsed(pos))
            {
                throw new BoardGamingException("There is already a piece in that position!");
            }
            else
            {
                Pieces[pos.Linha, pos.Coluna] = x;
                x.PositionPiece = pos;
            }
        }
        public Piece RemovePiece(Position pos)
        {
            if(GetPosition(pos) == null)
            {
                return null;
            }
            Piece aux = GetPosition(pos);
            aux.PositionPiece = null;
            Pieces[pos.Linha, pos.Coluna] = null;
            return aux;

        }
        public bool PositionValid(Position pos)
        {
            if(pos.Linha < 0 || pos.Linha >= Linha && pos.Coluna < 0 || pos.Coluna >= Coluna)
            {
                return false;
            }
            else
            return true;
        }
        public bool AlreadyUsed(Position pos)
        {
            ValidPosition(pos);
            return GetPosition(pos) != null;
        }
        public void ValidPosition(Position pos)
        {
            if (!PositionValid(pos))
            {
                throw new BoardGamingException("Position Invalid");
            }
        }
    }
}
