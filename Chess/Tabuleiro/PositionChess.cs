namespace Tabuleiro
{
    internal class PositionChess
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }
        public PositionChess(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }
        public Position ToPosition()
        {
            return new Position(8 - Linha, Coluna - 'a');
        }
        public override string ToString()
        {
            return "" + Coluna + Linha;
        }
    }
}
