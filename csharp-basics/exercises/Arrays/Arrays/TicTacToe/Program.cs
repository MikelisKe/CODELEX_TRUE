using System;
using System.IO;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main(string[] args)
        {
            InitBoard();            
            string playTurn = "O";
            int counter = 0;
            DisplayBoard();
            while (counter < 9)
            {

                if (playTurn == "O" && End() == false)
                {
                    Console.WriteLine("choose a row (0-2):");
                    int playerRow = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("choose a column (0-2):");
                    int playerColumn = Convert.ToInt32(Console.ReadLine());
                    board[playerRow, playerColumn] = 'X';
                    playTurn = "X";
                    DisplayBoard();
                    counter++;                        
                }
                else if (playTurn == "X" && End() == false )
                {
                    Console.WriteLine("choose a row (0-2):");
                    int playerRow = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("choose a column (0-2):");
                    int playerColumn = Convert.ToInt32(Console.ReadLine());
                    board[playerRow, playerColumn] = 'O';
                    playTurn = "O";
                    DisplayBoard();
                    counter++;
                }

                else 
                {
                    Console.WriteLine($"Game is over, {playTurn} won ");
                    break;             
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
            if (board[0, 0] == board[0,1] && board[0, 1]== board[0,2] && board[0,2] != ' ' )
            {
                return true;
            }
            else if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && board[1, 2] != ' ')
            {
                return true;
            }
            else if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && board[2, 2] != ' ')
            {
                return true; 
            }
            else if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] && board[2, 0] != ' ')
            {
                return true;
            }
            else if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] && board[2, 1] != ' ')
            {
                return true;
            }
            else if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2] && board[2, 2] != ' ')
            {
                return true;
            }
            else if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[2, 2] != ' ')
            {
                return true;
            }
            else if (board[0, 2] == board[1, 1] && board[1, 1] == board[0, 2] && board[0, 2] != ' ')
            {
                return true;
            }
            return false;
        }
    }
}
