using Tabuleiro;

namespace Chess
{
    internal class Tela
    {
        public static void PrintBoardGaming(BoardGaming tabuleiro)
        {
            for(int i = 0; i < tabuleiro.Linha; i++)
            {
                Console.Write(8 - i + " ");
                for(int j = 0; j < tabuleiro.Coluna; j++)
                {
                    if (tabuleiro.GetPiece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        PrintPiece(tabuleiro.GetPiece(i, j));
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }

        public static void PrintPiece(Piece piece)
        {
            if(piece.Color == Cor.White)
            {
                Console.WriteLine(piece);
            }
            else
            {
                ConsoleColor x = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(piece);
                Console.ForegroundColor = x;
            }
        }
    }
}
