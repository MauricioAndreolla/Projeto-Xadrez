using System;
using System.Collections.Generic;
using System.Text;
using Projeto_Xadrez.GameBoardContainer.GameBoardContainerExceptions;

namespace Projeto_Xadrez.GameBoardContainer
{
    class GameBoard
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private Piece[,] Pieces;


        public GameBoard() { }

        public GameBoard(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
            Pieces = new Piece[lines, columns];
        }

        public bool PiecePosition(Position position) {
            PositionValid(position);
            return getPiece(position) != null;
        }

        public Piece getPiece(int line, int column)
        {
            return Pieces[line, column];
        }

        public Piece getPiece(Position position)
        {
            CheckPosition(position);
            return Pieces[position.Line, position.Column];
        }

        public void SetPiece(Piece piece, Position position)
        {
            if (PiecePosition(position)) {
                throw new GameBoardException("Já existe a peça");
            }
            Pieces[position.Line, position.Column] = piece;
            piece.Position = position;
        }

        public Piece RemovePiece(Position position)
        {
            if (getPiece(position) == null)
            {
                return null;
            }

            Piece aux = getPiece(position);
            aux.Position = null;

            Pieces[position.Line, position.Column] = null;
            return aux;

        }

        public Piece SetPiece(Position position)
        {
            return Pieces[position.Line, position.Column];
        }


        public bool PositionValid(Position position)
        {
            if (position.Line < 0 || position.Line > Lines || position.Column < 0 || position.Column > Columns)
            {
                return false;
            }
            return true;
        }

        public void CheckPosition(Position position)
        {
            if (!PositionValid(position))
            {
                throw new GameBoardException("Posição Inválida");
            }

        }

    }
}
