using System;
using Tabuleiro;

namespace Chess
{
    class Program
    {
        static void Main()
        {
            Position P;
            BoardGaming tabuleiro = new BoardGaming(8, 8);

            P = new Position(3, 4);
            Tela.PrintBoardGaming(tabuleiro);
        }
    }
}
