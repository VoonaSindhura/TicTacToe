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
        public void Test_DiagonalWin_Player1()
        {
            string[,] board = new string[3, 3] {
            { "*", "*", "X" },
            { "*", "X", "*" },
            { "X", "*", "*" } };
            Assert.IsTrue(Program.CheckforWinner(board, 1));
        }

        [Test]
        public void Test_DiagonalWin_Player2()
        {
            string[,] board = new string[3, 3] {
            { "O", "*", "*" },
            { "*", "O", "*" },
            { "*", "*", "O" } };
            Assert.IsTrue(Program.CheckforWinner(board, 2));
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
        public void Test_GetCoordinates_ValidInput()
        {
            string input = "1 2";
            Console.SetIn(new StringReader(input)); // Set the console input to simulate user input
            Tuple<int, int> expected = Tuple.Create(1, 2);
            Assert.That(Program.GetCoordinates(), Is.EqualTo(expected));
        }

        [Test]
        public void Test_GetCoordinates_InValidInput()
        {
            string input = "3 1";
            Console.SetIn(new StringReader(input)); // Set the console input to simulate user input
            string expectedOutput = "Invalid input. Please enter two numbers between 0 and 2 separated by a space.\r\n";

            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            // Act and Assert
            Assert.Throws<NullReferenceException>(() => Program.GetCoordinates());

            // Check the console output for the expected error message
            Assert.That(sw.ToString().Trim(), Is.EqualTo(expectedOutput.Trim()));
        }

        [Test]
        public void Test_OccupiedCell()
        {
            string[,] board = new string[3, 3] {
        { "O", "X", "O" },
        { "*", "*", "*" },
        { "*", "*", "*" } };

            string input = "0 0"; // Simulate user input

            StringReader sr = new StringReader(input);
            Console.SetIn(sr);

            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            // Act and Assert
            Assert.Throws<NullReferenceException>(() => Program.PlayGame(board));

            // Check the console output for the expected error message
            string actualOutput = sw.ToString();
            string expectedOccupiedErrorMessage = "This cell is already occupied. Please choose another one.";

            // Extract the relevant part of the actual output
            int startIndex = actualOutput.IndexOf(expectedOccupiedErrorMessage);
            string actualOccupiedErrorMessage = actualOutput.Substring(startIndex, expectedOccupiedErrorMessage.Length);

            // Assert that the extracted part matches the expected part
            Assert.That(actualOccupiedErrorMessage, Is.EqualTo(expectedOccupiedErrorMessage));
        }
    }
}