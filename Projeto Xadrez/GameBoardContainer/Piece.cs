using System;
using System.Collections.Generic;
using System.Text;
using Projeto_Xadrez;

namespace Projeto_Xadrez.GameBoardContainer
{
    abstract class Piece
    {
        public Position Position { get; set; } = null;
        public Color Color { get; protected set; }
        public int AmountOfMoves { get; protected set; } = 0;
        public GameBoard GameBoard { get; protected set; }

        public Piece() { }

        public Piece(Color color, GameBoard gameBoard) {
           
            Color = color;
            GameBoard = gameBoard;
        } 

        public void AddMovement() {
            AmountOfMoves = AmountOfMoves + 1;
        }

        public abstract bool[,] PossibleMovements();
    }
}
