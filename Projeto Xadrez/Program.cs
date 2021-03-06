using System;
using Projeto_Xadrez.GameBoardContainer;
using Projeto_Xadrez.GameBoardContainer.GameBoardContainerExceptions;
using Projeto_Xadrez.Chess;


namespace Projeto_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ChessGame chessGame = new ChessGame();

                while (!chessGame.finished)
                {
                    Console.Clear();

                    Screen.ShowGameBoard(chessGame.GameBoard);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Position original = Screen.ReadPositionChess().ToPosition();

                    bool[,] avaliablePosition = chessGame.GameBoard.getPiece(original).PossibleMovements();

                    Console.Clear();
                    Screen.ShowGameBoard(chessGame.GameBoard, avaliablePosition);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Position destiny = Screen.ReadPositionChess().ToPosition();

                    chessGame.ExecMove(original, destiny);

                }
            }
            catch (GameBoardException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
