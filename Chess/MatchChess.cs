using Chess.ChessLayer;
using System;
using Tabuleiro;

namespace Chess
{
    internal class MatchChess
    {
        public BoardGaming Board { get; private set;}
        private int Turno;
        private Cor PlayerAtual;

        public MatchChess()
        {
            Board = new BoardGaming(8, 8);
            Turno = 1;
            PlayerAtual = Cor.White;
        }

        public void ExecutMovimet(Position origem, Position destino)
        {
            Piece p = Board.RemovePiece(origem);
            p.IncrementMoviment();
            Piece pieceCaptured = Board.RemovePiece(destino);
            Board.PiecePut(p, destino);
        }

        private void PutPiece()
        {
            Board.PiecePut(new Tower(Board, Cor.White), new PositionChess('c', 1).ToPosition());
            Board.PiecePut(new Tower(Board, Cor.White), new PositionChess('c', 2).ToPosition());
            Board.PiecePut(new Tower(Board, Cor.White), new PositionChess('d', 2).ToPosition());
            Board.PiecePut(new Tower(Board, Cor.White), new PositionChess('e', 2).ToPosition());
            Board.PiecePut(new Tower(Board, Cor.White), new PositionChess('e', 1).ToPosition()); Board.PiecePut(new Tower(Board, Cor.White), new PositionChess('d', 1).ToPosition());

            Board.PiecePut(new Tower(Board, Cor.Red), new PositionChess('c', 7).ToPosition());
            Board.PiecePut(new Tower(Board, Cor.Red), new PositionChess('c', 8).ToPosition());
            Board.PiecePut(new Tower(Board, Cor.Red), new PositionChess('d', 7).ToPosition());
            Board.PiecePut(new Tower(Board, Cor.Red), new PositionChess('e', 7).ToPosition());
            Board.PiecePut(new Tower(Board, Cor.Red), new PositionChess('e', 8).ToPosition());
            Board.PiecePut(new Tower(Board, Cor.Red), new PositionChess('d', 8).ToPosition());


        }
    }
}
