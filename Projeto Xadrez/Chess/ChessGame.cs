using Projeto_Xadrez.GameBoardContainer;
using Projeto_Xadrez.GameBoardContainer.GameBoardContainerExceptions;
using System;

namespace Projeto_Xadrez.Chess
{
    class ChessGame
    {
        public GameBoard GameBoard { get; private set; }
        private int Turn;
        private Color actualPlayer;
        public bool finished { get; set; }

        public ChessGame()
        {
            GameBoard = new GameBoard(8, 8);
            Turn = 1;
            actualPlayer = Color.White;
            finished = false; 
            putPieces();
        }

        private void putPieces()
        {

            GameBoard.SetPiece(new King(GameBoard, Color.Black), new PositionChess('c', 2).ToPosition());
            GameBoard.SetPiece(new Rook(GameBoard, Color.Black), new PositionChess('a', 1).ToPosition());


        }

        public void ExecMove(Position original, Position destination)
        {
            Piece piece = GameBoard.RemovePiece(original);
            piece.AddMovement();
            Piece PieceCatch = GameBoard.RemovePiece(destination);
            GameBoard.SetPiece(piece, destination);

        }


    }
}
