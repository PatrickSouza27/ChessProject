using System;
using Tabuleiro;
using Chess.ChessLayer;

namespace Chess
{
    class Program
    {
        static void Main()
        {
            try
            {
                MatchChess matchChess = new MatchChess();
                Tela.PrintBoardGaming(matchChess.Board);

            }catch(BadImageFormatException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}