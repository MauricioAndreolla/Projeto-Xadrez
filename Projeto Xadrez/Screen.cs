using System;
using System.Collections.Generic;
using System.Text;
using Projeto_Xadrez.GameBoardContainer;

namespace Projeto_Xadrez
{
    class Screen
    {
        public static void ShowGameBoard(GameBoard gameBoard)
        {
            for (int i = 0; i < gameBoard.Lines; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < gameBoard.Columns; j++)
                {

                    Screen.ImprimirPiece(gameBoard.getPiece(i, j));

                }
                Console.WriteLine();

            }
            Console.WriteLine("  A B C D E F G H");

        }


        public static void ShowGameBoard(GameBoard gameBoard, bool[,] possiblePositions)
        {

            ConsoleColor consoleColor = Console.BackgroundColor;
            ConsoleColor consoleColorNew = ConsoleColor.DarkGray;

            for (int i = 0; i < gameBoard.Lines; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < gameBoard.Columns; j++)
                {
                    if (possiblePositions[i, j] == true)
                    {
                        Console.BackgroundColor = consoleColorNew;

                    }
                    else
                    {
                        Console.BackgroundColor = consoleColor;

                    }
                    Screen.ImprimirPiece(gameBoard.getPiece(i, j));

                }
                Console.WriteLine();

            }
            Console.WriteLine("  A B C D E F G H");
            Console.BackgroundColor = consoleColor;
        }

        static public void ImprimirPiece(Piece piece)
        {
            if (piece == null)
            {
                Console.Write("- ");
            }
            else
            {


                if (piece.Color == Color.White)
                {
                    Console.Write(piece);
                }
                else
                {
                    ConsoleColor consoleColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(piece);
                    Console.ForegroundColor = consoleColor;
                }
                Console.Write(" ");
            }
        }



        static public PositionChess ReadPositionChess()
        {
            string s = Console.ReadLine();
            char column = s[0];
            int line = int.Parse(s[1] + " ");
            return new PositionChess(column, line);
        }


    }
}
