using System;
using Tabuleiro;
using Chess.ChessLayer;

namespace Chess
{
    class Program
    {
        static void Main()
        {
            BoardGaming tabuleiro = new BoardGaming(8, 8);
            tabuleiro.PiecePut(new Tower(tabuleiro, Cor.Black), new Position(0, 0));
            tabuleiro.PiecePut(new Tower(tabuleiro, Cor.Black), new Position(1, 3));
            tabuleiro.PiecePut(new King(tabuleiro, Cor.Black), new Position(2, 4));

            Tela.PrintBoardGaming(tabuleiro);
          

        }
    }
}
