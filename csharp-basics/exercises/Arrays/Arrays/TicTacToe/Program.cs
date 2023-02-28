using System;
using System.IO;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main(string[] args)
        {
            //InitBoard();
            //DisplayBoard();
            int playTurn = 1;
            char turns = ' ';
            int counter = 0;


            while (counter < 9)
            {
                Console.WriteLine("Players");
                InitBoard();
                DisplayBoard();

                if (playTurn == 1)
                {
                    Console.WriteLine("choose a row (0-2):");
                    int playerRow = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("choose a column (0-2):");
                    int playerColumn = Convert.ToInt32(Console.ReadLine());
                    board[playerRow, playerColumn] = 'X';
                    playTurn = 2;
                    counter++;                        
                }
                else if (playTurn == 2 && End() == true )
                {
                    Console.WriteLine("choose a row (0-2):");
                    int playerRow = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("choose a column (0-2):");
                    int playerColumn = Convert.ToInt32(Console.ReadLine());
                    board[playerRow, playerColumn] = 'O';
                    playTurn = 1;
                    counter++;
                }
            }
            Console.ReadKey();

        }

        private static void InitBoard()
        {
            // fills up the board with blanks
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }
            
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
        }
        private static bool End()
        {
            if (board[0, 0] == board[0,1] && board[0, 1]== board[0,2])
            {
                return true;
            }
            else if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2])
            {
                return true;
            }
            else if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2])
            {
                return true;
            }
            else if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0])
            {
                return true;
            }
            else if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1])
            {
                return true;
            }
            else if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2])
            {
                return true;
            }
            else if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                return true;
            }
            else if (board[0, 2] == board[1, 1] && board[1, 1] == board[0, 2])
            {
                return true;
            }
            return false;
        }
    }
}
