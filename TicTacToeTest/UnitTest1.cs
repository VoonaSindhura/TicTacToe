using TicTacToe;
namespace TicTacToeTest
{
    [TestFixture]

    public class Tests
    {
        [Test]
        public void Test_RowWin()
        {
            string[,] board = new string[3, 3] {
            { "X", "X", "X" },
            { "*", "*", "*" },
            { "*", "*", "*" } };
            Assert.IsTrue(Program.CheckforWinner(board, 1));
        }

        [Test]
        public void Test_ColumnWin()
        {
            string[,] board = new string[3, 3] {
            { "*", "*", "O" },
            { "*", "*", "O" },
            { "*", "*", "O" } };
            Assert.IsTrue(Program.CheckforWinner(board, 2));
        }

        [Test]
        public void Test_DiagonalWin()
        {
            string[,] board = new string[3, 3] {
            { "*", "*", "X" },
            { "*", "X", "*" },
            { "X", "*", "*" } };
            Assert.IsTrue(Program.CheckforWinner(board, 1));
        }

        [Test]
        public void Test_Draw()
        {
            string[,] board = new string[3, 3] {
            { "X", "O", "X" },
            { "X", "O", "O" },
            { "O", "X", "X" } };
            Assert.IsFalse(Program.CheckforWinner(board, 1) || Program.CheckforWinner(board, 2));
        }

        [Test]
        public void Test_AlternatePlayers()
        {
            string[,] board = new string[3, 3] {
            { "*", "*", "*" },
            { "*", "*", "*" },
            { "*", "*", "*" } };
            Assert.IsFalse(Program.CheckforWinner(board, 1) || Program.CheckforWinner(board, 2));
        }

        [Test]
        public void PlayGame_ValidMoves_GameProceeds()
        {
            // Arrange
            string[,] board = new string[3, 3] { { "*", "*", "*" }, { "*", "*", "*" }, { "*", "*", "*" } };
            string[,] expectedBoard = new string[3, 3] { { "X", "*", "*" }, { "*", "*", "*" }, { "*", "*", "*" } };
            string input = "0 0\n"; // Simulating user input for first move

            // Redirect Console input
            using (StringReader sr = new StringReader(input))
            {
                Console.SetIn(sr);

                // Act
                Program.PlayGame(board);

                // Assert
                Assert.That(board, Is.EqualTo(expectedBoard));
            }
        }

        [Test]
        public void Test_OccupiedCell()
        {
            string[,] board = new string[3, 3] {
            { "O", "X", "O" },
            { "*", "*", "*" },
            { "*", "*", "*" } };
            
            string input = "0 2"; // Simulate user input
            string expectedOutput = "This cell is already occupied. Please choose another one.\r\n";

            using (StringWriter sw = new StringWriter())
            {
                using (StringReader sr = new StringReader(input))
                {
                    Console.SetOut(sw); // Redirect console output to StringWriter
                    Console.SetIn(sr); // Set console input to StringReader
                    Program.PlayGame(board); // Call the method to simulate the game
                }
                Assert.That(sw.ToString(), Is.EqualTo(expectedOutput)); // Assert that the correct error message is displayed
            }
        }

        [Test]
        public void Test_GetCoordinates_ValidInput()
        {
            string input = "1 2";
            Console.SetIn(new System.IO.StringReader(input)); // Set the console input to simulate user input
            Tuple<int, int> expected = Tuple.Create(1, 2);
            Assert.That(Program.GetCoordinates(), Is.EqualTo(expected));
        }

        [Test]
        public void Test_GetCoordinates_InValidInput()
        {
            string input = "3 1";
            Console.SetIn(new System.IO.StringReader(input)); // Set the console input to simulate user input
            string expectedOutput = "Invalid input. Please enter two numbers between 0 and 2 with give a space.\r\n";
            Assert.That(Program.GetCoordinates().ToString(), Is.EqualTo(expectedOutput));
        }
    }
}