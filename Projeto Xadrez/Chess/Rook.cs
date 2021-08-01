using Projeto_Xadrez.GameBoardContainer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Xadrez.Chess
{
    class Rook : Piece
    {

        public Rook(GameBoard gameBoard, Color color) : base(color, gameBoard)
        {

        }

        public override string ToString()
        {
            return "T";
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
            
            while(GameBoard.PositionValid(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
                if (GameBoard.getPiece(position) != null && GameBoard.getPiece(position).Color != this.Color) {
                    break;
                }
                position.Line = position.Line - 1;
            }


            // Below
            position.DefineValues(Position.Line + 1, Position.Column);

            while (GameBoard.PositionValid(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
                if (GameBoard.getPiece(position) != null && GameBoard.getPiece(position).Color != this.Color)
                {
                    break;
                }
                position.Line = position.Line + 1;
            }


            // Right
            position.DefineValues(Position.Line, Position.Column + 1);

            while (GameBoard.PositionValid(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
                if (GameBoard.getPiece(position) != null && GameBoard.getPiece(position).Color != this.Color)
                {
                    break;
                }
                position.Column = position.Column + 1;
            }


            // Left
            position.DefineValues(Position.Line, Position.Column - 1);

            while (GameBoard.PositionValid(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
                if (GameBoard.getPiece(position) != null && GameBoard.getPiece(position).Color != this.Color)
                {
                    break;
                }
                position.Column = position.Column - 1;
            }

            return mat;
        }
    }
}
