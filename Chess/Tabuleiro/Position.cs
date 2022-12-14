namespace Tabuleiro
{
    internal class Position
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Position(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        public override string ToString()
        {
            return ($"Posição: {Linha}, {Coluna}");
        }
    }
}
