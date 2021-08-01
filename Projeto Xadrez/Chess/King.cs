using System;
using System.Collections.Generic;
using System.Text;
using Projeto_Xadrez.GameBoardContainer;

namespace Projeto_Xadrez.Chess
{
    class King : Piece
    {
        public King(GameBoard gameBoard, Color color) : base(color, gameBoard)
        {

        }

        public override string ToString()
        {
            return "R";
        }

        private bool CanMove(Position position)
        {
            Piece piece = GameBoard.getPiece(position);
            return piece == null || piece.Color != this.Color;

        }

        public override bool[,] PossibleMovements()
        {
            bool[,] mat = new bool[GameBoard.Lines, GameBoard.Columns];

            Position position = new Position(0, 0);

            // Above
            position.DefineValues(Position.Line - 1, Position.Column);
            if (GameBoard.PositionValid(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
            }

            // NE
            position.DefineValues(Position.Line - 1, Position.Column + 1);
            if (GameBoard.PositionValid(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
            }

            // Right
            position.DefineValues(Position.Line, Position.Column + 1);
            if (GameBoard.PositionValid(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
            }

            // SE
            position.DefineValues(Position.Line + 1, Position.Column + 1);
            if (GameBoard.PositionValid(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
            }


            // Below
            position.DefineValues(Position.Line + 1, Position.Column);
            if (GameBoard.PositionValid(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
            }

            // SO
            position.DefineValues(Position.Line + 1, Position.Column - 1);
            if (GameBoard.PositionValid(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
            }


            // Left
            position.DefineValues(Position.Line, Position.Column - 1);
            if (GameBoard.PositionValid(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
            }


            // NO
            position.DefineValues(Position.Line - 1, Position.Column - 1);
            if (GameBoard.PositionValid(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
            }
            return mat;
        }

    }
}
