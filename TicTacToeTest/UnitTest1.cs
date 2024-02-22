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
            string expectedOutput = "Invalid input. Please enter two numbers between 0 and 2 separated by a space.\r\n";

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act and Assert
                Assert.Throws<NullReferenceException>(() => Program.GetCoordinates());

                // Check the console output for the expected error message
                Assert.That(sw.ToString().Trim(), Is.EqualTo(expectedOutput.Trim()));
            }
        }
    }
}