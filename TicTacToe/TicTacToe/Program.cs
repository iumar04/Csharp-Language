using System;

namespace TicTacToe
{
    class Program
    {
        static char[] board = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };  // Game board
        static int player = 1;  // Player 1 starts first
        static int choice;      // User choice for position
        static int flag = 0;    // Flag to check game status

        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Player 1: X and Player 2: O");
                Console.WriteLine("\n");
                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2's turn (O)");
                }
                else
                {
                    Console.WriteLine("Player 1's turn (X)");
                }
                Console.WriteLine("\n");
                DisplayBoard();  // Display the current game board

                // Get input from the player
                choice = int.Parse(Console.ReadLine());

                // Mark the board with player's choice
                if (board[choice] != 'X' && board[choice] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        board[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        board[choice] = 'X';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, the row {0} is already marked with a {1}.", choice, board[choice]);
                    Console.WriteLine("Please wait 2 seconds, and try again...");
                    System.Threading.Thread.Sleep(2000);
                }

                flag = CheckWin();  // Check if there's a winner
            }
            while (flag != 1 && flag != -1);  // Continue till someone wins or it's a draw

            Console.Clear();
            DisplayBoard();  // Final board display

            if (flag == 1)
            {
                Console.WriteLine("Player {0} has won!", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
            // Wait for the user to press a key before closing
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }

        // Display the Tic-Tac-Toe board
        private static void DisplayBoard()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2} ", board[1], board[2], board[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2} ", board[4], board[5], board[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2} ", board[7], board[8], board[9]);
            Console.WriteLine("     |     |      ");
        }

        // Check if there's a winner or draw
        private static int CheckWin()
        {
            #region Winning Combinations
            // Horizontal winning combinations
            if (board[1] == board[2] && board[2] == board[3])
                return 1;
            else if (board[4] == board[5] && board[5] == board[6])
                return 1;
            else if (board[7] == board[8] && board[8] == board[9])
                return 1;

            // Vertical winning combinations
            else if (board[1] == board[4] && board[4] == board[7])
                return 1;
            else if (board[2] == board[5] && board[5] == board[8])
                return 1;
            else if (board[3] == board[6] && board[6] == board[9])
                return 1;

            // Diagonal winning combinations
            else if (board[1] == board[5] && board[5] == board[9])
                return 1;
            else if (board[3] == board[5] && board[5] == board[7])
                return 1;
            #endregion

            // Checking for draw (i.e., no more moves)
            else if (board[1] != '1' && board[2] != '2' && board[3] != '3' && board[4] != '4' &&
                     board[5] != '5' && board[6] != '6' && board[7] != '7' && board[8] != '8' && board[9] != '9')
                return -1;

            // No winner yet
            else
                return 0;
        }
    }
}
