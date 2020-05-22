using System;


namespace Tic_Tac_Toe
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string playagain = "yes";
            while (playagain == "yes")
            {
                char player = 'x';
                char[,] board = new char[3, 3];
                Initialize(board);
                int movesPlayed = 0;
               

                while (true)
                {
                    Console.Clear();
                    Print(board);

                    Console.Write("Please enter row: ");
                    int row = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter col: ");
                    int col = Convert.ToInt32(Console.ReadLine());

                    board[row, col] = player;

                    // check rows
                    if (board[0, 0] == player && board[0, 1] == player && board[0, 2] == player)
                    {
                        Console.WriteLine(player + " has won the game!");
                        break;
                    }
                    if (board[1, 0] == player && board[1, 1] == player && board[1, 2] == player)
                    {
                        Console.WriteLine(player + " has won the game!");
                        break;
                    }
                    if (board[2, 0] == player && board[2, 1] == player && board[2, 2] == player)
                    {
                        Console.WriteLine(player + " has won the game!");
                        break;
                    }
                    // check columns
                    if (board[0, 0] == player && board[1, 0] == player && board[2, 0] == player)
                    {
                        Console.WriteLine(player + " has won the game!");
                        break;
                    }
                    if (board[0, 1] == player && board[1, 1] == player && board[2, 1] == player)
                    {
                        Console.WriteLine(player + " has won the game!");
                        break;
                    }
                    if (board[0, 2] == player && board[1, 2] == player && board[2, 2] == player)
                    {
                        Console.WriteLine(player + " has won the game!");
                        break;
                    }
                    // check diags
                    if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
                    {
                        Console.WriteLine(player + " has won the game!");
                        break;
                    }
                    if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)
                    {
                        Console.WriteLine(player + " Has Won The Game!");
                        break;
                    }
                    // check draw
                    movesPlayed = movesPlayed + 1;
                    if (movesPlayed == 9)
                    {
                        Console.WriteLine("DRAW");
                        break;
                    }

                    player = ChangeTurn(player);

                    
                }
                Console.WriteLine("Do You want to play? (yes/no)");
                playagain = Console.ReadLine();


            }

            Console.WriteLine("Good Bye");

        }


        static char ChangeTurn(char currentPlayer)
        {
            if (currentPlayer == 'x')
            {
                return 'o';
            }
            else
            {
                return 'x';
            }
        }

        static void Initialize(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = ' ';
                }
            }

        }

        static void Print(char[,] board)
        {
            Console.WriteLine("  | 0 | 1 | 2 |");
            for (int row = 0; row < 3; row++)
            {
                Console.Write(row + " | ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }

        }
    }
}