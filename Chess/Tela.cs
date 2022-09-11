using Tabuleiro;

namespace Chess
{
    internal class Tela
    {
        public static void PrintBoardGaming(BoardGaming tabuleiro)
        {
            for(int i = 0; i < tabuleiro.Linha; i++)
            {
                for(int j = 0; j < tabuleiro.Coluna; j++)
                {
                    if (tabuleiro.GetPiece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                        Console.Write(tabuleiro.GetPiece(i, j) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
