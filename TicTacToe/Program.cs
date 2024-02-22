namespace TicTacToe
{
    public class Program()
    {
        static void Main(string[] args)
        {
            string[,] board = new string[3, 3] { { "*", "*", "*" }, { "*", "*", "*" }, { "*", "*", "*" } };
            IntializeBoard(board);
            PlayGame(board);
        }

        public static void IntializeBoard(string[,] board)
        {
            Console.WriteLine(" Tic Tac Toe Game\n");
            Console.WriteLine("     0         1        2    ");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("0   {0}   |   {1}   |   {2}  ", board[0, 0], board[0, 1], board[0, 2]);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1   {0}   |   {1}   |   {2}  ", board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("2   {0}   |   {1}   |   {2}  ", board[2, 0], board[2, 1], board[2, 2]);
            Console.WriteLine("-----------------------------");
        }

        public static void PlayGame(string[,] board)
        {
            int playerTurn = 1;

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine($"\nPlayer {playerTurn}, please enter row and column numbers with give a space (e.g., '0 1'): ");
                Tuple<int, int> coordinates = GetCoordinates();
                int rowIndex = coordinates.Item1;
                int columnIndex = coordinates.Item2;

                if (board[rowIndex, columnIndex] == "*")
                {
                    board[rowIndex, columnIndex] = (playerTurn == 1) ? "X" : "O";

                    IntializeBoard(board);

                    CheckforWinner(board, playerTurn);

                    playerTurn = (playerTurn == 1) ? 2 : 1;
                }
                else
                {
                    Console.WriteLine("This cell is already occupied. Please choose another one.");
                    i--; // To repeat the same player's turn
                }
            }
        }

        public static Tuple<int, int> GetCoordinates()
        {
            int rowIndex, columnIndex;
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (input.Length != 2 || !int.TryParse(input[0], out rowIndex) || !int.TryParse(input[1], out columnIndex) ||
                    rowIndex < 0 || rowIndex > 2 || columnIndex < 0 || columnIndex > 2)
                {
                    Console.WriteLine("Invalid input. Please enter two numbers between 0 and 2 separated by a space.");
                    continue;
                }
                return Tuple.Create(rowIndex, columnIndex);
            }
        }

        public static bool CheckforWinner(string[,] board, int playerTurn)
        {
            string symbol = (playerTurn == 1) ? "X" : "O";

            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == symbol && board[i, 1] == symbol && board[i, 2] == symbol)
                {
                    Console.WriteLine($"Player {playerTurn} wins!");
                    return true;
                }
            }

            // Check columns
            for (int j = 0; j < 3; j++)
            {
                if (board[0, j] == symbol && board[1, j] == symbol && board[2, j] == symbol)
                {
                    Console.WriteLine($"Player {playerTurn} wins!");
                    return true;
                }
            }

            // Check diagonals
            if ((board[0, 0] == symbol && board[1, 1] == symbol && board[2, 2] == symbol) ||
                    (board[0, 2] == symbol && board[1, 1] == symbol && board[2, 0] == symbol))
            {
                Console.WriteLine($"Player {playerTurn} wins!");
                return true;
            }

            return false;
        }
    }
}