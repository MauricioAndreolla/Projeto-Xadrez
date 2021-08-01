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
                    if (gameBoard.getPiece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        
                        Screen.ImprimirPiece(gameBoard.getPiece(i, j));
                        Console.Write(" ");
    
                    }



                }
                Console.WriteLine();

            }
            Console.WriteLine("  A B C D E F G H");

        }

        static public void ImprimirPiece(Piece piece) {
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
        
        }



        static public PositionChess ReadPositionChess()
        {
            string s = Console.ReadLine();
            char  column= s[0];
            int line = int.Parse(s[1] + " ");
            return new PositionChess(column, line);
        }


    }
}
